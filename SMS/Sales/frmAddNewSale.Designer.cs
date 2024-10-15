namespace SMS.Sales
{
    partial class frmAddNewSale
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
            this.btnAddNewCustomer = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPage1UserID = new System.Windows.Forms.Label();
            this.lblPage1DateID = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblPage1OrderID = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblPage1CutomerID = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOrderedByUserID = new System.Windows.Forms.Label();
            this.lblOderDate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmProductQuantity = new System.Windows.Forms.ComboBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductDecscription = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.pcCustomerImage = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.pcProductImage = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcCustomerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewCustomer.Location = new System.Drawing.Point(161, 233);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewCustomer.TabIndex = 145;
            this.btnAddNewCustomer.Text = "إضف العميل";
            this.btnAddNewCustomer.UseVisualStyleBackColor = true;
            this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(22, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 443);
            this.tabControl1.TabIndex = 148;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(777, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "معالجة الطلب";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPage1UserID);
            this.groupBox2.Controls.Add(this.btnAddNewCustomer);
            this.groupBox2.Controls.Add(this.lblPage1DateID);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.pcCustomerImage);
            this.groupBox2.Controls.Add(this.lblPage1OrderID);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.lblPage1CutomerID);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox2.Location = new System.Drawing.Point(53, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(686, 289);
            this.groupBox2.TabIndex = 146;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "الطلب";
            // 
            // lblPage1UserID
            // 
            this.lblPage1UserID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPage1UserID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblPage1UserID.ForeColor = System.Drawing.Color.Black;
            this.lblPage1UserID.Location = new System.Drawing.Point(412, 143);
            this.lblPage1UserID.Name = "lblPage1UserID";
            this.lblPage1UserID.Size = new System.Drawing.Size(122, 18);
            this.lblPage1UserID.TabIndex = 148;
            this.lblPage1UserID.Text = "A/N";
            this.lblPage1UserID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPage1DateID
            // 
            this.lblPage1DateID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPage1DateID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblPage1DateID.ForeColor = System.Drawing.Color.Black;
            this.lblPage1DateID.Location = new System.Drawing.Point(388, 196);
            this.lblPage1DateID.Name = "lblPage1DateID";
            this.lblPage1DateID.Size = new System.Drawing.Size(146, 18);
            this.lblPage1DateID.TabIndex = 147;
            this.lblPage1DateID.Text = "A/N";
            this.lblPage1DateID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(567, 141);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(72, 22);
            this.label12.TabIndex = 146;
            this.label12.Text = "رقم البائع:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(567, 196);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(56, 22);
            this.label13.TabIndex = 145;
            this.label13.Text = "التاريخ:";
            // 
            // lblPage1OrderID
            // 
            this.lblPage1OrderID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPage1OrderID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblPage1OrderID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPage1OrderID.Location = new System.Drawing.Point(388, 33);
            this.lblPage1OrderID.Name = "lblPage1OrderID";
            this.lblPage1OrderID.Size = new System.Drawing.Size(146, 18);
            this.lblPage1OrderID.TabIndex = 130;
            this.lblPage1OrderID.Text = "A/N";
            this.lblPage1OrderID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(570, 31);
            this.label19.Name = "label19";
            this.label19.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label19.Size = new System.Drawing.Size(75, 22);
            this.label19.TabIndex = 131;
            this.label19.Text = "رقم الطلب:";
            // 
            // lblPage1CutomerID
            // 
            this.lblPage1CutomerID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPage1CutomerID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblPage1CutomerID.ForeColor = System.Drawing.Color.Black;
            this.lblPage1CutomerID.Location = new System.Drawing.Point(388, 90);
            this.lblPage1CutomerID.Name = "lblPage1CutomerID";
            this.lblPage1CutomerID.Size = new System.Drawing.Size(146, 18);
            this.lblPage1CutomerID.TabIndex = 139;
            this.lblPage1CutomerID.Text = "A/N";
            this.lblPage1CutomerID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(570, 86);
            this.label21.Name = "label21";
            this.label21.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label21.Size = new System.Drawing.Size(78, 22);
            this.label21.TabIndex = 133;
            this.label21.Text = "رقم العميل:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(777, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "عملية البيع";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblOrderedByUserID);
            this.groupBox1.Controls.Add(this.lblOderDate);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmProductQuantity);
            this.groupBox1.Controls.Add(this.lblTotalPrice);
            this.groupBox1.Controls.Add(this.lblOrderID);
            this.groupBox1.Controls.Add(this.lblProductPrice);
            this.groupBox1.Controls.Add(this.lblProductDecscription);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblCustomerID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblProductID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.pcProductImage);
            this.groupBox1.Location = new System.Drawing.Point(15, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(744, 348);
            this.groupBox1.TabIndex = 145;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الفاتورة";
            // 
            // lblOrderedByUserID
            // 
            this.lblOrderedByUserID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblOrderedByUserID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblOrderedByUserID.ForeColor = System.Drawing.Color.Black;
            this.lblOrderedByUserID.Location = new System.Drawing.Point(24, 309);
            this.lblOrderedByUserID.Name = "lblOrderedByUserID";
            this.lblOrderedByUserID.Size = new System.Drawing.Size(65, 18);
            this.lblOrderedByUserID.TabIndex = 148;
            this.lblOrderedByUserID.Text = "A/N";
            this.lblOrderedByUserID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOderDate
            // 
            this.lblOderDate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblOderDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblOderDate.ForeColor = System.Drawing.Color.Black;
            this.lblOderDate.Location = new System.Drawing.Point(173, 311);
            this.lblOderDate.Name = "lblOderDate";
            this.lblOderDate.Size = new System.Drawing.Size(185, 18);
            this.lblOderDate.TabIndex = 147;
            this.lblOderDate.Text = "A/N";
            this.lblOderDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(95, 309);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(72, 22);
            this.label9.TabIndex = 146;
            this.label9.Text = "رقم البائع:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(364, 309);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(56, 22);
            this.label8.TabIndex = 145;
            this.label8.Text = "التاريخ:";
            // 
            // cmProductQuantity
            // 
            this.cmProductQuantity.FormattingEnabled = true;
            this.cmProductQuantity.Location = new System.Drawing.Point(486, 265);
            this.cmProductQuantity.Name = "cmProductQuantity";
            this.cmProductQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmProductQuantity.Size = new System.Drawing.Size(121, 21);
            this.cmProductQuantity.TabIndex = 137;
            this.cmProductQuantity.SelectedIndexChanged += new System.EventHandler(this.cmProductQuantity_SelectedIndexChanged);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTotalPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPrice.Location = new System.Drawing.Point(477, 311);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(125, 18);
            this.lblTotalPrice.TabIndex = 143;
            this.lblTotalPrice.Text = "A/N";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOrderID
            // 
            this.lblOrderID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblOrderID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblOrderID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOrderID.Location = new System.Drawing.Point(456, 45);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(146, 18);
            this.lblOrderID.TabIndex = 130;
            this.lblOrderID.Text = "A/N";
            this.lblOrderID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblProductPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblProductPrice.ForeColor = System.Drawing.Color.Black;
            this.lblProductPrice.Location = new System.Drawing.Point(456, 221);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(146, 18);
            this.lblProductPrice.TabIndex = 140;
            this.lblProductPrice.Text = "A/N";
            this.lblProductPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProductDecscription
            // 
            this.lblProductDecscription.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblProductDecscription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblProductDecscription.ForeColor = System.Drawing.Color.Black;
            this.lblProductDecscription.Location = new System.Drawing.Point(456, 177);
            this.lblProductDecscription.Name = "lblProductDecscription";
            this.lblProductDecscription.Size = new System.Drawing.Size(146, 18);
            this.lblProductDecscription.TabIndex = 142;
            this.lblProductDecscription.Text = "A/N";
            this.lblProductDecscription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(635, 89);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 132;
            this.label2.Text = "رقم المنتج:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(638, 45);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 131;
            this.label1.Text = "رقم الطلب:";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblCustomerID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblCustomerID.ForeColor = System.Drawing.Color.Black;
            this.lblCustomerID.Location = new System.Drawing.Point(456, 133);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(146, 18);
            this.lblCustomerID.TabIndex = 139;
            this.lblCustomerID.Text = "A/N";
            this.lblCustomerID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(635, 133);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 133;
            this.label3.Text = "رقم العميل:";
            // 
            // lblProductID
            // 
            this.lblProductID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblProductID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblProductID.ForeColor = System.Drawing.Color.Black;
            this.lblProductID.Location = new System.Drawing.Point(456, 89);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(146, 18);
            this.lblProductID.TabIndex = 138;
            this.lblProductID.Text = "A/N";
            this.lblProductID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(635, 177);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(95, 22);
            this.label7.TabIndex = 141;
            this.label7.Text = "وصف المنتج:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(638, 221);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 134;
            this.label4.Text = "سعر المنتج:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(638, 265);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(51, 22);
            this.label5.TabIndex = 135;
            this.label5.Text = "الكمية:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(638, 309);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(105, 22);
            this.label6.TabIndex = 136;
            this.label6.Text = "السعر الإجمالي:";
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::SMS.Properties.Resources.close__1_5;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(22, 457);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 39);
            this.btnClose.TabIndex = 147;
            this.btnClose.Text = "خروج          ";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnNext.Image = global::SMS.Properties.Resources.image1;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(53, 324);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(86, 38);
            this.btnNext.TabIndex = 148;
            this.btnNext.Text = "التالي        ";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pcCustomerImage
            // 
            this.pcCustomerImage.Location = new System.Drawing.Point(36, 31);
            this.pcCustomerImage.Name = "pcCustomerImage";
            this.pcCustomerImage.Size = new System.Drawing.Size(346, 187);
            this.pcCustomerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcCustomerImage.TabIndex = 144;
            this.pcCustomerImage.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::SMS.Properties.Resources.Save_324;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(15, 371);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 37);
            this.btnSave.TabIndex = 146;
            this.btnSave.Text = "حفظ         ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pcProductImage
            // 
            this.pcProductImage.Location = new System.Drawing.Point(24, 45);
            this.pcProductImage.Name = "pcProductImage";
            this.pcProductImage.Size = new System.Drawing.Size(392, 242);
            this.pcProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcProductImage.TabIndex = 144;
            this.pcProductImage.TabStop = false;
            // 
            // frmAddNewSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(829, 503);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddNewSale";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " عملية البيع";
            this.Load += new System.EventHandler(this.frmAddNewSale_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcCustomerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcProductImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddNewCustomer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblPage1UserID;
        private System.Windows.Forms.Label lblPage1DateID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pcCustomerImage;
        private System.Windows.Forms.Label lblPage1OrderID;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblPage1CutomerID;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblOrderedByUserID;
        private System.Windows.Forms.Label lblOderDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pcProductImage;
        private System.Windows.Forms.ComboBox cmProductQuantity;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductDecscription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNext;
    }
}