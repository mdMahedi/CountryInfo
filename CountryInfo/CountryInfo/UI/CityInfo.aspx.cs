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
    public partial class CityInfo : System.Web.UI.Page
    {
        CityInfoManager aCityInfoManager=new CityInfoManager();
        CountryManager aCountryManager=new CountryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            showGridView.DataSource = aCityInfoManager.GetAllCityInfo();
            showGridView.DataBind();
        }
        protected void saveButton_Click(object sender, EventArgs e)
        {
            City city=new City();
            city.Name = nameTextBox.Text;
            city.About = aboutTextBox.Text;
            if (dwellersTextBox.Text == String.Empty)
            {
                city.Dwellers = 0;
            }
            else
            {
                city.Dwellers = Convert.ToDouble(dwellersTextBox.Text);
            }
            
            city.Location = locationTextBox.Text;
            city.Weather = weatherTextBox.Text;
            city.CountryInfo = Convert.ToInt32(countryDropDownList.SelectedItem.Value);
            lblMsg.Text=aCityInfoManager.InsertCityInfo(city);

            ClearTextboxes();
            showGridView.DataSource = aCityInfoManager.GetAllCityInfo();
            showGridView.DataBind();
        }
        public void ClearTextboxes()
        {
            nameTextBox.Text=String.Empty;
            aboutTextBox.Text=String.Empty;
            dwellersTextBox.Text=String.Empty;
            locationTextBox.Text=String.Empty;
            weatherTextBox.Text=String.Empty;
        }
    }
}