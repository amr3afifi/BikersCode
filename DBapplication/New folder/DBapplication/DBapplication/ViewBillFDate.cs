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
    public partial class ViewBillFDate : Form
    {
        Controller controllerObj;
        User U;
        public ViewBillFDate(User user)
        {
            controllerObj = new Controller();
            U = user;
            InitializeComponent();
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
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            if (U.Priv == Privileges.Admin)
            {
                DataTable dt = controllerObj.SelectBillByDate(date);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            else
            {
                DataTable dt = controllerObj.SelectBillByDateAndBranch(date,U.BranchName);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
        }

        private void ViewBillFDate_Load(object sender, EventArgs e)
        {

        }
    }
}
