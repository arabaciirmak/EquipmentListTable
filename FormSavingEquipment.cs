using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;

namespace EquipmentListTable
{
    public partial class FormSavingEquipment : Form
    {
        public FormSavingEquipment()
        {
            InitializeComponent();
        }

        void clear() // Cleans all of the inputs from the screen
        {
            textBoxEquipmentName.Clear();
            textBoxSerialNumber.Clear();
            textBoxInventoryNo.Clear();
            textBoxBorrower.Clear();
            textBoxRelatedDocsHyperlink.Clear();
            textBoxImageHyperlink.Clear();
            textBoxPriceHyperlink.Clear();
            textBoxHistoryDocsHyperlink.Clear();
            comboBoxEquipmentType.SelectedIndex = -1;
            comboBoxDefaultLocation.SelectedIndex = -1;
            comboBoxLoanedOwnerSite.SelectedIndex = -1;
            comboBoxDedicatedToProject.SelectedIndex = -1;
            comboBoxStatus.SelectedIndex = -1;
            checkBoxCalibratable.Checked = false;
            checkBoxInHouseProduction.Checked = false;
            checkBoxLoaned.Checked = false;
            dateTimePickerCalibration.Checked = false;
            dateTimePickerLoanedReturn.Checked = false;
            richTextBoxComment.Clear();
            richTextBoxFaultDescription.Clear();
            for (int i = 0; i < checkedListBoxSharedProjects.Items.Count; i++)
            {
                checkedListBoxSharedProjects.SetItemChecked(i, false);
            }
            dateTimePickerCalibration.Value = DateTime.Today;
            dateTimePickerLoanedReturn.Value = DateTime.Today;
        }


        void LoadComboboxes() // Reload the options in comboboxes
        {
            SqlCommand sc1 = new SqlCommand("SELECT * FROM EquipmentTypeTable", con);
            SqlDataReader dr1;
            con.Open();
            dr1 = sc1.ExecuteReader();
            while (dr1.Read())
            {
                comboBoxEquipmentType.Items.Add(dr1["Equipment Type"]);
            }
            con.Close();

            SqlCommand sc2 = new SqlCommand("SELECT * FROM DefaultLocationTable", con);
            SqlDataReader dr2;
            con.Open();
            dr2 = sc2.ExecuteReader();
            while (dr2.Read())
            {
                comboBoxDefaultLocation.Items.Add(dr2["Default Location"]);
            }
            con.Close();

            SqlCommand sc3 = new SqlCommand("SELECT * FROM LoanedOwnerSiteTable", con);
            SqlDataReader dr3;
            con.Open();
            dr3 = sc3.ExecuteReader();
            while (dr3.Read())
            {
                comboBoxLoanedOwnerSite.Items.Add(dr3["Loaned Owner Site"]);
            }
            con.Close();

            SqlCommand sc4 = new SqlCommand("SELECT * FROM DedictedToProjectTable", con);
            SqlDataReader dr4;
            con.Open();
            dr4 = sc4.ExecuteReader();
            while (dr4.Read())
            {
                comboBoxDedicatedToProject.Items.Add(dr4["Dedicted To Project"]);
            }
            con.Close();
        }


        int count;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EIER2L0\\SQLEXPRESS03;Initial Catalog=EQUIPMENT;Integrated Security=True;TrustServerCertificate=True;");
        // We declared global variables because we will use repeatedly 


        private void FormSavingEquipment_Load(object sender, EventArgs e)
        {
            clear();
            LoadComboboxes();
            UpdateUIFormSavingEquipment();
        }

