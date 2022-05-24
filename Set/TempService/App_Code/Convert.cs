using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for Convert
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class Convert : System.Web.Services.WebService
{

    public Convert()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }

    [WebMethod]
    public double FahrenheitToCelcius(double Fahrenheit)
    {
        return ((Fahrenheit - 32) * 5) / 9; // Fahrenheit To Celcius
    }

    [WebMethod]
    public double CelciusToFahrenheit(double Celcius)
    {
        return ((Celcius * 9) / 5) + 32; // Tersi.
    }
}
