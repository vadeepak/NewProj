using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPPP
{
    public partial class DropDown : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("Select CityId, CityName, Country from tblCity", con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    DropDownList1.DataTextField = "CityName";
                    DropDownList1.DataValueField = "CityId";
                    DropDownList1.DataSource = rdr;
                    DropDownList1.DataBind();
                }
            }
        }
    }
}