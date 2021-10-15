using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace career_guidance_system
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["New"] != null)
            {
                label_welcome.Text = Session["New"].ToString();
            }
            else

             Response.Redirect("Login.aspx");
        }

        protected void BtnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("../../Login.aspx");
        }

        protected void BtnBack_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT [Class] FROM [dbo].[mds_users] WHERE Email = @Email", conn);
                cmd.Parameters.AddWithValue("@Email", label_welcome.Text.Trim());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Label1.Text = dr.GetValue(0).ToString();
                }
                conn.Close();
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("SELECT [Role] FROM [dbo].[mds_users] WHERE Email = @Email", conn);
                cmd1.Parameters.AddWithValue("@Email", label_welcome.Text.Trim());
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    Label2.Text = dr1.GetValue(0).ToString();
                }
                conn.Close();

                string class2 = "O' level";
                string class3 = "A level";
                string class4 = "Undergrad";
                
                string role = "Parent";

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
                if (Label2.Text == role)
                {
                    Response.Redirect("body/parents/parentshome.aspx");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error " + ex + " Message')</script> ");
            }
        }
    }
}
