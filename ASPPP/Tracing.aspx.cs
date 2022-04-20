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
    public partial class Tracing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Trace.Warn("GetAllEmployees() started");
            GetAllEmployees();
            Trace.Warn("GetAllEmployees() Complete");

            Trace.Warn("GetEmployeesByGender() started");
            GetEmployeesByGender();
            Trace.Warn("GetEmployeesByGender() Complete");

            Trace.Warn("GetEmployeesByDepartment() started");
            GetEmployeesByDepartment();
            Trace.Warn("GetEmployeesByDepartment() Complete");
        }

        private void GetAllEmployees()
        {
            gvAllEmployees.DataSource = ExecuteStoredProcedure("spGetEmployees");
            gvAllEmployees.DataBind();
        }

        private void GetEmployeesByGender()
        {
            gvEmployeesByGender.DataSource = ExecuteStoredProcedure("spGetEmployeesByGender");
            gvEmployeesByGender.DataBind();
        }

        private void GetEmployeesByDepartment()
        {
            gvEmployeesByDepartment.DataSource = ExecuteStoredProcedure("spGetEmployeesByDepartment");
            gvEmployeesByDepartment.DataBind();
        }


        private DataSet ExecuteStoredProcedure(string spname)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);
            SqlDataAdapter da = new SqlDataAdapter(spname, con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet DS = new DataSet();
            da.Fill(DS);
            if (spname == "spGetEmployeesByGender")
            {
                System.Threading.Thread.Sleep(7000);
            }
            return DS;
        }
    }
}