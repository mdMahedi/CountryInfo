using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CountryInfo.DAO.Model;

namespace CountryInfo.DAO.Gateway
{
    public class CityInfoGateway
    {
        public bool InsertCityInfo(City city)
        {
            SqlConnection connection = ConnectionDBGateway.GetCityInfoDBConnection();
            string query = "Insert Into tbl_City Values ('" + city.Name + "','" + city.About + "','" + city.Dwellers +
                           "','" + city.Location + "','" + city.Weather + "','" + city.CountryInfo + "')";
            SqlCommand command=new SqlCommand(query,connection);
            if (command.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsCountryNameExist(City city)
        {
            City aCity=new City();
            SqlConnection connection = ConnectionDBGateway.GetCityInfoDBConnection();
            string query = "Select cityName from tbl_City Where cityName='" + city.Name + "'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                aCity.Name = reader["cityName"].ToString();
            }
            reader.Close();
            connection.Close();
            if (aCity.Name == city.Name)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable GetAllCityInfo()
        {
            SqlConnection connection = ConnectionDBGateway.GetCityInfoDBConnection();
            string query = "Select RANK() over(order by c.cityName asc) as Sl, c.cityName as City, " +
                           "c.dwellers as Dwellers, t.name as Country from tbl_City c join  tbl_Country t on t.id=c.country";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            connection.Close();
            return data;
        }

        public DataTable ViewCities()
        {
            SqlConnection connection = ConnectionDBGateway.GetCityInfoDBConnection();
            string query = "select RANK() over(order by c.cityName asc) as Sl, c.cityName,c.about, " +
                           "c.dwellers as [No of Dwellers],c.location, t.name, t.about as [About Country] " +
                           "from tbl_City c join tbl_Country t on t.id=c.country";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            connection.Close();
            return data;
        }

        public DataTable SearchCitiesByName(string name)
        {
            SqlConnection connection = ConnectionDBGateway.GetCityInfoDBConnection();
            string query = "select RANK() over(order by c.cityName asc) as Sl, c.cityName as [City]," +
                           "c.about as [About], c.dwellers as [No of Dwellers],c.location as [Location], " +
                           "t.name as[Country Name], t.about as [About] from tbl_City c join tbl_Country t " +
                           "on t.id=c.country Where c.cityName like '%["+name+"]%'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            connection.Close();
            return data;
        }
    }
}