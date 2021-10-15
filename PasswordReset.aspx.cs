using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace career_guidance_system
{
    public partial class PasswordReset : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Email"] != null)
            {
                Label1.Text = Session["Email"].ToString();
            }
        }

 
        protected void BtnSend_Click1(object sender, EventArgs e)
        {
            //reset password
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            conn.Open();
            if (txtPass.Text == txtConfirm.Text)
            {
                string insertQuery = "UPDATE  mds_users SET Password= @Password WHERE Email= @Email ";
                SqlCommand com = new SqlCommand(insertQuery, conn);
                com.Parameters.AddWithValue("@Email", Label1.Text);
                //encrypt password
                com.Parameters.AddWithValue("@Password", Password.EncryptStringAES(txtPass.Text.Trim(), "PlusProPassword#202020"));
                com.ExecuteNonQuery();
                Response.Redirect("Login.aspx");
            }
            else
            {
                Response.Write("<script>alert('Passwords do not match')</script>");
            }
        }
    }
}