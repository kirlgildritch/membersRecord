namespace employeeManagement
{
    partial class Settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.notificationPreference = new ReaLTaiizor.Controls.HopeToggle();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.auditTrail = new ReaLTaiizor.Controls.HopeToggle();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(58, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Notification Preferences";
            // 
            // notificationPreference
            // 
            this.notificationPreference.AutoSize = true;
            this.notificationPreference.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.notificationPreference.BaseColorA = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.notificationPreference.BaseColorB = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.notificationPreference.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notificationPreference.ForeColor = System.Drawing.Color.Black;
            this.notificationPreference.HeadColorA = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.notificationPreference.HeadColorB = System.Drawing.Color.White;
            this.notificationPreference.HeadColorC = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.notificationPreference.HeadColorD = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.notificationPreference.Location = new System.Drawing.Point(5, 52);
            this.notificationPreference.Name = "notificationPreference";
            this.notificationPreference.Size = new System.Drawing.Size(48, 20);
            this.notificationPreference.TabIndex = 9;
            this.notificationPreference.Text = "notificationPreference";
            this.notificationPreference.UseVisualStyleBackColor = true;
            this.notificationPreference.CheckedChanged += new System.EventHandler(this.notificationPreference_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(57, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(447, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "(Allow users to set notification preferences for changes, updates, or low invento" +
    "ry alerts.)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(58, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Audit Trail";
            // 
            // auditTrail
            // 
            this.auditTrail.AutoSize = true;
            this.auditTrail.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.auditTrail.BaseColorA = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.auditTrail.BaseColorB = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.auditTrail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.auditTrail.ForeColor = System.Drawing.Color.Black;
            this.auditTrail.HeadColorA = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.auditTrail.HeadColorB = System.Drawing.Color.White;
            this.auditTrail.HeadColorC = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.auditTrail.HeadColorD = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.auditTrail.Location = new System.Drawing.Point(5, 103);
            this.auditTrail.Name = "auditTrail";
            this.auditTrail.Size = new System.Drawing.Size(48, 20);
            this.auditTrail.TabIndex = 9;
            this.auditTrail.Text = "auditTrail";
            this.auditTrail.UseVisualStyleBackColor = true;
            this.auditTrail.CheckedChanged += new System.EventHandler(this.auditTrail_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(58, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(370, 14);
            this.label6.TabIndex = 7;
            this.label6.Text = "(Record and display changes made to records over time for accountability.)";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(962, 521);
            this.ControlBox = false;
            this.Controls.Add(this.auditTrail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.notificationPreference);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.HopeToggle notificationPreference;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private ReaLTaiizor.Controls.HopeToggle auditTrail;
        private System.Windows.Forms.Label label6;
    }
}