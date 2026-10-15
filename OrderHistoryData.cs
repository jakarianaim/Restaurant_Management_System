using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System
{
    class OrderHistoryData
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Database\Restaurant MS.mdf;Integrated Security=True;Connect Timeout=30");

        public string OrderID { set; get; }
        public DateTime Date { set; get; }
        public string Products { set; get; }
        public string PaymentId { set; get; }
        public string EmployeeId { set; get; }


        public List<OrderHistoryData> OrderHistoryDataList(string query = "Select * From OrderHistory")
        {
            List<OrderHistoryData> listData = new List<OrderHistoryData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            OrderHistoryData emp = new OrderHistoryData();
                            emp.OrderID = reader["ORDER_ID"].ToString();
                            emp.Date = (DateTime)reader["DATE"];
                            emp.Products = reader["PRODUCTS"].ToString();
                            emp.PaymentId = reader["PAYMENT_ID"].ToString();
                            emp.EmployeeId = reader["EMPLOYEE_ID"].ToString();

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
