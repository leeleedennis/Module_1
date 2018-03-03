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
    public partial class All_Users : Form
    {
        Gate_LogEntities ctx = new Gate_LogEntities();


        public All_Users()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void All_Users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gate_LogDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.gate_LogDataSet.Users);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.usersTableAdapter.FillBy(this.gate_LogDataSet.Users);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            var user = new User();
            ctx.Users.Add(user);
        }

        private void edit_button_Click(object sender, EventArgs e)
        {

        }

        private void remove_button_Click(object sender, EventArgs e)
        {

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {

        }
    }
}
