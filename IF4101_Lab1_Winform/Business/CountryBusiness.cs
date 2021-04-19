using System;
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
            this.connectionDataAccess = new ConnectionDataAccess();
        }
        /*
       first way
       private string country_name; 

       public string Country_name
       {
           get { return country_name; }
           set { country_name = value; }
       }
      */

        // Use a shorthand
        public string Country_name { get; set; }

    }
}
