using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CountryInfo.DAO.Gateway
{
    public class ConnectionDBGateway
    {
        public static SqlConnection GetCityInfoDBConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Conn_CityInfoDB"].ConnectionString;
            SqlConnection connection=new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}