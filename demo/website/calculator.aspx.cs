using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace website
{
    public partial class calculator : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(number1.ToString());
            double num2 = double.Parse(number2.ToString());
            double res = 0;
            string op = opValue.Text;

            // check if the op is valid
            if (op != "/" &&  op != "*" && op != "+" && op != "-")
            {
                // return unvalid op
            }

            if (op == "+")
            {

            }
            if (op == "-")
            {

            }
            if (op == "/")
            {

            }
            if (op == "*")
            {

            }

            result.Text = res.ToString();
        }
    }
}