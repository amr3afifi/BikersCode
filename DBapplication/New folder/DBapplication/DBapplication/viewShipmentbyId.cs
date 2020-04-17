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
    public partial class viewShipmentbyId : Form
    {
        Controller controllerObj = new Controller();
        User U;
        public viewShipmentbyId(User user,string s="")
        {
            InitializeComponent();
            if (s == "")
            {
                if (U.Priv == Privileges.Admin)
                {
                    comboBox2.DataSource = controllerObj.GetShipmentIdView();
                }
                else
                {
                    comboBox2.DataSource = controllerObj.GetShipmentIdViewByBranch(U.BranchName);
                }
                comboBox2.DisplayMember = "ID";
               
            }
            else 
            { 
                textBox2.Text = s;
                comboBox2.Enabled = false;
            }
        }

        private void viewShipmentbyId_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                dataGridView1.DataSource = controllerObj.GetShipemntItems(Convert.ToInt32(comboBox2.Text));
                dataGridView1.Refresh();

                dataGridView5.DataSource = controllerObj.GetShipmentDetails(Convert.ToInt32(comboBox2.Text));
                dataGridView5.Refresh();


            }
            else
            {
                dataGridView1.DataSource = controllerObj.GetShipemntItems(Convert.ToInt32(textBox2.Text));
                dataGridView1.Refresh();

                dataGridView5.DataSource = controllerObj.GetShipmentDetails(Convert.ToInt32(textBox2.Text));
                dataGridView5.Refresh();
               
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
