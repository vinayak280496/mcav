using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataReaderConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string connetionString = @"Data Source=DESKTOP-AC4AK63;Initial Catalog=PSELF;Persist Security Info=True;User ID=sa;Password=Password@123";
                SqlConnection conn = new SqlConnection(connetionString);
                SqlCommand cmd = new SqlCommand("SELECT ID , NAME FROM user;", conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}\t{1}", reader.GetString(0), reader.GetString(1));
                    }
                    reader.Close();
                }
                else
                {
                    Console.WriteLine("No Rows Found.");
                }
            }
            catch (Exception ex) {
                Console.WriteLine("Database Error."+ex);
                
            }
            Console.ReadKey();
            
        }
    }
}
