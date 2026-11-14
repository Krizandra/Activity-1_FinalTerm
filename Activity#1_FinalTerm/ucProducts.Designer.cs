namespace Activity_1_FinalTerm
{
    partial class ucProducts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblLowStock = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblInStock = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblOutOfStock = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtReorderLevel = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.DomainUpDown();
            this.txtCategory = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(27, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 46);
            this.label2.TabIndex = 54;
            this.label2.Text = "Products";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(32, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 25);
            this.label3.TabIndex = 55;
            this.label3.Text = "Manage your inventory products";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Controls.Add(this.lblLowStock);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(602, 125);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(231, 125);
            this.panel5.TabIndex = 64;
            // 
            // lblLowStock
            // 
            this.lblLowStock.AutoSize = true;
            this.lblLowStock.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblLowStock.ForeColor = System.Drawing.Color.Gold;
            this.lblLowStock.Location = new System.Drawing.Point(8, 62);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(42, 46);
            this.lblLowStock.TabIndex = 2;
            this.lblLowStock.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Gold;
            this.label9.Location = new System.Drawing.Point(10, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 30);
            this.label9.TabIndex = 1;
            this.label9.Text = "Low Stock";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Controls.Add(this.lblInStock);
            this.panel4.Controls.Add(this.label7);
            this.panel4.ForeColor = System.Drawing.SystemColors.Control;
            this.panel4.Location = new System.Drawing.Point(327, 125);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(231, 125);
            this.panel4.TabIndex = 65;
            // 
            // lblInStock
            // 
            this.lblInStock.AutoSize = true;
            this.lblInStock.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblInStock.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblInStock.Location = new System.Drawing.Point(8, 62);
            this.lblInStock.Name = "lblInStock";
            this.lblInStock.Size = new System.Drawing.Size(42, 46);
            this.lblInStock.TabIndex = 2;
            this.lblInStock.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.LimeGreen;
            this.label7.Location = new System.Drawing.Point(10, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 30);
            this.label7.TabIndex = 1;
            this.label7.Text = "In Stock";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(52, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 125);
            this.panel1.TabIndex = 63;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTotal.Location = new System.Drawing.Point(8, 62);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 46);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(10, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total Products";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel7.Location = new System.Drawing.Point(36, 125);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(248, 125);
            this.panel7.TabIndex = 66;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LimeGreen;
            this.panel8.Location = new System.Drawing.Point(310, 125);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(248, 125);
            this.panel8.TabIndex = 67;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Red;
            this.panel10.Controls.Add(this.panel2);
            this.panel10.Location = new System.Drawing.Point(860, 125);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(248, 125);
            this.panel10.TabIndex = 68;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.lblOutOfStock);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(16, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 125);
            this.panel2.TabIndex = 57;
            // 
            // lblOutOfStock
            // 
            this.lblOutOfStock.AutoSize = true;
            this.lblOutOfStock.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblOutOfStock.ForeColor = System.Drawing.Color.Red;
            this.lblOutOfStock.Location = new System.Drawing.Point(8, 62);
            this.lblOutOfStock.Name = "lblOutOfStock";
            this.lblOutOfStock.Size = new System.Drawing.Size(42, 46);
            this.lblOutOfStock.TabIndex = 2;
            this.lblOutOfStock.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(10, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 30);
            this.label11.TabIndex = 1;
            this.label11.Text = "Out of Stock";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Gold;
            this.panel9.Location = new System.Drawing.Point(585, 125);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(248, 125);
            this.panel9.TabIndex = 69;
            // 
            // button11
            // 
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button11.ForeColor = System.Drawing.Color.SteelBlue;
            this.button11.Location = new System.Drawing.Point(985, 529);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(122, 42);
            this.button11.TabIndex = 82;
            this.button11.Text = "Refresh";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(39, 535);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(160, 30);
            this.label20.TabIndex = 81;
            this.label20.Text = "Product List";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSearch.Location = new System.Drawing.Point(633, 535);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(325, 30);
            this.txtSearch.TabIndex = 80;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(36, 580);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 62;
            this.dgvProducts.RowTemplate.Height = 28;
            this.dgvProducts.Size = new System.Drawing.Size(1071, 288);
            this.dgvProducts.TabIndex = 79;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.btnClear);
            this.panel11.Controls.Add(this.btnDelete);
            this.panel11.Controls.Add(this.btnUpdate);
            this.panel11.Controls.Add(this.btnAdd);
            this.panel11.Controls.Add(this.label18);
            this.panel11.Controls.Add(this.txtReorderLevel);
            this.panel11.Controls.Add(this.label17);
            this.panel11.Controls.Add(this.txtQuantity);
            this.panel11.Controls.Add(this.label16);
            this.panel11.Controls.Add(this.txtDescription);
            this.panel11.Controls.Add(this.label15);
            this.panel11.Controls.Add(this.txtUnitPrice);
            this.panel11.Controls.Add(this.txtCategory);
            this.panel11.Controls.Add(this.label14);
            this.panel11.Controls.Add(this.label13);
            this.panel11.Controls.Add(this.txtProductName);
            this.panel11.Controls.Add(this.label12);
            this.panel11.Location = new System.Drawing.Point(36, 277);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1072, 230);
            this.panel11.TabIndex = 78;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(873, 166);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(170, 38);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(873, 122);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(170, 38);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(873, 78);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(170, 38);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(873, 34);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(170, 38);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 9F);
            this.label18.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label18.Location = new System.Drawing.Point(576, 125);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(123, 21);
            this.label18.TabIndex = 14;
            this.label18.Text = "Reorder Level";
            // 
            // txtReorderLevel
            // 
            this.txtReorderLevel.Font = new System.Drawing.Font("Arial", 9F);
            this.txtReorderLevel.Location = new System.Drawing.Point(579, 148);
            this.txtReorderLevel.Name = "txtReorderLevel";
            this.txtReorderLevel.Size = new System.Drawing.Size(232, 28);
            this.txtReorderLevel.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9F);
            this.label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label17.Location = new System.Drawing.Point(302, 125);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 21);
            this.label17.TabIndex = 12;
            this.label17.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Arial", 9F);
            this.txtQuantity.Location = new System.Drawing.Point(304, 148);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(232, 28);
            this.txtQuantity.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9F);
            this.label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label16.Location = new System.Drawing.Point(27, 125);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 21);
            this.label16.TabIndex = 10;
            this.label16.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Arial", 9F);
            this.txtDescription.Location = new System.Drawing.Point(30, 148);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(232, 56);
            this.txtDescription.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9F);
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(576, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 21);
            this.label15.TabIndex = 8;
            this.label15.Text = "Unit Price";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("Arial", 9F);
            this.txtUnitPrice.Location = new System.Drawing.Point(579, 78);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(232, 28);
            this.txtUnitPrice.TabIndex = 6;
            // 
            // txtCategory
            // 
            this.txtCategory.Font = new System.Drawing.Font("Arial", 9F);
            this.txtCategory.FormattingEnabled = true;
            this.txtCategory.Items.AddRange(new object[] {
            "Noodles",
            "Drinks",
            "Baking",
            "Toiletries",
            "Snacks"});
            this.txtCategory.Location = new System.Drawing.Point(304, 75);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(230, 29);
            this.txtCategory.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9F);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(300, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 21);
            this.label14.TabIndex = 4;
            this.label14.Text = "Category";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9F);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(27, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 21);
            this.label13.TabIndex = 2;
            this.label13.Text = "Product Name";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Arial", 9F);
            this.txtProductName.Location = new System.Drawing.Point(30, 78);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(232, 28);
            this.txtProductName.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(10, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "Product Details";
            // 
            // ucProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucProducts";
            this.Size = new System.Drawing.Size(1148, 892);
            this.Load += new System.EventHandler(this.ucProducts_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblLowStock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblInStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblOutOfStock;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtReorderLevel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DomainUpDown txtUnitPrice;
        private System.Windows.Forms.ComboBox txtCategory;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label12;
    }
}
