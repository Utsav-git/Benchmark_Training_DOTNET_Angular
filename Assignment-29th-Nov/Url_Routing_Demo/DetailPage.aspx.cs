using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Url_Routing_Demo
{
    public partial class DetailPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.RouteData.Values["id"].ToString() != null) {
                string ID = Page.RouteData.Values["id"].ToString();

                SqlConnection con = new SqlConnection("Server = UTSAV\\MSSQLSERVER01; Database = EmpDB; trusted_connection = true");

                SqlCommand cmd = new SqlCommand("select * from article where id = "+ID, con);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                string title = ds.Tables[0].Rows[0]["title"].ToString();
                string description = ds.Tables[0].Rows[0]["description"].ToString();
                string author = ds.Tables[0].Rows[0]["author"].ToString();

                lbl_title.Text = title;
                lbl_desc.Text = description;
                lbl_author.Text = author;
                
                Page.DataBind();
            }

        }
    }
}