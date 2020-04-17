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
    public partial class updatemotor : Form
    {
        Controller controllerObj = new Controller();
        string pid;
        public updatemotor(string i)
        {
            InitializeComponent();
            pid = i;
            DataTable dt;
            dt = controllerObj.SelectSupplier();
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "name";
            comboBox2.Text = controllerObj.getsupname(pid).ToString();
            pricetextbox.Text = controllerObj.getprice(pid).ToString();
            typetextBox.Text = controllerObj.gettypem(pid).ToString();
            textBox1.Text = controllerObj.getmodel(pid).ToString();
            yeartextBox.Text = controllerObj.getyear(pid).ToString();
            cctextBox.Text = controllerObj.getcc(pid).ToString();
            colortextBox.Text = controllerObj.getcolor(pid).ToString();
        }

        private void updatemotor_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
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

        private void typetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void yeartextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(yeartextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                yeartextBox.Text = yeartextBox.Text.Remove(yeartextBox.Text.Length - 1);
                yeartextBox.Text = String.Empty;
            }
        }

        private void cctextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(cctextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                cctextBox.Text = cctextBox.Text.Remove(cctextBox.Text.Length - 1);
                cctextBox.Text = String.Empty;
            }
        }

        private void colortextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            controllerObj.Updatepro(pid, comboBox2.Text, pricetextbox.Text);
            int result = controllerObj.updatemotofunc(pid, textBox1.Text, typetextBox.Text,yeartextBox.Text, cctextBox.Text, colortextBox.Text);
          
            if (result <= 0)
                MessageBox.Show("Motorcycle update failed");

            else
                MessageBox.Show("Motorcycle updated successfuly");
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
    }
}
