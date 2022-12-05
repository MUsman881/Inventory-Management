namespace Electornics_Project
{
    partial class PurchaseVoucher
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseVoucher));
            this.gbox_SupplierInfo = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gbx_fetchprdct = new System.Windows.Forms.GroupBox();
            this.txtdisc = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_netttl = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ttldisc = new System.Windows.Forms.TextBox();
            this.txt_ttlqty = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_ttlamnt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Rate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Qty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboprdct = new System.Windows.Forms.ComboBox();
            this.custCartGrid = new System.Windows.Forms.DataGridView();
            this.tb_AddToCart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.txtno = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txtsuppname = new System.Windows.Forms.TextBox();
            this.combo_term = new MetroFramework.Controls.MetroComboBox();
            this.combo_datetime = new MetroFramework.Controls.MetroDateTime();
            this.Combosupp = new MetroFramework.Controls.MetroComboBox();
            this.txt_cell = new System.Windows.Forms.TextBox();
            this.btn_fresh = new System.Windows.Forms.Button();
            this.gbox_SupplierInfo.SuspendLayout();
            this.gbx_fetchprdct.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custCartGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // gbox_SupplierInfo
            // 
            this.gbox_SupplierInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbox_SupplierInfo.BackColor = System.Drawing.Color.CadetBlue;
            this.gbox_SupplierInfo.Controls.Add(this.txtsuppname);
            this.gbox_SupplierInfo.Controls.Add(this.combo_term);
            this.gbox_SupplierInfo.Controls.Add(this.combo_datetime);
            this.gbox_SupplierInfo.Controls.Add(this.Combosupp);
            this.gbox_SupplierInfo.Controls.Add(this.txt_cell);
            this.gbox_SupplierInfo.Controls.Add(this.btn_save);
            this.gbox_SupplierInfo.Controls.Add(this.label14);
            this.gbox_SupplierInfo.Controls.Add(this.button1);
            this.gbox_SupplierInfo.Controls.Add(this.label1);
            this.gbox_SupplierInfo.Controls.Add(this.label12);
            this.gbox_SupplierInfo.Controls.Add(this.label11);
            this.gbox_SupplierInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_SupplierInfo.ForeColor = System.Drawing.Color.White;
            this.gbox_SupplierInfo.Location = new System.Drawing.Point(239, 29);
            this.gbox_SupplierInfo.Name = "gbox_SupplierInfo";
            this.gbox_SupplierInfo.Size = new System.Drawing.Size(713, 221);
            this.gbox_SupplierInfo.TabIndex = 84;
            this.gbox_SupplierInfo.TabStop = false;
            this.gbox_SupplierInfo.Text = "Supplier Information";
            this.gbox_SupplierInfo.Enter += new System.EventHandler(this.gbox_CustomerInfo_Enter);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.PowderBlue;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(65, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 19);
            this.label14.TabIndex = 87;
            this.label14.Text = "DATE:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(485, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 66);
            this.button1.TabIndex = 64;
            this.button1.Text = "Search";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PowderBlue;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(61, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 62;
            this.label1.Text = "Terms :";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.PowderBlue;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(10, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 19);
            this.label12.TabIndex = 60;
            this.label12.Text = "Supplier Cell#  :";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.PowderBlue;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(10, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 19);
            this.label11.TabIndex = 59;
            this.label11.Text = "Supplier Name :";
            // 
            // gbx_fetchprdct
            // 
            this.gbx_fetchprdct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbx_fetchprdct.BackColor = System.Drawing.Color.CadetBlue;
            this.gbx_fetchprdct.Controls.Add(this.txtdisc);
            this.gbx_fetchprdct.Controls.Add(this.label15);
            this.gbx_fetchprdct.Controls.Add(this.groupBox2);
            this.gbx_fetchprdct.Controls.Add(this.label7);
            this.gbx_fetchprdct.Controls.Add(this.txttotal);
            this.gbx_fetchprdct.Controls.Add(this.label6);
            this.gbx_fetchprdct.Controls.Add(this.Rate);
            this.gbx_fetchprdct.Controls.Add(this.label5);
            this.gbx_fetchprdct.Controls.Add(this.Qty);
            this.gbx_fetchprdct.Controls.Add(this.label4);
            this.gbx_fetchprdct.Controls.Add(this.comboprdct);
            this.gbx_fetchprdct.Controls.Add(this.custCartGrid);
            this.gbx_fetchprdct.Controls.Add(this.tb_AddToCart);
            this.gbx_fetchprdct.Controls.Add(this.label2);
            this.gbx_fetchprdct.Controls.Add(this.txt_desc);
            this.gbx_fetchprdct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_fetchprdct.ForeColor = System.Drawing.Color.White;
            this.gbx_fetchprdct.Location = new System.Drawing.Point(12, 256);
            this.gbx_fetchprdct.Name = "gbx_fetchprdct";
            this.gbx_fetchprdct.Size = new System.Drawing.Size(949, 383);
            this.gbx_fetchprdct.TabIndex = 87;
            this.gbx_fetchprdct.TabStop = false;
            this.gbx_fetchprdct.Text = "Fetch Product";
            // 
            // txtdisc
            // 
            this.txtdisc.BackColor = System.Drawing.Color.White;
            this.txtdisc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtdisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdisc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtdisc.Location = new System.Drawing.Point(687, 56);
            this.txtdisc.Multiline = true;
            this.txtdisc.Name = "txtdisc";
            this.txtdisc.Size = new System.Drawing.Size(103, 25);
            this.txtdisc.TabIndex = 4;
            this.txtdisc.Text = "0";
            this.txtdisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdisc.Leave += new System.EventHandler(this.txtdisc_Leave);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.PowderBlue;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(699, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 20);
            this.label15.TabIndex = 76;
            this.label15.Text = "Disc(%)";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_netttl);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_ttldisc);
            this.groupBox2.Controls.Add(this.txt_ttlqty);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txt_ttlamnt);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(184, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(739, 75);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Purchase Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(550, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 18);
            this.label9.TabIndex = 74;
            this.label9.Text = "Net Total :";
            // 
            // txt_netttl
            // 
            this.txt_netttl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_netttl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_netttl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_netttl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_netttl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_netttl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_netttl.Location = new System.Drawing.Point(629, 32);
            this.txt_netttl.Name = "txt_netttl";
            this.txt_netttl.ReadOnly = true;
            this.txt_netttl.Size = new System.Drawing.Size(93, 20);
            this.txt_netttl.TabIndex = 73;
            this.txt_netttl.Text = "0";
            this.txt_netttl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(386, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 72;
            this.label8.Text = "Discount:";
            // 
            // txt_ttldisc
            // 
            this.txt_ttldisc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_ttldisc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_ttldisc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ttldisc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_ttldisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ttldisc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_ttldisc.Location = new System.Drawing.Point(460, 31);
            this.txt_ttldisc.Name = "txt_ttldisc";
            this.txt_ttldisc.ReadOnly = true;
            this.txt_ttldisc.Size = new System.Drawing.Size(89, 20);
            this.txt_ttldisc.TabIndex = 71;
            this.txt_ttldisc.Text = "0";
            this.txt_ttldisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_ttlqty
            // 
            this.txt_ttlqty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_ttlqty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_ttlqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ttlqty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_ttlqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ttlqty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_ttlqty.Location = new System.Drawing.Point(102, 30);
            this.txt_ttlqty.Name = "txt_ttlqty";
            this.txt_ttlqty.ReadOnly = true;
            this.txt_ttlqty.Size = new System.Drawing.Size(91, 20);
            this.txt_ttlqty.TabIndex = 67;
            this.txt_ttlqty.Text = "0";
            this.txt_ttlqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(193, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 18);
            this.label17.TabIndex = 70;
            this.label17.Text = "Total Amount :";
            // 
            // txt_ttlamnt
            // 
            this.txt_ttlamnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_ttlamnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_ttlamnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ttlamnt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_ttlamnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ttlamnt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_ttlamnt.Location = new System.Drawing.Point(298, 31);
            this.txt_ttlamnt.Name = "txt_ttlamnt";
            this.txt_ttlamnt.ReadOnly = true;
            this.txt_ttlamnt.Size = new System.Drawing.Size(88, 20);
            this.txt_ttlamnt.TabIndex = 68;
            this.txt_ttlamnt.Text = "0";
            this.txt_ttlamnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 18);
            this.label16.TabIndex = 69;
            this.label16.Text = "Total Qunatity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.PowderBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(822, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 71;
            this.label7.Text = "Total";
            // 
            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.Color.White;
            this.txttotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txttotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txttotal.Location = new System.Drawing.Point(803, 55);
            this.txttotal.Multiline = true;
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(103, 25);
            this.txttotal.TabIndex = 5;
            this.txttotal.Text = "0";
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.PowderBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(602, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 69;
            this.label6.Text = "Rate";
            // 
            // Rate
            // 
            this.Rate.BackColor = System.Drawing.Color.White;
            this.Rate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Rate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Rate.Location = new System.Drawing.Point(574, 56);
            this.Rate.Multiline = true;
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(103, 25);
            this.Rate.TabIndex = 3;
            this.Rate.Text = "0";
            this.Rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Rate.Leave += new System.EventHandler(this.QtyRate_leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PowderBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(496, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 67;
            this.label5.Text = "Qty";
            // 
            // Qty
            // 
            this.Qty.BackColor = System.Drawing.Color.White;
            this.Qty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Qty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Qty.Location = new System.Drawing.Point(465, 56);
            this.Qty.Multiline = true;
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(103, 25);
            this.Qty.TabIndex = 2;
            this.Qty.Text = "0";
            this.Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Qty.Leave += new System.EventHandler(this.QtyRate_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PowderBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(301, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 65;
            this.label4.Text = "Description";
            // 
            // comboprdct
            // 
            this.comboprdct.BackColor = System.Drawing.Color.White;
            this.comboprdct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboprdct.FormattingEnabled = true;
            this.comboprdct.Location = new System.Drawing.Point(22, 48);
            this.comboprdct.Name = "comboprdct";
            this.comboprdct.Size = new System.Drawing.Size(200, 32);
            this.comboprdct.TabIndex = 0;
            // 
            // custCartGrid
            // 
            this.custCartGrid.AllowUserToAddRows = false;
            this.custCartGrid.AllowUserToDeleteRows = false;
            this.custCartGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.custCartGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.custCartGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.custCartGrid.BackgroundColor = System.Drawing.Color.White;
            this.custCartGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.custCartGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.custCartGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.custCartGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.custCartGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.custCartGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.custCartGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.custCartGrid.Location = new System.Drawing.Point(22, 87);
            this.custCartGrid.MultiSelect = false;
            this.custCartGrid.Name = "custCartGrid";
            this.custCartGrid.ReadOnly = true;
            this.custCartGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custCartGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.custCartGrid.Size = new System.Drawing.Size(900, 183);
            this.custCartGrid.TabIndex = 58;
            this.custCartGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.custCartGrid_CellClick);
            this.custCartGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.custCartGrid_CellContentDoubleClick);
            // 
            // tb_AddToCart
            // 
            this.tb_AddToCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_AddToCart.BackColor = System.Drawing.Color.CadetBlue;
            this.tb_AddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_AddToCart.FlatAppearance.BorderSize = 0;
            this.tb_AddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tb_AddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_AddToCart.ForeColor = System.Drawing.Color.White;
            this.tb_AddToCart.Image = ((System.Drawing.Image)(resources.GetObject("tb_AddToCart.Image")));
            this.tb_AddToCart.Location = new System.Drawing.Point(22, 292);
            this.tb_AddToCart.Name = "tb_AddToCart";
            this.tb_AddToCart.Size = new System.Drawing.Size(156, 75);
            this.tb_AddToCart.TabIndex = 6;
            this.tb_AddToCart.Text = "Add Item";
            this.tb_AddToCart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tb_AddToCart.UseVisualStyleBackColor = false;
            this.tb_AddToCart.Click += new System.EventHandler(this.tb_AddToCart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PowderBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(61, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Product Name";
            // 
            // txt_desc
            // 
            this.txt_desc.BackColor = System.Drawing.Color.White;
            this.txt_desc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_desc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desc.Location = new System.Drawing.Point(231, 48);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(231, 33);
            this.txt_desc.TabIndex = 1;
            // 
            // txtno
            // 
            this.txtno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtno.Location = new System.Drawing.Point(12, 156);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(198, 29);
            this.txtno.TabIndex = 89;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(40, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 25);
            this.label13.TabIndex = 88;
            this.label13.Text = "VOUCHER# :";
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(34, 63);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 42);
            this.button4.TabIndex = 92;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.Location = new System.Drawing.Point(485, 37);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(198, 66);
            this.btn_save.TabIndex = 90;
            this.btn_save.Text = "&Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txtsuppname
            // 
            this.txtsuppname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsuppname.BackColor = System.Drawing.Color.White;
            this.txtsuppname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtsuppname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtsuppname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsuppname.Location = new System.Drawing.Point(148, 41);
            this.txtsuppname.Name = "txtsuppname";
            this.txtsuppname.Size = new System.Drawing.Size(138, 26);
            this.txtsuppname.TabIndex = 95;
            // 
            // combo_term
            // 
            this.combo_term.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_term.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.combo_term.FormattingEnabled = true;
            this.combo_term.ItemHeight = 23;
            this.combo_term.Items.AddRange(new object[] {
            "Cash",
            "Credit"});
            this.combo_term.Location = new System.Drawing.Point(148, 117);
            this.combo_term.Name = "combo_term";
            this.combo_term.Size = new System.Drawing.Size(266, 29);
            this.combo_term.TabIndex = 93;
            this.combo_term.UseSelectable = true;
            // 
            // combo_datetime
            // 
            this.combo_datetime.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_datetime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.combo_datetime.Location = new System.Drawing.Point(148, 158);
            this.combo_datetime.MinimumSize = new System.Drawing.Size(0, 29);
            this.combo_datetime.Name = "combo_datetime";
            this.combo_datetime.Size = new System.Drawing.Size(266, 29);
            this.combo_datetime.TabIndex = 94;
            this.combo_datetime.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // Combosupp
            // 
            this.Combosupp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Combosupp.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.Combosupp.FormattingEnabled = true;
            this.Combosupp.ItemHeight = 23;
            this.Combosupp.Location = new System.Drawing.Point(292, 37);
            this.Combosupp.Name = "Combosupp";
            this.Combosupp.Size = new System.Drawing.Size(172, 29);
            this.Combosupp.TabIndex = 91;
            this.Combosupp.UseSelectable = true;
            // 
            // txt_cell
            // 
            this.txt_cell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cell.BackColor = System.Drawing.Color.White;
            this.txt_cell.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_cell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_cell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cell.Location = new System.Drawing.Point(148, 82);
            this.txt_cell.Name = "txt_cell";
            this.txt_cell.Size = new System.Drawing.Size(316, 26);
            this.txt_cell.TabIndex = 92;
            // 
            // btn_fresh
            // 
            this.btn_fresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_fresh.BackgroundImage")));
            this.btn_fresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_fresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fresh.Location = new System.Drawing.Point(128, 63);
            this.btn_fresh.Name = "btn_fresh";
            this.btn_fresh.Size = new System.Drawing.Size(62, 42);
            this.btn_fresh.TabIndex = 98;
            this.btn_fresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_fresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_fresh.UseVisualStyleBackColor = true;
            // 
            // PurchaseVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 680);
            this.Controls.Add(this.btn_fresh);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtno);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.gbx_fetchprdct);
            this.Controls.Add(this.gbox_SupplierInfo);
            this.Name = "PurchaseVoucher";
            this.Text = "Purchase Voucher";
            this.Load += new System.EventHandler(this.PurchaseVoucher_Load);
            this.gbox_SupplierInfo.ResumeLayout(false);
            this.gbox_SupplierInfo.PerformLayout();
            this.gbx_fetchprdct.ResumeLayout(false);
            this.gbx_fetchprdct.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custCartGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox_SupplierInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbx_fetchprdct;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_netttl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ttldisc;
        private System.Windows.Forms.TextBox txt_ttlqty;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_ttlamnt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox Rate;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox Qty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboprdct;
        private System.Windows.Forms.DataGridView custCartGrid;
        private System.Windows.Forms.Button tb_AddToCart;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtdisc;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txtsuppname;
        private MetroFramework.Controls.MetroComboBox combo_term;
        private MetroFramework.Controls.MetroDateTime combo_datetime;
        private MetroFramework.Controls.MetroComboBox Combosupp;
        private System.Windows.Forms.TextBox txt_cell;
        private System.Windows.Forms.Button btn_fresh;
    }
}