﻿namespace NCH_Project
{
    partial class frmPatientInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatientInfo));
            System.Windows.Forms.Label patient_NumberLabel;
            System.Windows.Forms.Label household_NumberLabel;
            System.Windows.Forms.Label patient_NameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label phoneLabel;
            this.grpSex = new System.Windows.Forms.GroupBox();
            this.rdoF = new System.Windows.Forms.RadioButton();
            this.rdoM = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtHolderSOC = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtHolderDOB = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPolicyName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtInsComp = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoOther = new System.Windows.Forms.RadioButton();
            this.rdoAsain = new System.Windows.Forms.RadioButton();
            this.rdoNativeAmerican = new System.Windows.Forms.RadioButton();
            this.rdoAfricanAmerican = new System.Windows.Forms.RadioButton();
            this.rdoHispanic = new System.Windows.Forms.RadioButton();
            this.rdoWhite = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEditPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEdietHouseholdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalLedgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accoubntReceivableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.providerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mTDPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postcardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.patientsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.systemsDataBase2DataSet = new NCH_Project.SystemsDataBase2DataSet();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsTableAdapter = new NCH_Project.SystemsDataBase2DataSetTableAdapters.PatientsTableAdapter();
            this.tableAdapterManager = new NCH_Project.SystemsDataBase2DataSetTableAdapters.TableAdapterManager();
            this.patient_NumberTextBox = new System.Windows.Forms.TextBox();
            this.household_NumberTextBox = new System.Windows.Forms.TextBox();
            this.patient_NameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            patient_NumberLabel = new System.Windows.Forms.Label();
            household_NumberLabel = new System.Windows.Forms.Label();
            patient_NameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            this.grpSex.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingNavigator)).BeginInit();
            this.patientsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.systemsDataBase2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSex
            // 
            this.grpSex.Controls.Add(this.rdoF);
            this.grpSex.Controls.Add(this.rdoM);
            this.grpSex.Location = new System.Drawing.Point(383, 108);
            this.grpSex.Name = "grpSex";
            this.grpSex.Size = new System.Drawing.Size(101, 42);
            this.grpSex.TabIndex = 34;
            this.grpSex.TabStop = false;
            this.grpSex.Text = "Sex";
            // 
            // rdoF
            // 
            this.rdoF.AutoSize = true;
            this.rdoF.Location = new System.Drawing.Point(63, 21);
            this.rdoF.Name = "rdoF";
            this.rdoF.Size = new System.Drawing.Size(37, 21);
            this.rdoF.TabIndex = 1;
            this.rdoF.TabStop = true;
            this.rdoF.Text = "F";
            this.rdoF.UseVisualStyleBackColor = true;
            // 
            // rdoM
            // 
            this.rdoM.AutoSize = true;
            this.rdoM.Location = new System.Drawing.Point(6, 15);
            this.rdoM.Name = "rdoM";
            this.rdoM.Size = new System.Drawing.Size(40, 21);
            this.rdoM.TabIndex = 0;
            this.rdoM.TabStop = true;
            this.rdoM.Text = "M";
            this.rdoM.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtHolderSOC);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtHolderDOB);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtPolicyName);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtInsComp);
            this.groupBox2.Location = new System.Drawing.Point(433, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 268);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medical Info";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 206);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 17);
            this.label15.TabIndex = 7;
            this.label15.Text = "Policy Holder Soc";
            // 
            // txtHolderSOC
            // 
            this.txtHolderSOC.Location = new System.Drawing.Point(4, 232);
            this.txtHolderSOC.Name = "txtHolderSOC";
            this.txtHolderSOC.Size = new System.Drawing.Size(188, 22);
            this.txtHolderSOC.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 146);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(133, 17);
            this.label16.TabIndex = 5;
            this.label16.Text = "Policy Holder D.O.B";
            // 
            // txtHolderDOB
            // 
            this.txtHolderDOB.Location = new System.Drawing.Point(5, 172);
            this.txtHolderDOB.Name = "txtHolderDOB";
            this.txtHolderDOB.Size = new System.Drawing.Size(188, 22);
            this.txtHolderDOB.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 17);
            this.label14.TabIndex = 3;
            this.label14.Text = "Policy Holder Name";
            // 
            // txtPolicyName
            // 
            this.txtPolicyName.Location = new System.Drawing.Point(5, 108);
            this.txtPolicyName.Name = "txtPolicyName";
            this.txtPolicyName.Size = new System.Drawing.Size(188, 22);
            this.txtPolicyName.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Insurance Company";
            // 
            // txtInsComp
            // 
            this.txtInsComp.Location = new System.Drawing.Point(6, 48);
            this.txtInsComp.Name = "txtInsComp";
            this.txtInsComp.Size = new System.Drawing.Size(188, 22);
            this.txtInsComp.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 258);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 17);
            this.label17.TabIndex = 52;
            this.label17.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(25, 278);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(354, 22);
            this.txtEmail.TabIndex = 53;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoOther);
            this.groupBox3.Controls.Add(this.rdoAsain);
            this.groupBox3.Controls.Add(this.rdoNativeAmerican);
            this.groupBox3.Controls.Add(this.rdoAfricanAmerican);
            this.groupBox3.Controls.Add(this.rdoHispanic);
            this.groupBox3.Controls.Add(this.rdoWhite);
            this.groupBox3.Location = new System.Drawing.Point(25, 328);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 131);
            this.groupBox3.TabIndex = 54;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " ";
            // 
            // rdoOther
            // 
            this.rdoOther.AutoSize = true;
            this.rdoOther.Location = new System.Drawing.Point(157, 79);
            this.rdoOther.Name = "rdoOther";
            this.rdoOther.Size = new System.Drawing.Size(65, 21);
            this.rdoOther.TabIndex = 5;
            this.rdoOther.TabStop = true;
            this.rdoOther.Text = "Other";
            this.rdoOther.UseVisualStyleBackColor = true;
            // 
            // rdoAsain
            // 
            this.rdoAsain.AutoSize = true;
            this.rdoAsain.Location = new System.Drawing.Point(157, 47);
            this.rdoAsain.Name = "rdoAsain";
            this.rdoAsain.Size = new System.Drawing.Size(64, 21);
            this.rdoAsain.TabIndex = 4;
            this.rdoAsain.TabStop = true;
            this.rdoAsain.Text = "Asian";
            this.rdoAsain.UseVisualStyleBackColor = true;
            // 
            // rdoNativeAmerican
            // 
            this.rdoNativeAmerican.AutoSize = true;
            this.rdoNativeAmerican.Location = new System.Drawing.Point(157, 21);
            this.rdoNativeAmerican.Name = "rdoNativeAmerican";
            this.rdoNativeAmerican.Size = new System.Drawing.Size(132, 21);
            this.rdoNativeAmerican.TabIndex = 3;
            this.rdoNativeAmerican.TabStop = true;
            this.rdoNativeAmerican.Text = "Native American";
            this.rdoNativeAmerican.UseVisualStyleBackColor = true;
            // 
            // rdoAfricanAmerican
            // 
            this.rdoAfricanAmerican.AutoSize = true;
            this.rdoAfricanAmerican.Location = new System.Drawing.Point(0, 81);
            this.rdoAfricanAmerican.Name = "rdoAfricanAmerican";
            this.rdoAfricanAmerican.Size = new System.Drawing.Size(136, 21);
            this.rdoAfricanAmerican.TabIndex = 2;
            this.rdoAfricanAmerican.TabStop = true;
            this.rdoAfricanAmerican.Text = "African American";
            this.rdoAfricanAmerican.UseVisualStyleBackColor = true;
            // 
            // rdoHispanic
            // 
            this.rdoHispanic.AutoSize = true;
            this.rdoHispanic.Location = new System.Drawing.Point(0, 49);
            this.rdoHispanic.Name = "rdoHispanic";
            this.rdoHispanic.Size = new System.Drawing.Size(83, 21);
            this.rdoHispanic.TabIndex = 1;
            this.rdoHispanic.TabStop = true;
            this.rdoHispanic.Text = "Hispanic";
            this.rdoHispanic.UseVisualStyleBackColor = true;
            // 
            // rdoWhite
            // 
            this.rdoWhite.AutoSize = true;
            this.rdoWhite.Location = new System.Drawing.Point(0, 23);
            this.rdoWhite.Name = "rdoWhite";
            this.rdoWhite.Size = new System.Drawing.Size(65, 21);
            this.rdoWhite.TabIndex = 0;
            this.rdoWhite.TabStop = true;
            this.rdoWhite.Text = "White";
            this.rdoWhite.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(284, 474);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 25);
            this.btnExit.TabIndex = 57;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.patientInfoToolStripMenuItem,
            this.billingToolStripMenuItem,
            this.appointmentToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(673, 28);
            this.menuStrip1.TabIndex = 60;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // patientInfoToolStripMenuItem
            // 
            this.patientInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEditPatientToolStripMenuItem,
            this.addEdietHouseholdToolStripMenuItem});
            this.patientInfoToolStripMenuItem.Name = "patientInfoToolStripMenuItem";
            this.patientInfoToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.patientInfoToolStripMenuItem.Text = "Patient Info";
            // 
            // addEditPatientToolStripMenuItem
            // 
            this.addEditPatientToolStripMenuItem.Name = "addEditPatientToolStripMenuItem";
            this.addEditPatientToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.addEditPatientToolStripMenuItem.Text = "Add/Edit Patient";
            this.addEditPatientToolStripMenuItem.Click += new System.EventHandler(this.addEditPatientToolStripMenuItem_Click);
            // 
            // addEdietHouseholdToolStripMenuItem
            // 
            this.addEdietHouseholdToolStripMenuItem.Name = "addEdietHouseholdToolStripMenuItem";
            this.addEdietHouseholdToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.addEdietHouseholdToolStripMenuItem.Text = "Add/Edit Household";
            this.addEdietHouseholdToolStripMenuItem.Click += new System.EventHandler(this.addEdietHouseholdToolStripMenuItem_Click);
            // 
            // billingToolStripMenuItem
            // 
            this.billingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalLedgerToolStripMenuItem,
            this.accoubntReceivableToolStripMenuItem});
            this.billingToolStripMenuItem.Name = "billingToolStripMenuItem";
            this.billingToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.billingToolStripMenuItem.Text = "Billing";
            // 
            // generalLedgerToolStripMenuItem
            // 
            this.generalLedgerToolStripMenuItem.Name = "generalLedgerToolStripMenuItem";
            this.generalLedgerToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.generalLedgerToolStripMenuItem.Text = "General Ledger";
            this.generalLedgerToolStripMenuItem.Click += new System.EventHandler(this.generalLedgerToolStripMenuItem_Click);
            // 
            // accoubntReceivableToolStripMenuItem
            // 
            this.accoubntReceivableToolStripMenuItem.Name = "accoubntReceivableToolStripMenuItem";
            this.accoubntReceivableToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.accoubntReceivableToolStripMenuItem.Text = "Account Receivable";
            this.accoubntReceivableToolStripMenuItem.Click += new System.EventHandler(this.accoubntReceivableToolStripMenuItem_Click);
            // 
            // appointmentToolStripMenuItem
            // 
            this.appointmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.appointmentToolStripMenuItem.Name = "appointmentToolStripMenuItem";
            this.appointmentToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.appointmentToolStripMenuItem.Text = "Appointment";
            // 
            // makeToolStripMenuItem
            // 
            this.makeToolStripMenuItem.Name = "makeToolStripMenuItem";
            this.makeToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.makeToolStripMenuItem.Text = "Make";
            this.makeToolStripMenuItem.Click += new System.EventHandler(this.makeToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appointmentListToolStripMenuItem,
            this.callListToolStripMenuItem,
            this.providerToolStripMenuItem,
            this.mTDPaymentToolStripMenuItem,
            this.postcardToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // appointmentListToolStripMenuItem
            // 
            this.appointmentListToolStripMenuItem.Name = "appointmentListToolStripMenuItem";
            this.appointmentListToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.appointmentListToolStripMenuItem.Text = "Appointment list";
            this.appointmentListToolStripMenuItem.Click += new System.EventHandler(this.appointmentListToolStripMenuItem_Click);
            // 
            // callListToolStripMenuItem
            // 
            this.callListToolStripMenuItem.Name = "callListToolStripMenuItem";
            this.callListToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.callListToolStripMenuItem.Text = "Call List";
            this.callListToolStripMenuItem.Click += new System.EventHandler(this.callListToolStripMenuItem_Click);
            // 
            // providerToolStripMenuItem
            // 
            this.providerToolStripMenuItem.Name = "providerToolStripMenuItem";
            this.providerToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.providerToolStripMenuItem.Text = "Provider";
            this.providerToolStripMenuItem.Click += new System.EventHandler(this.providerToolStripMenuItem_Click);
            // 
            // mTDPaymentToolStripMenuItem
            // 
            this.mTDPaymentToolStripMenuItem.Name = "mTDPaymentToolStripMenuItem";
            this.mTDPaymentToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.mTDPaymentToolStripMenuItem.Text = "MTD Payment";
            this.mTDPaymentToolStripMenuItem.Click += new System.EventHandler(this.mTDPaymentToolStripMenuItem_Click);
            // 
            // postcardToolStripMenuItem
            // 
            this.postcardToolStripMenuItem.Name = "postcardToolStripMenuItem";
            this.postcardToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.postcardToolStripMenuItem.Text = "Postcard";
            this.postcardToolStripMenuItem.Click += new System.EventHandler(this.postcardToolStripMenuItem_Click);
            // 
            // patientsBindingNavigator
            // 
            this.patientsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.patientsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.patientsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.patientsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.patientsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.patientsBindingNavigatorSaveItem});
            this.patientsBindingNavigator.Location = new System.Drawing.Point(0, 28);
            this.patientsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.patientsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.patientsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.patientsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.patientsBindingNavigator.Name = "patientsBindingNavigator";
            this.patientsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.patientsBindingNavigator.Size = new System.Drawing.Size(673, 27);
            this.patientsBindingNavigator.TabIndex = 61;
            this.patientsBindingNavigator.Text = "bindingNavigator1";
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
            // patientsBindingNavigatorSaveItem
            // 
            this.patientsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.patientsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("patientsBindingNavigatorSaveItem.Image")));
            this.patientsBindingNavigatorSaveItem.Name = "patientsBindingNavigatorSaveItem";
            this.patientsBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.patientsBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // systemsDataBase2DataSet
            // 
            this.systemsDataBase2DataSet.DataSetName = "SystemsDataBase2DataSet";
            this.systemsDataBase2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.systemsDataBase2DataSet;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Appointment_DataTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Complete_Service_DataTableAdapter = null;
            this.tableAdapterManager.Cpt_CodesTableAdapter = null;
            this.tableAdapterManager.HouseHoldTableAdapter = null;
            this.tableAdapterManager.InsurancecompaniesTableAdapter = null;
            this.tableAdapterManager.MTDChargesTableAdapter = null;
            this.tableAdapterManager.MTDPaymentsTableAdapter = null;
            this.tableAdapterManager.PatientsTableAdapter = this.patientsTableAdapter;
            this.tableAdapterManager.Pending_Insurance_ClaimsTableAdapter = null;
            this.tableAdapterManager.PostCardTableAdapter = null;
            this.tableAdapterManager.ProvidersTableAdapter = null;
            this.tableAdapterManager.RacesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NCH_Project.SystemsDataBase2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Visit_InfoTableAdapter = null;
            // 
            // patient_NumberLabel
            // 
            patient_NumberLabel.AutoSize = true;
            patient_NumberLabel.Location = new System.Drawing.Point(18, 74);
            patient_NumberLabel.Name = "patient_NumberLabel";
            patient_NumberLabel.Size = new System.Drawing.Size(110, 17);
            patient_NumberLabel.TabIndex = 61;
            patient_NumberLabel.Text = "Patient Number:";
            // 
            // patient_NumberTextBox
            // 
            this.patient_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "Patient Number", true));
            this.patient_NumberTextBox.Location = new System.Drawing.Point(134, 71);
            this.patient_NumberTextBox.Name = "patient_NumberTextBox";
            this.patient_NumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.patient_NumberTextBox.TabIndex = 62;
            // 
            // household_NumberLabel
            // 
            household_NumberLabel.AutoSize = true;
            household_NumberLabel.Location = new System.Drawing.Point(245, 74);
            household_NumberLabel.Name = "household_NumberLabel";
            household_NumberLabel.Size = new System.Drawing.Size(134, 17);
            household_NumberLabel.TabIndex = 62;
            household_NumberLabel.Text = "Household Number:";
            // 
            // household_NumberTextBox
            // 
            this.household_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "Household Number", true));
            this.household_NumberTextBox.Location = new System.Drawing.Point(384, 71);
            this.household_NumberTextBox.Name = "household_NumberTextBox";
            this.household_NumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.household_NumberTextBox.TabIndex = 63;
            // 
            // patient_NameLabel
            // 
            patient_NameLabel.AutoSize = true;
            patient_NameLabel.Location = new System.Drawing.Point(18, 111);
            patient_NameLabel.Name = "patient_NameLabel";
            patient_NameLabel.Size = new System.Drawing.Size(97, 17);
            patient_NameLabel.TabIndex = 63;
            patient_NameLabel.Text = "Patient Name:";
            // 
            // patient_NameTextBox
            // 
            this.patient_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "Patient Name", true));
            this.patient_NameTextBox.Location = new System.Drawing.Point(121, 108);
            this.patient_NameTextBox.Name = "patient_NameTextBox";
            this.patient_NameTextBox.Size = new System.Drawing.Size(210, 22);
            this.patient_NameTextBox.TabIndex = 64;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(18, 151);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(64, 17);
            addressLabel.TabIndex = 64;
            addressLabel.Text = "Address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(88, 148);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(274, 22);
            this.addressTextBox.TabIndex = 65;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(22, 205);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(53, 17);
            phoneLabel.TabIndex = 65;
            phoneLabel.Text = "Phone:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(21, 225);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 22);
            this.phoneTextBox.TabIndex = 66;
            // 
            // frmPatientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 530);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(patient_NameLabel);
            this.Controls.Add(this.patient_NameTextBox);
            this.Controls.Add(household_NumberLabel);
            this.Controls.Add(this.household_NumberTextBox);
            this.Controls.Add(patient_NumberLabel);
            this.Controls.Add(this.patient_NumberTextBox);
            this.Controls.Add(this.patientsBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpSex);
            this.Name = "frmPatientInfo";
            this.Text = " PatientInfo";
            this.Load += new System.EventHandler(this.frmPatientInfo_Load);
            this.grpSex.ResumeLayout(false);
            this.grpSex.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingNavigator)).EndInit();
            this.patientsBindingNavigator.ResumeLayout(false);
            this.patientsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.systemsDataBase2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpSex;
        private System.Windows.Forms.RadioButton rdoF;
        private System.Windows.Forms.RadioButton rdoM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPolicyName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtInsComp;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtHolderSOC;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtHolderDOB;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoOther;
        private System.Windows.Forms.RadioButton rdoAsain;
        private System.Windows.Forms.RadioButton rdoNativeAmerican;
        private System.Windows.Forms.RadioButton rdoAfricanAmerican;
        private System.Windows.Forms.RadioButton rdoHispanic;
        private System.Windows.Forms.RadioButton rdoWhite;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEditPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEdietHouseholdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalLedgerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accoubntReceivableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem callListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem providerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mTDPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postcardToolStripMenuItem;
        private System.Windows.Forms.BindingNavigator patientsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton patientsBindingNavigatorSaveItem;
        private SystemsDataBase2DataSet systemsDataBase2DataSet;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private SystemsDataBase2DataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private SystemsDataBase2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox patient_NumberTextBox;
        private System.Windows.Forms.TextBox household_NumberTextBox;
        private System.Windows.Forms.TextBox patient_NameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
    }
}