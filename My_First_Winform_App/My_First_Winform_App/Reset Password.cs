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
    public partial class Reset_Password : Form
    {
        public Reset_Password()
        {
            InitializeComponent();
        }

        private void Reset_Password_Load(object sender, EventArgs e)
        {

        }

        private void reset_button_Click(object sender, EventArgs e)
        {
           if(this.new_password.Text == this.confirm_password.Text && new_password.TextLength >= 8)
            {
                MessageBox.Show("Password change successful");
                this.Close();
            }
            else
            {
                MessageBox.Show("Password does not match");
                
            }

            
        }

        private void cancel_forget_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
