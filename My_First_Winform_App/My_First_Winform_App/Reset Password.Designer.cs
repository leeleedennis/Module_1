namespace My_First_Winform_App
{
    partial class Reset_Password
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
            this.Old_pass_label = new System.Windows.Forms.Label();
            this.old_password = new System.Windows.Forms.TextBox();
            this.new_pass_label = new System.Windows.Forms.Label();
            this.confirm_pass_label = new System.Windows.Forms.Label();
            this.new_password = new System.Windows.Forms.TextBox();
            this.confirm_password = new System.Windows.Forms.TextBox();
            this.update_button = new System.Windows.Forms.Button();
            this.forget_password_title = new System.Windows.Forms.Label();
            this.cancel_forget_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Old_pass_label
            // 
            this.Old_pass_label.AutoSize = true;
            this.Old_pass_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Old_pass_label.Location = new System.Drawing.Point(23, 57);
            this.Old_pass_label.Name = "Old_pass_label";
            this.Old_pass_label.Size = new System.Drawing.Size(95, 17);
            this.Old_pass_label.TabIndex = 0;
            this.Old_pass_label.Text = "Old Password";
            // 
            // old_password
            // 
            this.old_password.Location = new System.Drawing.Point(162, 57);
            this.old_password.Name = "old_password";
            this.old_password.PasswordChar = '*';
            this.old_password.Size = new System.Drawing.Size(128, 20);
            this.old_password.TabIndex = 1;
            // 
            // new_pass_label
            // 
            this.new_pass_label.AutoSize = true;
            this.new_pass_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_pass_label.Location = new System.Drawing.Point(23, 102);
            this.new_pass_label.Name = "new_pass_label";
            this.new_pass_label.Size = new System.Drawing.Size(100, 17);
            this.new_pass_label.TabIndex = 2;
            this.new_pass_label.Text = "New Password";
            // 
            // confirm_pass_label
            // 
            this.confirm_pass_label.AutoSize = true;
            this.confirm_pass_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_pass_label.Location = new System.Drawing.Point(23, 146);
            this.confirm_pass_label.Name = "confirm_pass_label";
            this.confirm_pass_label.Size = new System.Drawing.Size(121, 17);
            this.confirm_pass_label.TabIndex = 3;
            this.confirm_pass_label.Text = "Confirm Password";
            // 
            // new_password
            // 
            this.new_password.Location = new System.Drawing.Point(162, 102);
            this.new_password.Name = "new_password";
            this.new_password.PasswordChar = '*';
            this.new_password.Size = new System.Drawing.Size(128, 20);
            this.new_password.TabIndex = 2;
            // 
            // confirm_password
            // 
            this.confirm_password.Location = new System.Drawing.Point(162, 146);
            this.confirm_password.Name = "confirm_password";
            this.confirm_password.PasswordChar = '*';
            this.confirm_password.Size = new System.Drawing.Size(128, 20);
            this.confirm_password.TabIndex = 3;
            //this.confirm_password.TextChanged += new System.EventHandler(this.confirm_password_TextChanged);
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.update_button.Location = new System.Drawing.Point(106, 225);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(78, 23);
            this.update_button.TabIndex = 4;
            this.update_button.Text = "Udate";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // forget_password_title
            // 
            this.forget_password_title.AutoSize = true;
            this.forget_password_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forget_password_title.Location = new System.Drawing.Point(119, 9);
            this.forget_password_title.Name = "forget_password_title";
            this.forget_password_title.Size = new System.Drawing.Size(129, 20);
            this.forget_password_title.TabIndex = 5;
            this.forget_password_title.Text = "Forget Password";
            // 
            // cancel_forget_button
            // 
            this.cancel_forget_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cancel_forget_button.Location = new System.Drawing.Point(215, 225);
            this.cancel_forget_button.Name = "cancel_forget_button";
            this.cancel_forget_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_forget_button.TabIndex = 5;
            this.cancel_forget_button.Text = "Cancel";
            this.cancel_forget_button.UseVisualStyleBackColor = false;
            this.cancel_forget_button.Click += new System.EventHandler(this.cancel_forget_button_Click);
            // 
            // Reset_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(388, 309);
            this.Controls.Add(this.cancel_forget_button);
            this.Controls.Add(this.forget_password_title);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.confirm_password);
            this.Controls.Add(this.new_password);
            this.Controls.Add(this.confirm_pass_label);
            this.Controls.Add(this.new_pass_label);
            this.Controls.Add(this.old_password);
            this.Controls.Add(this.Old_pass_label);
            this.Name = "Reset_Password";
            this.Text = "Reset_Password";
            this.Load += new System.EventHandler(this.Reset_Password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Old_pass_label;
        private System.Windows.Forms.TextBox old_password;
        private System.Windows.Forms.Label new_pass_label;
        private System.Windows.Forms.Label confirm_pass_label;
        private System.Windows.Forms.TextBox new_password;
        private System.Windows.Forms.TextBox confirm_password;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Label forget_password_title;
        private System.Windows.Forms.Button cancel_forget_button;
    }
}