namespace membersRecord
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addRecord = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateofbirth = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateofmembership = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.attendance = new System.Windows.Forms.RichTextBox();
            this.updateRecord = new System.Windows.Forms.Button();
            this.deleteRecord = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.address = new System.Windows.Forms.TextBox();
            this.sharecapital = new System.Windows.Forms.TextBox();
            this.fullname = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(380, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "|     DATA BANK - MEMBERSHIP";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::membersRecord.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(59, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(121, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "DALDESCO  Printing Service Cooperative";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(991, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "___";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Find:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(98, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 23);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(524, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 27);
            this.button1.TabIndex = 9;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Name",
            "Gender",
            "Age",
            "Date of Birth"});
            this.comboBox1.Location = new System.Drawing.Point(394, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(988, 232);
            this.dataGridView1.TabIndex = 11;
            // 
            // addRecord
            // 
            this.addRecord.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRecord.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRecord.Location = new System.Drawing.Point(601, 617);
            this.addRecord.Name = "addRecord";
            this.addRecord.Size = new System.Drawing.Size(107, 27);
            this.addRecord.TabIndex = 12;
            this.addRecord.Text = "Add Record";
            this.addRecord.UseVisualStyleBackColor = false;
            this.addRecord.Click += new System.EventHandler(this.addRecord_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(82, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Full Name:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(96, 431);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Gender:";
            // 
            // Gender
            // 
            this.Gender.AllowDrop = true;
            this.Gender.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Gender.Location = new System.Drawing.Point(152, 427);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(92, 24);
            this.Gender.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(114, 463);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Age:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(67, 506);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Date of Birth:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // dateofbirth
            // 
            this.dateofbirth.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateofbirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateofbirth.Location = new System.Drawing.Point(152, 502);
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.Size = new System.Drawing.Size(92, 23);
            this.dateofbirth.TabIndex = 20;
            this.dateofbirth.Value = new System.DateTime(2024, 2, 12, 14, 24, 27, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(463, 394);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Address:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(395, 430);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "Date of membership:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // dateofmembership
            // 
            this.dateofmembership.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateofmembership.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateofmembership.Location = new System.Drawing.Point(524, 428);
            this.dateofmembership.Name = "dateofmembership";
            this.dateofmembership.Size = new System.Drawing.Size(92, 23);
            this.dateofmembership.TabIndex = 25;
            this.dateofmembership.Value = new System.DateTime(2024, 2, 12, 14, 24, 27, 0);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(434, 465);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "Share Capital:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(444, 502);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 16);
            this.label13.TabIndex = 29;
            this.label13.Text = "Attendance:";
            // 
            // attendance
            // 
            this.attendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendance.Location = new System.Drawing.Point(524, 501);
            this.attendance.Name = "attendance";
            this.attendance.Size = new System.Drawing.Size(523, 96);
            this.attendance.TabIndex = 30;
            this.attendance.Text = "";
            // 
            // updateRecord
            // 
            this.updateRecord.BackColor = System.Drawing.SystemColors.ControlLight;
            this.updateRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateRecord.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateRecord.Location = new System.Drawing.Point(714, 617);
            this.updateRecord.Name = "updateRecord";
            this.updateRecord.Size = new System.Drawing.Size(107, 27);
            this.updateRecord.TabIndex = 31;
            this.updateRecord.Text = "Update Record";
            this.updateRecord.UseVisualStyleBackColor = false;
            // 
            // deleteRecord
            // 
            this.deleteRecord.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deleteRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteRecord.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRecord.Location = new System.Drawing.Point(827, 617);
            this.deleteRecord.Name = "deleteRecord";
            this.deleteRecord.Size = new System.Drawing.Size(107, 27);
            this.deleteRecord.TabIndex = 32;
            this.deleteRecord.Text = "Delete Record";
            this.deleteRecord.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(59, 616);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 27);
            this.button5.TabIndex = 33;
            this.button5.Text = "Back to Menu";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // address
            // 
            this.address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(524, 391);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(523, 23);
            this.address.TabIndex = 34;
            // 
            // sharecapital
            // 
            this.sharecapital.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sharecapital.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sharecapital.Location = new System.Drawing.Point(524, 463);
            this.sharecapital.Name = "sharecapital";
            this.sharecapital.Size = new System.Drawing.Size(92, 23);
            this.sharecapital.TabIndex = 35;
            // 
            // fullname
            // 
            this.fullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullname.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullname.Location = new System.Drawing.Point(152, 390);
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(215, 23);
            this.fullname.TabIndex = 36;
            // 
            // Age
            // 
            this.Age.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Age.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age.Location = new System.Drawing.Point(152, 461);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(92, 23);
            this.Age.TabIndex = 37;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(940, 617);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(107, 27);
            this.clear.TabIndex = 38;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1116, 655);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.fullname);
            this.Controls.Add(this.sharecapital);
            this.Controls.Add(this.address);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.deleteRecord);
            this.Controls.Add(this.updateRecord);
            this.Controls.Add(this.attendance);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateofmembership);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateofbirth);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addRecord);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
           
           
            this.Text = "DALDESCO";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addRecord;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateofbirth;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateofmembership;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox attendance;
        private System.Windows.Forms.Button updateRecord;
        private System.Windows.Forms.Button deleteRecord;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox sharecapital;
        private System.Windows.Forms.TextBox fullname;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.Button clear;
    }
}

