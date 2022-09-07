using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyMS
{
    public partial class IndexUi : Form
    {
        public IndexUi()
        {
            InitializeComponent();
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            CategoryUi categoryUi = new CategoryUi();
            categoryUi.Tag = this;
            categoryUi.Show (this);


        }

        private void medicineButton_Click(object sender, EventArgs e)
        {
            MedicineUi medicineUi = new MedicineUi();
            medicineUi.Tag = this;
            medicineUi.Show(this);
        }

        private void sellerButton_Click(object sender, EventArgs e)
        {
            SellerUi sellerUi = new SellerUi();
            sellerUi.Tag = this;
            sellerUi.Show(this);
        }

        private void supplierButton_Click(object sender, EventArgs e)
        {
            SupplierUi supplierUi = new SupplierUi();
            supplierUi.Tag = this;
            supplierUi.Show(this);

        }

        private void genericNameButton_Click(object sender, EventArgs e)
        {
            GenericNameUi genericNameUi = new GenericNameUi();
            genericNameUi.Tag = this;
            genericNameUi.Show(this);
        }

        private void doseButton_Click(object sender, EventArgs e)
        {
            DoseUi doseUi = new DoseUi();
            doseUi.Tag = this;
            doseUi.Show(this);
        }

        private void companyButton_Click(object sender, EventArgs e)
        {
            CompanyUi companyUi = new CompanyUi();
            companyUi.Tag = this;
            companyUi.Show(this);
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            PurchaseUi purchaseUi = new PurchaseUi();
            purchaseUi.Tag = this;
            purchaseUi.Show(this);
        }

        private void salesButton_Click(object sender, EventArgs e)
        {
            SaleUi saleUi = new SaleUi();
            saleUi.Tag = this;
            saleUi.Show(this);
        }
    }
}
