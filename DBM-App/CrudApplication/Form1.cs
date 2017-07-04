using DataModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CrudApplication
{
    /// <summary>
    /// The code behind the form.
    /// </summary>
    public partial class Form1 : Form
    {
        #region Private Fields

        // keep track of the currently loaded vehicle record Id (primary key in the table)
        private int _currentVehicleId = -1;

        #endregion

        #region Constructors

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Form Loading and Closing

        private void Form1_Load(object sender, EventArgs e)
        {
            // update the vehicle inventory from the database
            UpdateVehicleInventory();

            // clear the data model input fields
            ResetVehicleInputFields();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // notify the helper that we are closing (exiting)
            VehicleDatabaseHelper.OnClosing();
        }

        #endregion

        #region Button Click Event Handlers

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            // execute a query using the CreateVehicle method
            ExecuteQuery(VehicleDatabaseHelper.CreateVehicle);
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            // get the selected item from the vehicle inventory list box
            object selectedItem = listBoxVehicleInventory.SelectedItem;

            // make sure an entry was actually selected
            if (null != selectedItem)
            {
                // create a vehicle from the selected item
                Vehicle selectedVehicle = Vehicle.ToVehicle(selectedItem.ToString());

                // read the vehicle record from the database
                Vehicle foundVehicle = VehicleDatabaseHelper.ReadVehicle(selectedVehicle);

                // if we found a corresponding vehicle...
                if (null != foundVehicle)
                {
                    // update the text boxes
                    MapVehicleToTextBoxes(foundVehicle);
                }
            }
            else
            {
                // no items were selected, so let the user know...
                textBoxResult.Text = @"No vehicle selected from inventory";
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // execute a query using the UpdateVehicle method
            ExecuteQuery(VehicleDatabaseHelper.UpdateVehicle);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // get the selected item from the vehicle inventory list box
            object selectedItem = listBoxVehicleInventory.SelectedItem;

            // make sure an entry was actually selected
            if (null != selectedItem)
            {
                // create a vehicle from the selected item
                Vehicle selectedVehicle = Vehicle.ToVehicle(selectedItem.ToString());

                // attempt to delete the vehicle record
                int recordsAffected = VehicleDatabaseHelper.DeleteVehicle(selectedVehicle);

                // inform the user
                textBoxResult.Text = $@"{recordsAffected} record(s) affected.";

                // update the inventory
                UpdateVehicleInventory();

                // reset the input fields
                ResetVehicleInputFields();
            }
            else
            {
                // no items were selected, so let the user know...
                textBoxResult.Text = @"No vehicle selected from inventory";
            }
        }

        #endregion

        #region Private Helper Methods

        /// <summary>
        /// Execute a query using the provided function.
        /// </summary>
        /// <param name="queryMethod">The query function to call</param>
        private void ExecuteQuery(Func<Vehicle, int> queryMethod)
        {
            // create a vehicle instance
            Vehicle vehicle = new Vehicle();

            // attempt to map the input fields to the vehicle instance
            if (TryMapTextBoxesToVehicle(vehicle))
            {
                // execute the query method specified
                int recordsAffected = queryMethod(vehicle);

                // inform the user
                textBoxResult.Text = $@"{recordsAffected} record(s) affected.";

                // update the inventory
                UpdateVehicleInventory();

                // reset the input fields
                ResetVehicleInputFields();
            }
        }

        /// <summary>
        /// Update the vehicle inventory list box.
        /// </summary>
        private void UpdateVehicleInventory(List<Vehicle> vehicles = null)
        {
            // read the vehicles from the database
            List<Vehicle> currentInventory;

            if (null == vehicles)
            {
                currentInventory = VehicleDatabaseHelper.ReadVehicles();
            }
            else
            {
                currentInventory = vehicles;
            }

            // indicate that we are starting to update the list box
            listBoxVehicleInventory.BeginUpdate();

            // clear the current contents
            listBoxVehicleInventory.Items.Clear();

            // add each vehicle to the list box
            foreach (var vehicle in currentInventory)
            {
                listBoxVehicleInventory.Items.Add(vehicle);
            }

            // end the update so the results can be drawn in the UI
            listBoxVehicleInventory.EndUpdate();
        }

        /// <summary>
        /// Reset the text input fields.
        /// </summary>
        private void ResetVehicleInputFields()
        {
            _currentVehicleId = -1;
            textBoxColor.Clear();
            textBoxCylinders.Clear();
            textBoxMake.Clear();
            textBoxModel.Clear();
            textBoxYear.Clear();
        }

        /// <summary>
        /// Map a <see cref="Vehicle"/> to the appropriate text boxes.
        /// </summary>
        /// <param name="vehicle">The <see cref="Vehicle"/> to map from</param>
        private void MapVehicleToTextBoxes(Vehicle vehicle)
        {
            _currentVehicleId = vehicle.Id;
            textBoxColor.Text = vehicle.Color;
            textBoxCylinders.Text = vehicle.Cylinders.ToString();
            textBoxMake.Text = vehicle.Make;
            textBoxModel.Text = vehicle.Model;
            textBoxYear.Text = vehicle.Year.ToString();
            textBoxResult.Text = $@"Loaded vehicle: [ {vehicle} ]"; // Note: here we are implicitly calling the Vehicle.ToString method
        }

        /// <summary>
        /// Map the text box inputs to a <see cref="Vehicle"/>.
        /// </summary>
        /// <param name="vehicle">The <see cref="Vehicle"/> to map to</param>
        private bool TryMapTextBoxesToVehicle(Vehicle vehicle)
        {
            try
            {
                // attempt to get the text box text fields
                // if they are not filed out, an exception may occur
                vehicle.Id = _currentVehicleId;
                vehicle.Make = textBoxMake.Text;
                vehicle.Model = textBoxModel.Text;
                vehicle.Year = Int32.Parse(textBoxYear.Text);
                vehicle.Color = textBoxColor.Text;
                vehicle.Cylinders = Int32.Parse(textBoxCylinders.Text);

                // mapping succeeded
                return true;
            }
            catch (Exception e)
            {
                // mapping failed, let the user know
                textBoxResult.Text = $@"Failed to map the text fields: {e.Message}";

                return false;
            }
        }

        #endregion

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            // 1. Get the text from the filter text boxes and the checked
            //    status from the match all check box
            string MakeFilterInput = textBoxMakeFilter.Text;
            string ColorFilterInput = textBoxColorFilter.Text;
            string ModelFilterInput = textBoxModelFilter.Text;
            string YearFilterInput = textBoxYearFilter.Text;
            string CylinderFilterInput = textBoxCylindersFilter.Text;

            bool matchAll = checkBoxMatchAll.Checked;

            // 2. Call the 'FilterVehicle' method on the 'VehicleDatabaseHelper'
            //    class to get  list of filtered vehicles

            List<Vehicle> vehicles = VehicleDatabaseHelper.FilterVehicles(MakeFilterInput, ModelFilterInput, YearFilterInput, ColorFilterInput, CylinderFilterInput, matchAll);

            // 3. Pass the returned list to the 'UpdateVehicleInventory' method
            //    on this class (see above, modified to accept a list)
            UpdateVehicleInventory(vehicles);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            // 1. Clear the text from the filter text boxes and set the checked
            //    status for the match all check box to false
            textBoxMakeFilter.Clear();
            textBoxColorFilter.Clear();
            textBoxModelFilter.Clear();
            textBoxYearFilter.Clear();
            textBoxCylindersFilter.Clear();

            checkBoxMatchAll.Checked = false;
            // 2. Call 'UpdateVehicleInventory' method with no parameter to get
            //    an update of all vehicles in the inventory

            UpdateVehicleInventory();

        }
    }
}
