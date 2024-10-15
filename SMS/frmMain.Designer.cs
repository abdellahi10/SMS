namespace SMS
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemAccountSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMyInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemChangPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ItemDataSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.إنشاءنسخةإحتياطيةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.إستعادةنسخةمحفوظةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemSales = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemManageProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemAddNewProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemManageCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemAddnewCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemPepole = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PcPeople = new System.Windows.Forms.PictureBox();
            this.pcUsers = new System.Windows.Forms.PictureBox();
            this.pcCutomers = new System.Windows.Forms.PictureBox();
            this.pcProducts = new System.Windows.Forms.PictureBox();
            this.pcOrders = new System.Windows.Forms.PictureBox();
            this.picSales = new System.Windows.Forms.PictureBox();
            this.lblPeople = new System.Windows.Forms.Label();
            this.lblUsers = new System.Windows.Forms.Label();
            this.lblCutomers = new System.Windows.Forms.Label();
            this.lblSales = new System.Windows.Forms.Label();
            this.lblOrders = new System.Windows.Forms.Label();
            this.lblProsucts = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCutomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSales)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemSettings,
            this.ItemSales,
            this.ItemProducts,
            this.ItemCategory,
            this.ItemUsers,
            this.ItemPepole,
            this.ItemCustomers,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1240, 80);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ItemSettings
            // 
            this.ItemSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemAccountSettings,
            this.toolStripSeparator1,
            this.ItemDataSettings});
            this.ItemSettings.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemSettings.Image = global::SMS.Properties.Resources.account_settings_642;
            this.ItemSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ItemSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ItemSettings.Name = "ItemSettings";
            this.ItemSettings.Size = new System.Drawing.Size(152, 76);
            this.ItemSettings.Text = "الإعدادات";
            // 
            // ItemAccountSettings
            // 
            this.ItemAccountSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemMyInfo,
            this.ItemChangPassword,
            this.ItemSignOut});
            this.ItemAccountSettings.Image = global::SMS.Properties.Resources.account_settings1;
            this.ItemAccountSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ItemAccountSettings.Name = "ItemAccountSettings";
            this.ItemAccountSettings.Size = new System.Drawing.Size(259, 78);
            this.ItemAccountSettings.Text = "اعدادات الحساب ";
            // 
            // ItemMyInfo
            // 
            this.ItemMyInfo.Name = "ItemMyInfo";
            this.ItemMyInfo.Size = new System.Drawing.Size(188, 24);
            this.ItemMyInfo.Text = "معلوماتي";
            this.ItemMyInfo.Click += new System.EventHandler(this.ItemMyInfo_Click);
            // 
            // ItemChangPassword
            // 
            this.ItemChangPassword.Name = "ItemChangPassword";
            this.ItemChangPassword.Size = new System.Drawing.Size(188, 24);
            this.ItemChangPassword.Text = "تغير كلمة السر";
            this.ItemChangPassword.Click += new System.EventHandler(this.ItemChangPassword_Click);
            // 
            // ItemSignOut
            // 
            this.ItemSignOut.Name = "ItemSignOut";
            this.ItemSignOut.Size = new System.Drawing.Size(188, 24);
            this.ItemSignOut.Text = "تسجيل الخروج";
            this.ItemSignOut.Click += new System.EventHandler(this.ItemSignOut_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(256, 6);
            // 
            // ItemDataSettings
            // 
            this.ItemDataSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.إنشاءنسخةإحتياطيةToolStripMenuItem,
            this.إستعادةنسخةمحفوظةToolStripMenuItem});
            this.ItemDataSettings.Image = global::SMS.Properties.Resources.database_development;
            this.ItemDataSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ItemDataSettings.Name = "ItemDataSettings";
            this.ItemDataSettings.Size = new System.Drawing.Size(259, 78);
            this.ItemDataSettings.Text = "البيانات";
            // 
            // إنشاءنسخةإحتياطيةToolStripMenuItem
            // 
            this.إنشاءنسخةإحتياطيةToolStripMenuItem.Name = "إنشاءنسخةإحتياطيةToolStripMenuItem";
            this.إنشاءنسخةإحتياطيةToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.إنشاءنسخةإحتياطيةToolStripMenuItem.Text = "إنشاء نسخة إحتياطية";
            // 
            // إستعادةنسخةمحفوظةToolStripMenuItem
            // 
            this.إستعادةنسخةمحفوظةToolStripMenuItem.Name = "إستعادةنسخةمحفوظةToolStripMenuItem";
            this.إستعادةنسخةمحفوظةToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.إستعادةنسخةمحفوظةToolStripMenuItem.Text = "إستعادة نسخة محفوظة";
            // 
            // ItemSales
            // 
            this.ItemSales.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemSales.Image = global::SMS.Properties.Resources.sales__1_;
            this.ItemSales.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ItemSales.Name = "ItemSales";
            this.ItemSales.Size = new System.Drawing.Size(159, 76);
            this.ItemSales.Text = " المبيعات";
            this.ItemSales.Click += new System.EventHandler(this.ItemSales_Click);
            // 
            // ItemProducts
            // 
            this.ItemProducts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemManageProducts,
            this.ItemAddNewProduct});
            this.ItemProducts.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemProducts.Image = global::SMS.Properties.Resources.inventory_categories1;
            this.ItemProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ItemProducts.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ItemProducts.Name = "ItemProducts";
            this.ItemProducts.Size = new System.Drawing.Size(157, 76);
            this.ItemProducts.Text = "المنتجات";
            // 
            // ItemManageProducts
            // 
            this.ItemManageProducts.Name = "ItemManageProducts";
            this.ItemManageProducts.Size = new System.Drawing.Size(207, 24);
            this.ItemManageProducts.Text = "إدارة المنتجات ";
            this.ItemManageProducts.Click += new System.EventHandler(this.ItemManageProducts_Click);
            // 
            // ItemAddNewProduct
            // 
            this.ItemAddNewProduct.Name = "ItemAddNewProduct";
            this.ItemAddNewProduct.Size = new System.Drawing.Size(207, 24);
            this.ItemAddNewProduct.Text = "إضافة منتج جديد ";
            this.ItemAddNewProduct.Click += new System.EventHandler(this.ItemAddNewProduct_Click);
            // 
            // ItemCategory
            // 
            this.ItemCategory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemManageCategories,
            this.ItemAddnewCategory});
            this.ItemCategory.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCategory.Image = global::SMS.Properties.Resources.categories;
            this.ItemCategory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ItemCategory.Name = "ItemCategory";
            this.ItemCategory.Size = new System.Drawing.Size(150, 76);
            this.ItemCategory.Text = "الأصناف";
            // 
            // ItemManageCategories
            // 
            this.ItemManageCategories.Name = "ItemManageCategories";
            this.ItemManageCategories.Size = new System.Drawing.Size(210, 24);
            this.ItemManageCategories.Text = "إدارة الأصناف";
            this.ItemManageCategories.Click += new System.EventHandler(this.ItemManageCategories_Click);
            // 
            // ItemAddnewCategory
            // 
            this.ItemAddnewCategory.Name = "ItemAddnewCategory";
            this.ItemAddnewCategory.Size = new System.Drawing.Size(210, 24);
            this.ItemAddnewCategory.Text = "إضافة صنف جديد ";
            this.ItemAddnewCategory.Click += new System.EventHandler(this.ItemAddnewCategory_Click);
            // 
            // ItemUsers
            // 
            this.ItemUsers.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemUsers.Image = global::SMS.Properties.Resources.users;
            this.ItemUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ItemUsers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ItemUsers.Name = "ItemUsers";
            this.ItemUsers.Size = new System.Drawing.Size(188, 76);
            this.ItemUsers.Text = "المستخدمين";
            this.ItemUsers.Click += new System.EventHandler(this.ItemUsers_Click);
            // 
            // ItemPepole
            // 
            this.ItemPepole.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemPepole.Image = global::SMS.Properties.Resources.human_resources;
            this.ItemPepole.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ItemPepole.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ItemPepole.Name = "ItemPepole";
            this.ItemPepole.Size = new System.Drawing.Size(166, 76);
            this.ItemPepole.Text = "الأشخاص";
            this.ItemPepole.Click += new System.EventHandler(this.ItemPepole_Click);
            // 
            // ItemCustomers
            // 
            this.ItemCustomers.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCustomers.Image = global::SMS.Properties.Resources.customers;
            this.ItemCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ItemCustomers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ItemCustomers.Name = "ItemCustomers";
            this.ItemCustomers.Size = new System.Drawing.Size(146, 76);
            this.ItemCustomers.Text = "العملاء ";
            this.ItemCustomers.Click += new System.EventHandler(this.ItemCustomers_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 76);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(12, 76);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1240, 405);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // PcPeople
            // 
            this.PcPeople.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.PcPeople.Image = ((System.Drawing.Image)(resources.GetObject("PcPeople.Image")));
            this.PcPeople.Location = new System.Drawing.Point(333, 210);
            this.PcPeople.Name = "PcPeople";
            this.PcPeople.Size = new System.Drawing.Size(165, 121);
            this.PcPeople.TabIndex = 20;
            this.PcPeople.TabStop = false;
            // 
            // pcUsers
            // 
            this.pcUsers.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.pcUsers.Image = ((System.Drawing.Image)(resources.GetObject("pcUsers.Image")));
            this.pcUsers.Location = new System.Drawing.Point(576, 210);
            this.pcUsers.Name = "pcUsers";
            this.pcUsers.Size = new System.Drawing.Size(165, 121);
            this.pcUsers.TabIndex = 21;
            this.pcUsers.TabStop = false;
            // 
            // pcCutomers
            // 
            this.pcCutomers.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.pcCutomers.Image = ((System.Drawing.Image)(resources.GetObject("pcCutomers.Image")));
            this.pcCutomers.Location = new System.Drawing.Point(818, 210);
            this.pcCutomers.Name = "pcCutomers";
            this.pcCutomers.Size = new System.Drawing.Size(165, 121);
            this.pcCutomers.TabIndex = 22;
            this.pcCutomers.TabStop = false;
            // 
            // pcProducts
            // 
            this.pcProducts.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.pcProducts.Image = ((System.Drawing.Image)(resources.GetObject("pcProducts.Image")));
            this.pcProducts.Location = new System.Drawing.Point(333, 388);
            this.pcProducts.Name = "pcProducts";
            this.pcProducts.Size = new System.Drawing.Size(165, 121);
            this.pcProducts.TabIndex = 23;
            this.pcProducts.TabStop = false;
            // 
            // pcOrders
            // 
            this.pcOrders.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.pcOrders.Image = ((System.Drawing.Image)(resources.GetObject("pcOrders.Image")));
            this.pcOrders.Location = new System.Drawing.Point(576, 388);
            this.pcOrders.Name = "pcOrders";
            this.pcOrders.Size = new System.Drawing.Size(165, 121);
            this.pcOrders.TabIndex = 24;
            this.pcOrders.TabStop = false;
            // 
            // picSales
            // 
            this.picSales.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.picSales.Image = ((System.Drawing.Image)(resources.GetObject("picSales.Image")));
            this.picSales.Location = new System.Drawing.Point(818, 388);
            this.picSales.Name = "picSales";
            this.picSales.Size = new System.Drawing.Size(165, 121);
            this.picSales.TabIndex = 25;
            this.picSales.TabStop = false;
            // 
            // lblPeople
            // 
            this.lblPeople.AutoSize = true;
            this.lblPeople.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.lblPeople.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeople.Location = new System.Drawing.Point(363, 248);
            this.lblPeople.Name = "lblPeople";
            this.lblPeople.Size = new System.Drawing.Size(22, 23);
            this.lblPeople.TabIndex = 26;
            this.lblPeople.Text = "0";
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.lblUsers.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.Location = new System.Drawing.Point(612, 248);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(22, 23);
            this.lblUsers.TabIndex = 27;
            this.lblUsers.Text = "0";
            // 
            // lblCutomers
            // 
            this.lblCutomers.AutoSize = true;
            this.lblCutomers.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.lblCutomers.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCutomers.Location = new System.Drawing.Point(854, 248);
            this.lblCutomers.Name = "lblCutomers";
            this.lblCutomers.Size = new System.Drawing.Size(22, 23);
            this.lblCutomers.TabIndex = 28;
            this.lblCutomers.Text = "0";
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.lblSales.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSales.Location = new System.Drawing.Point(854, 430);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(22, 23);
            this.lblSales.TabIndex = 29;
            this.lblSales.Text = "0";
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.lblOrders.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrders.Location = new System.Drawing.Point(612, 430);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(22, 23);
            this.lblOrders.TabIndex = 30;
            this.lblOrders.Text = "0";
            // 
            // lblProsucts
            // 
            this.lblProsucts.AutoSize = true;
            this.lblProsucts.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.lblProsucts.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProsucts.Location = new System.Drawing.Point(363, 430);
            this.lblProsucts.Name = "lblProsucts";
            this.lblProsucts.Size = new System.Drawing.Size(22, 23);
            this.lblProsucts.TabIndex = 31;
            this.lblProsucts.Text = "0";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1240, 485);
            this.Controls.Add(this.lblProsucts);
            this.Controls.Add(this.lblOrders);
            this.Controls.Add(this.lblSales);
            this.Controls.Add(this.lblCutomers);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.lblPeople);
            this.Controls.Add(this.picSales);
            this.Controls.Add(this.pcOrders);
            this.Controls.Add(this.pcProducts);
            this.Controls.Add(this.pcCutomers);
            this.Controls.Add(this.pcUsers);
            this.Controls.Add(this.PcPeople);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الرئيسية";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCutomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ItemSettings;
        private System.Windows.Forms.ToolStripMenuItem ItemAccountSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ItemDataSettings;
        private System.Windows.Forms.ToolStripMenuItem إنشاءنسخةإحتياطيةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem إستعادةنسخةمحفوظةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ItemCustomers;
        private System.Windows.Forms.ToolStripMenuItem ItemSales;
        private System.Windows.Forms.ToolStripMenuItem ItemUsers;
        private System.Windows.Forms.ToolStripMenuItem ItemCategory;
        private System.Windows.Forms.ToolStripMenuItem ItemProducts;
        private System.Windows.Forms.ToolStripMenuItem ItemAddNewProduct;
        private System.Windows.Forms.ToolStripMenuItem ItemManageProducts;
        private System.Windows.Forms.ToolStripMenuItem ItemManageCategories;
        private System.Windows.Forms.ToolStripMenuItem ItemAddnewCategory;
        private System.Windows.Forms.ToolStripMenuItem ItemPepole;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ItemMyInfo;
        private System.Windows.Forms.ToolStripMenuItem ItemChangPassword;
        private System.Windows.Forms.ToolStripMenuItem ItemSignOut;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PcPeople;
        private System.Windows.Forms.PictureBox pcUsers;
        private System.Windows.Forms.PictureBox pcCutomers;
        private System.Windows.Forms.PictureBox pcProducts;
        private System.Windows.Forms.PictureBox pcOrders;
        private System.Windows.Forms.PictureBox picSales;
        private System.Windows.Forms.Label lblPeople;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Label lblCutomers;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.Label lblProsucts;
    }
}