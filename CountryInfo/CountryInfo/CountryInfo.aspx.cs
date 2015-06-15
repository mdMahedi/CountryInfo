using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CountryInfo.BLL;
using CountryInfo.DAO.Model;

namespace CountryInfo
{
    public partial class CountryInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            countryGridView.DataSource = aCountryManager.GetAllCountry();
            countryGridView.DataBind();
        }
        CountryManager aCountryManager=new CountryManager();
        protected void saveButton_Click(object sender, EventArgs e)
        {
            Country country=new Country();
            country.Name = nameTextBox.Text;
            country.About = aboutTextBox.Text;
            lblMsg.Text= aCountryManager.InsertCountryInfo(country).ToString();
            ClearTextboxes();
            countryGridView.DataSource = aCountryManager.GetAllCountry();
            countryGridView.DataBind();
        }
        private void ClearTextboxes()
        {
            nameTextBox.Text=String.Empty;
            aboutTextBox.Text=String.Empty;
        }
    }
}