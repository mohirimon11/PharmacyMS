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
    public partial class GenericNameUi : Form
    {
        int Id_value;
        GenericNameManager _genericNameManager = new GenericNameManager();
        public GenericNameUi()
        {
            InitializeComponent();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            {
                ////Start point..
                //detailTextBox.Text = "";
                //nameTextBox.Text = "";
                //codeTextBox.Text = "";
            }
            GenericName genericName = new GenericName();
            try {
                    if (String.IsNullOrEmpty(codeTextBox.Text) || codeTextBox.Text.Length != 4)
                    {
                        MessageBox.Show("Code Should consists of 4 character");
                        return;
                    }
                    genericName.Code = codeTextBox.Text;

                    if (_genericNameManager.IsCodeExists(genericName))
                    {
                        MessageBox.Show(codeTextBox.Text + " Already Exists");
                        return;
                    }

                    if (String.IsNullOrEmpty(nameTextBox.Text))
                    {
                        MessageBox.Show("Category Name cannot be empty");
                        return;
                    }

                    genericName.Name = nameTextBox.Text;
                    if (_genericNameManager.IsNameExists(genericName))
                    {
                        MessageBox.Show(nameTextBox.Text + " Already Exists");
                        return;
                    }
                    if (String.IsNullOrEmpty(detailTextBox.Text))
                    {
                        MessageBox.Show("Category Detail cannot be empty");
                        return;
                    }
                    genericName.Detail = detailTextBox.Text;
                    if (_genericNameManager.Add(genericName))
                    {
                        MessageBox.Show("Data is successfully Saved!");
                    }
                    else
                    {
                        MessageBox.Show("Save Error");
                    }

                }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }

            showDataGridView.DataSource = _genericNameManager.Display();
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            
            GenericName genericName = new GenericName();
            genericName.ID = Id_value;
            genericName.Code = codeTextBox.Text;
            genericName.Name = nameTextBox.Text;
            genericName.Detail = detailTextBox.Text;
            //try
            //{

            //}
            //catch(Exception exeption)
            //{
            //    MessageBox.Show(exeption.Message);
            //}
            if (String.IsNullOrEmpty(codeTextBox.Text) || codeTextBox.Text.Length != 4)
            {
                MessageBox.Show("Company Code Should consists of 4 character");
                return;
            }
            genericName.Code = codeTextBox.Text;
            if (_genericNameManager.UpdateIsCodeExists(genericName))
            {
                MessageBox.Show(codeTextBox.Text + " Already Exists");
                return;
            }


            if (String.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Company Name Cannot be empty");
                return;
            }
            genericName.Name = nameTextBox.Text;
            if (_genericNameManager.UpdateIsNameExists(genericName))
            {
                MessageBox.Show(nameTextBox.Text + " Already Exists");
                return;
            }

            if (_genericNameManager.Update(genericName))
            {
                MessageBox.Show("Data is successfully Updated!");
            }
            else
            {
                MessageBox.Show("Update Error");
            }
            showDataGridView.DataSource = _genericNameManager.Display();
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            GenericName genericName = new GenericName();
            if (String.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Please Enter the Name to search");
                return;
            }
            genericName.Name = nameTextBox.Text;
            showDataGridView.DataSource = _genericNameManager.Search(genericName);
        }
        private void GenericNameUi_Load(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _genericNameManager.Display();

        }
        private void showDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showDataGridView.CurrentRow.Selected = true;
            Id_value = Convert.ToInt32(showDataGridView.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString());
            codeTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Code"].FormattedValue.ToString();
            nameTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
            detailTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Detail"].FormattedValue.ToString();
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            GenericName genericName = new GenericName();
            genericName.ID = Id_value;
            try
            {

            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            showDataGridView.DataSource = _genericNameManager.Display();

        }
    }
}
