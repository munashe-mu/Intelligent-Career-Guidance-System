using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace career_guidance_system
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateData(1, 5);
            }
            AddpagingButton();

        }

        private void AddpagingButton()
        {
            //this method is for generate custom button for custom pagin in gridview
            int totalRecord = 0;
            int noOfRecord = 0;
            totalRecord = ViewState["TotalRecord"] != null ? (int)ViewState["TotalRecord"] : 0;
            noOfRecord = ViewState["NoOfRecord"] != null ? (int)ViewState["NoOfRecord"] : 0;

            int pages = 0;
            if (totalRecord > 0 && noOfRecord > 0)
            { //count no of pages
                pages = (totalRecord / noOfRecord) + ((totalRecord % noOfRecord) > 0 ? 1 : 0);
                for (int i = 0; i < pages; i++)
                {
                    Button b = new Button
                    {
                        Text = (i + 1).ToString(),
                        CommandArgument = (i + 1).ToString(),
                        ID = "Button_" + (i + 1).ToString()
                    };
                    b.Click += new EventHandler(this.B_click);
                    Panel1.Controls.Add(b);
                }
            }
        }
        private void B_click(object sender, EventArgs e)
        {// get data from database on button (paging button) click
            string pageNo = ((Button)sender).CommandArgument;
            PopulateData(Convert.ToInt32(pageNo), 5);

        }

        private void PopulateData(int pageNo, int noOfRecords)
        {
            // This method is for getting data from the database based on selected page
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("getData", conn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@PageNo", pageNo);
                cmd.Parameters.AddWithValue("@NoOfRecord", noOfRecords);

                SqlParameter TotalRecordSP = new SqlParameter("@TotalRecord", System.Data.SqlDbType.Int)
                {
                    Direction = System.Data.ParameterDirection.Output
                };
                cmd.Parameters.Add(TotalRecordSP);

                DataTable dt = new DataTable();
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                dt.Load(cmd.ExecuteReader());

                int totalRecord = 0;
                if (TotalRecordSP.Value != null)
                {
                    int.TryParse(TotalRecordSP.Value.ToString(), out totalRecord);
                }
                GridView1.DataSource = dt;
                GridView1.DataBind();

                //store Total Record & No of record per page into view state for use in generate paging button method
                ViewState["TotalRecord"] = totalRecord;
                ViewState["NoOfRecord"] = noOfRecords;
            }
        } 
    }
}
