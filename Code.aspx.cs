using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace career_guidance_system
{
    public partial class Code : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Code"] != null)
            {
                Label1.Text = Session["Code"].ToString();
            }

            if (Session["Email"] != null)
            {
                Label2.Text = Session["Email"].ToString();
            }

        }

        protected void BtnSendCode_Click(object sender, EventArgs e)
        {
            if (Label1.Text == txtCode.Text)
            {
                Response.Redirect("PasswordReset.aspx");
            }
            else
            {
                Response.Write("<script>alert('Wrong code, check code sent to your Email to reset password')</script>");
            }

        }
    }
}