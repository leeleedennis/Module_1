namespace My_First_Winform_App
{
    partial class Login_Control
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
            this.title_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.username_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.hint_label = new System.Windows.Forms.Label();
            this.forget_label = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.Location = new System.Drawing.Point(159, 34);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(130, 24);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "Leelee\'s Secret";
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.Location = new System.Drawing.Point(66, 94);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(83, 20);
            this.username_label.TabIndex = 0;
            this.username_label.Text = "Username";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(66, 150);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(78, 20);
            this.password_label.TabIndex = 2;
            this.password_label.Text = "Password";
            // 
            // username_tb
            // 
            this.username_tb.Location = new System.Drawing.Point(163, 88);
            this.username_tb.Multiline = true;
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(179, 26);
            this.username_tb.TabIndex = 1;
            // 
            // password_tb
            // 
            this.password_tb.Location = new System.Drawing.Point(163, 143);
            this.password_tb.Multiline = true;
            this.password_tb.Name = "password_tb";
            this.password_tb.PasswordChar = '*';
            this.password_tb.Size = new System.Drawing.Size(179, 27);
            this.password_tb.TabIndex = 2;
            // 
            // hint_label
            // 
            this.hint_label.AutoSize = true;
            this.hint_label.Location = new System.Drawing.Point(267, 173);
            this.hint_label.Name = "hint_label";
            this.hint_label.Size = new System.Drawing.Size(75, 13);
            this.hint_label.TabIndex = 4;
            this.hint_label.Text = "Password Hint";
            // 
            // forget_label
            // 
            this.forget_label.AutoSize = true;
            this.forget_label.Location = new System.Drawing.Point(160, 173);
            this.forget_label.Name = "forget_label";
            this.forget_label.Size = new System.Drawing.Size(92, 13);
            this.forget_label.TabIndex = 5;
            this.forget_label.Text = "Forget Password?";
            this.forget_label.Click += new System.EventHandler(this.forget_label_Click);
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(136, 216);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 23);
            this.login_button.TabIndex = 3;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(270, 216);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 6;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // Login_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(445, 303);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.forget_label);
            this.Controls.Add(this.hint_label);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.username_tb);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.title_label);
            this.Name = "Login_Control";
            this.Text = "Login_Control";
            this.Load += new System.EventHandler(this.Login_Control_Load);
            this.Click += new System.EventHandler(this.Login_Control_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Label hint_label;
        private System.Windows.Forms.Label forget_label;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button cancel_button;
    }
}