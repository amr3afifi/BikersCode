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
    public partial class ViewBillFPrices : Form
    {
        Controller controllerObj;
        User U;
        public ViewBillFPrices(User user)
        {
            InitializeComponent();
            U = user;
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (U.Priv == Privileges.Admin)
            {
                DataTable dt = controllerObj.SelectAllBillsXPrice();
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            else
            {
                DataTable dt = controllerObj.SelectAllBillsXPriceByBranch(U.BranchName);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                DataTable dt = controllerObj.SelectAllBillsXPriceByPriceAndBranch(textBox1.Text,'>',U.BranchName);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }

            else if(radioButton2.Checked)
            {
                DataTable dt = controllerObj.SelectAllBillsXPriceByPriceAndBranch(textBox1.Text, '<',U.BranchName);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
        }

        private void ViewBillFPrices_Load(object sender, EventArgs e)
        {

        }
    }
}
