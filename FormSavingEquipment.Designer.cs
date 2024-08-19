namespace EquipmentListTable
{
    partial class FormSavingEquipment
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitle = new Label();
            labelEquipmentName = new Label();
            labelSerialNumber = new Label();
            labelEquipmentType = new Label();
            labelInventoryNo = new Label();
            labelDefaultLocation = new Label();
            labelBorrower = new Label();
            textBoxEquipmentName = new TextBox();
            textBoxSerialNumber = new TextBox();
            textBoxInventoryNo = new TextBox();
            comboBoxEquipmentType = new ComboBox();
            comboBoxDefaultLocation = new ComboBox();
            textBoxBorrower = new TextBox();
            labelLoanedReturnDate = new Label();
            labelCalibrationDate = new Label();
            labelLoaned = new Label();
            labelInHouseProduction = new Label();
            labelCalibratable = new Label();
            labelOwnerSite = new Label();
            checkBoxCalibratable = new CheckBox();
            checkBoxInHouseProduction = new CheckBox();
            checkBoxLoaned = new CheckBox();
            comboBoxLoanedOwnerSite = new ComboBox();
            dateTimePickerCalibration = new DateTimePicker();
            dateTimePickerLoanedReturn = new DateTimePicker();
            comboBoxDedicatedToProject = new ComboBox();
            labelDedicatedToProject = new Label();
            labelStatus = new Label();
            labelPriceHyperlink = new Label();
            labelImageHyperlink = new Label();
            labelRelatedDocsHyperlink = new Label();
            labelSharedProjects = new Label();
            labelComment = new Label();
            labelHistoryDocsHyperlink = new Label();
            labelFaultDescription = new Label();
            comboBoxStatus = new ComboBox();
            richTextBoxComment = new RichTextBox();
            richTextBoxFaultDescription = new RichTextBox();
            checkedListBoxSharedProjects = new CheckedListBox();
            buttonSave = new Button();
            buttonClear = new Button();
            textBoxRelatedDocsHyperlink = new TextBox();
            textBoxImageHyperlink = new TextBox();
            textBoxPriceHyperlink = new TextBox();
            textBoxHistoryDocsHyperlink = new TextBox();
            buttonUpdate = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(27, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(179, 38);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "EQUIPMENT";
            // 
            // labelEquipmentName
            // 
            labelEquipmentName.AutoSize = true;
            labelEquipmentName.Location = new Point(27, 59);
            labelEquipmentName.Name = "labelEquipmentName";
            labelEquipmentName.Size = new Size(125, 20);
            labelEquipmentName.TabIndex = 1;
            labelEquipmentName.Text = "Equipment Name";
            // 
            // labelSerialNumber
            // 
            labelSerialNumber.AutoSize = true;
            labelSerialNumber.Location = new Point(27, 99);
            labelSerialNumber.Name = "labelSerialNumber";
            labelSerialNumber.Size = new Size(104, 20);
            labelSerialNumber.TabIndex = 2;
            labelSerialNumber.Text = "Serial Number";
            // 
            // labelEquipmentType
            // 
            labelEquipmentType.AutoSize = true;
            labelEquipmentType.Location = new Point(27, 138);
            labelEquipmentType.Name = "labelEquipmentType";
            labelEquipmentType.Size = new Size(116, 20);
            labelEquipmentType.TabIndex = 3;
            labelEquipmentType.Text = "Equipment Type";
            // 
            // labelInventoryNo
            // 
            labelInventoryNo.AutoSize = true;
            labelInventoryNo.Location = new Point(547, 95);
            labelInventoryNo.Name = "labelInventoryNo";
            labelInventoryNo.Size = new Size(94, 20);
            labelInventoryNo.TabIndex = 0;
            labelInventoryNo.Text = "Inventory No";
            // 
            // labelDefaultLocation
            // 
            labelDefaultLocation.AutoSize = true;
            labelDefaultLocation.Location = new Point(27, 172);
            labelDefaultLocation.Name = "labelDefaultLocation";
            labelDefaultLocation.Size = new Size(119, 20);
            labelDefaultLocation.TabIndex = 5;
            labelDefaultLocation.Text = "Default Location";
            // 
            // labelBorrower
            // 
            labelBorrower.AutoSize = true;
            labelBorrower.Location = new Point(27, 207);
            labelBorrower.Name = "labelBorrower";
            labelBorrower.Size = new Size(70, 20);
            labelBorrower.TabIndex = 6;
            labelBorrower.Text = "Borrower";
            // 
            // textBoxEquipmentName
            // 
            textBoxEquipmentName.Location = new Point(219, 56);
            textBoxEquipmentName.Name = "textBoxEquipmentName";
            textBoxEquipmentName.Size = new Size(693, 27);
            textBoxEquipmentName.TabIndex = 7;
            // 
            // textBoxSerialNumber
            // 
            textBoxSerialNumber.Location = new Point(219, 92);
            textBoxSerialNumber.Name = "textBoxSerialNumber";
            textBoxSerialNumber.Size = new Size(214, 27);
            textBoxSerialNumber.TabIndex = 8;
            // 
            // textBoxInventoryNo
            // 
            textBoxInventoryNo.Location = new Point(699, 92);
            textBoxInventoryNo.Name = "textBoxInventoryNo";
            textBoxInventoryNo.Size = new Size(214, 27);
            textBoxInventoryNo.TabIndex = 9;
            // 
            // comboBoxEquipmentType
            // 
            comboBoxEquipmentType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxEquipmentType.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxEquipmentType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEquipmentType.FormattingEnabled = true;
            comboBoxEquipmentType.Location = new Point(219, 130);
            comboBoxEquipmentType.Name = "comboBoxEquipmentType";
            comboBoxEquipmentType.Size = new Size(693, 28);
            comboBoxEquipmentType.TabIndex = 10;
            // 
            // comboBoxDefaultLocation
            // 
            comboBoxDefaultLocation.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxDefaultLocation.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxDefaultLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDefaultLocation.FormattingEnabled = true;
            comboBoxDefaultLocation.Items.AddRange(new object[] { "6. DOLAP - 1.BÖLME" });
            comboBoxDefaultLocation.Location = new Point(219, 164);
            comboBoxDefaultLocation.Name = "comboBoxDefaultLocation";
            comboBoxDefaultLocation.Size = new Size(265, 28);
            comboBoxDefaultLocation.TabIndex = 11;
            // 
            // textBoxBorrower
            // 
            textBoxBorrower.Location = new Point(219, 200);
            textBoxBorrower.Name = "textBoxBorrower";
            textBoxBorrower.Size = new Size(214, 27);
            textBoxBorrower.TabIndex = 12;
            // 
            // labelLoanedReturnDate
            // 
            labelLoanedReturnDate.AutoSize = true;
            labelLoanedReturnDate.Location = new Point(547, 328);
            labelLoanedReturnDate.Name = "labelLoanedReturnDate";
            labelLoanedReturnDate.Size = new Size(141, 20);
            labelLoanedReturnDate.TabIndex = 0;
            labelLoanedReturnDate.Text = "Loaned Return Date";
            // 
            // labelCalibrationDate
            // 
            labelCalibrationDate.AutoSize = true;
            labelCalibrationDate.Location = new Point(547, 249);
            labelCalibrationDate.Name = "labelCalibrationDate";
            labelCalibrationDate.Size = new Size(118, 20);
            labelCalibrationDate.TabIndex = 0;
            labelCalibrationDate.Text = "Calibration Date";
            // 
            // labelLoaned
            // 
            labelLoaned.AutoSize = true;
            labelLoaned.Location = new Point(27, 334);
            labelLoaned.Name = "labelLoaned";
            labelLoaned.Size = new Size(58, 20);
            labelLoaned.TabIndex = 0;
            labelLoaned.Text = "Loaned";
            // 
            // labelInHouseProduction
            // 
            labelInHouseProduction.AutoSize = true;
            labelInHouseProduction.Location = new Point(27, 298);
            labelInHouseProduction.Name = "labelInHouseProduction";
            labelInHouseProduction.Size = new Size(142, 20);
            labelInHouseProduction.TabIndex = 0;
            labelInHouseProduction.Text = "In-house Production";
            // 
            // labelCalibratable
            // 
            labelCalibratable.AutoSize = true;
            labelCalibratable.Location = new Point(27, 262);
            labelCalibratable.Name = "labelCalibratable";
            labelCalibratable.Size = new Size(90, 20);
            labelCalibratable.TabIndex = 0;
            labelCalibratable.Text = "Calibratable";
            // 
            // labelOwnerSite
            // 
            labelOwnerSite.AutoSize = true;
            labelOwnerSite.Location = new Point(547, 358);
            labelOwnerSite.Name = "labelOwnerSite";
            labelOwnerSite.Size = new Size(134, 20);
            labelOwnerSite.TabIndex = 0;
            labelOwnerSite.Text = "Loaned Owner Site";
            // 
            // checkBoxCalibratable
            // 
            checkBoxCalibratable.AutoSize = true;
            checkBoxCalibratable.Location = new Point(219, 258);
            checkBoxCalibratable.Name = "checkBoxCalibratable";
            checkBoxCalibratable.Size = new Size(18, 17);
            checkBoxCalibratable.TabIndex = 13;
            checkBoxCalibratable.UseVisualStyleBackColor = true;
            // 
            // checkBoxInHouseProduction
            // 
            checkBoxInHouseProduction.AutoSize = true;
            checkBoxInHouseProduction.Location = new Point(219, 294);
            checkBoxInHouseProduction.Name = "checkBoxInHouseProduction";
            checkBoxInHouseProduction.Size = new Size(18, 17);
            checkBoxInHouseProduction.TabIndex = 14;
            checkBoxInHouseProduction.UseVisualStyleBackColor = true;
            // 
            // checkBoxLoaned
            // 
            checkBoxLoaned.AutoSize = true;
            checkBoxLoaned.Location = new Point(219, 331);
            checkBoxLoaned.Name = "checkBoxLoaned";
            checkBoxLoaned.Size = new Size(18, 17);
            checkBoxLoaned.TabIndex = 15;
            checkBoxLoaned.UseVisualStyleBackColor = true;
            // 
            // comboBoxLoanedOwnerSite
            // 
            comboBoxLoanedOwnerSite.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxLoanedOwnerSite.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxLoanedOwnerSite.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLoanedOwnerSite.FormattingEnabled = true;
            comboBoxLoanedOwnerSite.ItemHeight = 20;
            comboBoxLoanedOwnerSite.Items.AddRange(new object[] { "TCBL" });
            comboBoxLoanedOwnerSite.Location = new Point(699, 355);
            comboBoxLoanedOwnerSite.Name = "comboBoxLoanedOwnerSite";
            comboBoxLoanedOwnerSite.Size = new Size(214, 28);
            comboBoxLoanedOwnerSite.TabIndex = 18;
            // 
            // dateTimePickerCalibration
            // 
            dateTimePickerCalibration.Location = new Point(699, 244);
            dateTimePickerCalibration.Name = "dateTimePickerCalibration";
            dateTimePickerCalibration.Size = new Size(214, 27);
            dateTimePickerCalibration.TabIndex = 16;
            // 
            // dateTimePickerLoanedReturn
            // 
            dateTimePickerLoanedReturn.Location = new Point(700, 323);
            dateTimePickerLoanedReturn.Name = "dateTimePickerLoanedReturn";
            dateTimePickerLoanedReturn.Size = new Size(214, 27);
            dateTimePickerLoanedReturn.TabIndex = 17;
            // 
            // comboBoxDedicatedToProject
            // 
            comboBoxDedicatedToProject.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxDedicatedToProject.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxDedicatedToProject.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDedicatedToProject.FormattingEnabled = true;
            comboBoxDedicatedToProject.ItemHeight = 20;
            comboBoxDedicatedToProject.Location = new Point(221, 407);
            comboBoxDedicatedToProject.Name = "comboBoxDedicatedToProject";
            comboBoxDedicatedToProject.Size = new Size(693, 28);
            comboBoxDedicatedToProject.TabIndex = 19;
            // 
            // labelDedicatedToProject
            // 
            labelDedicatedToProject.AutoSize = true;
            labelDedicatedToProject.Location = new Point(27, 410);
            labelDedicatedToProject.Name = "labelDedicatedToProject";
            labelDedicatedToProject.Size = new Size(146, 20);
            labelDedicatedToProject.TabIndex = 25;
            labelDedicatedToProject.Text = "Dedicated to Project";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(27, 664);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(49, 20);
            labelStatus.TabIndex = 31;
            labelStatus.Text = "Status";
            // 
            // labelPriceHyperlink
            // 
            labelPriceHyperlink.AutoSize = true;
            labelPriceHyperlink.Location = new Point(27, 612);
            labelPriceHyperlink.Name = "labelPriceHyperlink";
            labelPriceHyperlink.Size = new Size(108, 20);
            labelPriceHyperlink.TabIndex = 30;
            labelPriceHyperlink.Text = "Price Hyperlink";
            // 
            // labelImageHyperlink
            // 
            labelImageHyperlink.AutoSize = true;
            labelImageHyperlink.Location = new Point(27, 565);
            labelImageHyperlink.Name = "labelImageHyperlink";
            labelImageHyperlink.Size = new Size(118, 20);
            labelImageHyperlink.TabIndex = 29;
            labelImageHyperlink.Text = "Image Hyperlink";
            // 
            // labelRelatedDocsHyperlink
            // 
            labelRelatedDocsHyperlink.AutoSize = true;
            labelRelatedDocsHyperlink.Location = new Point(27, 517);
            labelRelatedDocsHyperlink.Name = "labelRelatedDocsHyperlink";
            labelRelatedDocsHyperlink.Size = new Size(164, 20);
            labelRelatedDocsHyperlink.TabIndex = 28;
            labelRelatedDocsHyperlink.Text = "Related Docs Hyperlink";
            // 
            // labelSharedProjects
            // 
            labelSharedProjects.AutoSize = true;
            labelSharedProjects.Location = new Point(24, 452);
            labelSharedProjects.Name = "labelSharedProjects";
            labelSharedProjects.Size = new Size(111, 20);
            labelSharedProjects.TabIndex = 27;
            labelSharedProjects.Text = "Shared Projects";
            // 
            // labelComment
            // 
            labelComment.AutoSize = true;
            labelComment.Location = new Point(27, 839);
            labelComment.Name = "labelComment";
            labelComment.Size = new Size(74, 20);
            labelComment.TabIndex = 34;
            labelComment.Text = "Comment";
            // 
            // labelHistoryDocsHyperlink
            // 
            labelHistoryDocsHyperlink.AutoSize = true;
            labelHistoryDocsHyperlink.Location = new Point(24, 784);
            labelHistoryDocsHyperlink.Name = "labelHistoryDocsHyperlink";
            labelHistoryDocsHyperlink.Size = new Size(123, 20);
            labelHistoryDocsHyperlink.TabIndex = 33;
            labelHistoryDocsHyperlink.Text = "History Hyperlink";
            // 
            // labelFaultDescription
            // 
            labelFaultDescription.AutoSize = true;
            labelFaultDescription.Location = new Point(24, 707);
            labelFaultDescription.Name = "labelFaultDescription";
            labelFaultDescription.Size = new Size(120, 20);
            labelFaultDescription.TabIndex = 32;
            labelFaultDescription.Text = "Fault Description";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxStatus.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.ItemHeight = 20;
            comboBoxStatus.Items.AddRange(new object[] { "Active", "Not Working", "Obsolete", "Scraped" });
            comboBoxStatus.Location = new Point(221, 661);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(265, 28);
            comboBoxStatus.TabIndex = 24;
            // 
            // richTextBoxComment
            // 
            richTextBoxComment.Location = new Point(221, 836);
            richTextBoxComment.Name = "richTextBoxComment";
            richTextBoxComment.Size = new Size(693, 60);
            richTextBoxComment.TabIndex = 27;
            richTextBoxComment.Text = "";
            // 
            // richTextBoxFaultDescription
            // 
            richTextBoxFaultDescription.Location = new Point(221, 704);
            richTextBoxFaultDescription.Name = "richTextBoxFaultDescription";
            richTextBoxFaultDescription.Size = new Size(693, 63);
            richTextBoxFaultDescription.TabIndex = 25;
            richTextBoxFaultDescription.Text = "";
            // 
            // checkedListBoxSharedProjects
            // 
            checkedListBoxSharedProjects.FormattingEnabled = true;
            checkedListBoxSharedProjects.Items.AddRange(new object[] { "AL BS6", "AL BS6 DCM7.1", "Albonair A2CU", "Albonair A2CU+ BS6", "Asia Pacific (AP)" });
            checkedListBoxSharedProjects.Location = new Point(221, 442);
            checkedListBoxSharedProjects.Name = "checkedListBoxSharedProjects";
            checkedListBoxSharedProjects.Size = new Size(693, 48);
            checkedListBoxSharedProjects.TabIndex = 20;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSave.Location = new Point(775, 920);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(138, 44);
            buttonSave.TabIndex = 29;
            buttonSave.Text = "SAVE";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClear.Location = new Point(631, 920);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(138, 44);
            buttonClear.TabIndex = 28;
            buttonClear.Text = "CLEAR";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // textBoxRelatedDocsHyperlink
            // 
            textBoxRelatedDocsHyperlink.Location = new Point(221, 510);
            textBoxRelatedDocsHyperlink.Name = "textBoxRelatedDocsHyperlink";
            textBoxRelatedDocsHyperlink.Size = new Size(693, 27);
            textBoxRelatedDocsHyperlink.TabIndex = 21;
            // 
            // textBoxImageHyperlink
            // 
            textBoxImageHyperlink.Location = new Point(221, 558);
            textBoxImageHyperlink.Name = "textBoxImageHyperlink";
            textBoxImageHyperlink.Size = new Size(693, 27);
            textBoxImageHyperlink.TabIndex = 22;
            // 
            // textBoxPriceHyperlink
            // 
            textBoxPriceHyperlink.Location = new Point(221, 605);
            textBoxPriceHyperlink.Name = "textBoxPriceHyperlink";
            textBoxPriceHyperlink.Size = new Size(692, 27);
            textBoxPriceHyperlink.TabIndex = 23;
            // 
            // textBoxHistoryDocsHyperlink
            // 
            textBoxHistoryDocsHyperlink.Location = new Point(221, 781);
            textBoxHistoryDocsHyperlink.Name = "textBoxHistoryDocsHyperlink";
            textBoxHistoryDocsHyperlink.Size = new Size(693, 27);
            textBoxHistoryDocsHyperlink.TabIndex = 26;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUpdate.Location = new Point(776, 920);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(138, 44);
            buttonUpdate.TabIndex = 29;
            buttonUpdate.Text = "UPDATE";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // FormSavingEquipment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(969, 1009);
            Controls.Add(buttonUpdate);
            Controls.Add(textBoxHistoryDocsHyperlink);
            Controls.Add(textBoxPriceHyperlink);
            Controls.Add(textBoxImageHyperlink);
            Controls.Add(textBoxRelatedDocsHyperlink);
            Controls.Add(buttonClear);
            Controls.Add(buttonSave);
            Controls.Add(checkedListBoxSharedProjects);
            Controls.Add(richTextBoxFaultDescription);
            Controls.Add(richTextBoxComment);
            Controls.Add(comboBoxStatus);
            Controls.Add(labelComment);
            Controls.Add(labelHistoryDocsHyperlink);
            Controls.Add(labelFaultDescription);
            Controls.Add(labelStatus);
            Controls.Add(labelPriceHyperlink);
            Controls.Add(labelImageHyperlink);
            Controls.Add(labelRelatedDocsHyperlink);
            Controls.Add(labelSharedProjects);
            Controls.Add(comboBoxDedicatedToProject);
            Controls.Add(labelDedicatedToProject);
            Controls.Add(dateTimePickerLoanedReturn);
            Controls.Add(dateTimePickerCalibration);
            Controls.Add(comboBoxLoanedOwnerSite);
            Controls.Add(checkBoxLoaned);
            Controls.Add(checkBoxInHouseProduction);
            Controls.Add(checkBoxCalibratable);
            Controls.Add(labelOwnerSite);
            Controls.Add(labelLoanedReturnDate);
            Controls.Add(labelCalibrationDate);
            Controls.Add(labelLoaned);
            Controls.Add(labelInHouseProduction);
            Controls.Add(labelCalibratable);
            Controls.Add(textBoxBorrower);
            Controls.Add(comboBoxDefaultLocation);
            Controls.Add(comboBoxEquipmentType);
            Controls.Add(textBoxInventoryNo);
            Controls.Add(textBoxSerialNumber);
            Controls.Add(textBoxEquipmentName);
            Controls.Add(labelBorrower);
            Controls.Add(labelDefaultLocation);
            Controls.Add(labelInventoryNo);
            Controls.Add(labelEquipmentType);
            Controls.Add(labelSerialNumber);
            Controls.Add(labelEquipmentName);
            Controls.Add(labelTitle);
            Name = "FormSavingEquipment";
            Text = "Saving Equipment";
            Load += FormSavingEquipment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button buttonSave;
        public Button buttonUpdate;
        public Label labelTitle;
        public Label labelEquipmentName;
        public Label labelSerialNumber;
        public Label labelEquipmentType;
        public Label labelInventoryNo;
        public Label labelDefaultLocation;
        public Label labelBorrower;
        public TextBox textBoxEquipmentName;
        public TextBox textBoxSerialNumber;
        public TextBox textBoxInventoryNo;
        public ComboBox comboBoxEquipmentType;
        public ComboBox comboBoxDefaultLocation;
        public TextBox textBoxBorrower;
        public Label labelLoanedReturnDate;
        public Label labelCalibrationDate;
        public Label labelLoaned;
        public Label labelInHouseProduction;
        public Label labelCalibratable;
        public Label labelOwnerSite;
        public CheckBox checkBoxCalibratable;
        public CheckBox checkBoxInHouseProduction;
        public CheckBox checkBoxLoaned;
        public ComboBox comboBoxLoanedOwnerSite;
        public DateTimePicker dateTimePickerCalibration;
        public DateTimePicker dateTimePickerLoanedReturn;
        public ComboBox comboBoxDedicatedToProject;
        public Label labelDedicatedToProject;
        public Label labelStatus;
        public Label labelPriceHyperlink;
        public Label labelImageHyperlink;
        public Label labelRelatedDocsHyperlink;
        public Label labelSharedProjects;
        public Label labelComment;
        public Label labelHistoryDocsHyperlink;
        public Label labelFaultDescription;
        public ComboBox comboBoxStatus;
        public RichTextBox richTextBoxComment;
        public RichTextBox richTextBoxFaultDescription;
        public CheckedListBox checkedListBoxSharedProjects;
        public Button buttonClear;
        public TextBox textBoxRelatedDocsHyperlink;
        public TextBox textBoxImageHyperlink;
        public TextBox textBoxPriceHyperlink;
        public TextBox textBoxHistoryDocsHyperlink;
    }
}