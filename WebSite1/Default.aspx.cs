using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

public partial class _Default : System.Web.UI.Page
{
    string connetionString;
    SqlConnection conn;
    SqlCommand cmd;
    string sql;
    SqlDataAdapter adp = new SqlDataAdapter();

    protected void Page_Load(object sender, EventArgs e)
    {
        Label10.Text = "Waiting for connection...";
        Thread.Sleep(1000);        
        try
        {
            
            Label10.Text = "Connection Successful";
        }
        catch (Exception ex) {                        
            Label10.Text = ("Connection Failed.\n"+ex);
        }
        
        

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string nameval = @"^\w+@[a-zA-Z]";
        string emailPattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$";
        string phonePattern = @"^[2-9]\d{2}-\d{3}-\d{4}$";

        bool isEmailValid = Regex.IsMatch(TextBox4.Text, emailPattern);
        bool isZipValid = Regex.IsMatch(TextBox1.Text, nameval);
        bool isPhoneValid = Regex.IsMatch(TextBox3.Text, phonePattern);  

        if (!isEmailValid)
        {
            Label10.Text=("Please enter a valid email");
        }

        if (!isZipValid)
        {
            Label10.Text=("Please enter a valid zip code");
        }

        if (!isPhoneValid)
        {
            Label10.Text=("Please enter a valid phone number");
        }  
        try
        {
            string name = TextBox1.Text;
            string age = TextBox2.Text;
            string mobile = TextBox3.Text;
            string email = TextBox4.Text;

            sql = "insert into users_data (name,age,mobile,email) values('"+name+"','"+age+"','"+mobile+"','"+email+"')";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            Label10.Text = "Data Inserted Successfully ";
            
        }
        catch (Exception ex) {
            Label9.Text = ex.ToString();
        }
        
    }
}