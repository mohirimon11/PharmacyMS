using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PharmacyMS.BLL;
using PharmacyMS.Model;
using System.Windows.Forms;

namespace PharmacyMS
{
    public partial class DoseUi : Form
    {
        int Id_value;
        DoseManager _doseManager = new DoseManager();
    
        public DoseUi()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
           // Category category = new Category();
            Dose dose = new Dose();
            //if (String.IsNullOrEmpty(codeTextBox.Text) || codeTextBox.Text.Length != 4)
            //{
            //    MessageBox.Show("Code Should consists of 4 character");
            //    return;
            //}
            //category.Code = codeTextBox.Text;

            //if (_doseManager.IsCodeExists(dose))
            //{
            //    MessageBox.Show(codeTextBox.Text + " Already Exists");
            //    return;
            //}

            if (String.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Dose Name cannot be empty");
                return;
            }
            dose.Name = nameTextBox.Text;
            if (_doseManager.IsNameExists(dose))
            {
                MessageBox.Show(nameTextBox.Text + " Already Exists");
                return;
            }
            if (_doseManager.Add(dose))
            {
                MessageBox.Show("Data is successfully Saved!");
            }
            else
            {
                MessageBox.Show("Save Error");
            }
            showDataGridView.DataSource = _doseManager.Display();
        }
        private void updateButton_Click_1(object sender, EventArgs e)
        {
            Dose dose = new Dose();
            dose.ID = Id_value;
            dose.Name = nameTextBox.Text;
            //if (String.IsNullOrEmpty(codeTextBox.Text) || codeTextBox.Text.Length != 4)
            //{
            //    MessageBox.Show("Category Code Should consists of 4 character");
            //    return;
            //}
            //dose.Code = codeTextBox.Text;
            //if (_categoryManager.UpdateIsCodeExists(category))
            //{
            //    MessageBox.Show(codeTextBox.Text + " Already Exists");
            //    return;
            //}

            if (String.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Dose Name Cannot be empty");
                return;
            }
            dose.Name = nameTextBox.Text;
            if (_doseManager.UpdateIsNameExists(dose))
            {
                MessageBox.Show(nameTextBox.Text + " Already Exists");
                return;
            }

            if (_doseManager.Update(dose))
            {
                MessageBox.Show("Data is successfully Updated!");
            }
            else
            {
                MessageBox.Show("Update Error");
            }
            showDataGridView.DataSource = _doseManager.Display();
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            Dose dose = new Dose();
            if (String.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Please Enter the Name to search");
                return;
            }

            dose.Name = nameTextBox.Text;
            showDataGridView.DataSource = _doseManager.Search(dose);
        }
        private void showDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showDataGridView.CurrentRow.Selected = true;
            Id_value = Convert.ToInt32(showDataGridView.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString());
            nameTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();

        }
        private void DoseUi_Load(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _doseManager.Display();
        }   
    }
}
