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
    public partial class Administrator : Form
    {
        private int status;

        public void SetStatus(int status)
        {
            this.status = status;
        }

        public int GetStatus()
        {
            return status;
        }
        private int childFormNumber = 0;

        public Administrator()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void windowsMenu_Click(object sender, EventArgs e)
        {

        }

        private void gateLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(GetStatus() == 1)
            {
                gate_log form1 = new gate_log();
                form1.MdiParent = this;
                form1.Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("Please login to use this option");
            }

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login_Control login_Control = new Login_Control();
            login_Control.MdiParent = this;
            login_Control.Show();
            SetStatus(1);
            
        }

        private void resetPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset_Password reset_Password = new Reset_Password();
            reset_Password.MdiParent = this;
            reset_Password.Show();
           // this.Hide();
        }

        private void Administrator_Load(object sender, EventArgs e)
        {

        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_User add_User = new Add_User();
            add_User.MdiParent = this;
            add_User.Show();

        }

        private void viewAllUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            All_Users all_User = new All_Users();
            all_User.MdiParent = this;
            all_User.Show();
        }
    }
}
