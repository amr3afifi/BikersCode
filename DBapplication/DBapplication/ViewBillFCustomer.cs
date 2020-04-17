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
    public partial class ViewBillFCustomer : Form
    {
        Controller controllerObj;
        User U;
        public ViewBillFCustomer(User user)
        {
            InitializeComponent();
            U = user;
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (U.Priv == Privileges.Admin)
            {
                DataTable dt = controllerObj.SelectAllBills();
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            else
            {
                DataTable dt = controllerObj.SelectAllBillsByBranch(U.BranchName);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (U.Priv == Privileges.Admin)
            {
                DataTable dt = controllerObj.SelectBillByCustomer(textBox1.Text);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            else
            {
                DataTable dt = controllerObj.SelectBillByCustomerAndBranch(textBox1.Text,U.BranchName);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
        }


        private void ViewBillFCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
