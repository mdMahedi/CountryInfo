using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace CountryInfo.DAO.Model
{
    public class City
    {
        public int Sl { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public double Dwellers { get; set; }
        public string Location { get; set; }
        public string Weather { get; set; }
        public int CountryInfo { get; set; }
    }
}