using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class InsertCustomer : Form
    {
        Controller controllerObj;
        public InsertCustomer()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void InsertCustomer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text=="") //validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else if (textBox3.Text != "" && Convert.ToInt32(textBox3.Text) < 0)
            {
                MessageBox.Show("Please insert an appropriate value for Points");
            }
            else
            {
                string Mobile, Points;
                if (textBox2.Text == "") Mobile = "NULL";
                else Mobile = textBox2.Text;
                if (textBox3.Text == "") Points = "NULL";
                else Points = textBox3.Text;
                int r = controllerObj.InsertCustomer(textBox1.Text, Mobile, Points);
                if (r > 0)
                    MessageBox.Show("Customer inserted successfully");
                else
                    MessageBox.Show("Error inserting customer");
            }
        }
    }
}
