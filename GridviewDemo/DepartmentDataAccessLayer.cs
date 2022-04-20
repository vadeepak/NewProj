using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using static GridviewDemo.GridviewinGridviewDataAccessLayeer;

namespace GridviewDemo
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public List<Employeesss> Employees
        {
            get
            {
                return GridviewinGridviewDataAccessLayeer.GetAllEmployees(this.DepartmentId);
            }
        }
    }
    public class DepartmentDataAccessLayer
    {
        public static List<Department> GetAllDepartmentsandEmployees()
        {
            List<Department> listDepartments = new List<Department>();

            string CS = ConfigurationManager.ConnectionStrings["aspppConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("Select * from tblDepartment", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Department department = new Department();
                    department.DepartmentId = Convert.ToInt32(rdr["DepartmentId"]);
                    department.DepartmentName = rdr["Name"].ToString();

                    listDepartments.Add(department);
                }
            }

            return listDepartments;
        }
       
    }
}