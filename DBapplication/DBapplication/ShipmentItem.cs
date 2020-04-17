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
    public partial class ShipmentItem : Form
    {
        Controller controllerObj = new Controller();
       
        int id;

        public ShipmentItem(int i)
        {
            InitializeComponent();
            id = i;
           
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            AddProduct AP = new AddProduct();
            AP.FormClosed += new FormClosedEventHandler(AP_FormClosed);
            AP.Show();
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
            if (numericUpDown1.Value > 0 && !string.IsNullOrWhiteSpace(comboBox1.Text) && !string.IsNullOrWhiteSpace(comboBox2.Text))
            {

                int result = controllerObj.AddItemToShipment(id,Convert.ToInt32(comboBox2.Text),Convert.ToInt32(numericUpDown1.Value));
                if (result <= 0)
                    MessageBox.Show("Item additon failed,Item may already exist");

                else
                {
                    MessageBox.Show("Item added to order");
                    double Price = Convert.ToDouble (controllerObj.GetProductPrice(comboBox2.Text));
                    Price *= Convert.ToInt32(numericUpDown1.Value);
                    controllerObj.UpdateShipmentPrice(Price.ToString(), id.ToString());
                }

            }
            else
            {
                MessageBox.Show("Enter Correct values for quantity");
                return; }
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
