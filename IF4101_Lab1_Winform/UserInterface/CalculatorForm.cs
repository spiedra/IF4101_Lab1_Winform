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
        private CalculatorBusiness calculatorBusiness;
        private List<CountryBusiness> countryList;
        public CalculatorForm()
        {
            InitializeComponent();
            this.InitObjects();
        }

        private void InitObjects()
        {
            this.currencyBusiness = new CurrencyBusiness();
            this.countryBusiness = new CountryBusiness();
            this.calculatorBusiness = new CalculatorBusiness();
            this.AddItemsToComboBoxCountry();
        }

        private void AddItemsToComboBoxCountry()
        {
            this.countryList = new List<CountryBusiness>();
            countryList = this.countryBusiness.GetCountriesList();
            for (int i = 0; i < countryList.Count; i++)
            {
                this.cbx_calculatorFrom.Items.Add(countryList[i].CountryName);
                this.cbx_calculatorTo.Items.Add(countryList[i].CountryName);
            }
        }

        private void btn_calculatorCalculate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hola"+ this.calculatorBusiness.CalculateCurrencyExchange(this.cbx_calculatorFrom.Text
                , this.cbx_calculatorTo.Text, decimal.Parse(this.tbx_calculatorAmount.Text)));
           
        }
    }
}
