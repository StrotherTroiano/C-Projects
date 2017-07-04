namespace CrudApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelMake = new System.Windows.Forms.Label();
            this.textBoxMake = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.textBoxCylinders = new System.Windows.Forms.TextBox();
            this.labelCylinders = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.listBoxVehicleInventory = new System.Windows.Forms.ListBox();
            this.labelVehicleList = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelMakeFilter = new System.Windows.Forms.Label();
            this.textBoxMakeFilter = new System.Windows.Forms.TextBox();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.textBoxCylindersFilter = new System.Windows.Forms.TextBox();
            this.labelCylinderFilter = new System.Windows.Forms.Label();
            this.textBoxColorFilter = new System.Windows.Forms.TextBox();
            this.labelColorFilter = new System.Windows.Forms.Label();
            this.textBoxYearFilter = new System.Windows.Forms.TextBox();
            this.labelYearFilter = new System.Windows.Forms.Label();
            this.textBoxModelFilter = new System.Windows.Forms.TextBox();
            this.labelModelFilter = new System.Windows.Forms.Label();
            this.checkBoxMatchAll = new System.Windows.Forms.CheckBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMake
            // 
            this.labelMake.AutoSize = true;
            this.labelMake.Location = new System.Drawing.Point(18, 23);
            this.labelMake.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMake.Name = "labelMake";
            this.labelMake.Size = new System.Drawing.Size(48, 20);
            this.labelMake.TabIndex = 0;
            this.labelMake.Text = "Make";
            // 
            // textBoxMake
            // 
            this.textBoxMake.Location = new System.Drawing.Point(100, 18);
            this.textBoxMake.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMake.Name = "textBoxMake";
            this.textBoxMake.Size = new System.Drawing.Size(148, 26);
            this.textBoxMake.TabIndex = 1;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(100, 58);
            this.textBoxModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(148, 26);
            this.textBoxModel.TabIndex = 3;
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(18, 63);
            this.labelModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(52, 20);
            this.labelModel.TabIndex = 2;
            this.labelModel.Text = "Model";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(100, 98);
            this.textBoxYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(148, 26);
            this.textBoxYear.TabIndex = 5;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(18, 103);
            this.labelYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(43, 20);
            this.labelYear.TabIndex = 4;
            this.labelYear.Text = "Year";
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(100, 138);
            this.textBoxColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(148, 26);
            this.textBoxColor.TabIndex = 7;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(18, 143);
            this.labelColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(46, 20);
            this.labelColor.TabIndex = 6;
            this.labelColor.Text = "Color";
            // 
            // textBoxCylinders
            // 
            this.textBoxCylinders.Location = new System.Drawing.Point(100, 178);
            this.textBoxCylinders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCylinders.Name = "textBoxCylinders";
            this.textBoxCylinders.Size = new System.Drawing.Size(148, 26);
            this.textBoxCylinders.TabIndex = 9;
            // 
            // labelCylinders
            // 
            this.labelCylinders.AutoSize = true;
            this.labelCylinders.Location = new System.Drawing.Point(18, 183);
            this.labelCylinders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCylinders.Name = "labelCylinders";
            this.labelCylinders.Size = new System.Drawing.Size(73, 20);
            this.labelCylinders.TabIndex = 8;
            this.labelCylinders.Text = "Cylinders";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(100, 220);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(112, 35);
            this.buttonCreate.TabIndex = 10;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // listBoxVehicleInventory
            // 
            this.listBoxVehicleInventory.FormattingEnabled = true;
            this.listBoxVehicleInventory.ItemHeight = 20;
            this.listBoxVehicleInventory.Location = new System.Drawing.Point(402, 18);
            this.listBoxVehicleInventory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxVehicleInventory.Name = "listBoxVehicleInventory";
            this.listBoxVehicleInventory.Size = new System.Drawing.Size(514, 184);
            this.listBoxVehicleInventory.TabIndex = 11;
            // 
            // labelVehicleList
            // 
            this.labelVehicleList.AutoSize = true;
            this.labelVehicleList.Location = new System.Drawing.Point(260, 23);
            this.labelVehicleList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVehicleList.Name = "labelVehicleList";
            this.labelVehicleList.Size = new System.Drawing.Size(130, 20);
            this.labelVehicleList.TabIndex = 12;
            this.labelVehicleList.Text = "Vehicle Inventory";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(100, 266);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(112, 35);
            this.buttonUpdate.TabIndex = 13;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(402, 220);
            this.buttonRead.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(112, 35);
            this.buttonRead.TabIndex = 14;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(402, 266);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(112, 35);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(100, 461);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(816, 26);
            this.textBoxResult.TabIndex = 16;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(18, 464);
            this.labelResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(55, 20);
            this.labelResult.TabIndex = 17;
            this.labelResult.Text = "Result";
            // 
            // labelMakeFilter
            // 
            this.labelMakeFilter.AutoSize = true;
            this.labelMakeFilter.Location = new System.Drawing.Point(686, 227);
            this.labelMakeFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMakeFilter.Name = "labelMakeFilter";
            this.labelMakeFilter.Size = new System.Drawing.Size(48, 20);
            this.labelMakeFilter.TabIndex = 18;
            this.labelMakeFilter.Text = "Make";
            // 
            // textBoxMakeFilter
            // 
            this.textBoxMakeFilter.Location = new System.Drawing.Point(768, 224);
            this.textBoxMakeFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMakeFilter.Name = "textBoxMakeFilter";
            this.textBoxMakeFilter.Size = new System.Drawing.Size(148, 26);
            this.textBoxMakeFilter.TabIndex = 19;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(566, 220);
            this.buttonFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(112, 35);
            this.buttonFilter.TabIndex = 20;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // textBoxCylindersFilter
            // 
            this.textBoxCylindersFilter.Location = new System.Drawing.Point(768, 380);
            this.textBoxCylindersFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCylindersFilter.Name = "textBoxCylindersFilter";
            this.textBoxCylindersFilter.Size = new System.Drawing.Size(148, 26);
            this.textBoxCylindersFilter.TabIndex = 28;
            // 
            // labelCylinderFilter
            // 
            this.labelCylinderFilter.AutoSize = true;
            this.labelCylinderFilter.Location = new System.Drawing.Point(686, 385);
            this.labelCylinderFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCylinderFilter.Name = "labelCylinderFilter";
            this.labelCylinderFilter.Size = new System.Drawing.Size(73, 20);
            this.labelCylinderFilter.TabIndex = 27;
            this.labelCylinderFilter.Text = "Cylinders";
            // 
            // textBoxColorFilter
            // 
            this.textBoxColorFilter.Location = new System.Drawing.Point(768, 340);
            this.textBoxColorFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxColorFilter.Name = "textBoxColorFilter";
            this.textBoxColorFilter.Size = new System.Drawing.Size(148, 26);
            this.textBoxColorFilter.TabIndex = 26;
            // 
            // labelColorFilter
            // 
            this.labelColorFilter.AutoSize = true;
            this.labelColorFilter.Location = new System.Drawing.Point(686, 345);
            this.labelColorFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelColorFilter.Name = "labelColorFilter";
            this.labelColorFilter.Size = new System.Drawing.Size(46, 20);
            this.labelColorFilter.TabIndex = 25;
            this.labelColorFilter.Text = "Color";
            // 
            // textBoxYearFilter
            // 
            this.textBoxYearFilter.Location = new System.Drawing.Point(768, 300);
            this.textBoxYearFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxYearFilter.Name = "textBoxYearFilter";
            this.textBoxYearFilter.Size = new System.Drawing.Size(148, 26);
            this.textBoxYearFilter.TabIndex = 24;
            // 
            // labelYearFilter
            // 
            this.labelYearFilter.AutoSize = true;
            this.labelYearFilter.Location = new System.Drawing.Point(686, 305);
            this.labelYearFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelYearFilter.Name = "labelYearFilter";
            this.labelYearFilter.Size = new System.Drawing.Size(43, 20);
            this.labelYearFilter.TabIndex = 23;
            this.labelYearFilter.Text = "Year";
            // 
            // textBoxModelFilter
            // 
            this.textBoxModelFilter.Location = new System.Drawing.Point(768, 260);
            this.textBoxModelFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxModelFilter.Name = "textBoxModelFilter";
            this.textBoxModelFilter.Size = new System.Drawing.Size(148, 26);
            this.textBoxModelFilter.TabIndex = 22;
            // 
            // labelModelFilter
            // 
            this.labelModelFilter.AutoSize = true;
            this.labelModelFilter.Location = new System.Drawing.Point(686, 265);
            this.labelModelFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelModelFilter.Name = "labelModelFilter";
            this.labelModelFilter.Size = new System.Drawing.Size(52, 20);
            this.labelModelFilter.TabIndex = 21;
            this.labelModelFilter.Text = "Model";
            // 
            // checkBoxMatchAll
            // 
            this.checkBoxMatchAll.AutoSize = true;
            this.checkBoxMatchAll.Location = new System.Drawing.Point(768, 414);
            this.checkBoxMatchAll.Name = "checkBoxMatchAll";
            this.checkBoxMatchAll.Size = new System.Drawing.Size(93, 24);
            this.checkBoxMatchAll.TabIndex = 29;
            this.checkBoxMatchAll.Text = "Match All";
            this.checkBoxMatchAll.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(566, 265);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(112, 35);
            this.buttonReset.TabIndex = 30;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 510);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.checkBoxMatchAll);
            this.Controls.Add(this.textBoxCylindersFilter);
            this.Controls.Add(this.labelCylinderFilter);
            this.Controls.Add(this.textBoxColorFilter);
            this.Controls.Add(this.labelColorFilter);
            this.Controls.Add(this.textBoxYearFilter);
            this.Controls.Add(this.labelYearFilter);
            this.Controls.Add(this.textBoxModelFilter);
            this.Controls.Add(this.labelModelFilter);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.textBoxMakeFilter);
            this.Controls.Add(this.labelMakeFilter);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelVehicleList);
            this.Controls.Add(this.listBoxVehicleInventory);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.textBoxCylinders);
            this.Controls.Add(this.labelCylinders);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.textBoxMake);
            this.Controls.Add(this.labelMake);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Vehicle CRUD Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMake;
        private System.Windows.Forms.TextBox textBoxMake;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.TextBox textBoxCylinders;
        private System.Windows.Forms.Label labelCylinders;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.ListBox listBoxVehicleInventory;
        private System.Windows.Forms.Label labelVehicleList;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelMakeFilter;
        private System.Windows.Forms.TextBox textBoxMakeFilter;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.TextBox textBoxCylindersFilter;
        private System.Windows.Forms.Label labelCylinderFilter;
        private System.Windows.Forms.TextBox textBoxColorFilter;
        private System.Windows.Forms.Label labelColorFilter;
        private System.Windows.Forms.TextBox textBoxYearFilter;
        private System.Windows.Forms.Label labelYearFilter;
        private System.Windows.Forms.TextBox textBoxModelFilter;
        private System.Windows.Forms.Label labelModelFilter;
        private System.Windows.Forms.CheckBox checkBoxMatchAll;
        private System.Windows.Forms.Button buttonReset;
    }
}

