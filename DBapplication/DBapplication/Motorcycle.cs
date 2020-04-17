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
    public partial class Motorcycle : Form
    {
        Controller controllerObj = new Controller();

        public Motorcycle()
        {
            InitializeComponent();
        }

        private void Motorcycle_Load(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            string t = typetextBox.Text;
            string m = textBox1.Text;
            string y = yeartextBox.Text;
            string cc = cctextBox.Text;
            string c = colortextBox.Text;

            int r, r2;
            if (!Int32.TryParse(y, out  r) || !Int32.TryParse(cc, out  r2))
            {
                MessageBox.Show("please enter a proper values");
                return;
            }


                int year = Convert.ToInt32(y);
                int CC = Convert.ToInt32(cc);


                int result = controllerObj.Insertmotor(m,t, year, CC, c);
                if (result <= 0)
                    MessageBox.Show("Motorcycle additon failed");

                else
                    MessageBox.Show("Motorcycle added successfuly");



            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

