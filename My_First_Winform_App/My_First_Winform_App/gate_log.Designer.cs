namespace My_First_Winform_App
{
    partial class gate_log
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
            this.FirstName_tb = new System.Windows.Forms.TextBox();
            this.LastName_tb = new System.Windows.Forms.TextBox();
            this.LicencePlate_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TimeIn = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.TimeOut = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.MiddleInitial_tb = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogButton = new System.Windows.Forms.Button();
            this.Laptop = new System.Windows.Forms.CheckBox();
            this.Clear_Form = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstName_tb
            // 
            this.FirstName_tb.BackColor = System.Drawing.Color.Silver;
            this.FirstName_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstName_tb.Location = new System.Drawing.Point(25, 218);
            this.FirstName_tb.Multiline = true;
            this.FirstName_tb.Name = "FirstName_tb";
            this.FirstName_tb.Size = new System.Drawing.Size(175, 24);
            this.FirstName_tb.TabIndex = 1;
            // 
            // LastName_tb
            // 
            this.LastName_tb.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.LastName_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastName_tb.Location = new System.Drawing.Point(645, 218);
            this.LastName_tb.Multiline = true;
            this.LastName_tb.Name = "LastName_tb";
            this.LastName_tb.Size = new System.Drawing.Size(163, 25);
            this.LastName_tb.TabIndex = 3;
            this.LastName_tb.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // LicencePlate_tb
            // 
            this.LicencePlate_tb.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.LicencePlate_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LicencePlate_tb.Location = new System.Drawing.Point(25, 301);
            this.LicencePlate_tb.Multiline = true;
            this.LicencePlate_tb.Name = "LicencePlate_tb";
            this.LicencePlate_tb.Size = new System.Drawing.Size(176, 28);
            this.LicencePlate_tb.TabIndex = 4;
            this.LicencePlate_tb.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(641, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Licence Plate Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Time In";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(384, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Time Out";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(238, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(398, 42);
            this.label6.TabIndex = 11;
            this.label6.Text = "VTDI Gate Access Log";
            // 
            // TimeIn
            // 
            this.TimeIn.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeIn.Location = new System.Drawing.Point(24, 399);
            this.TimeIn.Name = "TimeIn";
            this.TimeIn.Size = new System.Drawing.Size(200, 20);
            this.TimeIn.TabIndex = 5;
            this.TimeIn.Value = new System.DateTime(2018, 2, 10, 15, 40, 33, 0);
            this.TimeIn.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 515);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Category";
            // 
            // TimeOut
            // 
            this.TimeOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeOut.Location = new System.Drawing.Point(388, 399);
            this.TimeOut.Name = "TimeOut";
            this.TimeOut.Size = new System.Drawing.Size(200, 20);
            this.TimeOut.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(365, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Middle Initial";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // MiddleInitial_tb
            // 
            this.MiddleInitial_tb.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MiddleInitial_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MiddleInitial_tb.Location = new System.Drawing.Point(369, 218);
            this.MiddleInitial_tb.Multiline = true;
            this.MiddleInitial_tb.Name = "MiddleInitial_tb";
            this.MiddleInitial_tb.Size = new System.Drawing.Size(156, 24);
            this.MiddleInitial_tb.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::My_First_Winform_App.Properties.Resources.HEART_Logo_Vector;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::My_First_Winform_App.Properties.Resources.HEART_Logo_Vector;
            this.pictureBox1.Location = new System.Drawing.Point(12, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // LogButton
            // 
            this.LogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogButton.Location = new System.Drawing.Point(274, 679);
            this.LogButton.Name = "LogButton";
            this.LogButton.Size = new System.Drawing.Size(113, 34);
            this.LogButton.TabIndex = 9;
            this.LogButton.Text = "Log";
            this.LogButton.UseVisualStyleBackColor = true;
            this.LogButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Laptop
            // 
            this.Laptop.AutoSize = true;
            this.Laptop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Laptop.Location = new System.Drawing.Point(28, 462);
            this.Laptop.Name = "Laptop";
            this.Laptop.Size = new System.Drawing.Size(78, 24);
            this.Laptop.TabIndex = 7;
            this.Laptop.Text = "Laptop";
            this.Laptop.UseVisualStyleBackColor = true;
            // 
            // Clear_Form
            // 
            this.Clear_Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_Form.Location = new System.Drawing.Point(529, 679);
            this.Clear_Form.Name = "Clear_Form";
            this.Clear_Form.Size = new System.Drawing.Size(107, 34);
            this.Clear_Form.TabIndex = 26;
            this.Clear_Form.Text = "Clear Form";
            this.Clear_Form.UseVisualStyleBackColor = true;
            this.Clear_Form.Click += new System.EventHandler(this.Clear_Form_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(30, 538);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Student";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(28, 561);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(64, 17);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Lecturer";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(28, 584);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(47, 17);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Staff";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(28, 607);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(53, 17);
            this.radioButton4.TabIndex = 11;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Visitor";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // gate_log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(899, 749);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Clear_Form);
            this.Controls.Add(this.Laptop);
            this.Controls.Add(this.LogButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MiddleInitial_tb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TimeOut);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TimeIn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LicencePlate_tb);
            this.Controls.Add(this.LastName_tb);
            this.Controls.Add(this.FirstName_tb);
            this.DoubleBuffered = true;
            this.Name = "gate_log";
            this.Text = "VTDI Gate Access Log";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox FirstName_tb;
        private System.Windows.Forms.TextBox LastName_tb;
        private System.Windows.Forms.TextBox LicencePlate_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker TimeIn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker TimeOut;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox MiddleInitial_tb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LogButton;
        private System.Windows.Forms.CheckBox Laptop;
        private System.Windows.Forms.Button Clear_Form;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}

