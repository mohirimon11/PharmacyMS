using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmacyMS.Model;
using PharmacyMS.BLL;

namespace PharmacyMS
{
    public partial class MedicineUi : Form
    {
        int Id_value;
        MedicineManager _medicineManager = new MedicineManager();
        private Medicine medicine;

        public MedicineUi()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            addMedicine();
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Medicine medicine = new Medicine();
            if (String.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Please Enter the Name to search");
                return;
            }
            medicine.Name = nameTextBox.Text;
            showDataGridView.DataSource = _medicineManager.Search(medicine);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Medicine medicine = new Medicine();
            medicine.ID = Id_value;
            medicine.Name = nameTextBox.Text;
            medicine.Code = codeTextBox.Text;
            medicine.ReorderLavel = Convert.ToInt32(reorderLTextBox.Text);
            medicine.CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue);
            medicine.CompanyId = Convert.ToInt32(companyComboBox.SelectedValue);
            medicine.GenericNameId = Convert.ToInt32(genericNComboBox.SelectedValue);
            medicine.DoseId = Convert.ToInt32(doseComboBox.SelectedValue);
            medicine.AgeLimite = ageLTextBox.Text;
            medicine.Country = countryTextBox.Text;
            medicine.Detail = detailTextBox.Text;
            medicine.Instruction = instructionTextBox.Text;



            if (String.IsNullOrEmpty(codeTextBox.Text) || codeTextBox.Text.Length != 4)
            {
                MessageBox.Show("Company Code Should consists of 4 character");
                return;
            }
            medicine.Code = codeTextBox.Text;
            if (_medicineManager.UpdateIsCodeExists(medicine))
            {
                MessageBox.Show(codeTextBox.Text + " Already Exists");
                return;
            }


            if (String.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Company Name Cannot be empty");
                return;
            }
            //medicine.Name = nameTextBox.Text;
            //if (_medicineManager.UpdateIsNameExists(medicine))
            //{
            //    MessageBox.Show(nameTextBox.Text + " Already Exists");
            //    return;
            //}

            if (_medicineManager.Update(medicine))
            {
                MessageBox.Show("Data is successfully Updated!");
                Clear();
            }
            else
            {
                MessageBox.Show("Update Error");
            }
            showDataGridView.DataSource = _medicineManager.Display();
        }

        private void MedicineUi_Load(object sender, EventArgs e)
        {
            categoryComboBox.DataSource = _medicineManager.LoadCatagory();
            categoryComboBox.Text = "-select-";
            companyComboBox.DataSource = _medicineManager.LoadCompany();
            companyComboBox.Text = "-select-";
            genericNComboBox.DataSource = _medicineManager.LoadGenericName();
            genericNComboBox.Text = "-select-";
            doseComboBox.DataSource = _medicineManager.LoadDose();
            doseComboBox.Text = "-select-";


            showDataGridView.DataSource = _medicineManager.Display();
        }

        private void showDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showDataGridView.CurrentRow.Selected = true;
            Id_value = Convert.ToInt32(showDataGridView.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString());
            codeTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Code"].FormattedValue.ToString();
            nameTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
            reorderLTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["ReorderLavel"].FormattedValue.ToString();
            ageLTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["AgeLimite"].FormattedValue.ToString();
            countryTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Country"].FormattedValue.ToString();
            instructionTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Instruction"].FormattedValue.ToString();
            categoryComboBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Name1"].FormattedValue.ToString();
            companyComboBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Name2"].FormattedValue.ToString();
            genericNComboBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Name3"].FormattedValue.ToString();
            doseComboBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Name4"].FormattedValue.ToString();
            detailTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Detail"].FormattedValue.ToString();


        }

        private void addMedicine()
        {
            medicine = new Medicine();
            if (String.IsNullOrEmpty(nameTextBox.Text) || String.IsNullOrEmpty(categoryComboBox.Text) || String.IsNullOrEmpty(instructionTextBox.Text) ||
                String.IsNullOrEmpty(companyComboBox.Text) || String.IsNullOrEmpty(doseComboBox.Text) || String.IsNullOrEmpty(genericNComboBox.Text) ||
                String.IsNullOrEmpty(reorderLTextBox.Text) || String.IsNullOrEmpty(ageLTextBox.Text) || String.IsNullOrEmpty(countryTextBox.Text) ||
                String.IsNullOrEmpty(detailTextBox.Text))
            {
                MessageBox.Show("Please Fill All The Box");
                return;
            }
            if (String.IsNullOrEmpty(codeTextBox.Text) || codeTextBox.Text.Length != 4)
            {
                MessageBox.Show("Code Should consists of 4 character");
                return;
            }
            medicine.Code = codeTextBox.Text;

            if (_medicineManager.IsCodeExists(medicine))
            {
                MessageBox.Show(codeTextBox.Text + " Already Exists");
                return;
            }
            try
            {
                medicine.ReorderLavel = Convert.ToInt32(reorderLTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Enter Valid Reorder.");
                return;
            }
            //Add Area--
            medicine.Name = nameTextBox.Text;
            medicine.CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue);
            medicine.CompanyId = Convert.ToInt32(companyComboBox.SelectedValue);
            medicine.DoseId = Convert.ToInt32(doseComboBox.SelectedValue);
            medicine.GenericNameId = Convert.ToInt32(genericNComboBox.SelectedValue);
            medicine.ReorderLavel = Convert.ToInt32(reorderLTextBox.Text);
            medicine.AgeLimite = ageLTextBox.Text;
            medicine.Country = countryTextBox.Text;
            medicine.Detail = detailTextBox.Text;
            medicine.Instruction = instructionTextBox.Text;
            int isExecuted = 0;

            isExecuted = _medicineManager.addMedicine(medicine);

            if (isExecuted > 0)
            {
                //messageLabel.Text = "Save Successful.";
                MessageBox.Show("Save Successful");
                Clear();
            }
            else
            {
                // messageLabel.Text = "Save Failed!";
                MessageBox.Show("Save Failed!");
            }
            showDataGridView.DataSource = _medicineManager.Display();

        }

        public void Clear()
        {

            codeTextBox.Text = "";
            nameTextBox.Text = "";
            categoryComboBox.Text = "";
            companyComboBox.Text = "";
            genericNComboBox.Text = "";
            doseComboBox.Text = "";
            ageLTextBox.Text = "";
            countryTextBox.Text = "";
            detailTextBox.Text = "";
            instructionTextBox.Text = "";
            reorderLTextBox.Text = "";

        }


    }
}
