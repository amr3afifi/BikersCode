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
    public partial class ViewShipmentByStatus : Form
    {
        Controller controllerObj = new Controller();
        User U;
        public ViewShipmentByStatus(User user)
        {
            InitializeComponent();
            U = user;
            comboBox2.DataSource = new string[] { "Pending Confirmation", "Awaiting Payment", "Supplier Packing", "At Supplier Port", "On Route", "At Home Port", "Arrived" };
        }

        private void ViewShipmentByStatus_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (U.Priv == Privileges.Admin)
            {
                comboBox1.DataSource = controllerObj.GetShipmentIDbyStatus(comboBox2.Text);
            }
            else
            {
                comboBox1.DataSource = controllerObj.GetShipmentIDbyStatusAndBranch(comboBox2.Text,U.BranchName);
            }
            comboBox1.DisplayMember = "ID";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                new viewShipmentbyId(U,comboBox1.Text).Show();
            }
        }
    }
}
