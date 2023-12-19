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

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {

            var name = txtname.Text;
            args.IsValid = (name.Length == 6);

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                LblInfo.Visible = true;
                LblInfo.Text = "Welcome " + txtname.Text;
                LblInfo.Text += "Mobile Number " + txtMobile.Text;
                LblInfo.Text += "Email " + txtEmail.Text;
                LblInfo.Text += "Password " + txtPass.Text;
            }
            
        }

        

    }
}