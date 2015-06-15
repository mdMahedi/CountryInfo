using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using CountryInfo.DAO.Gateway;
using CountryInfo.DAO.Model;

namespace CountryInfo.BLL
{
    public class CityInfoManager
    {
        CityInfoGateway aCityInfoGateway=new CityInfoGateway();

        public string InsertCityInfo(City city)
        {
            if (city.Name == String.Empty)
            {
                return "City name missing...";
            }
            else if (city.About==String.Empty)
            {
                return "City about information missing...";
            }
            //else if (city.Dwellers==0)
            //{
            //    return "City dwellers missing...";
            //}
            else if (city.Location==String.Empty)
            {
                return "City location missing...";
            }
            else if (city.Weather==String.Empty)
            {
                return "Weather missing...";
            }
            //else if (city.CountryInfo==null)
            //{
            //    return "Country reference missing...";
            //}
            else if (aCityInfoGateway.IsCountryNameExist(city))
            {
                return "City name already exist...";
            }
             else if (aCityInfoGateway.InsertCityInfo(city))
             {
                 return "Saved Succesfully...";
             }
             else
             {
                 return "Sorry,, saved failed...";
             }
        }

        public DataTable GetAllCityInfo()
        {
            return aCityInfoGateway.GetAllCityInfo();
        }

        public DataTable ShowCities()
        {
            return aCityInfoGateway.ViewCities();
        }

        public DataTable SearchCitiesByName(string name)
        {
            return aCityInfoGateway.SearchCitiesByName(name);
        }
    }
}