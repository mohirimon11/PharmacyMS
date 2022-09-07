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
    public partial class CompanyUi : Form
    {
        int Id_value;
        CompanyManager _companyManager = new CompanyManager();        
        public CompanyUi()
        {
            InitializeComponent();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            if (String.IsNullOrEmpty(codeTextBox.Text) || codeTextBox.Text.Length != 4)
            {
                MessageBox.Show("Code Should consists of 4 character");
                return;
            }
            company.Code = codeTextBox.Text;

            if (_companyManager.IsCodeExists(company))
            {
                MessageBox.Show(codeTextBox.Text + " Already Exists");
                return;
            }

            if (String.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Category Name cannot be empty");
                return;
            }

            company.Name = nameTextBox.Text;
            if (_companyManager.IsNameExists(company))
            {
                MessageBox.Show(nameTextBox.Text + " Already Exists");
                return;
            }
            if (String.IsNullOrEmpty(detailTextBox.Text))
            {
                MessageBox.Show("Category Detail cannot be empty");
                return;
            }
            company.Detail = detailTextBox.Text;
            if (_companyManager.Add(company))
            {
                MessageBox.Show("Data is successfully Saved!");
            }
            else
            {
                MessageBox.Show("Save Error");
            }
            showDataGridView.DataSource = _companyManager.Display();

        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            company.ID = Id_value;
            company.Code = codeTextBox.Text;
            company.Name = nameTextBox.Text;
            company.Detail = detailTextBox.Text;

            if (String.IsNullOrEmpty(codeTextBox.Text) || codeTextBox.Text.Length != 4)
            {
                MessageBox.Show("Company Code Should consists of 4 character");
                return;
            }
            company.Code = codeTextBox.Text;
            if (_companyManager.UpdateIsCodeExists(company))
            {
                MessageBox.Show(codeTextBox.Text + " Already Exists");
                return;
            }


            if (String.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Company Name Cannot be empty");
                return;
            }
            company.Name = nameTextBox.Text;
            if (_companyManager.UpdateIsNameExists(company))
            {
                MessageBox.Show(nameTextBox.Text + " Already Exists");
                return;
            }

            if (_companyManager.Update(company))
            {
                MessageBox.Show("Data is successfully Updated!");
            }
            else
            {
                MessageBox.Show("Update Error");
            }
            showDataGridView.DataSource = _companyManager.Display();
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            if (String.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Please Enter the Name to search");
                return;
            }
            company.Name = nameTextBox.Text;
            showDataGridView.DataSource = _companyManager.Search(company);
        }
        private void CompanyUi_Load(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _companyManager.Display();
        }
        private void showDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showDataGridView.CurrentRow.Selected = true;
            Id_value = Convert.ToInt32(showDataGridView.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString());
            codeTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Code"].FormattedValue.ToString();
            nameTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
            detailTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Detail"].FormattedValue.ToString();
        }

        
    }
}
