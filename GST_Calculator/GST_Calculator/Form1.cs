using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace GST_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {           
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.ForeColor=Color.Red;
            label7.ForeColor=Color.Red;
            label8.ForeColor=Color.Red;
            label9.ForeColor=Color.Red;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i <= 100; i++)
            {
                progressBar1.Value = i;
                Thread.Sleep(50);

                if (i == 100)
                {
                    Thread.Sleep(20);
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    int gst28 = Convert.ToInt32(textBox1.Text);
                    int gst18 = Convert.ToInt32(textBox1.Text);
                    int gst12 = Convert.ToInt32(textBox1.Text);
                    int gst5 = Convert.ToInt32(textBox1.Text);

                    float gst28cal = (gst28 * 28 / 100);
                    label6.Text = (gst28cal.ToString());
                    Thread.Sleep(20);

                    float gst18cal = (gst18 * 18 / 100);
                    label7.Text = (gst18cal.ToString());
                    Thread.Sleep(20);

                    float gst12cal = (gst12 * 12 / 100);
                    label8.Text = (gst12cal.ToString());
                    Thread.Sleep(20);

                    float gst5cal = (gst5 * 5 / 100);
                    label9.Text = (gst5cal.ToString());
                    Thread.Sleep(10);
                    progressBar1.Visible = false;
                }
            }
        }
    }
}

