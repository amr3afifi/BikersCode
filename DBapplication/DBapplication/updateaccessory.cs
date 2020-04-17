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
    public partial class updateaccessory : Form
    {
        Controller controllerObj = new Controller();
        string pid;
        public updateaccessory(string i)
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
            typetextBox.Text = controllerObj.gettypea(pid).ToString();
            comboBox1.Text = controllerObj.getsize(pid).ToString();
        }

        private void typetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addbutton2_Click(object sender, EventArgs e)
        {
            controllerObj.Updatepro(pid, comboBox2.Text, pricetextbox.Text);
            int result = controllerObj.updateaccfunc(pid, typetextBox.Text, comboBox1.Text);

            if (result <= 0)
                MessageBox.Show("Accessory update failed");

            else
                MessageBox.Show("Accessory updated successfuly");
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

        private void pricetextbox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(pricetextbox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                pricetextbox.Text = pricetextbox.Text.Remove(pricetextbox.Text.Length - 1);
                pricetextbox.Text = String.Empty;
            }
        }
    }
}
