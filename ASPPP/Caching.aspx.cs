using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPPP
{
    public partial class Caching : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Label1.Text = "This page is cached by the server @ " + DateTime.Now.ToString();
            Response.Cache.SetExpires(DateTime.Now.AddSeconds(60));
            Response.Cache.VaryByParams["None"] = true;
            Response.Cache.SetCacheability(HttpCacheability.Server);


            //string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            //SqlConnection con = new SqlConnection(CS);
            //SqlDataAdapter da = new SqlDataAdapter("spGetProducts", con);
            //da.SelectCommand.CommandType = CommandType.StoredProcedure;
            //DataSet DS = new DataSet();
            //da.Fill(DS);
            //GridView1.DataSource = DS;
            //GridView1.DataBind();
        }
    }
}