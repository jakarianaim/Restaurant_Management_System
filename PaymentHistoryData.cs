using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System
{
    class PaymentHistoryData
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Database\Restaurant MS.mdf;Integrated Security=True;Connect Timeout=30");

        public string PaymentID { set; get; }
        public double Amount { set; get; }
        public string Type { set; get; }
        public string OrderID { set; get; }
        public string EmployeeID { set; get; }
        public DateTime Time { set; get; }
        
        public List<PaymentHistoryData> PaymentHistoryDataList(string query = "Select * From PaymentHistory")
        {
            List<PaymentHistoryData> listData = new List<PaymentHistoryData>();

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
                            PaymentHistoryData emp = new PaymentHistoryData();
                            emp.PaymentID = reader["PAYMENT_ID"].ToString();
                            emp.Amount = Convert.ToDouble(reader["AMOUNT"]);
                            emp.Type = reader["TYPE"].ToString();
                            emp.OrderID = reader["ORDER_ID"].ToString();
                            emp.EmployeeID = reader["EMPLOYEE_ID"].ToString();
                            emp.Time = (DateTime)reader["TIME"];
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
