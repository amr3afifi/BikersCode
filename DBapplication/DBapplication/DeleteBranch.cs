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
    public partial class DeleteBranch : Form
    {
        Controller controllerObj = new Controller();

        public DeleteBranch()
        {
            InitializeComponent();
            DataTable dt = controllerObj.SelectBranches();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "name";
        }

        private void DeleteBranch_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int t = controllerObj.DeleteBranch(comboBox1.Text);

            if (t >= 1) { MessageBox.Show("Branch Deleted"); }
            else { MessageBox.Show("Failed, Branch doesnt exist"); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