        private void buttonSave_Click(object sender, EventArgs e) // Enters the input informations to the sql database
        {
            FormInventoryManagement f2 = (FormInventoryManagement)Application.OpenForms["FormInventoryManagement"];
            // To set the relation with No and IDType by using count variable
            SqlCommand sc_count = new SqlCommand("SELECT TOP 1 No FROM Equipment_Table ORDER BY No DESC", con);
            SqlDataReader dr_count;
            con.Open();
            dr_count = sc_count.ExecuteReader();
            if (dr_count.Read())
            {
                count = Convert.ToInt32(dr_count["No"]);
                count++;
            }
            con.Close();

            string sqlQuery = "INSERT INTO Equipment_Table (IDType, EquipmentName, EquipmentType, DefaultLocation, Status, Borrower, DedicatedtoProject, SharedProject, RelatedDocsHyperlink, Comment, CalibrationDate, InventoryNumber, Calibratible, FaultDescription, HistoryHyperlink, ImageHyperlink, InHouseProduction, Loaned, LoanedOwnerSite, LoanedReturnDate, PriceHyperlink, SerialNumber, CreatedBy, Created) " +
                                           "VALUES (@IDType, @EquipmentName, @EquipmentType, @DefaultLocation, @Status, @Borrower, @DedicatedtoProject, @SharedProject, @RelatedDocsHyperlink, @Comment, @CalibrationDate, @InventoryNumber, @Calibratible, @FaultDescription, @HistoryHyperlink, @ImageHyperlink, @InHouseProduction, @Loaned, @LoanedOwnerSite, @LoanedReturnDate, @PriceHyperlink, @SerialNumber, @CreatedBy, @Created)";
            SqlCommand sc = new SqlCommand(sqlQuery, con);
            sc.Parameters.AddWithValue("@IDType", "EQ " + count);
            sc.Parameters.AddWithValue("@EquipmentName", textBoxEquipmentName.Text);
            sc.Parameters.AddWithValue("@EquipmentType", comboBoxEquipmentType.Text);
            sc.Parameters.AddWithValue("@DefaultLocation", comboBoxDefaultLocation.Text);
            sc.Parameters.AddWithValue("@Status", comboBoxStatus.Text);
            sc.Parameters.AddWithValue("@Borrower", textBoxBorrower.Text);
            sc.Parameters.AddWithValue("@DedicatedtoProject", comboBoxDedicatedToProject.Text);
            var checkedItems = checkedListBoxSharedProjects.CheckedItems.OfType<string>().ToArray();
            string sharedProjects = string.Join(", ", checkedItems);
            sc.Parameters.AddWithValue("@SharedProject", sharedProjects);
            sc.Parameters.AddWithValue("@RelatedDocsHyperlink", textBoxRelatedDocsHyperlink.Text);
            sc.Parameters.AddWithValue("@Comment", richTextBoxComment.Text);
            sc.Parameters.AddWithValue("@InventoryNumber", textBoxInventoryNo.Text);
            if (checkBoxCalibratable.Checked)
            {
                sc.Parameters.AddWithValue("@Calibratible", "TRUE");
            }
            else
            {
                sc.Parameters.AddWithValue("@Calibratible", "FALSE");
            }
            if (dateTimePickerCalibration.Value.Date == DateTime.Today)
            {
                sc.Parameters.AddWithValue("@CalibrationDate", DBNull.Value);
            }
            else
            {
                sc.Parameters.AddWithValue("@CalibrationDate", dateTimePickerCalibration.Value);
            }
            sc.Parameters.AddWithValue("@FaultDescription", richTextBoxFaultDescription.Text);
            sc.Parameters.AddWithValue("@HistoryHyperlink", textBoxImageHyperlink.Text);
            sc.Parameters.AddWithValue("@ImageHyperlink", textBoxPriceHyperlink.Text);
            if (checkBoxInHouseProduction.Checked)
            {
                sc.Parameters.AddWithValue("@InHouseProduction", "TRUE");
            }
            else
            {
                sc.Parameters.AddWithValue("@InHouseProduction", "FALSE");
            }
            sc.Parameters.AddWithValue("@LoanedOwnerSite", comboBoxLoanedOwnerSite.Text);
            if (checkBoxLoaned.Checked)
            {
                sc.Parameters.AddWithValue("@Loaned", "TRUE");
            }
            else
            {
                sc.Parameters.AddWithValue("@Loaned", "FALSE");
            }
            if (dateTimePickerLoanedReturn.Value.Date == DateTime.Today)
            {
                sc.Parameters.AddWithValue("@LoanedReturnDate", DBNull.Value);
            }
            else
            {
                sc.Parameters.AddWithValue("@LoanedReturnDate", dateTimePickerLoanedReturn.Value);
            }
            sc.Parameters.AddWithValue("@PriceHyperlink", textBoxHistoryDocsHyperlink.Text);
            sc.Parameters.AddWithValue("@SerialNumber", textBoxSerialNumber.Text);
            sc.Parameters.AddWithValue("@CreatedBy", Environment.UserName);
            sc.Parameters.AddWithValue("@Created", DateTime.Now);
            con.Open();
            sc.ExecuteNonQuery();
            con.Close();
            clear();
            LoadComboboxes();
            f2.LoadDataTable();
        }


