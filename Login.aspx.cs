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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            //login user
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            conn.Open();
            string checkuser = "select count(*)  from mds_users where Email = '" + txtEmail.Text + "'";
            SqlCommand com = new SqlCommand(checkuser, conn);
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            conn.Close();
            if (temp == 1)
            {
                conn.Open();
                string checkPasswordQuery = "SELECT password from mds_users where Email = '" + txtEmail.Text + "'";
                SqlCommand passCom = new SqlCommand(checkPasswordQuery, conn);
                string password = passCom.ExecuteScalar().ToString().Replace(" ", "");
                string tmp_DecryptedPass = Password.DecryptStringAES(password, "PlusProPassword#202020");
                if (tmp_DecryptedPass == txtPass.Text)
                {
                    //Navigate users to their respective classes
                    Session["New"] = txtEmail.Text;

                    SqlCommand cmd = new SqlCommand("SELECT [Class],[Role] FROM [dbo].[mds_users] WHERE Email = @Email", conn);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Label1.Text = dr.GetValue(0).ToString();
                        Label2.Text = dr.GetValue(1).ToString();
                    }

                    string class1 = "";
                    string class2 = "O' level";
                    string class3 = "A level";
                    string class4 = "Undergrad";
                    string role = "Parent";

                    if (Label2.Text == role)
                    {
                        Response.Redirect("body/parents/parentshome.aspx");
                    }
                    if (Label1.Text == class1)
                    {
                        Response.Redirect("body/olevel/student_homepage.aspx");
                    }
                    if (Label1.Text == class2)
                    {
                        Response.Redirect("body/olevel/student_homepage.aspx");
                    }
                    if (Label1.Text == class3)
                    {
                        Response.Redirect("body/alevel/alevel_homepage.aspx");
                    }
                    if (Label1.Text == class4)
                    {
                        Response.Redirect("body/undergrad/undergradhome.aspx");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Wrong password')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Email not correct')</script>");
            }
        }
    }
}