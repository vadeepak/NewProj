using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;

namespace GridviewDemo
{
    public class Employeee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public string Photo { get; set; }
    }

    public class EmployeeDataAccessslayer
    {
        public static List<Employeee> GetAllEmployees()
        {
            List<Employeee> listEmployees = new List<Employeee>();

            string CS = ConfigurationManager.ConnectionStrings["aspppConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("Select * from tblEmployeee", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Employeee employeee = new Employeee();
                    employeee.EmployeeId = Convert.ToInt32(rdr["EmployeeId"]);
                    employeee.Name = rdr["Name"].ToString();
                    employeee.Gender = rdr["Gender"].ToString();
                    employeee.City = rdr["City"].ToString();
                    employeee.Photo = rdr["PhotoPath"].ToString();

                    listEmployees.Add(employeee);
                }
            }

            return listEmployees;
        }
    }
}