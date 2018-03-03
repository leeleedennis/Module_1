namespace My_First_Winform_App
{
    partial class Add_User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.password_tb = new System.Windows.Forms.TextBox();
            this.username_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.username_labe = new System.Windows.Forms.Label();
            this.psssword_label = new System.Windows.Forms.Label();
            this.addbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.confirm_pass_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // password_tb
            // 
            this.password_tb.Location = new System.Drawing.Point(193, 208);
            this.password_tb.Multiline = true;
            this.password_tb.Name = "password_tb";
            this.password_tb.PasswordChar = '*';
            this.password_tb.Size = new System.Drawing.Size(200, 27);
            this.password_tb.TabIndex = 3;
            this.password_tb.TextChanged += new System.EventHandler(this.password_tb_TextChanged);
            // 
            // username_tb
            // 
            this.username_tb.Location = new System.Drawing.Point(194, 153);
            this.username_tb.Multiline = true;
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(199, 27);
            this.username_tb.TabIndex = 2;
            this.username_tb.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add User";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // username_labe
            // 
            this.username_labe.AutoSize = true;
            this.username_labe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_labe.Location = new System.Drawing.Point(22, 160);
            this.username_labe.Name = "username_labe";
            this.username_labe.Size = new System.Drawing.Size(83, 20);
            this.username_labe.TabIndex = 0;
            this.username_labe.Text = "Username";
            // 
            // psssword_label
            // 
            this.psssword_label.AutoSize = true;
            this.psssword_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.psssword_label.Location = new System.Drawing.Point(21, 215);
            this.psssword_label.Name = "psssword_label";
            this.psssword_label.Size = new System.Drawing.Size(78, 20);
            this.psssword_label.TabIndex = 0;
            this.psssword_label.Text = "Password";
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addbutton.Location = new System.Drawing.Point(224, 325);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(75, 23);
            this.addbutton.TabIndex = 6;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(193, 252);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(200, 27);
            this.textBox1.TabIndex = 7;
            // 
            // confirm_pass_label
            // 
            this.confirm_pass_label.AutoSize = true;
            this.confirm_pass_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_pass_label.Location = new System.Drawing.Point(22, 259);
            this.confirm_pass_label.Name = "confirm_pass_label";
            this.confirm_pass_label.Size = new System.Drawing.Size(137, 20);
            this.confirm_pass_label.TabIndex = 8;
            this.confirm_pass_label.Text = "Confirm Password";
            this.confirm_pass_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // Add_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(486, 372);
            this.Controls.Add(this.confirm_pass_label);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.psssword_label);
            this.Controls.Add(this.username_labe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.username_tb);
            this.Controls.Add(this.password_tb);
            this.Name = "Add_User";
            this.Text = "Add_User";
            this.Load += new System.EventHandler(this.Add_User_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label username_labe;
        private System.Windows.Forms.Label psssword_label;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label confirm_pass_label;
    }
}