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
    public partial class Add_User : Form
    {
        public Add_User()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_User_Load(object sender, EventArgs e)
        {

        }

        private void password_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            var username_value = username_tb.Text;
            var password_value = password_tb.Text;
            var datecreated_value = DateTime.Now;
            var createdby_value = "Admin";

            if (String.IsNullOrEmpty(this.username_tb.Text) || String.IsNullOrEmpty(this.password_tb.Text))
            {
                MessageBox.Show("Please complete all relevant fields");
            }
            else
            {
                try
                {
                    //Create a new object of type 'user' which represent the database table.
                    var user = new User
                    {
                        Username = username_value,
                        Password = EasyEncryption.SHA.ComputeSHA256Hash(password_value),
                        Date_Created = datecreated_value,
                        Created_By = createdby_value

                    };
                    // ctx represnts the object of the ADO entity encompassing all the tables in the diagram.

                    Gate_LogEntities ctx = new Gate_LogEntities();

                    //add the new created object of type user, to the list of objects of type user and then save changes to comit the information to the database.

                    ctx.Users.Add(user);
                    ctx.SaveChanges();

                    //this will noitfy the user that the operation wsa successfull.
                }
                catch (Exception)
                {

                    throw;
                }
                MessageBox.Show("User Succesfully Added.");
            }
          
        }
    }
}
