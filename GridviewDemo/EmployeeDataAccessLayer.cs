using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;

namespace GridviewDemo
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
    }

    public class EmployeeDataAccessLayer
    {
        public static List<Employee> GetAllEmployees()
        {
            List<Employee> listEmployees = new List<Employee>();

            string CS = ConfigurationManager.ConnectionStrings["aspppConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("Select * from tblEmployee", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Employee employee = new Employee();
                    employee.EmployeeId = Convert.ToInt32(rdr["EmployeeId"]);
                    employee.Name = rdr["Name"].ToString();
                    employee.Gender = rdr["Gender"].ToString();
                    employee.City = rdr["City"].ToString();

                    listEmployees.Add(employee);
                }
            }

            return listEmployees;
        }

        public static void DeleteEmployees(List<string> EmployeeIds)
        {
            string CS = ConfigurationManager.ConnectionStrings["aspppConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                List<string> parameters = EmployeeIds.Select((s, i) => "@Parameter" + i.ToString()).ToList();
                string inClause = string.Join(",", parameters);
                string deleteCommandText = "Delete from tblEmployee where EmployeeId IN (" + inClause + ")";
                SqlCommand cmd = new SqlCommand(deleteCommandText, con);

                for (int i = 0; i < parameters.Count; i++)
                {
                    cmd.Parameters.AddWithValue(parameters[i], EmployeeIds[i]);
                }

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
