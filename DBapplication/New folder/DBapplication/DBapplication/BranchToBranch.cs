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
    public partial class BranchtoBranch : Form
    {
        Controller controllerObj = new Controller();
       
        

        public BranchtoBranch()
        {
            InitializeComponent();
            
            DataTable dt1 = controllerObj.SelectBranches();
            comboBox3.DataSource = dt1;
            comboBox3.DisplayMember = "Name";
            comboBox3.ValueMember = "Name";

            DataTable dt2 = controllerObj.SelectBranches();
            comboBox4.DataSource = dt2;
            comboBox4.DisplayMember = "Name";
            comboBox4.ValueMember = "Name";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void ShipmentItem_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        

        void AP_FormClosed(object sender, FormClosedEventArgs e)
        {
            string t = comboBox1.Text;

            if (t != null)
            {
                DataTable dt = controllerObj.GetItemIDbyType(t);
                comboBox2.DataSource = dt;

                if (t == "MotorCycle")
                { comboBox2.DisplayMember = "motorcycle_id"; }
                else if (t == "SparePart")
                { comboBox2.DisplayMember = "spareparts_id"; }
                else
                { comboBox2.DisplayMember = "accessory_id"; }
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string t = comboBox1.Text;

            if (t != null)
            {
                DataTable dt = controllerObj.GetItemIDbyType(t);
                comboBox2.DataSource = dt;

                if (t == "MotorCycle") 
                { comboBox2.DisplayMember = "motorcycle_id"; }
                else if (t == "SparePart") 
                {comboBox2.DisplayMember="spareparts_id"; }
                else 
                { comboBox2.DisplayMember="accessory_id" ; }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string t = comboBox1.Text;
            string n = textBox2.Text;

            if (t != null)
            {
                DataTable dt = controllerObj.GetItemDetailByName(n,t);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int r = controllerObj.UpdateQuantityHasinBranch((numericUpDown1.Value.ToString()), comboBox2.Text, comboBox3.Text);
            int q = controllerObj.UpdateQuantityHasinBranchplus((numericUpDown1.Value.ToString()), comboBox2.Text, comboBox4.Text);

            if (r*q <= 0)
                MessageBox.Show("Transfer failed");

            else
                MessageBox.Show("Transfer successful");
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
