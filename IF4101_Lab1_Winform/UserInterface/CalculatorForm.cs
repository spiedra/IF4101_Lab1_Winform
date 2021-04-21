using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IF4101_Lab1_Winform.Business;

namespace IF4101_Lab1_Winform
{
    public partial class CalculatorForm : Form
    {
        private CurrencyBusiness currencyBusiness;
        private CountryBusiness countryBusiness;
        public CalculatorForm()
        {
            InitializeComponent();
            this.InitObjectsBusiness();
        }

        private void InitObjectsBusiness()
        {
            this.currencyBusiness = new CurrencyBusiness();
            this.countryBusiness = new CountryBusiness();
            this.AddItemsToComboBoxCountry();
        }

        private void AddItemsToComboBoxCountry()
        {
            List<CountryBusiness> countryList = new List<CountryBusiness>();
            countryList = this.countryBusiness.GetCountriesList();
            for (int i = 0; i < countryList.Count; i++)
            {
                this.cbx_calculatorFrom.Items.Add(countryList[i].CountryName);
                this.cbx_calculatorTo.Items.Add(countryList[i].CountryName);
            }
        }

        private void tbx_calculatorAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_calculatorAmount_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CalculatorWindow_Load(object sender, EventArgs e)
        {

        }

        private void lb_calculatorTo_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
