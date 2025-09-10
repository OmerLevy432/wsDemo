using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using webService.App_Code;

namespace webService
{
    /// <summary>
    /// Summary description for MainService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MainService : System.Web.Services.WebService
    {

        [WebMethod]
        public PhoneContact GetContact(string email, string phoneNumber, string name)
        {
            PhoneContact contact = new PhoneContact();
            contact.email = email;
            contact.phoneNumber = phoneNumber;
            contact.name = name;

            return contact;
        }
    }
}
