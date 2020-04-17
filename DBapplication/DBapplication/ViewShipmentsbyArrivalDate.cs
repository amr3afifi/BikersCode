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
    public partial class ViewShipmentsbyArrivalDate : Form
    {
        Controller controllerObj = new Controller();
        User U;
        public ViewShipmentsbyArrivalDate(User user)
        {
            InitializeComponent();
            U = user;
        }

        private void ViewShipmentsbyArrivalDate_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int r;
            if (radioButton1.Checked == true)
            { r = 0; }
            else if (radioButton2.Checked == true)
            { r = 1; }
            else if (radioButton3.Checked == true)
            { r = 2; }
            else return;

            DateTime date = Convert.ToDateTime(dateTimePicker1.Value);
            if (U.Priv == Privileges.Admin)
            {
                DataTable dt = controllerObj.GetShipmentByArrivalDate(date, r);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "ID";
            }
            else
            {
                DataTable dt = controllerObj.GetShipmentByArrivalDateAndBranch(date, r,U.BranchName);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "ID";
            }
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
