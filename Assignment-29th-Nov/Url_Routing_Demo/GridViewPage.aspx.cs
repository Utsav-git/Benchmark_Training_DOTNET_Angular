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
    public partial class GridViewPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server =  UTSAV\\MSSQLSERVER01; Database = EmpDB; trusted_connection = true");
            SqlCommand cmd = new SqlCommand("select * from article", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            adapter.Fill(ds);

            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();

        }
        protected string getTitle(Object str) {
            return str.ToString().Replace(' ', '_');
        }
    }
}