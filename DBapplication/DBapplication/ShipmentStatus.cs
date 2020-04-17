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
    public partial class ShipmentStatus : Form
    {
        Controller controllerObj = new Controller();
        User U;

        public ShipmentStatus(User user)
        {
            InitializeComponent();
            U = user;
            if (U.Priv == Privileges.Admin)
            {
                DataTable dt = controllerObj.SelectShipmentsNotArrived();
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "ID";
                comboBox1.ValueMember = "ID";
            }
            else
            {
                DataTable dt = controllerObj.SelectShipmentsNotArrivedByBranch(U.BranchName);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "ID";
                comboBox1.ValueMember = "ID";
            }

            comboBox2.DataSource = new string[] {"Pending Confirmation","Awaiting Payment","Supplier Packing","At Supplier Port","On Route","At Home Port","Arrived" };

        }

        private void ShipmentStatus_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Status Updated");

            controllerObj.UpdateShipStatus(Convert.ToInt32(comboBox1.Text),comboBox2.Text);

            if (comboBox2.Text == "Arrived")
            {
                DateTime today = DateTime.Today;
                string newdate = today.ToString("yyyy-MM-dd");
                controllerObj.UpdateShipmentArrivalDate(newdate, comboBox1.Text);
                int r=controllerObj.UpdateProductTotalStockFromShipment(comboBox1.Text);
                if (r >= 0) { MessageBox.Show("Products' total_stock has been updated"); }
                r = controllerObj.ShipmentArrived(Convert.ToInt32(comboBox1.Text));
                if (r >= 0) { MessageBox.Show("Branch updated"); }
            }

            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
