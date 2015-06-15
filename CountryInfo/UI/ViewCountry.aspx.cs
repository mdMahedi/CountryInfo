using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CountryInfo.BLL;

namespace CountryInfo.UI
{
    public partial class ViewCountry : System.Web.UI.Page
    {
        CountryManager aCountryManager=new CountryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            showGridView.DataSource = aCountryManager.ViewCountries();
            showGridView.DataBind();
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            string name = searchTextBox.Text;
            showGridView.DataSource= aCountryManager.ViewCountryByName(name);
            showGridView.DataBind();
            searchTextBox.Text = "";
        }
    }
}