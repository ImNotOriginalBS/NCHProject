﻿namespace NCH_Project
{
    partial class frmApptList
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label appointment_NumberLabel;
            System.Windows.Forms.Label appointment_TimeLabel;
            System.Windows.Forms.Label date_TImeLabel;
            System.Windows.Forms.Label visit_InformationLabel;
            System.Windows.Forms.Label end_TimeLabel;
            System.Windows.Forms.Label appointment_CompletedLabel;
            System.Windows.Forms.Label patient_NumberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmApptList));
            this.systemsDataBase2DataSet = new NCH_Project.SystemsDataBase2DataSet();
            this.appointment_DataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointment_DataTableAdapter = new NCH_Project.SystemsDataBase2DataSetTableAdapters.Appointment_DataTableAdapter();
            this.tableAdapterManager = new NCH_Project.SystemsDataBase2DataSetTableAdapters.TableAdapterManager();
            this.appointment_DataBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.appointment_DataBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.appointment_NumberTextBox = new System.Windows.Forms.TextBox();
            this.appointment_TimeTextBox = new System.Windows.Forms.TextBox();
            this.date_TImeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.visit_InformationTextBox = new System.Windows.Forms.TextBox();
            this.end_TimeTextBox = new System.Windows.Forms.TextBox();
            this.appointment_CompletedCheckBox = new System.Windows.Forms.CheckBox();
            this.patient_NumberTextBox = new System.Windows.Forms.TextBox();
            appointment_NumberLabel = new System.Windows.Forms.Label();
            appointment_TimeLabel = new System.Windows.Forms.Label();
            date_TImeLabel = new System.Windows.Forms.Label();
            visit_InformationLabel = new System.Windows.Forms.Label();
            end_TimeLabel = new System.Windows.Forms.Label();
            appointment_CompletedLabel = new System.Windows.Forms.Label();
            patient_NumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.systemsDataBase2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointment_DataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointment_DataBindingNavigator)).BeginInit();
            this.appointment_DataBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // appointment_NumberLabel
            // 
            appointment_NumberLabel.AutoSize = true;
            appointment_NumberLabel.Location = new System.Drawing.Point(12, 71);
            appointment_NumberLabel.Name = "appointment_NumberLabel";
            appointment_NumberLabel.Size = new System.Drawing.Size(145, 17);
            appointment_NumberLabel.TabIndex = 63;
            appointment_NumberLabel.Text = "Appointment Number:";
            // 
            // appointment_TimeLabel
            // 
            appointment_TimeLabel.AutoSize = true;
            appointment_TimeLabel.Location = new System.Drawing.Point(12, 144);
            appointment_TimeLabel.Name = "appointment_TimeLabel";
            appointment_TimeLabel.Size = new System.Drawing.Size(126, 17);
            appointment_TimeLabel.TabIndex = 64;
            appointment_TimeLabel.Text = "Appointment Time:";
            // 
            // date_TImeLabel
            // 
            date_TImeLabel.AutoSize = true;
            date_TImeLabel.Location = new System.Drawing.Point(321, 144);
            date_TImeLabel.Name = "date_TImeLabel";
            date_TImeLabel.Size = new System.Drawing.Size(77, 17);
            date_TImeLabel.TabIndex = 65;
            date_TImeLabel.Text = "Date/TIme:";
            // 
            // visit_InformationLabel
            // 
            visit_InformationLabel.AutoSize = true;
            visit_InformationLabel.Location = new System.Drawing.Point(12, 219);
            visit_InformationLabel.Name = "visit_InformationLabel";
            visit_InformationLabel.Size = new System.Drawing.Size(112, 17);
            visit_InformationLabel.TabIndex = 66;
            visit_InformationLabel.Text = "Visit Information:";
            // 
            // end_TimeLabel
            // 
            end_TimeLabel.AutoSize = true;
            end_TimeLabel.Location = new System.Drawing.Point(159, 144);
            end_TimeLabel.Name = "end_TimeLabel";
            end_TimeLabel.Size = new System.Drawing.Size(72, 17);
            end_TimeLabel.TabIndex = 67;
            end_TimeLabel.Text = "End Time:";
            // 
            // appointment_CompletedLabel
            // 
            appointment_CompletedLabel.AutoSize = true;
            appointment_CompletedLabel.Location = new System.Drawing.Point(472, 71);
            appointment_CompletedLabel.Name = "appointment_CompletedLabel";
            appointment_CompletedLabel.Size = new System.Drawing.Size(170, 17);
            appointment_CompletedLabel.TabIndex = 68;
            appointment_CompletedLabel.Text = "Appointment Completed?:";
            // 
            // patient_NumberLabel
            // 
            patient_NumberLabel.AutoSize = true;
            patient_NumberLabel.Location = new System.Drawing.Point(188, 71);
            patient_NumberLabel.Name = "patient_NumberLabel";
            patient_NumberLabel.Size = new System.Drawing.Size(110, 17);
            patient_NumberLabel.TabIndex = 69;
            patient_NumberLabel.Text = "Patient Number:";
            // 
            // systemsDataBase2DataSet
            // 
            this.systemsDataBase2DataSet.DataSetName = "SystemsDataBase2DataSet";
            this.systemsDataBase2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointment_DataBindingSource
            // 
            this.appointment_DataBindingSource.DataMember = "Appointment Data";
            this.appointment_DataBindingSource.DataSource = this.systemsDataBase2DataSet;
            // 
            // appointment_DataTableAdapter
            // 
            this.appointment_DataTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Complete_Service_DataTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Cpt_CodesTableAdapter = null;
            this.tableAdapterManager.HouseHoldTableAdapter = null;
            this.tableAdapterManager.InsurancecompaniesTableAdapter = null;
            this.tableAdapterManager.MTDChargesTableAdapter = null;
            this.tableAdapterManager.MTDPaymentsTableAdapter = null;
            this.tableAdapterManager.PatientsTableAdapter = null;
            this.tableAdapterManager.Pending_Insurance_ClaimsTableAdapter = null;
            this.tableAdapterManager.PostCardTableAdapter = null;
            this.tableAdapterManager.ProvidersTableAdapter = null;
            this.tableAdapterManager.RacesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NCH_Project.SystemsDataBase2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Visit_InfoTableAdapter = null;
            // 
            // appointment_DataBindingNavigator
            // 
            this.appointment_DataBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.appointment_DataBindingNavigator.BindingSource = this.appointment_DataBindingSource;
            this.appointment_DataBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.appointment_DataBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.appointment_DataBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.appointment_DataBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.appointment_DataBindingNavigatorSaveItem});
            this.appointment_DataBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.appointment_DataBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.appointment_DataBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.appointment_DataBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.appointment_DataBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.appointment_DataBindingNavigator.Name = "appointment_DataBindingNavigator";
            this.appointment_DataBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.appointment_DataBindingNavigator.Size = new System.Drawing.Size(696, 27);
            this.appointment_DataBindingNavigator.TabIndex = 63;
            this.appointment_DataBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // appointment_DataBindingNavigatorSaveItem
            // 
            this.appointment_DataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.appointment_DataBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("appointment_DataBindingNavigatorSaveItem.Image")));
            this.appointment_DataBindingNavigatorSaveItem.Name = "appointment_DataBindingNavigatorSaveItem";
            this.appointment_DataBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.appointment_DataBindingNavigatorSaveItem.Text = "Save Data";
            this.appointment_DataBindingNavigatorSaveItem.Click += new System.EventHandler(this.appointment_DataBindingNavigatorSaveItem_Click);
            // 
            // appointment_NumberTextBox
            // 
            this.appointment_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointment_DataBindingSource, "Appointment Number", true));
            this.appointment_NumberTextBox.Location = new System.Drawing.Point(15, 91);
            this.appointment_NumberTextBox.Name = "appointment_NumberTextBox";
            this.appointment_NumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.appointment_NumberTextBox.TabIndex = 64;
            // 
            // appointment_TimeTextBox
            // 
            this.appointment_TimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointment_DataBindingSource, "Appointment Time", true));
            this.appointment_TimeTextBox.Location = new System.Drawing.Point(15, 164);
            this.appointment_TimeTextBox.Name = "appointment_TimeTextBox";
            this.appointment_TimeTextBox.Size = new System.Drawing.Size(100, 22);
            this.appointment_TimeTextBox.TabIndex = 65;
            // 
            // date_TImeDateTimePicker
            // 
            this.date_TImeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.appointment_DataBindingSource, "Date/TIme", true));
            this.date_TImeDateTimePicker.Location = new System.Drawing.Point(324, 164);
            this.date_TImeDateTimePicker.Name = "date_TImeDateTimePicker";
            this.date_TImeDateTimePicker.Size = new System.Drawing.Size(224, 22);
            this.date_TImeDateTimePicker.TabIndex = 66;
            // 
            // visit_InformationTextBox
            // 
            this.visit_InformationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointment_DataBindingSource, "Visit Information", true));
            this.visit_InformationTextBox.Location = new System.Drawing.Point(15, 239);
            this.visit_InformationTextBox.Name = "visit_InformationTextBox";
            this.visit_InformationTextBox.Size = new System.Drawing.Size(142, 22);
            this.visit_InformationTextBox.TabIndex = 67;
            // 
            // end_TimeTextBox
            // 
            this.end_TimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointment_DataBindingSource, "End Time", true));
            this.end_TimeTextBox.Location = new System.Drawing.Point(162, 164);
            this.end_TimeTextBox.Name = "end_TimeTextBox";
            this.end_TimeTextBox.Size = new System.Drawing.Size(100, 22);
            this.end_TimeTextBox.TabIndex = 68;
            // 
            // appointment_CompletedCheckBox
            // 
            this.appointment_CompletedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.appointment_DataBindingSource, "Appointment Completed", true));
            this.appointment_CompletedCheckBox.Location = new System.Drawing.Point(480, 91);
            this.appointment_CompletedCheckBox.Name = "appointment_CompletedCheckBox";
            this.appointment_CompletedCheckBox.Size = new System.Drawing.Size(104, 24);
            this.appointment_CompletedCheckBox.TabIndex = 69;
            this.appointment_CompletedCheckBox.Text = "Yes";
            this.appointment_CompletedCheckBox.UseVisualStyleBackColor = true;
            // 
            // patient_NumberTextBox
            // 
            this.patient_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointment_DataBindingSource, "Patient Number", true));
            this.patient_NumberTextBox.Location = new System.Drawing.Point(191, 93);
            this.patient_NumberTextBox.Name = "patient_NumberTextBox";
            this.patient_NumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.patient_NumberTextBox.TabIndex = 70;
            // 
            // frmApptList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 357);
            this.ControlBox = false;
            this.Controls.Add(patient_NumberLabel);
            this.Controls.Add(this.patient_NumberTextBox);
            this.Controls.Add(appointment_CompletedLabel);
            this.Controls.Add(this.appointment_CompletedCheckBox);
            this.Controls.Add(end_TimeLabel);
            this.Controls.Add(this.end_TimeTextBox);
            this.Controls.Add(visit_InformationLabel);
            this.Controls.Add(this.visit_InformationTextBox);
            this.Controls.Add(date_TImeLabel);
            this.Controls.Add(this.date_TImeDateTimePicker);
            this.Controls.Add(appointment_TimeLabel);
            this.Controls.Add(this.appointment_TimeTextBox);
            this.Controls.Add(appointment_NumberLabel);
            this.Controls.Add(this.appointment_NumberTextBox);
            this.Controls.Add(this.appointment_DataBindingNavigator);
            this.Name = "frmApptList";
            this.Text = "Appointment List";
            this.Load += new System.EventHandler(this.frmApptList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.systemsDataBase2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointment_DataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointment_DataBindingNavigator)).EndInit();
            this.appointment_DataBindingNavigator.ResumeLayout(false);
            this.appointment_DataBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SystemsDataBase2DataSet systemsDataBase2DataSet;
        private System.Windows.Forms.BindingSource appointment_DataBindingSource;
        private SystemsDataBase2DataSetTableAdapters.Appointment_DataTableAdapter appointment_DataTableAdapter;
        private SystemsDataBase2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator appointment_DataBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton appointment_DataBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox appointment_NumberTextBox;
        private System.Windows.Forms.TextBox appointment_TimeTextBox;
        private System.Windows.Forms.DateTimePicker date_TImeDateTimePicker;
        private System.Windows.Forms.TextBox visit_InformationTextBox;
        private System.Windows.Forms.TextBox end_TimeTextBox;
        private System.Windows.Forms.CheckBox appointment_CompletedCheckBox;
        private System.Windows.Forms.TextBox patient_NumberTextBox;
    }
}