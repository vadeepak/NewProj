using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace GridviewDemo
{
    public class GridviewinGridviewDataAccessLayeer
    {
        public class Employeesss
        {
            public int EmployeeId { get; set; }
            public string EmployeeName { get; set; }
        }

        public static List<Employeesss> GetAllEmployees(int DepartmentId)
        {
            List<Employeesss> listEmployees = new List<Employeesss>();

            string CS = ConfigurationManager.ConnectionStrings["aspppConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("Select * from tblEmployeesss where DeptId = @DepartmentId", con);
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@DepartmentId";
                parameter.Value = DepartmentId;
                cmd.Parameters.Add(parameter);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Employeesss employee = new Employeesss();
                    employee.EmployeeId = Convert.ToInt32(rdr["EmployeeId"]);
                    employee.EmployeeName = rdr["Name"].ToString();

                    listEmployees.Add(employee);
                }
            }

            return listEmployees;
        }
    }
}