using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Net.Mail;
using System.Net;
using System.Drawing;
using System.IO;

namespace career_guidance_system
{
    public partial class ResetCode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSendCode_Click(object sender, EventArgs e)
        {
            string randomcode;

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            conn.Open();
            string checkuser = "select count(*)  from mds_users where Email = '" + txtEmail.Text + "'";
            SqlCommand com = new SqlCommand(checkuser, conn);
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());

            if (temp == 1)
            {

                string checkuser1 = "select Name  from mds_users where Email = '" + txtEmail.Text + "'";
                SqlCommand com1 = new SqlCommand(checkuser1, conn);
                SqlDataReader dr1 = com1.ExecuteReader();
                while (dr1.Read())
                {
                    Label1.Text = dr1.GetValue(0).ToString();
                }

                try
                {
                    Random rand = new Random();
                    randomcode = (rand.Next(999999)).ToString();
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                    mail.From = new MailAddress("murimimunashe@gmail.com");
                    mail.To.Add(txtEmail.Text.Trim());
                    mail.Subject = "CACG Password Reset";
                    mail.IsBodyHtml = true;
                    mail.Body = "Hi " + Label1.Text + "<br /> Use this code to reset your password " + randomcode + "<br/><br/> Computer Assisted Career Guidance Team!";
                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("careerguidanceteam2@gmail.com", "Careers@2021");
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Send(mail);

                    Response.Write("<script>alert('Email sent, check your Email to reset password')</script>");
                    Session["Code"] = randomcode;
                    Session["Email"] = txtEmail.Text;
                    Response.Redirect("Code.aspx");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Response.Write(ex.ToString());
                }
            }
            else
            {
                Response.Write("<script>alert('Sorry this email is not registered')</script>");
            }
        }
    }
}