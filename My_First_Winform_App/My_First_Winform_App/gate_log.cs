using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_First_Winform_App
{
    public partial class gate_log : Form
    {
        public gate_log()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Laptop = this.Laptop.Checked ? "Yes" : "No";

            if(String.IsNullOrEmpty(this.FirstName_tb.Text) || String.IsNullOrEmpty(this.LicencePlate_tb.Text))
            {
                MessageBox.Show("Please complete all relevant fields.");
            }
            else
            {

                //MessageBox.Show("Entry Submitted");
                MessageBox.Show($"Name: {this.FirstName_tb.Text} {this.MiddleInitial_tb.Text} " +
                    $"{this.LastName_tb.Text}\n Licence Plate: {this.LicencePlate_tb.Text}\n Time: {this.TimeIn.Text} " +
                    $"{this.TimeOut.Text}\n Laptop: {Laptop}");

            }



        }

        private void Clear_Form_Click(object sender, EventArgs e)
        {
            this.FirstName_tb.Text = "";
            this.MiddleInitial_tb.Text = "";
            this.Laptop.Text = "";
            this.TimeIn.Text = "";
            this.TimeOut.Text = "";
            this.LicencePlate_tb.Text = "";
            this.radioButton1.Checked = false;
            this.radioButton2.Checked = false;
            this.radioButton3.Checked = false;
            this.radioButton4.Checked = false;
            this.Laptop.Checked = false;
            //this.Clear_Form.Text = "";

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
          /*  Reset_Password reset_Password = new Reset_Password();
            reset_Password.Show();
            this.Hide();*/

        }
    }
}
