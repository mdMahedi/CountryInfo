using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using CountryInfo.DAO.Gateway;
using CountryInfo.DAO.Model;

namespace CountryInfo.BLL
{
    public class CountryManager
    {
        CountryInfoGateway countryInfo=new CountryInfoGateway();

        public string InsertCountryInfo(Country country)
        {
            if (country.Name == String.Empty)
            {
                return "Country name missing...";
            }
            else if (country.About == String.Empty)
            {
                return "Country about information missing...";
            }
            else if (countryInfo.IsCountryNameExist(country))
            {
                return "Country name already exist...";
            }
            else if (countryInfo.InsertCountryInfo(country))
            {
                return "Saved succesfully...";
            }
            else
            {
                return "Sorry,, Failed...";
            }
        }

        public DataTable GetAllCountry()
        {
            return countryInfo.GetAllCountries();
        }

        public List<Country> GetCountryName()
        {
            return countryInfo.GetCountryName();
        }

        public DataTable SearchCountryByName(string name)
        {
            return countryInfo.SearchCountryByName(name);
        }

        public DataTable ViewCountries()
        {
            return countryInfo.ViewCountries();
        }

        public DataTable ViewCountryByName(string name)
        {
            return countryInfo.ViewCountryByName(name);
        }
    }
}