namespace InventoryManager
{
    partial class InventoryManagementSystem
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryManagementSystem));
            label1 = new Label();
            inventoryGridView = new DataGridView();
            newButton = new Button();
            saveButton = new Button();
            deleteButton = new Button();
            nameTextBox = new TextBox();
            priceTextBox = new TextBox();
            quantityTextBox = new TextBox();
            categoryBox = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            skuTextBox = new TextBox();
            descriptionTextBox = new RichTextBox();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            label9 = new Label();
            findTextBox = new TextBox();
            label10 = new Label();
            label11 = new Label();
            FilterBox = new ComboBox();
            viewAll = new LinkLabel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)inventoryGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(118, 24);
            label1.Name = "label1";
            label1.Size = new Size(254, 19);
            label1.TabIndex = 0;
            label1.Text = "DALDESCO   Printing Service Cooperative ";
            // 
            // inventoryGridView
            // 
            inventoryGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            inventoryGridView.BackgroundColor = Color.Gainsboro;
            inventoryGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventoryGridView.Location = new Point(52, 118);
            inventoryGridView.Name = "inventoryGridView";
            inventoryGridView.Size = new Size(916, 270);
            inventoryGridView.TabIndex = 2;
            inventoryGridView.CellDoubleClick += inventoryGridView_CellDoubleClick;
            // 
            // newButton
            // 
            newButton.BackColor = Color.WhiteSmoke;
            newButton.FlatStyle = FlatStyle.Flat;
            newButton.Location = new Point(758, 570);
            newButton.Name = "newButton";
            newButton.Size = new Size(102, 23);
            newButton.TabIndex = 3;
            newButton.Text = "Edit Record";
            newButton.UseVisualStyleBackColor = false;
            newButton.Click += newButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.WhiteSmoke;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Location = new Point(650, 570);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(102, 23);
            saveButton.TabIndex = 4;
            saveButton.Text = "Add Record";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.WhiteSmoke;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Location = new Point(866, 570);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(102, 23);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "Delete Record";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = SystemColors.Window;
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Location = new Point(137, 439);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(211, 23);
            nameTextBox.TabIndex = 6;
            // 
            // priceTextBox
            // 
            priceTextBox.BackColor = SystemColors.Window;
            priceTextBox.BorderStyle = BorderStyle.FixedSingle;
            priceTextBox.Location = new Point(532, 404);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(142, 23);
            priceTextBox.TabIndex = 7;
            // 
            // quantityTextBox
            // 
            quantityTextBox.BackColor = SystemColors.Window;
            quantityTextBox.BorderStyle = BorderStyle.FixedSingle;
            quantityTextBox.Location = new Point(532, 437);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(142, 23);
            quantityTextBox.TabIndex = 10;
            // 
            // categoryBox
            // 
            categoryBox.AutoCompleteCustomSource.AddRange(new string[] { "Ink", "Paper", "Board" });
            categoryBox.FormattingEnabled = true;
            categoryBox.Items.AddRange(new object[] { "Ink", "Paper", "Board" });
            categoryBox.Location = new Point(137, 469);
            categoryBox.Name = "categoryBox";
            categoryBox.Size = new Size(112, 23);
            categoryBox.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(51, 408);
            label2.Name = "label2";
            label2.Size = new Size(80, 14);
            label2.TabIndex = 12;
            label2.Text = "SKU Number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(89, 439);
            label3.Name = "label3";
            label3.Size = new Size(42, 14);
            label3.TabIndex = 13;
            label3.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(71, 472);
            label4.Name = "label4";
            label4.Size = new Size(60, 14);
            label4.TabIndex = 14;
            label4.Text = "Category:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(489, 408);
            label5.Name = "label5";
            label5.Size = new Size(37, 14);
            label5.TabIndex = 15;
            label5.Text = "Price:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(468, 439);
            label6.Name = "label6";
            label6.Size = new Size(58, 14);
            label6.TabIndex = 16;
            label6.Text = "Quantity:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(455, 469);
            label7.Name = "label7";
            label7.Size = new Size(71, 14);
            label7.TabIndex = 17;
            label7.Text = "Description:";
            // 
            // skuTextBox
            // 
            skuTextBox.BorderStyle = BorderStyle.FixedSingle;
            skuTextBox.Location = new Point(137, 404);
            skuTextBox.Name = "skuTextBox";
            skuTextBox.Size = new Size(211, 23);
            skuTextBox.TabIndex = 18;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.BorderStyle = BorderStyle.FixedSingle;
            descriptionTextBox.Location = new Point(532, 467);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(436, 87);
            descriptionTextBox.TabIndex = 19;
            descriptionTextBox.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cooperative_logo;
            pictureBox1.Location = new Point(56, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.BackColor = Color.White;
            label8.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(392, 24);
            label8.Name = "label8";
            label8.Size = new Size(254, 19);
            label8.TabIndex = 21;
            label8.Text = "|     DATA BANK - INVENTORY";
            // 
            // label9
            // 
            label9.BackColor = Color.White;
            label9.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(52, 43);
            label9.Name = "label9";
            label9.Size = new Size(916, 19);
            label9.TabIndex = 22;
            label9.Text = resources.GetString("label9.Text");
            // 
            // findTextBox
            // 
            findTextBox.BorderStyle = BorderStyle.FixedSingle;
            findTextBox.Location = new Point(91, 72);
            findTextBox.Name = "findTextBox";
            findTextBox.Size = new Size(291, 23);
            findTextBox.TabIndex = 23;
            findTextBox.TextChanged += findTextBox_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(52, 74);
            label10.Name = "label10";
            label10.Size = new Size(33, 14);
            label10.TabIndex = 24;
            label10.Text = "Find:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(388, 74);
            label11.Name = "label11";
            label11.Size = new Size(37, 14);
            label11.TabIndex = 25;
            label11.Text = "Filter:";
            // 
            // FilterBox
            // 
            FilterBox.AutoCompleteCustomSource.AddRange(new string[] { "Ink", "Paper", "Board" });
            FilterBox.FormattingEnabled = true;
            FilterBox.Items.AddRange(new object[] { "SKU", "Name", "Category", "Price", "Quantity", "Description" });
            FilterBox.Location = new Point(431, 72);
            FilterBox.Name = "FilterBox";
            FilterBox.Size = new Size(104, 23);
            FilterBox.TabIndex = 26;
            // 
            // viewAll
            // 
            viewAll.AutoSize = true;
            viewAll.LinkBehavior = LinkBehavior.HoverUnderline;
            viewAll.LinkColor = Color.Black;
            viewAll.Location = new Point(922, 100);
            viewAll.Name = "viewAll";
            viewAll.Size = new Size(46, 15);
            viewAll.TabIndex = 27;
            viewAll.TabStop = true;
            viewAll.Text = "ViewAll";
            viewAll.VisitedLinkColor = Color.Black;
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(42, 570);
            button1.Name = "button1";
            button1.Size = new Size(102, 23);
            button1.TabIndex = 28;
            button1.Text = "Back to Menu";
            button1.UseVisualStyleBackColor = false;
            // 
            // InventoryManagementSystem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1017, 605);
            Controls.Add(button1);
            Controls.Add(viewAll);
            Controls.Add(FilterBox);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(findTextBox);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(pictureBox1);
            Controls.Add(descriptionTextBox);
            Controls.Add(skuTextBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(categoryBox);
            Controls.Add(quantityTextBox);
            Controls.Add(priceTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(deleteButton);
            Controls.Add(saveButton);
            Controls.Add(newButton);
            Controls.Add(inventoryGridView);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InventoryManagementSystem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System";
            Load += InventoryManagementSystem_Load;
            ((System.ComponentModel.ISupportInitialize)inventoryGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView inventoryGridView;
        private Button newButton;
        private Button saveButton;
        private Button deleteButton;
        private TextBox nameTextBox;
        private TextBox priceTextBox;
        private TextBox quantityTextBox;
        private ComboBox categoryBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox skuTextBox;
        private RichTextBox descriptionTextBox;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label9;
        private TextBox findTextBox;
        private Label label10;
        private Label label11;
        private ComboBox FilterBox;
        private LinkLabel viewAll;
        private Button button1;
    }
}
