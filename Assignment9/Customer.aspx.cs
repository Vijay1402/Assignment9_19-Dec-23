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
            args.IsValid = args.Value.Length > 5;
        }

        protected void BtnReg_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                LblInfo.Visible = true;
                LblInfo.Text = "Registration Done!!";
                LblInfo.Text += " Your Name is " + TxtName.Text;
                LblInfo.Text += " Your number is " + TxtMobile.Text;
                LblInfo.Text += " Your email is " + TxtEmail.Text;
                LblInfo.Text += " Your Password is " + TxtPwd.Text;

            }
        }

        protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = args.Value == "pass@123";
        }
    }
}