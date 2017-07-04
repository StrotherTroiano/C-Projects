using System;
using DataLayer;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace DataModel
{
    /// <summary>
    /// A helper class to assist with interacting with the Vehicle table.
    /// </summary>
    public static class VehicleDatabaseHelper
    {
        #region Constructors

        /// <summary>
        /// Static constructor to initialize the database layer.
        /// </summary>
        static VehicleDatabaseHelper()
        {
            Database.ApplicationName = "My Vehicles Application";

            Database.ConnectionTimeout = 30;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Submit a query to the data layer to create a vehicle in the Vehicle table
        /// </summary>
        /// <param name="vehicle">The vehicle to create</param>
        /// <returns>The number of records affected (should only be one)</returns>
        public static int CreateVehicle(Vehicle vehicle)
        {
            // construct the query string
            string query = $"INSERT [dbo].[{VehicleTableSchema.TableName}] " +
                           $"({VehicleTableSchema.MakeField}, " +
                           $"{VehicleTableSchema.ModelField}, " +
                           $"{VehicleTableSchema.YearField}, " +
                           $"{VehicleTableSchema.ColorField}, " +
                           $"{VehicleTableSchema.CylindersField}) " +
                           $"VALUES({vehicle.ToValuesString()})";

            // submit it to the data layer and return the result
            return Database.Create(query);
        }

        /// <summary>
        /// Read a vehicle record from the Vehicle table.
        /// </summary>
        /// <param name="vehicle">An instance of a <see cref="Vehicle"/> to load from the table</param>
        /// <returns>The instance</returns>
        public static Vehicle ReadVehicle(Vehicle vehicle)
        {
            // construct the query string
            string query = $"SELECT * FROM [dbo].[{VehicleTableSchema.TableName}] " +
                           $"WHERE {VehicleTableSchema.IdField}={vehicle.Id}";

            // execute the query (this method returns a list)
            List<Vehicle> vehicles = Database.Read<Vehicle>(query);

            // return the result (should only be one, so return the first)
            return vehicles.FirstOrDefault();
        }

        /// <summary>
        /// Read all the vehicle records from the Vehicle table.
        /// </summary>
        /// <returns>The vehicle records as a <see cref="List{T}"/> of type <see cref="Vehicle"/></returns>
        public static List<Vehicle> ReadVehicles()
        {
            // construct the query string
            string query = $"SELECT * FROM [dbo].[{VehicleTableSchema.TableName}]";

            // execute the query (this method returns a list)
            List<Vehicle> vehicles = Database.Read<Vehicle>(query);

            // return the results
            return vehicles;
        }

        public static List<Vehicle> FilterVehicles(string make, string model, string year, string color, string cylinders, bool matchAll)
        {
            string query = $"SELECT * FROM [dbo].[{VehicleTableSchema.TableName}]";

            // 1. Using the parameters passed, construct a SELECT query with a
            //    WHERE clause that either requires vehicles to match all (AND)
            //    the criteria, or any (OR).
            Vehicle vehicle = new Vehicle
            {
                Make = make,
                Model = model,
                Year = string.IsNullOrWhiteSpace(year) ? -1 : Int32.Parse(year),
                Color = color,
                Cylinders = string.IsNullOrWhiteSpace(cylinders) ? -1 : Int32.Parse(cylinders)
            };

            var clause = vehicle.ToWhereClause(matchAll);

            if (!String.IsNullOrWhiteSpace(clause))
            {
                query += $" WHERE {clause}";
            }

            List<Vehicle> vehicles = Database.Read<Vehicle>(query);

            return vehicles;
        }

        /// <summary>
        /// Update a vehicle record.
        /// </summary>
        /// <param name="vehicle">The updated version of the <see cref="Vehicle"/></param>
        /// <returns>The number of records affected (should only be one)</returns>
        public static int UpdateVehicle(Vehicle vehicle)
        {
            // construct the query string
            string query = $"UPDATE [dbo].[{VehicleTableSchema.TableName}] " +
                           $"SET {vehicle.ToUpdateString()} " +
                           $"WHERE {VehicleTableSchema.IdField}={vehicle.Id}";

            // submit it to the data layer and return the result
            return Database.Update(query);
        }

        /// <summary>
        /// Delete a vehicle record.
        /// </summary>
        /// <param name="vehicle">The <see cref="Vehicle"/> to delete</param>
        /// <returns>The number of records affected (should only be one)</returns>
        public static int DeleteVehicle(Vehicle vehicle)
        {
            // construct the query string
            string query = $"DELETE FROM [dbo].[{VehicleTableSchema.TableName}] " +
                           $"WHERE {VehicleTableSchema.IdField}={vehicle.Id}";

            // submit it to the data layer and return the result
            return Database.Delete(query);
        }

        /// <summary>
        /// When no longer needed, call this method to close the data layer
        /// connection and dispose of resources.
        /// </summary>
        public static void OnClosing()
        {
            Database.OnClosing();
        }

        #endregion
    }
}
