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
  
    public partial class updatesparepart : Form
    {
        Controller controllerObj = new Controller();
        string pid;
        public updatesparepart(string i)
        {
            InitializeComponent();
        pid = i;
            DataTable dt; DataTable mt;
            dt = controllerObj.SelectSupplier();
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "name";

            mt = controllerObj.GetMotorCycleId();
            comboBox1.DataSource = mt;
            comboBox1.DisplayMember = "motorcycle_id";

            comboBox2.Text = controllerObj.getsupname(pid).ToString();
            pricetextbox.Text = controllerObj.getprice(pid).ToString();
            typetextBox.Text = controllerObj.gettypes(pid).ToString();
            textBox1.Text = controllerObj.getcondition(pid).ToString();
            comboBox1.Text = controllerObj.getbelmoto(pid).ToString();
            
          
        }

        private void typetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pricetextbox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(pricetextbox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                pricetextbox.Text = pricetextbox.Text.Remove(pricetextbox.Text.Length - 1);
                pricetextbox.Text = String.Empty;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            InsertSupplier iis = new InsertSupplier();
            iis.FormClosed += new FormClosedEventHandler(iis_FormClosed);
            iis.Show();
        }

        private void iis_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataTable dt;
            dt = controllerObj.SelectSupplier();
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "name";
        }

        private void addbutton2_Click(object sender, EventArgs e)
        {
            controllerObj.Updatepro(pid, comboBox2.Text, pricetextbox.Text);
            int result = controllerObj.updatespfunc(pid, typetextBox.Text, textBox1.Text, comboBox1.Text);

            if (result <= 0)
                MessageBox.Show("Sparepart update failed");

            else
                MessageBox.Show("Sparepart updated successfuly");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetMotorCycleByName(textBox2.Text);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
                textBox2.Text = String.Empty;
            }
        }
    }
}
