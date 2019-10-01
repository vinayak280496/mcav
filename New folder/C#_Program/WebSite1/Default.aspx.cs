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
    int cardNo;         
    int pin;
    double withAmount;
    Boolean isLogin = false;
    string connetionString;
    SqlConnection conn;       
    SqlDataAdapter adp = new SqlDataAdapter();
    int atmno = 123123;
    int atmpin = 1234;
    double balance = 1000;

    protected void Page_Load(object sender, EventArgs e)
    {        
        Button3.Visible=false;

        //TextBox4.Visible = false;
        //try { 
        //connetionString = @"Data Source=DESKTOP-AC4AK63;Initial Catalog=PSELF; user id = sa; password = Password@123;";           
        //conn = new SqlConnection(connetionString);
        //conn.Open();
        //lblstatus.Text = ("Connected.");

        //    }catch(Exception ex){
        //        lblstatus.Text = ("Connection Failed."+ex);
        //    }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            cardNo = Convert.ToInt32(TextBox1.Text);
            pin = Convert.ToInt32(TextBox2.Text);

            //SqlCommand command = new SqlCommand("select * from atm_entries where atm_num = @param1 AND atm_pin = @param2", conn);

            //command.Parameters.AddWithValue("@param1", cardNo); 
            //command.Parameters.AddWithValue("@param2", pin); 
            //SqlDataReader reader = command.ExecuteReader(); 

            if (cardNo == atmno && pin == atmpin)
            {
                isLogin = true;
                lblstatus.Text = "Login success";
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                TextBox3.Visible = true;
                TextBox1.Visible = false;
                Button3.Visible = true;
            }
            else
            {
                isLogin = false;
                lblstatus.Text = "Login failed";
            }
        }catch(Exception){
        }
         }   

    protected void  Button2_Click(object sender, EventArgs e)
{

}
protected void  Button3_Click(object sender, EventArgs e)
{    
    withAmount=Convert.ToInt64(TextBox3.Text);
    if(withAmount>balance){
        lblstatus.Text="Amount is lesser the balance";

    }else{
        balance=balance-withAmount;
        lblstatus.Text = balance.ToString();
    }
    

}
}
    //protected void Button3_Click(object sender, EventArgs e)
    //{
    //    cardNo = TextBox1.Text;
    //    pin = TextBox2.Text;
    //    withAmount = TextBox3.Text;
    //    int balance;
    //    //SqlCommand checkExists = new SqlCommand("select balance from atm_entries where atm_num = @param1", conn);
    //    //checkExists.Parameters.AddWithValue("@param1", cardNo); 
    //    //SqlDataReader checkReader = checkExists.ExecuteReader();
    //     if ()                     
    //     {                         
    //         balance = (int)checkReader[0];                         
    //         int withdrawal = Int32.Parse(withAmount); 
    //          lblstatus.Text = "Balance: " + balance + " Withdrawal balance: " +withdrawal; 
    //          if (balance < withdrawal)                         
    //          {                             
    //              lblstatus.Text = "Insufficient Balance";                         
    //          } 
    //          else                         
    //          {                             
    //              int remainingAmount = balance - withdrawal; 
    //              SqlCommand updateCommand = conn.CreateCommand(); 
    //              updateCommand.CommandText = "UPDATE atm_entries SET balance = @param1 WHERE atm_num = @param2 "; 
    //              updateCommand.Parameters.AddWithValue("@param1",  remainingAmount);       
    //              updateCommand.Parameters.AddWithValue("@param2", cardNo); 
    //              checkReader.Close();         
    //              var id = updateCommand.ExecuteScalar();       
    //              lblstatus.Text = "Transcation Successfull: Remaining Balance = " + remainingAmount;
    //          }
    //     } checkReader.Close(); 

    //}
    //protected void Button2_Click(object sender, EventArgs e)
    //{
    //    cardNo = TextBox1.Text;             
    //    SqlCommand command = new SqlCommand("select balance from atm_entries where atm_num = @param1", conn);
    //    command.Parameters.AddWithValue("@param1", cardNo);             
    //    SqlDataReader checkReader = command.ExecuteReader();             
    //    if (checkReader.Read())             
    //    {                 
    //        lblstatus.Text = "Your balance: " + checkReader[0].ToString();             
    //    }             
    //    else             
    //    {                 
    //        lblstatus.Text = "Error try again";             
    //    }         
    //}   
//}