using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TempSite
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConvert_Click(object sender, EventArgs e)
        {
            localhost.Convert wsConvert = new localhost.Convert();
            double temperature = Convert.ToDouble(TemperatureTextbox.Text);
            FahrenheitLabel.Text = wsConvert.CelciusToFahrenheit(temperature).ToString();
            CelciusLabel.Text = wsConvert.FahrenheitToCelcius(temperature).ToString();
        }
    }
}