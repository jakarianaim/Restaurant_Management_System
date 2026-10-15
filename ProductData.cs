using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Restaurant_Management_System
{
    class ProductData
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Database\Restaurant MS.mdf;Integrated Security=True;Connect Timeout=30");

        public string Id { set; get; }
        public string Name { set; get; }
        public double Price { set; get; }
        public string Category { set; get; }
        public int Stock { set; get; }
        public string Product_Image { set; get; }
        public double Product_Tax { set; get; }
        public string Product_Status { set; get; }

        public List<ProductData> ProductDataList()
        {
            List<ProductData> listData = new List<ProductData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string query = "Select * From Product";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            ProductData emp = new ProductData();
                            emp.Id = reader["ID"].ToString();
                            emp.Name = reader["NAME"].ToString();
                            emp.Price = Convert.ToDouble(reader["PRICE"]);
                            emp.Category = reader["CATEGORY"].ToString();
                            emp.Stock = Convert.ToInt32(reader["STOCK"]);
                            emp.Product_Image = reader["IMAGE"].ToString();
                            emp.Product_Tax = Convert.ToDouble(reader["TAX"]);
                            emp.Product_Status = reader["STATUS"].ToString();
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