        private void buttonClear_Click(object sender, EventArgs e)
        {
            clear();
        }


        private void buttonUpdate_Click(object sender, EventArgs e) // Enters the input informations that we have changed to the sql database
        {
            FormInventoryManagement f2 = (FormInventoryManagement)Application.OpenForms["FormInventoryManagement"];
            string newEquipmentName = textBoxEquipmentName.Text;
            string newEquipmentType = comboBoxEquipmentType.Text;
            string newDefaultLocation = comboBoxDefaultLocation.Text;
            string newStatus = comboBoxStatus.Text;
            string newBorrower = textBoxBorrower.Text;
            string newDedicatedtoProject = comboBoxDedicatedToProject.Text;
            var checkedItems = checkedListBoxSharedProjects.CheckedItems.OfType<string>().ToArray();
            string newSharedProject = string.Join(", ", checkedItems); // To add more than one input in database for SharedProject
            string newRelatedDocsHyperlink = textBoxRelatedDocsHyperlink.Text;
            string newComment = richTextBoxComment.Text;
            DateTime newCalibrationDate = dateTimePickerCalibration.Value;
            string newInventoryNumber = textBoxInventoryNo.Text;
            string newCalibratible = checkBoxCalibratable.Checked.ToString().ToUpper();
            string newFaultDescription = richTextBoxFaultDescription.Text;
            string newHistoryHyperlink = textBoxImageHyperlink.Text;
            string newImageHyperlink = textBoxPriceHyperlink.Text;
            string newInHouseProduction = checkBoxInHouseProduction.Checked.ToString().ToUpper();
            string newLoaned = checkBoxLoaned.Checked.ToString().ToUpper();
            string newLoanedOwnerSite = comboBoxLoanedOwnerSite.Text;
            DateTime newLoanedReturnDate = dateTimePickerLoanedReturn.Value;
            string newPriceHyperlink = textBoxHistoryDocsHyperlink.Text;
            string newSerialNumber = textBoxSerialNumber.Text;
            string newModifiedBy = Environment.UserName;
            DateTime newModified = DateTime.Now;
            string newIDType = f2.dataGridViewEquipmentList.CurrentRow.Cells[1].Value.ToString();

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Equipment_Table SET EquipmentName = @newEquipmentName, EquipmentType = @newEquipmentType, DefaultLocation = @newDefaultLocation, Status = @newStatus, Borrower = @newBorrower, " +
                "DedicatedtoProject = @newDedicatedtoProject, SharedProject = @newSharedProject, RelatedDocsHyperlink = @newRelatedDocsHyperlink, Comment = @newComment, CalibrationDate = @newCalibrationDate, InventoryNumber = @newInventoryNumber, " +
                " Calibratible = @newCalibratible, FaultDescription = @newFaultDescription, HistoryHyperlink = @newHistoryHyperlink, ImageHyperlink = @newImageHyperlink, InHouseProduction = @newInHouseProduction, " +
                "Loaned = @newLoaned, LoanedOwnerSite = @newLoanedOwnerSite, LoanedReturnDate = @newLoanedReturnDate, PriceHyperlink = @newPriceHyperlink, SerialNumber = @newSerialNumber, ModifiedBy = @newModifiedBy, Modified = @newModified WHERE IDType = @newIDType";
            cmd.Parameters.AddWithValue("@newEquipmentName", newEquipmentName);
            cmd.Parameters.AddWithValue("@newEquipmentType", newEquipmentType);
            cmd.Parameters.AddWithValue("@newDefaultLocation", newDefaultLocation);
            cmd.Parameters.AddWithValue("@newStatus", newStatus);
            cmd.Parameters.AddWithValue("@newBorrower", newBorrower);
            cmd.Parameters.AddWithValue("@newDedicatedtoProject", newDedicatedtoProject);
            cmd.Parameters.AddWithValue("@newSharedProject", newSharedProject);
            cmd.Parameters.AddWithValue("@newRelatedDocsHyperlink", newRelatedDocsHyperlink);
            cmd.Parameters.AddWithValue("@newComment", newComment);
            cmd.Parameters.AddWithValue("@newCalibratible", newCalibratible);
            cmd.Parameters.AddWithValue("@newInventoryNumber", newInventoryNumber);
            if (dateTimePickerCalibration.Value == DateTime.Today)
            {
                cmd.Parameters.AddWithValue("@newCalibrationDate", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@newCalibrationDate", newCalibrationDate);
            }
            cmd.Parameters.AddWithValue("@newFaultDescription", newFaultDescription);
            cmd.Parameters.AddWithValue("@newHistoryHyperlink", newHistoryHyperlink);
            cmd.Parameters.AddWithValue("@newImageHyperlink", newImageHyperlink);
            cmd.Parameters.AddWithValue("@newInHouseProduction", newInHouseProduction);
            cmd.Parameters.AddWithValue("@newLoaned", newLoaned);
            cmd.Parameters.AddWithValue("@newLoanedOwnerSite", newLoanedOwnerSite);
            if (dateTimePickerLoanedReturn.Value == DateTime.Today)
            {
                cmd.Parameters.AddWithValue("@newLoanedReturnDate", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@newLoanedReturnDate", newLoanedReturnDate);
            }
            cmd.Parameters.AddWithValue("@newPriceHyperlink", newPriceHyperlink);
            cmd.Parameters.AddWithValue("@newSerialNumber", newSerialNumber);
            cmd.Parameters.AddWithValue("@newModifiedBy", newModifiedBy);
            cmd.Parameters.AddWithValue("@newModified", newModified);
            cmd.Parameters.AddWithValue("@newIDType", newIDType);
            cmd.ExecuteNonQuery();
            con.Close();
            LoadComboboxes();
            clear();
            this.Close();
            f2.Show();
            f2.LoadDataTable();
        }

        public void UpdateUIFormSavingEquipment()
        {
            FormInventoryManagement f2 = (FormInventoryManagement)Application.OpenForms["FormInventoryManagement"];
            ResourceManager resM2 = new ResourceManager("EquipmentListTable.Localization", typeof(FormSavingEquipment).Assembly);
            labelTitle.Text = resM2.GetString("equipment");
            labelEquipmentName.Text = resM2.GetString("equipmentName");
            labelEquipmentType.Text = resM2.GetString("equipmentType");
            labelSerialNumber.Text = resM2.GetString("serialNumber");
            labelBorrower.Text = resM2.GetString("borrower");
            labelInventoryNo.Text = resM2.GetString("inventoryNo");
            labelDefaultLocation.Text = resM2.GetString("defaultLocation");
            labelCalibratable.Text = resM2.GetString("calibratable");
            labelInHouseProduction.Text = resM2.GetString("inHouseProduction");
            labelLoaned.Text = resM2.GetString("loaned");
            labelDedicatedToProject.Text = resM2.GetString("dedicatedToProject");
            labelSharedProjects.Text = resM2.GetString("sharedProjects");
            labelLoanedReturnDate.Text = resM2.GetString("loanedReturnDate");
            labelOwnerSite.Text = resM2.GetString("loanedOwnerSite");
            buttonClear.Text = resM2.GetString("clear");
            buttonSave.Text = resM2.GetString("save");
            buttonUpdate.Text = resM2.GetString("update");
            labelComment.Text = resM2.GetString("comment");
            labelStatus.Text = resM2.GetString("status");
            labelFaultDescription.Text = resM2.GetString("faultDescription");
            labelCalibrationDate.Text = resM2.GetString("calibrationDate");
            labelRelatedDocsHyperlink.Text = resM2.GetString("relatedDocsHyperlink");
            labelImageHyperlink.Text = resM2.GetString("imageHyperlink");
            labelPriceHyperlink.Text = resM2.GetString("priceHyperlink");
            labelHistoryDocsHyperlink.Text = resM2.GetString("historyHyperlink");
            dateTimePickerCalibration.Format = DateTimePickerFormat.Custom;
            dateTimePickerCalibration.CustomFormat = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            dateTimePickerLoanedReturn.Format = DateTimePickerFormat.Custom;
            dateTimePickerLoanedReturn.CustomFormat = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            f2.dataGridViewEquipmentList.Columns[1].HeaderText = resM2.GetString("idType");
            f2.dataGridViewEquipmentList.Columns[2].HeaderText = resM2.GetString("equipmentName");
            f2.dataGridViewEquipmentList.Columns[3].HeaderText = resM2.GetString("equipmentType");
            f2.dataGridViewEquipmentList.Columns[4].HeaderText = resM2.GetString("defaultLocation");
            f2.dataGridViewEquipmentList.Columns[5].HeaderText = resM2.GetString("status");
            f2.dataGridViewEquipmentList.Columns[6].HeaderText = resM2.GetString("borrower");
            f2.dataGridViewEquipmentList.Columns[7].HeaderText = resM2.GetString("dedicatedToProject");
            f2.dataGridViewEquipmentList.Columns[8].HeaderText = resM2.GetString("sharedProjects");
            f2.dataGridViewEquipmentList.Columns[9].HeaderText = resM2.GetString("relatedDocsHyperlink");
            f2.dataGridViewEquipmentList.Columns[10].HeaderText = resM2.GetString("comment");
            f2.dataGridViewEquipmentList.Columns[11].HeaderText = resM2.GetString("calibrationDate");
            f2.dataGridViewEquipmentList.Columns[12].HeaderText = resM2.GetString("inventoryNumber");
            f2.dataGridViewEquipmentList.Columns[13].HeaderText = resM2.GetString("calibratable");
            f2.dataGridViewEquipmentList.Columns[14].HeaderText = resM2.GetString("faultDescription");
            f2.dataGridViewEquipmentList.Columns[15].HeaderText = resM2.GetString("historyHyperlink");
            f2.dataGridViewEquipmentList.Columns[16].HeaderText = resM2.GetString("imageHyperlink");
            f2.dataGridViewEquipmentList.Columns[17].HeaderText = resM2.GetString("inHouseProduction");
            f2.dataGridViewEquipmentList.Columns[18].HeaderText = resM2.GetString("loaned");
            f2.dataGridViewEquipmentList.Columns[19].HeaderText = resM2.GetString("loanedOwnerSite");
            f2.dataGridViewEquipmentList.Columns[20].HeaderText = resM2.GetString("loanedReturnDate");
            f2.dataGridViewEquipmentList.Columns[21].HeaderText = resM2.GetString("priceHyperlink");
            f2.dataGridViewEquipmentList.Columns[22].HeaderText = resM2.GetString("serialNumber");
            f2.dataGridViewEquipmentList.Columns[23].HeaderText = resM2.GetString("createdBy");
            f2.dataGridViewEquipmentList.Columns[24].HeaderText = resM2.GetString("modifiedBy");
            f2.dataGridViewEquipmentList.Columns[25].HeaderText = resM2.GetString("modified");
            f2.dataGridViewEquipmentList.Columns[26].HeaderText = resM2.GetString("created");
        }
    }
}
