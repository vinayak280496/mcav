using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseConnection
{
    public partial class Form1 : Form
    {
        string connectionstring;
        SqlConnection conn;
        SqlCommand sqlcmd;
        string sqlquery;
        SqlDataAdapter sqladp = new SqlDataAdapter();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = "Connected";
            }catch(Exception ex){
                label2.Text = ex.ToString();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "Not connected";
            label2.ForeColor = Color.Red;
        }
    }
}
