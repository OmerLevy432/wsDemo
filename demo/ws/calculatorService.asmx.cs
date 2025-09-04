using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ws
{
    /// <summary>
    /// Summary description for calculatorService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class calculatorService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public double add(double x, double y)
        {
            return x + y;
        }

        [WebMethod]
        public double sub(double x, double y)
        {
            return x - y;
        }

        [WebMethod]
        public double mul(double x, double y)
        {
            return x * y;
        }

        [WebMethod]
        public double div(double x, double y)
        {
            return x / y;
        }
    }
}
