using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;

namespace career_guidance_system
{
    public partial class RegisterStudent : System.Web.UI.Page
    {
            protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Register_Click(object sender, EventArgs e)
        { //Register password
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM mds_users WHERE Email = @Email");
            cmd.Parameters.AddWithValue("@Email", email.Text);
            cmd.Connection = conn;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                Response.Write("< script > alert('Email already exist') </ script >");   
            }
            else
            {
                conn.Close();
                try
                   
                {
                    conn.Open();
                    if(password.Text != "" && ConfirmPassword.Text != "" && password.Text == ConfirmPassword.Text)
                    {
                        string insertQuery = "INSERT INTO mds_users (Name,Surname,Email,Password,Role) VALUES (@Name,@Surname,@Email,@Password,@Role) ";
                        SqlCommand com = new SqlCommand(insertQuery, conn);
                        com.Parameters.AddWithValue("@Name", firstname.Text);
                        com.Parameters.AddWithValue("@Surname", surname.Text);
                        com.Parameters.AddWithValue("@Email", email.Text);
                        com.Parameters.AddWithValue("@Role", txtRole.Text);
                        com.Parameters.AddWithValue("@Password", Password.EncryptStringAES(password.Text.Trim(), "PlusProPassword#202020"));
                        com.ExecuteNonQuery();
                        string insertQuery1 = "INSERT INTO mds_undergrad_scie1 (Email) VALUES (@Email) ";
                        SqlCommand com1 = new SqlCommand(insertQuery1, conn);
                        com1.Parameters.AddWithValue("@Email", email.Text);
                        com1.ExecuteNonQuery();
                        string insertQuery2 = "INSERT INTO mds_combination_arts_1 (Email) VALUES (@Email) ";
                        SqlCommand com2 = new SqlCommand(insertQuery2, conn);
                        com2.Parameters.AddWithValue("@Email", email.Text);
                        com2.ExecuteNonQuery();
                        string insertQuery3 = "INSERT INTO mds_combination_arts_2 (Email) VALUES (@Email) ";
                        SqlCommand com3 = new SqlCommand(insertQuery3, conn);
                        com3.Parameters.AddWithValue("@Email", email.Text);
                        com3.ExecuteNonQuery();
                        string insertQuery4 = "INSERT INTO mds_combination_arts_3 (Email) VALUES (@Email) ";
                        SqlCommand com4 = new SqlCommand(insertQuery4, conn);
                        com4.Parameters.AddWithValue("@Email", email.Text);
                        com4.ExecuteNonQuery();
                        string insertQuery5 = "INSERT INTO mds_combination_com_1 (Email) VALUES (@Email) ";
                        SqlCommand com5 = new SqlCommand(insertQuery5, conn);
                        com5.Parameters.AddWithValue("@Email", email.Text);
                        com5.ExecuteNonQuery();
                        string insertQuery6 = "INSERT INTO mds_combination_com_2 (Email) VALUES (@Email) ";
                        SqlCommand com6 = new SqlCommand(insertQuery6, conn);
                        com6.Parameters.AddWithValue("@Email", email.Text);
                        com6.ExecuteNonQuery();
                        string insertQuery7 = "INSERT INTO mds_combination_com_3 (Email) VALUES (@Email) ";
                        SqlCommand com7 = new SqlCommand(insertQuery7, conn);
                        com7.Parameters.AddWithValue("@Email", email.Text);
                        com7.ExecuteNonQuery();
                        string insertQuery8 = "INSERT INTO mds_combination_com_4 (Email) VALUES (@Email) ";
                        SqlCommand com8 = new SqlCommand(insertQuery8, conn);
                        com8.Parameters.AddWithValue("@Email", email.Text);
                        com8.ExecuteNonQuery();
                        string insertQuery9 = "INSERT INTO mds_combination_scie_1 (Email) VALUES (@Email) ";
                        SqlCommand com9 = new SqlCommand(insertQuery9, conn);
                        com9.Parameters.AddWithValue("@Email", email.Text);
                        com9.ExecuteNonQuery();
                        string insertQuery10 = "INSERT INTO mds_combination_scie_2 (Email) VALUES (@Email) ";
                        SqlCommand com10 = new SqlCommand(insertQuery10, conn);
                        com10.Parameters.AddWithValue("@Email", email.Text);
                        com10.ExecuteNonQuery();
                        string insertQuery11 = "INSERT INTO mds_combination_scie_3 (Email) VALUES (@Email) ";
                        SqlCommand com11 = new SqlCommand(insertQuery11, conn);
                        com11.Parameters.AddWithValue("@Email", email.Text);
                        com11.ExecuteNonQuery();
                        string insertQuery12 = "INSERT INTO mds_combination_scie_4 (Email) VALUES (@Email) ";
                        SqlCommand com12 = new SqlCommand(insertQuery12, conn);
                        com12.Parameters.AddWithValue("@Email", email.Text);
                        com12.ExecuteNonQuery();
                        string insertQuery13 = "INSERT INTO mds_combination_scie_5 (Email) VALUES (@Email) ";
                        SqlCommand com13 = new SqlCommand(insertQuery13, conn);
                        com13.Parameters.AddWithValue("@Email", email.Text);
                        com13.ExecuteNonQuery();
                        string insertQuery14 = "INSERT INTO mds_undergrad_com1 (Email) VALUES (@Email) ";
                        SqlCommand com14 = new SqlCommand(insertQuery14, conn);
                        com14.Parameters.AddWithValue("@Email", email.Text);
                        com14.ExecuteNonQuery();
                        string insertQuery15 = "INSERT INTO mds_undergrad_arts1 (Email) VALUES (@Email) ";
                        SqlCommand com15 = new SqlCommand(insertQuery15, conn);
                        com15.Parameters.AddWithValue("@Email", email.Text);
                        com15.ExecuteNonQuery();
                        conn.Close();
                        Response.Write("<script>alert('Registration Successful')</script>");
                        Response.Redirect("RegisterSuccess.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('Passwords do not match')</script>");
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("Error:" + ex.ToString());
                }
            } 
        }
            
    }
}


