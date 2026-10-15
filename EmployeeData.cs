using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Restaurant_Management_System
{
    class EmployeeData
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Database\Restaurant MS.mdf;Integrated Security=True;Connect Timeout=30");

        public string Id { set; get; }
        public string Pass { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public int Salary { set; get; }
        public string Gender { set; get; }
        public string JoinDate { set; get; }
        public string Role { set; get; }
        public string Status { set; get; }

        public List<EmployeeData> EmployeeDataList()
        {
            List<EmployeeData> listData = new List<EmployeeData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string query = "Select * From Employee";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            EmployeeData emp = new EmployeeData();
                            emp.Id = reader["ID"].ToString();
                            emp.Pass = reader["PASSWORD"].ToString();
                            emp.Name = reader["NAME"].ToString();
                            emp.Email = reader["EMAIL"].ToString();
                            emp.Salary = Convert.ToInt32(reader["SALARY"]);
                            emp.Gender = reader["GENDER"].ToString();
                            emp.JoinDate = reader["JOIN_DATE"].ToString();
                            emp.Role = reader["ROLE"].ToString();
                            emp.Status = reader["STATUS"].ToString();
                            listData.Add(emp);

                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error Opening Connection: " + ex);
                }
                finally
                {
                    connect.Close();
                }

            }
            return listData;
        }
    }
}
