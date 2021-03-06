using System;
using System.Windows.Forms;
using System.Collections.Generic;
using IF4101_Lab1_Winform.Business;

namespace IF4101_Lab1_Winform
{
    public partial class ManagerForm : Form
    {
        private CurrencyBusiness currencyBusiness;
        private CountryBusiness countryBusiness;
        public ManagerForm()
        {
            InitializeComponent();
            this.InitObjectsBusiness();
        }

        private void InitObjectsBusiness()
        {
            this.currencyBusiness = new CurrencyBusiness();
            this.countryBusiness = new CountryBusiness();
        }

        private void btn_managerAdd_Click(object sender, EventArgs e)
        {
            if (this.chbx_managerDelete.Checked)
            {
                this.countryBusiness.DeleteCountry(this.cmbx_managerCountries.Text);
                this.RefreshDeleteForm();
            }
            else
            {
                this.countryBusiness.InsertIntoTbCountry(this.txb_managerNameContry.Text, this.cmbx_managerCurrency.SelectedIndex + 1);
                this.RefreshAddForm();
            }
        }

        private void getCountryInput()
        {
            CountryBusiness countryBusiness = new CountryBusiness();
            countryBusiness.CountryName = this.txb_managerNameContry.Text;
        }

        private void AddItemsToComboBoxCurrency()
        {
            List<CurrencyBusiness> currencyList = new List<CurrencyBusiness>();
            currencyList = this.currencyBusiness.GetCurrencyData();
            for (int i = 0; i < currencyList.Count; i++)
            {
                this.cmbx_managerCurrency.Items.Add(currencyList[i].CurrencyName);
            }
        }

        private void AddItemsToComboBoxCountry()
        {
            List<CountryBusiness> countryList = new List<CountryBusiness>();
            countryList = this.countryBusiness.GetCountriesList();
            for (int i = 0; i < countryList.Count; i++)
            {
                this.cmbx_managerCountries.Items.Add(countryList[i].CountryName);
            }
        }

        private void chbx_managerAdd_Click(object sender, EventArgs e)
        {
            this.AddItemsToComboBoxCurrency();
            if (this.chbx_managerDelete.Checked)
            {
                this.setInvisibleDeleteComponets();
            }
            this.setVisibleAddComponents();
            this.RefreshAddForm();
        }

        private void chbx_managerDelete_Click(object sender, EventArgs e)
        {
            this.AddItemsToComboBoxCountry();
            if (this.chbx_managerAdd.Checked)
            {
                this.setInvisibleAddComponents();
            }
            this.setVisibleDeleteComponents();
            this.RefreshDeleteForm();
        }

        private void RefreshAddForm()
        {
            this.txb_managerNameContry.Clear();
            this.cmbx_managerCurrency.Text = null;
            this.cmbx_managerCurrency.Items.Clear();
            this.AddItemsToComboBoxCurrency();
        }

        private void RefreshDeleteForm()
        {
            this.cmbx_managerCountries.Text = null;
            this.cmbx_managerCountries.Items.Clear();
            this.AddItemsToComboBoxCountry();
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

        private void cmbx_managerCurrency_Click(object sender, EventArgs e)
        {

        }

        private void cmbx_managerCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
