using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IF4101_Lab1_Winform.Business;
using IF4101_Lab1_Winform.UserInterface;

namespace IF4101_Lab1_Winform
{
    public partial class CalculatorForm : Form
    {
        private CurrencyBusiness currencyBusiness;
        private CountryBusiness countryBusiness;
        private CalculatorBusiness calculatorBusiness;
        private List<CountryBusiness> countryList;
        private decimal currencyFrom;
        private decimal currencyTo;
        private decimal total;
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
            MessageForm messageForm = new MessageForm(this.CreateFinalString());
            messageForm.Show();
        }

        private string CreateFinalString()
        {
            this.GetMessageValue();
            string message = "Selected countries:" + String.Format(Environment.NewLine)
                + String.Format(Environment.NewLine) + "Amount: " + this.tbx_calculatorAmount.Text
                + String.Format(Environment.NewLine) + String.Format(Environment.NewLine) + "From: " + this.cbx_calculatorFrom.Text
                + String.Format(Environment.NewLine) + "Currency value: " + this.currencyFrom
                + String.Format(Environment.NewLine) + String.Format(Environment.NewLine) + "To: " + this.cbx_calculatorTo.Text
                + String.Format(Environment.NewLine) + "Currency value: " + this.calculatorBusiness.GetDollarValueCurrency(this.cbx_calculatorTo.Text)
                + String.Format(Environment.NewLine) + String.Format(Environment.NewLine) + "Total: " + this.total
                + String.Format(Environment.NewLine) + "Total + cost: " + this.calculatorBusiness.GetExchangeProfit(this.total);
            return message;
        }

        private void GetMessageValue()
        {
            this.currencyFrom = this.calculatorBusiness.GetDollarValueCurrency(this.cbx_calculatorFrom.Text);
            this.currencyTo = this.calculatorBusiness.GetDollarValueCurrency(this.cbx_calculatorTo.Text);
            this.total = this.calculatorBusiness.CalculateCurrencyExchange(currencyFrom, currencyTo
                , decimal.Parse(this.tbx_calculatorAmount.Text));
        }
    }
}
