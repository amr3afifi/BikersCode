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
    public partial class AddShipments : Form
    {
        Controller controllerObj = new Controller();
        User U;
        public AddShipments(User user)
        {
               InitializeComponent();
               U = user;
               if (U.Priv == Privileges.Admin)
               {
                   DataTable dt = controllerObj.SelectBranches();
                   comboBox2.DataSource = dt;
                   comboBox2.DisplayMember = "name";
                   comboBox2.ValueMember = "name";
               }
               else
               {
                   comboBox2.Text = U.BranchName;
               }
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int r=controllerObj.InsertShipment(dateTimePicker1.Value,dateTimePicker2.Value,comboBox2.Text);
            if (r <= 0)
            {
                MessageBox.Show("Shipment wasnt added");
                return;
            }

            else
                MessageBox.Show("Shipment added");

            int ID = controllerObj.GetShipmentId();

             new ShipmentItem(ID).Show();
             this.Close();
          
        }

        private void AddShipments_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
