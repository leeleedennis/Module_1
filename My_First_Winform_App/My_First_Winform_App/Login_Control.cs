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
    public partial class Login_Control : Form
    {

        public Login_Control()
        {
            InitializeComponent();
        }

        private void Login_Control_Click(object sender, EventArgs e)
        {
          
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            var username = "gateadmin";
            var password = "password";

            if (username == username_tb.Text && password == password_tb.Text)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter valid information");

            }
        }

        private void forget_label_Click(object sender, EventArgs e)
        {
            Reset_Password reset_Password = new Reset_Password();
            reset_Password.Show();
            this.Hide();
           
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Control_Load(object sender, EventArgs e)
        {

        }
    }
}
