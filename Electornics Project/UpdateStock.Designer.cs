namespace Electornics_Project
{
    partial class UpdateStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateStock));
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.btnPurchasePrice = new System.Windows.Forms.Button();
            this.txtNPurchasePrice = new System.Windows.Forms.TextBox();
            this.comboctgry = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnUDel = new System.Windows.Forms.Button();
            this.txtDelete_PName = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.btnUQty = new System.Windows.Forms.Button();
            this.txtqty_new = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUProductName = new System.Windows.Forms.Button();
            this.txtName_New = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.txtPurchasePrice);
            this.groupBox6.Controls.Add(this.btnPurchasePrice);
            this.groupBox6.Controls.Add(this.txtNPurchasePrice);
            this.groupBox6.Location = new System.Drawing.Point(13, 231);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(462, 166);
            this.groupBox6.TabIndex = 24;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Update Purchase Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "New:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Previous:";
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPurchasePrice.Location = new System.Drawing.Point(12, 47);
            this.txtPurchasePrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.ReadOnly = true;
            this.txtPurchasePrice.Size = new System.Drawing.Size(195, 20);
            this.txtPurchasePrice.TabIndex = 14;
            this.txtPurchasePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPurchasePrice
            // 
            this.btnPurchasePrice.BackColor = System.Drawing.Color.Transparent;
            this.btnPurchasePrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPurchasePrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchasePrice.Image = ((System.Drawing.Image)(resources.GetObject("btnPurchasePrice.Image")));
            this.btnPurchasePrice.Location = new System.Drawing.Point(12, 79);
            this.btnPurchasePrice.Margin = new System.Windows.Forms.Padding(4);
            this.btnPurchasePrice.Name = "btnPurchasePrice";
            this.btnPurchasePrice.Size = new System.Drawing.Size(399, 38);
            this.btnPurchasePrice.TabIndex = 1;
            this.btnPurchasePrice.Text = "CHANGE";
            this.btnPurchasePrice.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPurchasePrice.UseVisualStyleBackColor = false;
            this.btnPurchasePrice.Click += new System.EventHandler(this.btnPurchasePrice_Click);
            // 
            // txtNPurchasePrice
            // 
            this.txtNPurchasePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNPurchasePrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNPurchasePrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNPurchasePrice.Location = new System.Drawing.Point(223, 47);
            this.txtNPurchasePrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtNPurchasePrice.Name = "txtNPurchasePrice";
            this.txtNPurchasePrice.Size = new System.Drawing.Size(188, 20);
            this.txtNPurchasePrice.TabIndex = 0;
            this.txtNPurchasePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboctgry
            // 
            this.comboctgry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboctgry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboctgry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboctgry.FormattingEnabled = true;
            this.comboctgry.Location = new System.Drawing.Point(623, 32);
            this.comboctgry.Margin = new System.Windows.Forms.Padding(4);
            this.comboctgry.Name = "comboctgry";
            this.comboctgry.Size = new System.Drawing.Size(226, 21);
            this.comboctgry.Sorted = true;
            this.comboctgry.TabIndex = 20;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.btnUDel);
            this.groupBox5.Controls.Add(this.txtDelete_PName);
            this.groupBox5.Location = new System.Drawing.Point(488, 228);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(361, 169);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Delete Product";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(78, 39);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Product Name";
            // 
            // btnUDel
            // 
            this.btnUDel.BackColor = System.Drawing.Color.Transparent;
            this.btnUDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUDel.Image = ((System.Drawing.Image)(resources.GetObject("btnUDel.Image")));
            this.btnUDel.Location = new System.Drawing.Point(80, 98);
            this.btnUDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnUDel.Name = "btnUDel";
            this.btnUDel.Size = new System.Drawing.Size(195, 38);
            this.btnUDel.TabIndex = 1;
            this.btnUDel.Text = "DELETE";
            this.btnUDel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUDel.UseVisualStyleBackColor = false;
            this.btnUDel.Click += new System.EventHandler(this.btnUDel_Click);
            // 
            // txtDelete_PName
            // 
            this.txtDelete_PName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDelete_PName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDelete_PName.Location = new System.Drawing.Point(80, 67);
            this.txtDelete_PName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDelete_PName.Name = "txtDelete_PName";
            this.txtDelete_PName.Size = new System.Drawing.Size(195, 20);
            this.txtDelete_PName.TabIndex = 0;
            this.txtDelete_PName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtProductQuantity);
            this.groupBox4.Controls.Add(this.btnUQty);
            this.groupBox4.Controls.Add(this.txtqty_new);
            this.groupBox4.Location = new System.Drawing.Point(493, 62);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(356, 160);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Update Product Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(178, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "New:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 20);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Previous:";
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtProductQuantity.Location = new System.Drawing.Point(57, 52);
            this.txtProductQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.ReadOnly = true;
            this.txtProductQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtProductQuantity.TabIndex = 14;
            this.txtProductQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnUQty
            // 
            this.btnUQty.BackColor = System.Drawing.Color.Transparent;
            this.btnUQty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUQty.Image = ((System.Drawing.Image)(resources.GetObject("btnUQty.Image")));
            this.btnUQty.Location = new System.Drawing.Point(57, 84);
            this.btnUQty.Margin = new System.Windows.Forms.Padding(4);
            this.btnUQty.Name = "btnUQty";
            this.btnUQty.Size = new System.Drawing.Size(224, 38);
            this.btnUQty.TabIndex = 1;
            this.btnUQty.Text = "CHANGE";
            this.btnUQty.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUQty.UseVisualStyleBackColor = false;
            this.btnUQty.Click += new System.EventHandler(this.btnUQty_Click);
            // 
            // txtqty_new
            // 
            this.txtqty_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtqty_new.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtqty_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtqty_new.Location = new System.Drawing.Point(180, 52);
            this.txtqty_new.Margin = new System.Windows.Forms.Padding(4);
            this.txtqty_new.Name = "txtqty_new";
            this.txtqty_new.Size = new System.Drawing.Size(100, 20);
            this.txtqty_new.TabIndex = 0;
            this.txtqty_new.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnUProductName);
            this.groupBox1.Controls.Add(this.txtName_New);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Location = new System.Drawing.Point(13, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(467, 161);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Product Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "New:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Previous:";
            // 
            // btnUProductName
            // 
            this.btnUProductName.BackColor = System.Drawing.Color.Transparent;
            this.btnUProductName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUProductName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUProductName.Image = ((System.Drawing.Image)(resources.GetObject("btnUProductName.Image")));
            this.btnUProductName.Location = new System.Drawing.Point(19, 85);
            this.btnUProductName.Margin = new System.Windows.Forms.Padding(4);
            this.btnUProductName.Name = "btnUProductName";
            this.btnUProductName.Size = new System.Drawing.Size(400, 39);
            this.btnUProductName.TabIndex = 1;
            this.btnUProductName.Text = "CHANGE";
            this.btnUProductName.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUProductName.UseVisualStyleBackColor = false;
            this.btnUProductName.Click += new System.EventHandler(this.btnUProductName_Click);
            // 
            // txtName_New
            // 
            this.txtName_New.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtName_New.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtName_New.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtName_New.Location = new System.Drawing.Point(223, 53);
            this.txtName_New.Margin = new System.Windows.Forms.Padding(4);
            this.txtName_New.Name = "txtName_New";
            this.txtName_New.Size = new System.Drawing.Size(196, 20);
            this.txtName_New.TabIndex = 0;
            this.txtName_New.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtProductName
            // 
            this.txtProductName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtProductName.Location = new System.Drawing.Point(19, 53);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(195, 20);
            this.txtProductName.TabIndex = 0;
            this.txtProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.Location = new System.Drawing.Point(681, 9);
            this.lbl_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(168, 20);
            this.lbl_1.TabIndex = 25;
            this.lbl_1.Text = "Select Category Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(13, 405);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(836, 184);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // UpdateStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 603);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.comboctgry);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "UpdateStock";
            this.ShowIcon = false;
            this.Text = "Update Stock";
            this.Load += new System.EventHandler(this.UpdateStock_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.Button btnPurchasePrice;
        private System.Windows.Forms.TextBox txtNPurchasePrice;
        private System.Windows.Forms.ComboBox comboctgry;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnUDel;
        private System.Windows.Forms.TextBox txtDelete_PName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtProductQuantity;
        private System.Windows.Forms.Button btnUQty;
        private System.Windows.Forms.TextBox txtqty_new;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUProductName;
        private System.Windows.Forms.TextBox txtName_New;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}