using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;

public partial class _Default : System.Web.UI.Page
{
    int atmno = 12345;
    int atmpin = 6116;
    double balance = 1000;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        Button2.Enabled = false;
        Label4.Text=("Default ATM Number is 12345 & ATM PIN is 6116");        
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            int txtatmnumber = Convert.ToInt32(TextBox1.Text);
            int txtatmpin = Convert.ToInt32(TextBox2.Text);

            if (txtatmnumber.Equals(atmno) && txtatmpin.Equals(txtatmpin))
            {
                Button2.Enabled = true;
                Label2.Text = "Amount to Withdraw";
                TextBox1.Text = "";

                Label3.Text = "Confirm Pin";
                TextBox2.Text = "";
                lblstatus.Text = "Login Successful.";
                Thread.Sleep(100);
                lblstatus.Text = ("Account Balance : "+balance.ToString());
            

            } else {
                lblstatus.Text = "Login failed.";                
                TextBox1.Text = "";
                TextBox2.Text = "";
            }
            
        }
        catch (Exception ex) {
            TextBox1.Text = "";
            TextBox2.Text = "";
            lblstatus.Text = "Invalid Data Entered.";
        }


    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {            
            int amtwithdraw = Convert.ToInt32(TextBox1.Text);
            int txtatmpin = Convert.ToInt32(TextBox2.Text);

            if (atmpin.Equals(txtatmpin) && amtwithdraw < 1000)
            {
                TextBox1.Text = "";
                TextBox2.Text = "";
                balance = balance - amtwithdraw;
                lblstatus.Text = ("Account Balance : "+balance.ToString());
            }
            else {
                TextBox1.Text = "";
                TextBox2.Text = "";
                lblstatus.Text = ("insufficient balance " + balance.ToString());
            }

        }
        catch (Exception ex) {

        }
    }
}