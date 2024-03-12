namespace employeeManagement
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
            this.age = new System.Windows.Forms.TextBox();
            this.fullname = new System.Windows.Forms.TextBox();
            this.sharecapital = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.deleteRecord = new System.Windows.Forms.Button();
            this.updateRecord = new System.Windows.Forms.Button();
            this.attendance = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateofmembership = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateofbirth = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addRecord = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label14 = new System.Windows.Forms.Label();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // age
            // 
            this.age.BackColor = System.Drawing.Color.White;
            this.age.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.age.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.ForeColor = System.Drawing.Color.Black;
            this.age.Location = new System.Drawing.Point(119, 418);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(92, 23);
            this.age.TabIndex = 68;
            // 
            // fullname
            // 
            this.fullname.BackColor = System.Drawing.Color.White;
            this.fullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullname.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullname.ForeColor = System.Drawing.Color.Black;
            this.fullname.Location = new System.Drawing.Point(119, 347);
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(215, 23);
            this.fullname.TabIndex = 67;
            // 
            // sharecapital
            // 
            this.sharecapital.BackColor = System.Drawing.Color.White;
            this.sharecapital.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sharecapital.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sharecapital.ForeColor = System.Drawing.Color.Black;
            this.sharecapital.Location = new System.Drawing.Point(491, 420);
            this.sharecapital.Name = "sharecapital";
            this.sharecapital.Size = new System.Drawing.Size(92, 23);
            this.sharecapital.TabIndex = 66;
            // 
            // address
            // 
            this.address.BackColor = System.Drawing.Color.White;
            this.address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.ForeColor = System.Drawing.Color.Black;
            this.address.Location = new System.Drawing.Point(491, 348);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(391, 23);
            this.address.TabIndex = 65;
            // 
            // deleteRecord
            // 
            this.deleteRecord.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deleteRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteRecord.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRecord.Location = new System.Drawing.Point(717, 563);
            this.deleteRecord.Name = "deleteRecord";
            this.deleteRecord.Size = new System.Drawing.Size(107, 27);
            this.deleteRecord.TabIndex = 63;
            this.deleteRecord.Text = "Delete Record";
            this.deleteRecord.UseVisualStyleBackColor = false;
            this.deleteRecord.Click += new System.EventHandler(this.deleteRecord_Click);
            // 
            // updateRecord
            // 
            this.updateRecord.BackColor = System.Drawing.SystemColors.ControlLight;
            this.updateRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateRecord.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateRecord.Location = new System.Drawing.Point(604, 563);
            this.updateRecord.Name = "updateRecord";
            this.updateRecord.Size = new System.Drawing.Size(107, 27);
            this.updateRecord.TabIndex = 62;
            this.updateRecord.Text = "Update Record";
            this.updateRecord.UseVisualStyleBackColor = false;
            this.updateRecord.Click += new System.EventHandler(this.updateRecord_Click);
            // 
            // attendance
            // 
            this.attendance.BackColor = System.Drawing.Color.White;
            this.attendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendance.ForeColor = System.Drawing.Color.Black;
            this.attendance.Location = new System.Drawing.Point(491, 458);
            this.attendance.Name = "attendance";
            this.attendance.Size = new System.Drawing.Size(391, 96);
            this.attendance.TabIndex = 61;
            this.attendance.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(401, 422);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 16);
            this.label12.TabIndex = 59;
            this.label12.Text = "Share Capital:";
            // 
            // dateofmembership
            // 
            this.dateofmembership.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateofmembership.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateofmembership.Location = new System.Drawing.Point(491, 385);
            this.dateofmembership.Name = "dateofmembership";
            this.dateofmembership.Size = new System.Drawing.Size(92, 23);
            this.dateofmembership.TabIndex = 58;
            this.dateofmembership.Value = new System.DateTime(2024, 2, 12, 14, 24, 27, 0);
            this.dateofmembership.ValueChanged += new System.EventHandler(this.dateofmembership_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(362, 387);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 16);
            this.label11.TabIndex = 57;
            this.label11.Text = "Date of membership:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(430, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 56;
            this.label10.Text = "Address:";
            // 
            // dateofbirth
            // 
            this.dateofbirth.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateofbirth.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dateofbirth.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dateofbirth.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateofbirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateofbirth.Location = new System.Drawing.Point(119, 459);
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.Size = new System.Drawing.Size(92, 23);
            this.dateofbirth.TabIndex = 55;
            this.dateofbirth.Value = new System.DateTime(2024, 2, 12, 14, 24, 27, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(34, 463);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 16);
            this.label9.TabIndex = 54;
            this.label9.Text = "Date of Birth:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(81, 420);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 16);
            this.label8.TabIndex = 53;
            this.label8.Text = "Age:";
            // 
            // gender
            // 
            this.gender.AllowDrop = true;
            this.gender.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.FormattingEnabled = true;
            this.gender.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender.Location = new System.Drawing.Point(119, 384);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(92, 24);
            this.gender.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(63, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 51;
            this.label7.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(49, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 50;
            this.label6.Text = "Full Name:";
            // 
            // addRecord
            // 
            this.addRecord.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRecord.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRecord.Location = new System.Drawing.Point(491, 563);
            this.addRecord.Name = "addRecord";
            this.addRecord.Size = new System.Drawing.Size(107, 27);
            this.addRecord.TabIndex = 49;
            this.addRecord.Text = "Add Record";
            this.addRecord.UseVisualStyleBackColor = false;
            this.addRecord.Click += new System.EventHandler(this.addRecord_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dataGridView1.Location = new System.Drawing.Point(38, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(856, 232);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridView1_Scroll);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.White;
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.Color.Black;
            this.searchBox.Location = new System.Drawing.Point(84, 36);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(282, 23);
            this.searchBox.TabIndex = 45;
            this.searchBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(42, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "Find:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(412, 460);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 16);
            this.label13.TabIndex = 70;
            this.label13.Text = "Attendance:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.White;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(829, 55);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(53, 16);
            this.linkLabel1.TabIndex = 72;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "View All";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(366, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 16);
            this.label14.TabIndex = 71;
            this.label14.Text = "Filter:";
            // 
            // searchComboBox
            // 
            this.searchComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.searchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchComboBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchComboBox.ForeColor = System.Drawing.Color.White;
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Items.AddRange(new object[] {
            "Age",
            "Gender",
            "Name"});
            this.searchComboBox.Location = new System.Drawing.Point(410, 36);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(62, 24);
            this.searchComboBox.TabIndex = 47;
            this.searchComboBox.Tag = "";
            this.searchComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.searchComboBox_DrawItem);
            this.searchComboBox.SelectedIndexChanged += new System.EventHandler(this.searchComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(953, 611);
            this.ControlBox = false;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.age);
            this.Controls.Add(this.fullname);
            this.Controls.Add(this.sharecapital);
            this.Controls.Add(this.address);
            this.Controls.Add(this.deleteRecord);
            this.Controls.Add(this.updateRecord);
            this.Controls.Add(this.attendance);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateofmembership);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateofbirth);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addRecord);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchComboBox);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label5);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox fullname;
        private System.Windows.Forms.TextBox sharecapital;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Button deleteRecord;
        private System.Windows.Forms.Button updateRecord;
        private System.Windows.Forms.RichTextBox attendance;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateofmembership;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateofbirth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addRecord;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox searchComboBox;
    }
}

