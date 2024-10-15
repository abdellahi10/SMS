namespace SMS.Sales
{
    partial class frmManageSales
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.cmsSales = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ItemSellerInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemCustomerInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemProductInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemOrderStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.sItemPendding = new System.Windows.Forms.ToolStripMenuItem();
            this.sItemShipped = new System.Windows.Forms.ToolStripMenuItem();
            this.sItemDelivered = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.cmsSales.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(1097, 556);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "#";
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Font = new System.Drawing.Font("Arial", 12F);
            this.txtFilterValue.Location = new System.Drawing.Point(182, 209);
            this.txtFilterValue.Multiline = true;
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(137, 26);
            this.txtFilterValue.TabIndex = 11;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.Font = new System.Drawing.Font("Arial", 12F);
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "لاشيء",
            "رقم العملية",
            "رقم الطلب",
            "رقم البائع",
            "تاريخ الطلب",
            "إسم العميل",
            "إسم المنتج",
            "حالة الطلب"});
            this.cbFilterBy.Location = new System.Drawing.Point(55, 209);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(121, 26);
            this.cbFilterBy.TabIndex = 10;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(9, 212);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(40, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = ":فلترة";
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecordsCount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRecordsCount.Location = new System.Drawing.Point(1081, 556);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(19, 22);
            this.lblRecordsCount.TabIndex = 8;
            this.lblRecordsCount.Text = "0";
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.BackgroundColor = System.Drawing.Color.White;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.ContextMenuStrip = this.cmsSales;
            this.dgvSales.Location = new System.Drawing.Point(9, 247);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            this.dgvSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSales.Size = new System.Drawing.Size(1107, 306);
            this.dgvSales.TabIndex = 7;
            this.dgvSales.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSales_CellMouseDown);
            // 
            // cmsSales
            // 
            this.cmsSales.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemSellerInfo,
            this.ItemCustomerInfo,
            this.ItemProductInfo,
            this.toolStripSeparator1,
            this.ItemOrderStatus});
            this.cmsSales.Name = "cmsSales";
            this.cmsSales.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmsSales.Size = new System.Drawing.Size(156, 98);
            this.cmsSales.Opening += new System.ComponentModel.CancelEventHandler(this.cmsSales_Opening);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // ItemSellerInfo
            // 
            this.ItemSellerInfo.Image = global::SMS.Properties.Resources.personal_record__2_;
            this.ItemSellerInfo.Name = "ItemSellerInfo";
            this.ItemSellerInfo.Size = new System.Drawing.Size(155, 22);
            this.ItemSellerInfo.Text = "معلومات البائع";
            this.ItemSellerInfo.Click += new System.EventHandler(this.ItemSellerInfo_Click);
            // 
            // ItemCustomerInfo
            // 
            this.ItemCustomerInfo.Image = global::SMS.Properties.Resources.personal_record__3_;
            this.ItemCustomerInfo.Name = "ItemCustomerInfo";
            this.ItemCustomerInfo.Size = new System.Drawing.Size(155, 22);
            this.ItemCustomerInfo.Text = "معلومات العميل";
            this.ItemCustomerInfo.Click += new System.EventHandler(this.ItemCustomerInfo_Click);
            // 
            // ItemProductInfo
            // 
            this.ItemProductInfo.Image = global::SMS.Properties.Resources.personal_record__1_;
            this.ItemProductInfo.Name = "ItemProductInfo";
            this.ItemProductInfo.Size = new System.Drawing.Size(155, 22);
            this.ItemProductInfo.Text = "معلومات المنتج";
            this.ItemProductInfo.Click += new System.EventHandler(this.ItemProductInfo_Click);
            // 
            // ItemOrderStatus
            // 
            this.ItemOrderStatus.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sItemPendding,
            this.sItemShipped,
            this.sItemDelivered});
            this.ItemOrderStatus.Image = global::SMS.Properties.Resources.status_away;
            this.ItemOrderStatus.Name = "ItemOrderStatus";
            this.ItemOrderStatus.Size = new System.Drawing.Size(155, 22);
            this.ItemOrderStatus.Text = "حالة الطلب";
            // 
            // sItemPendding
            // 
            this.sItemPendding.Enabled = false;
            this.sItemPendding.Image = global::SMS.Properties.Resources.waiting_room;
            this.sItemPendding.Name = "sItemPendding";
            this.sItemPendding.Size = new System.Drawing.Size(180, 22);
            this.sItemPendding.Text = "قيد الأنتظار";
            // 
            // sItemShipped
            // 
            this.sItemShipped.Image = global::SMS.Properties.Resources.delivery_motorcycle;
            this.sItemShipped.Name = "sItemShipped";
            this.sItemShipped.Size = new System.Drawing.Size(180, 22);
            this.sItemShipped.Text = "تم الشحن";
            this.sItemShipped.Click += new System.EventHandler(this.sItemShipped_Click);
            // 
            // sItemDelivered
            // 
            this.sItemDelivered.Enabled = false;
            this.sItemDelivered.Image = global::SMS.Properties.Resources.delivery_package;
            this.sItemDelivered.Name = "sItemDelivered";
            this.sItemDelivered.Size = new System.Drawing.Size(180, 22);
            this.sItemDelivered.Text = "تم التوصيل";
            this.sItemDelivered.Click += new System.EventHandler(this.sItemDelivered_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(284, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(500, 33);
            this.label3.TabIndex = 142;
            this.label3.Text = "إدارة المبيعات";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmManageSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1124, 595);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.txtFilterValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageSales";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة المبيعات";
            this.Load += new System.EventHandler(this.frmManageSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.cmsSales.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.ContextMenuStrip cmsSales;
        private System.Windows.Forms.ToolStripMenuItem ItemCustomerInfo;
        private System.Windows.Forms.ToolStripMenuItem ItemProductInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ItemOrderStatus;
        private System.Windows.Forms.ToolStripMenuItem sItemPendding;
        private System.Windows.Forms.ToolStripMenuItem sItemShipped;
        private System.Windows.Forms.ToolStripMenuItem sItemDelivered;
        private System.Windows.Forms.ToolStripMenuItem ItemSellerInfo;
        private System.Windows.Forms.Label label3;
    }
}