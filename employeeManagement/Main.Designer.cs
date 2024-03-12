namespace employeeManagement
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.helpBtn = new System.Windows.Forms.Button();
            this.inventoryBtn = new System.Windows.Forms.Button();
            this.membersBtn = new System.Windows.Forms.Button();
            this.homebtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelForAll = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelAnimationTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.helpBtn);
            this.panel1.Controls.Add(this.inventoryBtn);
            this.panel1.Controls.Add(this.membersBtn);
            this.panel1.Controls.Add(this.homebtn);
            this.panel1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 692);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(42, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Service Cooperative";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(46, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "DALDESCO Printing";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::employeeManagement.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(39, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // helpBtn
            // 
            this.helpBtn.AutoSize = true;
            this.helpBtn.BackColor = System.Drawing.Color.Transparent;
            this.helpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpBtn.ForeColor = System.Drawing.Color.Black;
            this.helpBtn.Image = global::employeeManagement.Properties.Resources.icons8_help_24;
            this.helpBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helpBtn.Location = new System.Drawing.Point(12, 653);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(196, 32);
            this.helpBtn.TabIndex = 0;
            this.helpBtn.Text = "          Help";
            this.helpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helpBtn.UseVisualStyleBackColor = false;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // inventoryBtn
            // 
            this.inventoryBtn.AutoSize = true;
            this.inventoryBtn.BackColor = System.Drawing.Color.Transparent;
            this.inventoryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventoryBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.inventoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventoryBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryBtn.ForeColor = System.Drawing.Color.Black;
            this.inventoryBtn.Image = global::employeeManagement.Properties.Resources.icons8_inventory_24__1_;
            this.inventoryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventoryBtn.Location = new System.Drawing.Point(10, 378);
            this.inventoryBtn.Name = "inventoryBtn";
            this.inventoryBtn.Size = new System.Drawing.Size(196, 38);
            this.inventoryBtn.TabIndex = 0;
            this.inventoryBtn.Text = "          Inventory";
            this.inventoryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventoryBtn.UseVisualStyleBackColor = false;
            this.inventoryBtn.Click += new System.EventHandler(this.inventoryBtn_Click);
            // 
            // membersBtn
            // 
            this.membersBtn.AutoSize = true;
            this.membersBtn.BackColor = System.Drawing.Color.Transparent;
            this.membersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.membersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.membersBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membersBtn.ForeColor = System.Drawing.Color.Black;
            this.membersBtn.Image = global::employeeManagement.Properties.Resources.icons8_user_24__1_;
            this.membersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.membersBtn.Location = new System.Drawing.Point(10, 338);
            this.membersBtn.Name = "membersBtn";
            this.membersBtn.Size = new System.Drawing.Size(196, 38);
            this.membersBtn.TabIndex = 0;
            this.membersBtn.Text = "          Members";
            this.membersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.membersBtn.UseVisualStyleBackColor = false;
            this.membersBtn.Click += new System.EventHandler(this.membersBtn_Click);
            // 
            // homebtn
            // 
            this.homebtn.AutoSize = true;
            this.homebtn.BackColor = System.Drawing.Color.Transparent;
            this.homebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homebtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.homebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homebtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtn.ForeColor = System.Drawing.Color.Black;
            this.homebtn.Image = global::employeeManagement.Properties.Resources.icons8_home_241;
            this.homebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homebtn.Location = new System.Drawing.Point(10, 298);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(196, 38);
            this.homebtn.TabIndex = 0;
            this.homebtn.Text = "          Home";
            this.homebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homebtn.UseVisualStyleBackColor = false;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(136)))), ((int)(((byte)(67)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(230, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(107, 32);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.labelForAll);
            this.panel3.Location = new System.Drawing.Point(5, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(98, 35);
            this.panel3.TabIndex = 5;
            // 
            // labelForAll
            // 
            this.labelForAll.AutoSize = true;
            this.labelForAll.BackColor = System.Drawing.Color.Black;
            this.labelForAll.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForAll.ForeColor = System.Drawing.Color.White;
            this.labelForAll.Location = new System.Drawing.Point(19, 4);
            this.labelForAll.Name = "labelForAll";
            this.labelForAll.Size = new System.Drawing.Size(63, 22);
            this.labelForAll.TabIndex = 2;
            this.labelForAll.Text = "Home";
            this.labelForAll.Click += new System.EventHandler(this.labelForAll_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contentPanel.AutoSize = true;
            this.contentPanel.BackColor = System.Drawing.Color.Transparent;
            this.contentPanel.Location = new System.Drawing.Point(227, 68);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(928, 612);
            this.contentPanel.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelAnimationTimer
            // 
            this.labelAnimationTimer.Tick += new System.EventHandler(this.labelAnimationTimer_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1167, 692);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daldesco";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label labelForAll;
        private System.Windows.Forms.Button inventoryBtn;
        private System.Windows.Forms.Button membersBtn;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer labelAnimationTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}