namespace employeeManagement
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label14 = new System.Windows.Forms.Label();
            this.itemTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inventoryGridView = new System.Windows.Forms.DataGridView();
            this.FilterBox = new System.Windows.Forms.ComboBox();
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.specificationTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.quantityInTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.addRecord = new System.Windows.Forms.Button();
            this.updateRecord = new System.Windows.Forms.Button();
            this.deleteRecord = new System.Windows.Forms.Button();
            this.quantityOutTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(829, 55);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(53, 16);
            this.linkLabel1.TabIndex = 103;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "View All";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(359, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 16);
            this.label14.TabIndex = 102;
            this.label14.Text = "Filter:";
            // 
            // itemTextBox
            // 
            this.itemTextBox.BackColor = System.Drawing.Color.White;
            this.itemTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTextBox.ForeColor = System.Drawing.Color.Black;
            this.itemTextBox.Location = new System.Drawing.Point(131, 348);
            this.itemTextBox.Name = "itemTextBox";
            this.itemTextBox.Size = new System.Drawing.Size(215, 23);
            this.itemTextBox.TabIndex = 99;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(87, 421);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 16);
            this.label10.TabIndex = 89;
            this.label10.Text = "Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(41, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 84;
            this.label7.Text = "Specification:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(87, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 83;
            this.label6.Text = "Item:";
            // 
            // inventoryGridView
            // 
            this.inventoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventoryGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.inventoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.inventoryGridView.Location = new System.Drawing.Point(38, 74);
            this.inventoryGridView.Name = "inventoryGridView";
            this.inventoryGridView.Size = new System.Drawing.Size(856, 232);
            this.inventoryGridView.TabIndex = 81;
            this.inventoryGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventoryGridView_CellClick);
            this.inventoryGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventoryGridView_CellContentClick);
            this.inventoryGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventoryGridView_CellEndEdit);
            this.inventoryGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventoryGridView_CellValueChanged);
            // 
            // FilterBox
            // 
            this.FilterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterBox.FormattingEnabled = true;
            this.FilterBox.Items.AddRange(new object[] {
            "Item",
            "Specification"});
            this.FilterBox.Location = new System.Drawing.Point(403, 37);
            this.FilterBox.Name = "FilterBox";
            this.FilterBox.Size = new System.Drawing.Size(79, 24);
            this.FilterBox.TabIndex = 80;
            this.FilterBox.Tag = "";
            this.FilterBox.SelectedIndexChanged += new System.EventHandler(this.FilterBox_SelectedIndexChanged);
            // 
            // findTextBox
            // 
            this.findTextBox.BackColor = System.Drawing.Color.White;
            this.findTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.findTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findTextBox.ForeColor = System.Drawing.Color.Black;
            this.findTextBox.Location = new System.Drawing.Point(77, 37);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(282, 23);
            this.findTextBox.TabIndex = 79;
            this.findTextBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(35, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 78;
            this.label5.Text = "Find:";
            // 
            // specificationTextBox
            // 
            this.specificationTextBox.BackColor = System.Drawing.Color.White;
            this.specificationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.specificationTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specificationTextBox.ForeColor = System.Drawing.Color.Black;
            this.specificationTextBox.Location = new System.Drawing.Point(131, 382);
            this.specificationTextBox.Name = "specificationTextBox";
            this.specificationTextBox.Size = new System.Drawing.Size(215, 23);
            this.specificationTextBox.TabIndex = 99;
            // 
            // priceTextBox
            // 
            this.priceTextBox.BackColor = System.Drawing.Color.White;
            this.priceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.ForeColor = System.Drawing.Color.Black;
            this.priceTextBox.Location = new System.Drawing.Point(131, 417);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(215, 23);
            this.priceTextBox.TabIndex = 99;
            // 
            // quantityInTextBox
            // 
            this.quantityInTextBox.BackColor = System.Drawing.Color.White;
            this.quantityInTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantityInTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityInTextBox.ForeColor = System.Drawing.Color.Black;
            this.quantityInTextBox.Location = new System.Drawing.Point(488, 350);
            this.quantityInTextBox.Name = "quantityInTextBox";
            this.quantityInTextBox.Size = new System.Drawing.Size(73, 23);
            this.quantityInTextBox.TabIndex = 99;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(423, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 16);
            this.label9.TabIndex = 89;
            this.label9.Text = "Quantity:";
            // 
            // addRecord
            // 
            this.addRecord.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRecord.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRecord.ForeColor = System.Drawing.Color.Black;
            this.addRecord.Location = new System.Drawing.Point(505, 545);
            this.addRecord.Name = "addRecord";
            this.addRecord.Size = new System.Drawing.Size(107, 27);
            this.addRecord.TabIndex = 82;
            this.addRecord.Text = "Add Record";
            this.addRecord.UseVisualStyleBackColor = false;
            this.addRecord.Click += new System.EventHandler(this.addRecord_Click);
            // 
            // updateRecord
            // 
            this.updateRecord.BackColor = System.Drawing.SystemColors.ControlLight;
            this.updateRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateRecord.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateRecord.ForeColor = System.Drawing.Color.Black;
            this.updateRecord.Location = new System.Drawing.Point(618, 545);
            this.updateRecord.Name = "updateRecord";
            this.updateRecord.Size = new System.Drawing.Size(107, 27);
            this.updateRecord.TabIndex = 94;
            this.updateRecord.Text = "Update Record";
            this.updateRecord.UseVisualStyleBackColor = false;
            this.updateRecord.Click += new System.EventHandler(this.updateRecord_Click);
            // 
            // deleteRecord
            // 
            this.deleteRecord.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deleteRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteRecord.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRecord.Location = new System.Drawing.Point(731, 545);
            this.deleteRecord.Name = "deleteRecord";
            this.deleteRecord.Size = new System.Drawing.Size(107, 27);
            this.deleteRecord.TabIndex = 95;
            this.deleteRecord.Text = "Delete Record";
            this.deleteRecord.UseVisualStyleBackColor = false;
            this.deleteRecord.Click += new System.EventHandler(this.deleteRecord_Click);
            // 
            // quantityOutTextBox
            // 
            this.quantityOutTextBox.BackColor = System.Drawing.Color.White;
            this.quantityOutTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantityOutTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityOutTextBox.ForeColor = System.Drawing.Color.Black;
            this.quantityOutTextBox.Location = new System.Drawing.Point(567, 350);
            this.quantityOutTextBox.Name = "quantityOutTextBox";
            this.quantityOutTextBox.Size = new System.Drawing.Size(73, 23);
            this.quantityOutTextBox.TabIndex = 99;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(514, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 89;
            this.label1.Text = "(in)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(586, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 89;
            this.label2.Text = "(out)";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(953, 588);
            this.ControlBox = false;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.specificationTextBox);
            this.Controls.Add(this.quantityOutTextBox);
            this.Controls.Add(this.quantityInTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.itemTextBox);
            this.Controls.Add(this.deleteRecord);
            this.Controls.Add(this.updateRecord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addRecord);
            this.Controls.Add(this.inventoryGridView);
            this.Controls.Add(this.FilterBox);
            this.Controls.Add(this.findTextBox);
            this.Controls.Add(this.label5);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inventory_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Inventory_FormClosed);
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Inventory_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox itemTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView inventoryGridView;
        private System.Windows.Forms.ComboBox FilterBox;
        private System.Windows.Forms.TextBox findTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox specificationTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox quantityInTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button addRecord;
        private System.Windows.Forms.Button updateRecord;
        private System.Windows.Forms.Button deleteRecord;
        private System.Windows.Forms.TextBox quantityOutTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}