namespace employeeManagement
{
    partial class NotificationsForm
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
            System.Windows.Forms.Label label12;
            this.btnMarkAllAsRead = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(101, 29);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(0, 13);
            label12.TabIndex = 0;
            label12.Click += new System.EventHandler(this.label_Click);
            // 
            // btnMarkAllAsRead
            // 
            this.btnMarkAllAsRead.Location = new System.Drawing.Point(387, 354);
            this.btnMarkAllAsRead.Name = "btnMarkAllAsRead";
            this.btnMarkAllAsRead.Size = new System.Drawing.Size(109, 39);
            this.btnMarkAllAsRead.TabIndex = 1;
            this.btnMarkAllAsRead.Text = "Mark all as Read";
            this.btnMarkAllAsRead.UseVisualStyleBackColor = true;
            this.btnMarkAllAsRead.Click += new System.EventHandler(this.btnMarkAllAsRead_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(117, 344);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 39);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(107, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(549, 326);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // NotificationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(label12);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnMarkAllAsRead);
            this.Name = "NotificationsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.NotificationsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMarkAllAsRead;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}