using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string conn = @"Data Source=DESKTOP-AC4AK63;Initial Catalog=PSELF; User ID=sa;Password=Password@123";
            string query = "SELECT * FROM user_data";

            SqlDataAdapter adp = new SqlDataAdapter(query,conn);
            DataSet ds = new DataSet();
            adp.Fill(ds, "user_data");
            Console.WriteLine(ds.GetXml());
            Console.ReadKey();
        }
    }
}
