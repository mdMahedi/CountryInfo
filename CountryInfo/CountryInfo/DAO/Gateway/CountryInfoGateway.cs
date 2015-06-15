using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CountryInfo.DAO.Model;

namespace CountryInfo.DAO.Gateway
{
    public class CountryInfoGateway
    {
        public bool InsertCountryInfo(Country country)
        {
            SqlConnection connection = ConnectionDBGateway.GetCityInfoDBConnection();
            string query = "Insert Into tbl_Country Values ('" + country.Name + "','" + country.About + "')";
            SqlCommand command= new SqlCommand(query,connection);
            if (command.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable GetAllCountries()
        {
            SqlConnection connection = ConnectionDBGateway.GetCityInfoDBConnection();
            string query = "Select RANK() over(order by name asc) as Sl,name,about from tbl_Country";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            connection.Close();
            return data;
        }

        public bool IsCountryNameExist(Country country)
        {
            Country aCountry=new Country();
            SqlConnection connection = ConnectionDBGateway.GetCityInfoDBConnection();
            string query = "Select name from tbl_Country Where name='" + country.Name + "'";
            SqlCommand command=new SqlCommand(query,connection);
            SqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                aCountry.Name = reader["name"].ToString();
            }
            reader.Close();
            connection.Close();
            if (aCountry.Name==country.Name)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<Country> GetCountryName()
        {
            List<Country> aCountries = new List<Country>();
            SqlConnection connection = ConnectionDBGateway.GetCityInfoDBConnection();
            string query = "Select id, name from tbl_Country";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Country country = new Country();
                
                country.Sl = Convert.ToInt32(reader["id"].ToString());
                country.Name = reader["name"].ToString();
                aCountries.Add(country);
            }
            connection.Close();
            return aCountries;
        }

        public DataTable SearchCountryByName(string name)
        {
            SqlConnection connection = ConnectionDBGateway.GetCityInfoDBConnection();
            string query = "select RANK() over(order by c.cityName asc) as Sl," +
                           "c.cityName as [City],c.about as [About], c.dwellers " +
                           "as [No of Dwellers],c.location as [Location], " +
                           "t.name as[Country Name], t.about as [About] " +
                           "from tbl_City c inner join tbl_Country t on t.id=c.country " +
                           "Where t.name ='"+name+"'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            connection.Close();
            return data;
        }
        public DataTable ViewCountries()
        {
            SqlConnection connection = ConnectionDBGateway.GetCityInfoDBConnection();
            string query = "select RANK() over(order by c.name asc) as Sl, " +
                           "c.[name] as Name,c.[about] as About, " +
                           "(select COUNT(ci.cityName))as [No of City]," +
                           "avg(ci.[dwellers]) as[No of City Dwellers] from" +
                           " [dbo].[tbl_Country] c join [dbo].[tbl_City] ci " +
                           "on c.id=ci.country group by c.[name],c.[about]";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            connection.Close();
            return data;
        }

        public DataTable ViewCountryByName(string name)
        {
            SqlConnection connection = ConnectionDBGateway.GetCityInfoDBConnection();
            string query = "select RANK() over(order by c.name asc) as Sl, c.[name] as Name," +
                           "c.[about] as About,(select COUNT(ci.cityName))as [No of City]," +
                           "avg(ci.[dwellers]) as[No of City Dwellers] from " +
                           "[dbo].[tbl_Country] c join [dbo].[tbl_City] ci " +
                           "on c.id=ci.country where c.name like '%[" + name + "]%' group by c.[name]," +
                           "c.[about]";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            connection.Close();
            return data;
        }
        
    }
}