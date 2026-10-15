using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System
{
    class DiscountData
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Database\Restaurant MS.mdf;Integrated Security=True;Connect Timeout=30");

        public string Id { set; get; }
        public string Name { set; get; }
        public string Coupon_Code { set; get; }
        public int Percentage { set; get; }
        public int Limit { set; get; }
        public int Maximum_Discount { set; get; }
        
        public int MINIMUM_REQ { set; get; }
        public DateTime Start_Date { set; get; }
        public DateTime End_Date { set; get; }



        public List<DiscountData> DiscountDataList()
        {
            List<DiscountData> listData = new List<DiscountData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string query = "Select * From Discount";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            DiscountData dis = new DiscountData();
                            dis.Id = reader["ID"].ToString();
                            dis.Name = reader["NAME"].ToString();
                            dis.Coupon_Code =reader["COUPON_CODE"].ToString();
                            dis.Percentage = Convert.ToInt32(reader["PERCENTAGE"]);
                            dis.Limit = Convert.ToInt32(reader["LIMIT"]);
                            dis.Maximum_Discount = Convert.ToInt32(reader["MAXIMUM_DISCOUNT"]);
                            dis.MINIMUM_REQ = Convert.ToInt32(reader["MINIMUM_REQ"]);
                            dis.Start_Date = (DateTime)reader["START_DATE"];
                            dis.End_Date = (DateTime)reader["END_DATE"];
                            listData.Add(dis);

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
