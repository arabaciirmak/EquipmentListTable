using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EquipmentListTable
{
    public partial class FormInventoryManagement : Form
    {
        public FormInventoryManagement()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;

        public void LoadDataTable()
        {
            con = new SqlConnection("Data Source=DESKTOP-EIER2L0\\SQLEXPRESS03;Initial Catalog=EQUIPMENT;Integrated Security=True;TrustServerCertificate=True;");
            con.Open();
            da = new SqlDataAdapter("SELECT *FROM Equipment_Table ORDER BY No", con);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridViewEquipmentList.DataSource = table;
            con.Close();
        }

        private void FormEquipmentList_Load(object sender, EventArgs e)
        {
            LoadDataTable();
            SetPlaceholderText();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            this.Text = "Inventory Management";
            UpdateUIFormIventoryManagement();
            FormSavingEquipment f1 = (FormSavingEquipment)Application.OpenForms["FormSavingEquipment"];
            if (f1 == null)
            {
                f1 = new FormSavingEquipment();
            }
            f1.UpdateUIFormSavingEquipment();
            LoadDataTable();
        }

        private void buttonNewEquipment_Click(object sender, EventArgs e) // Direct us to the saving screen
        {
            FormSavingEquipment f1 = (FormSavingEquipment)Application.OpenForms["FormSavingEquipment"];
            if (f1 == null)
            {
                f1 = new FormSavingEquipment();
            }
            f1.Show();
            f1.buttonSave.Visible = true;
            f1.buttonUpdate.Visible = false;
        }

        private void buttonUpdateSelected_Click(object sender, EventArgs e) // Direct us to the updating screen
        {   // To fill components with the information of the equipment that we want to change
            if (dataGridViewEquipmentList.CurrentRow != null)
            {
                FormSavingEquipment f1 = (FormSavingEquipment)Application.OpenForms["FormSavingEquipment"];
                if (f1 == null)
                {
                    f1 = new FormSavingEquipment();
                    f1.Show();
                }
                f1.textBoxEquipmentName.Text = dataGridViewEquipmentList.CurrentRow.Cells["EquipmentName"].Value.ToString();
                f1.textBoxSerialNumber.Text = dataGridViewEquipmentList.CurrentRow.Cells["SerialNumber"].Value.ToString();
                f1.textBoxInventoryNo.Text = dataGridViewEquipmentList.CurrentRow.Cells["InventoryNumber"].Value.ToString();
                f1.textBoxBorrower.Text = dataGridViewEquipmentList.CurrentRow.Cells["Borrower"].Value.ToString();
                f1.textBoxRelatedDocsHyperlink.Text = dataGridViewEquipmentList.CurrentRow.Cells["RelatedDocsHyperlink"].Value.ToString();
                f1.textBoxImageHyperlink.Text = dataGridViewEquipmentList.CurrentRow.Cells["ImageHyperlink"].Value.ToString();
                f1.textBoxPriceHyperlink.Text = dataGridViewEquipmentList.CurrentRow.Cells["PriceHyperlink"].Value.ToString();
                f1.textBoxHistoryDocsHyperlink.Text = dataGridViewEquipmentList.CurrentRow.Cells["HistoryHyperlink"].Value.ToString();
                f1.richTextBoxComment.Text = dataGridViewEquipmentList.CurrentRow.Cells["Comment"].Value.ToString();
                f1.richTextBoxFaultDescription.Text = dataGridViewEquipmentList.CurrentRow.Cells["FaultDescription"].Value.ToString();
                f1.comboBoxEquipmentType.SelectedItem = dataGridViewEquipmentList.CurrentRow.Cells["EquipmentType"].Value;
                f1.comboBoxDefaultLocation.SelectedItem = dataGridViewEquipmentList.CurrentRow.Cells["DefaultLocation"].Value;
                f1.comboBoxLoanedOwnerSite.SelectedItem = dataGridViewEquipmentList.CurrentRow.Cells["LoanedOwnerSite"].Value;
                f1.comboBoxDedicatedToProject.SelectedItem = dataGridViewEquipmentList.CurrentRow.Cells["DedicatedtoProject"].Value;
                f1.comboBoxStatus.SelectedItem = dataGridViewEquipmentList.CurrentRow.Cells["Status"].Value;
                f1.checkBoxCalibratable.Checked = dataGridViewEquipmentList.CurrentRow.Cells["Calibratible"].Value.ToString().Equals("TRUE", StringComparison.OrdinalIgnoreCase);
                f1.checkBoxInHouseProduction.Checked = dataGridViewEquipmentList.CurrentRow.Cells["InHouseProduction"].Value.ToString().Equals("TRUE", StringComparison.OrdinalIgnoreCase);
                f1.checkBoxLoaned.Checked = dataGridViewEquipmentList.CurrentRow.Cells["Loaned"].Value.ToString().Equals("TRUE", StringComparison.OrdinalIgnoreCase);
                if (dataGridViewEquipmentList.CurrentRow.Cells["CalibrationDate"].Value != DBNull.Value)
                {
                    f1.dateTimePickerCalibration.Value = Convert.ToDateTime(dataGridViewEquipmentList.CurrentRow.Cells["CalibrationDate"].Value);
                }
                if (dataGridViewEquipmentList.CurrentRow.Cells["LoanedReturnDate"].Value != DBNull.Value)
                {
                    f1.dateTimePickerLoanedReturn.Value = Convert.ToDateTime(dataGridViewEquipmentList.CurrentRow.Cells["LoanedReturnDate"].Value);
                }
                var cellValue = dataGridViewEquipmentList.CurrentRow.Cells["SharedProject"].Value;
                if (cellValue != DBNull.Value)
                {
                    string[] cellValueSplitted = cellValue.ToString().Split(',');
                    for (int i = 0; i < f1.checkedListBoxSharedProjects.Items.Count; i++)
                    {
                        string listItemText = f1.checkedListBoxSharedProjects.Items[i].ToString();
                        bool isChecked = false;
                        foreach (string item in cellValueSplitted)
                        {
                            if (item.Trim().Equals(listItemText, StringComparison.OrdinalIgnoreCase))
                            {
                                isChecked = true;
                            }
                        }
                        f1.checkedListBoxSharedProjects.SetItemChecked(i, isChecked);
                    }
                }
                else
                {
                    for (int i = 0; i < f1.checkedListBoxSharedProjects.Items.Count; i++)
                    {
                        f1.checkedListBoxSharedProjects.SetItemChecked(i, false);
                    }
                }
                f1.buttonUpdate.Visible = true;
                f1.buttonSave.Visible = false;
            }
        }

        private void SetPlaceholderText()
        {
            if (this.Text == "Inventory Management")
            {
                textBoxFilter.Text = "Please type for searching...";
            }
            else if (this.Text == "Envanter Yönetimi")
            {
                textBoxFilter.Text = "Lütfen aramak için yazınız...";
            }
            textBoxFilter.ForeColor = Color.SlateGray;
            textBoxFilter.Font = new Font("Segoe UI", 9.0f, FontStyle.Italic);
        }


        private void textBoxFilter_TextChanged(object sender, EventArgs e) //One filter works for all string columns at the same time
        {
            if (textBoxFilter.Text != "Lütfen aramak için yazınız..." && textBoxFilter.Text != "Please type for searching...")
            {
                DataTable dt = dataGridViewEquipmentList.DataSource as DataTable;
                if (dt != null)
                {
                    string filteringText = textBoxFilter.Text.Replace("'", "''");
                    string filterExpression = "";

                    foreach (DataColumn column in dt.Columns)
                    {
                        if (column.DataType == typeof(string))
                        {
                            if (filterExpression.Length > 0)
                            {
                                filterExpression += " OR ";
                            }
                            filterExpression += string.Format("{0} LIKE '%{1}%'", column.ColumnName, filteringText);
                        }
                    }
                    dt.DefaultView.RowFilter = filterExpression;
                }
            }
            else
            {
                DataTable dt = dataGridViewEquipmentList.DataSource as DataTable;
                if (dt != null)
                {
                    dt.DefaultView.RowFilter = "";
                }
            }
        }

        private void textBoxFilter_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxFilter.ForeColor == Color.SlateGray)
            {
                textBoxFilter.Clear();
                textBoxFilter.ForeColor = Color.Black;
                textBoxFilter.Font = new Font("Segoe UI", 9.0f);
            }
        }

        private void textBoxFilter_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFilter.Text))
            {
                textBoxFilter.ForeColor = Color.SlateGray;
                textBoxFilter.Font = new Font("Segoe UI", 9.0f, FontStyle.Italic);
                if (this.Text == "Inventory Management")
                {
                    textBoxFilter.Text = "Please type for searching...";
                }
                else if (this.Text == "Envanter Yönetimi")
                {
                    textBoxFilter.Text = "Lütfen aramak için yazınız...";
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (choice == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void UpdateUIFormIventoryManagement()
        {
            ResourceManager resM1 = new ResourceManager("EquipmentListTable.Localization", typeof(FormInventoryManagement).Assembly);
            this.fileToolStripMenuItem.Text = resM1.GetString("file");
            this.helpToolStripMenuItem.Text = resM1.GetString("help");
            this.exitToolStripMenuItem.Text = resM1.GetString("exit");
            this.aboutToolStripMenuItem.Text = resM1.GetString("about");
            this.userGuideToolStripMenuItem.Text = resM1.GetString("userGuide");
            this.buttonNewEquipment.Text = resM1.GetString("newEquipmentButton");
            this.buttonUpdateSelected.Text = resM1.GetString("updateButton");
            this.labelTitle.Text = resM1.GetString("equipmentRegistrationSystem");
            this.languageToolStripMenuItem.Text = resM1.GetString("language");
            this.textBoxFilter.Text = resM1.GetString("filter");
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            this.Text = "Inventory Management";
            UpdateUIFormIventoryManagement();
            FormSavingEquipment f1 = (FormSavingEquipment)Application.OpenForms["FormSavingEquipment"];
            if (f1 == null)
            {
                f1 = new FormSavingEquipment();
            }
            f1.UpdateUIFormSavingEquipment();
            LoadDataTable();
        }

        private void türkçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("tr-TR");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("tr-TR");
            this.Text = "Envanter Yönetimi";
            UpdateUIFormIventoryManagement();
            FormSavingEquipment f1 = (FormSavingEquipment)Application.OpenForms["FormSavingEquipment"];
            if (f1 == null)
            {
                f1 = new FormSavingEquipment();
            }
            f1.UpdateUIFormSavingEquipment();
            LoadDataTable();
        }

    }
}



