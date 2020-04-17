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
    public partial class InsertSupplier : Form
    {
        Controller controllerObj;
        public InsertSupplier()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ""|| textBox2.Text == "") //validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else if(dateTimePicker1.Value>=dateTimePicker2.Value)
            {
                MessageBox.Show("Please choose appropriate start and end_dates " +
                    "for supplier's contract");
            }
            else if(Convert.ToDouble(textBox2.Text)<0)
            {
                MessageBox.Show("Sorry, supplier's quota_filled must be greater than 0");
            }
            else
            {

                string sdate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string edate = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                int r = controllerObj.InsertSupplier(textBox1.Text, sdate, edate, textBox2.Text);
                if (r > 0)
                {
                    MessageBox.Show("Supplier inserted successfully");
                    textBox1.Text = "";
                    textBox2.Text = "";

                }
                else
                    MessageBox.Show("Error inserting supplier");
            }
        }
    }
}
