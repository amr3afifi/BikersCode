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
    public partial class AddBranch : Form
    {
        Controller controllerObj = new Controller();
        public AddBranch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int t=controllerObj.AddBranch(textBox1.Text, textBox2.Text);

            if (t >= 1) 
            { 
                MessageBox.Show("Branch added");
                DataTable dt = controllerObj.GetAllProductID();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string pid = dt.Rows[i][0].ToString();
                    controllerObj.InsertProductinBranchHas(pid, textBox1.Text);
                    controllerObj.InsertProductinBranchSold(pid, textBox1.Text);
                }
            }
            else { MessageBox.Show("Failed, maybe branch_name exists or missing data to fill"); }
        }

        private void AddBranch_Load(object sender, EventArgs e)
        {

        }
    }
}
