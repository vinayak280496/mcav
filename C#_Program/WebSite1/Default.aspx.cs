using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{             
    String cardNo;         
    String pin;
    String withAmount;
    Boolean isLogin = false;
    string connetionString;
    SqlConnection conn;       
    SqlDataAdapter adp = new SqlDataAdapter();

    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox4.Visible = false;
        try { 
        connetionString = @"Data Source=DESKTOP-AC4AK63;Initial Catalog=PSELF; user id = sa; password = Password@123;";           
        conn = new SqlConnection(connetionString);
        conn.Open();
        lblstatus.Text = ("Connected.");

            }catch(Exception ex){
                lblstatus.Text = ("Connection Failed."+ex);
            }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        cardNo = TextBox1.Text;
        pin = TextBox2.Text;
        withAmount = TextBox3.Text;
        SqlCommand command = new SqlCommand("select * from atm_entries where atm_num = @param1 AND atm_pin = @param2", conn);

        command.Parameters.AddWithValue("@param1", cardNo); 
        command.Parameters.AddWithValue("@param2", pin); 
        SqlDataReader reader = command.ExecuteReader(); 

         if (reader.Read())             
         { 
             if (reader[1].ToString().Equals(pin))                 
             {                     
                 isLogin = true;                     
                 lblstatus.Text = "Login success";                 
                 TextBox2.Visible = true;                     
                 TextBox3.Visible = true;                     
                 TextBox3.Visible = true;                                      
                 TextBox1.Visible = false;                 
             }
             else 
             { 
                 isLogin = false;
                 lblstatus.Text = "Login failed";
             }
         }
         else 
         { 
             lblstatus.Text = "Atm card not present or wrong password"; 
         }         

         reader.Close(); 

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        cardNo = TextBox1.Text;
        pin = TextBox2.Text;
        withAmount = TextBox3.Text;
        int balance;
        SqlCommand checkExists = new SqlCommand("select balance from atm_entries where atm_num = @param1", conn);
        checkExists.Parameters.AddWithValue("@param1", cardNo); 
        SqlDataReader checkReader = checkExists.ExecuteReader();
         if (checkReader.Read())                     
         {                         
             balance = (int)checkReader[0];                         
             int withdrawal = Int32.Parse(withAmount); 
              lblstatus.Text = "Balance: " + balance + " Withdrawal balance: " +withdrawal; 
              if (balance < withdrawal)                         
              {                             
                  lblstatus.Text = "Insufficient Balance";                         
              } 
              else                         
              {                             
                  int remainingAmount = balance - withdrawal; 
                  SqlCommand updateCommand = conn.CreateCommand(); 
                  updateCommand.CommandText = "UPDATE atm_entries SET balance = @param1 WHERE atm_num = @param2 "; 
                  updateCommand.Parameters.AddWithValue("@param1",  remainingAmount);       
                  updateCommand.Parameters.AddWithValue("@param2", cardNo); 
                  checkReader.Close();         
                  var id = updateCommand.ExecuteScalar();       
                  lblstatus.Text = "Transcation Successfull: Remaining Balance = " + remainingAmount;
              }
         } checkReader.Close(); 

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        cardNo = TextBox1.Text;             
        SqlCommand command = new SqlCommand("select balance from atm_entries where atm_num = @param1", conn);
        command.Parameters.AddWithValue("@param1", cardNo);             
        SqlDataReader checkReader = command.ExecuteReader();             
        if (checkReader.Read())             
        {                 
            lblstatus.Text = "Your balance: " + checkReader[0].ToString();             
        }             
        else             
        {                 
            lblstatus.Text = "Error try again";             
        }         
    }   
}