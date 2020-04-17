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
    public partial class ViewShipmentsBySuppliers : Form
    {
        Controller controllerObj = new Controller();
        User U;
        public ViewShipmentsBySuppliers(User user)
        {
            InitializeComponent();
            U = user;
            comboBox2.DataSource = controllerObj.SelectSupplier();
            comboBox2.DisplayMember = "Name";
        }

        private void ViewShipmentsBySuppliers_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (U.Priv == Privileges.Admin)
            {
                comboBox1.DataSource = controllerObj.GetShipmentIDbySupplier(comboBox2.Text);
            }
            else
            {
                comboBox1.DataSource = controllerObj.GetShipmentIDbySupplierAndBranch(comboBox2.Text,U.BranchName);
            }
            comboBox1.DisplayMember = "shipment_id";

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

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
