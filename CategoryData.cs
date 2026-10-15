using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System
{
    class CategoryData
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Database\Restaurant MS.mdf;Integrated Security=True;Connect Timeout=30");

        public string Id { set; get; }
        public string Name { set; get; }
        public string Category_Status { set; get; }
        public string Category_Image { set; get; }
        public List<CategoryData> CategoryDataList()
        {
            List<CategoryData> listData = new List<CategoryData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string query = "Select * From Category";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            CategoryData emp = new CategoryData();
                            emp.Id = reader["ID"].ToString();
                            emp.Name = reader["NAME"].ToString();
                            emp.Category_Status = reader["STATUS"].ToString();
                            emp.Category_Image = reader["IMAGE"].ToString();
                            listData.Add(emp);

                        }
                    }
                    connect.Close();
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
