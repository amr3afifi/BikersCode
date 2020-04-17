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
    public partial class Edit_Shipment : Form
    {
        Controller controllerObj = new Controller();
        User U;
        public Edit_Shipment(User user)
        {
            InitializeComponent();
            U = user;
            if (U.Priv == Privileges.Admin)
            {
                DataTable dt = controllerObj.SelectShipmentsUpdate();
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "ID";
                comboBox1.ValueMember = "ID";
            }
            else
            {
                DataTable dt = controllerObj.SelectShipmentsUpdateByBranch(U.BranchName);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "ID";
                comboBox1.ValueMember = "ID";
            }
   
            
        }

        private void Edit_Shipment_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int r = Convert.ToInt32(comboBox1.SelectedValue);

            comboBox2.DataSource=controllerObj.GetShipmentItems(r);
            comboBox2.DisplayMember = "product_id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = Convert.ToInt32(comboBox1.SelectedValue);
            int r2 = Convert.ToInt32(comboBox2.Text);

            if (numericUpDown1.Value > 0)
            {
                int t=controllerObj.UpdateShipmentItems(r, r2,Convert.ToInt32( numericUpDown1.Value));

                if(t>=1){MessageBox.Show("Item Quantity Updated");}
            }

      else
            {
                int t = controllerObj.DeleteShipmentItems(r, r2);
                if (t >= 1) { MessageBox.Show("Item Removed"); }
            }
        }
    }
}
