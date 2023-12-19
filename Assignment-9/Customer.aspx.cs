using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment9
{
    public partial class Customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            LblInfo.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            LblInfo.Visible = true;
            LblInfo.Text = "Customer Name : " + TextBox1.Text;
            LblInfo.Text += "Mobile No : " + TextBox2.Text;
            LblInfo.Text += "Email Id : " + TextBox3.Text;
        }
        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string len = (args.Value);
            args.IsValid = len.Length > 6;


        }
    }
}
