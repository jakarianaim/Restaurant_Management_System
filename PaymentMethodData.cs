using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System
{
    class PaymentMethodData
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Database\Restaurant MS.mdf;Integrated Security=True;Connect Timeout=30");

        public string Id { set; get; }
        public string Name { set; get; }
        public double Status { set; get; }
        
        public List<PaymentMethodData> PaymentMethodDataList()
        {
            List<PaymentMethodData> listData = new List<PaymentMethodData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string query = "Select * From PaymentMethod";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            PaymentMethodData emp = new PaymentMethodData();
                            emp.Id = reader["ID"].ToString();
                            emp.Name = reader["NAME"].ToString();
                            emp.Name = reader["STATUS"].ToString();
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
