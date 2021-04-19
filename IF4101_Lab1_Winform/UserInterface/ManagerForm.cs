using System;
using System.Windows.Forms;
using IF4101_Lab1_Winform.DataAccess;
using IF4101_Lab1_Winform.Business;

namespace IF4101_Lab1_Winform
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void btn_managerAdd_Click(object sender, EventArgs e)
        {
            this.getCountryInput();
            //test
           //ConnectionDataAccess connectionDataAccess = new ConnectionDataAccess();
           //connectionDataAccess.insertIntoTbCountry("Costa Rica", 2); 
        }

        private void getCountryInput()
        {
            CountryBusiness countryBusiness = new CountryBusiness();
            countryBusiness.Country_name = this.txb_managerNameContry.Text;
        }

        private void getCurrencyInput()
        {
            //
        }

        private void chbx_managerAdd_Click(object sender, EventArgs e)
        {
            if (this.chbx_managerDelete.Checked)
            {
                this.setInvisibleDeleteComponets();
            }
            this.setVisibleAddComponents();
        }

        private void chbx_managerDelete_Click(object sender, EventArgs e)
        {
            if (this.chbx_managerAdd.Checked)
            {
                this.setInvisibleAddComponents();
            }
            this.setVisibleDeleteComponents();
        }

        private void setVisibleDeleteComponents()
        {
            this.lb_managerNameCountry.Visible = true;
            this.cmbx_managerCountries.Visible = true;
            this.btn_managerAdd.Text = "Delete";
            this.btn_managerAdd.Visible = true;
        }

        private void setVisibleAddComponents()
        {
            this.lb_managerNameCountry.Visible = true;
            this.lb_managerCurrency.Visible = true;
            this.txb_managerNameContry.Visible = true;
            this.cmbx_managerCurrency.Visible = true;
            this.btn_managerAdd.Text = "Add";
            this.btn_managerAdd.Visible = true;
        }

        private void setInvisibleDeleteComponets()
        {
            this.cmbx_managerCountries.Visible = false;
            this.chbx_managerDelete.Checked = false;
        }

        private void setInvisibleAddComponents()
        {
            this.lb_managerCurrency.Visible = false;
            this.txb_managerNameContry.Visible = false;
            this.cmbx_managerCurrency.Visible = false;
            this.chbx_managerAdd.Checked = false;
        }
    }
}
