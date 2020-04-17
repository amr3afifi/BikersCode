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
    public partial class UpdateSupplier : Form
    {
        Controller controllerObj;
        public UpdateSupplier()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") //validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                string date;
                double oldquota= controllerObj.GetQuota(textBox1.Text);
                double filledquota= controllerObj.GetQuotaFilled(textBox1.Text);
                if (checkBox1.Checked) date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                else date = "";
                int r = controllerObj.UpdateSupplier(textBox1.Text, date, textBox2.Text);
                if (r > 0)
                {
                    MessageBox.Show("Supplier updated successfully");
                    controllerObj.UpdateSupplierQuotaFilled(textBox1.Text,Convert.ToDouble( textBox2.Text), filledquota, oldquota);
                    textBox1.Text = "";
                    textBox2.Text = "";

                }
                else
                    MessageBox.Show("Error updating supplier");
            }
        }
    }
}
