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
    public partial class ViewShipemntsByBranch : Form
    {
        Controller controllerObj = new Controller();
        User U;
        public ViewShipemntsByBranch(User user)
        {
            InitializeComponent();
            U = user;
            comboBox2.DataSource = controllerObj.SelectBranches();
            comboBox2.DisplayMember = "Name";
        }

        private void ViewShipemntsByBranch_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.DataSource = controllerObj.GetShipmentIDbyBranch(comboBox2.Text);
            comboBox1.DisplayMember = "ID";
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
