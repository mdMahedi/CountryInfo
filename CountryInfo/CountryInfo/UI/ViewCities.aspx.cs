using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CountryInfo.BLL;
using CountryInfo.DAO.Model;

namespace CountryInfo.UI
{
    public partial class ViewCities : System.Web.UI.Page
    {
        CityInfoManager aCityInfoManager=new CityInfoManager();
        CountryManager aCountryManager=new CountryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            showGridView.DataSource = aCityInfoManager.ShowCities();
            showGridView.DataBind();
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            string country = countryDropDownList.SelectedItem.ToString();
            string city = cityNameTextBox.Text;

            if (cityNameRadiobox.Checked)
            {
                showGridView.DataSource=aCityInfoManager.SearchCitiesByName(city);
                showGridView.DataBind();
            }
            else if (countryNameRadiobox.Checked)
            {
                showGridView.DataSource = aCountryManager.SearchCountryByName(country);
                showGridView.DataBind();
            }
        }
    }
}