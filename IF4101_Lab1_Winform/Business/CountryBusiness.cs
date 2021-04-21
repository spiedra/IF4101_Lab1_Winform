﻿using System;
using System.Collections.Generic;
using System.Text;
using IF4101_Lab1_Winform.DataAccess;

namespace IF4101_Lab1_Winform.Business
{
    class CountryBusiness
    {
        ConnectionDataAccess connectionDataAccess;
        public CountryBusiness()
        {
            this.CountryId = 0;
            this.CurrencyId = 0;
            this.CountryName = null;
            this.connectionDataAccess = new ConnectionDataAccess();
        }

        public CountryBusiness(int countryId, int currencyId, string countryName)
        {
            this.CountryId = countryId;
            this.CurrencyId = currencyId;
            this.CountryName = countryName;
        }

        // Use a shorthand
        public int CountryId { get; set; }
        public int CurrencyId { get; set; }
        public string CountryName { get; set; }


        public List<CountryBusiness> GetCountriesList()
        {
            return this.connectionDataAccess.GetCountriesList();
        }

        public void InsertIntoTbCountry(string countryName, int countryId)
        {
            this.connectionDataAccess.InsertIntoTbCountry(countryName, countryId);
        }

        public void DeleteCountry(string countryName)
        {
            this.connectionDataAccess.DeleteCountry(countryName);
        }
    }
}
