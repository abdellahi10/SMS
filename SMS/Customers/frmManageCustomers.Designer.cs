namespace SMS.Customers
{
    partial class frmManageCustomers
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
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.cmCustomers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ItemShowCustomerInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemAddnewCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemUpadteCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemDeleteCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.cmCustomers.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(616, 525);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "#";
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Font = new System.Drawing.Font("Arial", 12F);
            this.txtFilterValue.Location = new System.Drawing.Point(192, 175);
            this.txtFilterValue.Multiline = true;
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFilterValue.Size = new System.Drawing.Size(137, 26);
            this.txtFilterValue.TabIndex = 23;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.Font = new System.Drawing.Font("Arial", 12F);
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "لاشيء",
            "المعرف",
            "الإسم الكامل",
            "الجنس",
            "تاريخ الإنشاء"});
            this.cbFilterBy.Location = new System.Drawing.Point(65, 175);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(121, 26);
            this.cbFilterBy.TabIndex = 22;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 179);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = ":فلترة";
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecordsCount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRecordsCount.Location = new System.Drawing.Point(600, 525);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(19, 22);
            this.lblRecordsCount.TabIndex = 20;
            this.lblRecordsCount.Text = "0";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.ContextMenuStrip = this.cmCustomers;
            this.dgvCustomers.Location = new System.Drawing.Point(12, 213);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(623, 306);
            this.dgvCustomers.TabIndex = 19;
            this.dgvCustomers.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCustomers_CellMouseDown);
            // 
            // cmCustomers
            // 
            this.cmCustomers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemShowCustomerInfo,
            this.ItemAddnewCustomer,
            this.ItemUpadteCustomer,
            this.ItemDeleteCustomer});
            this.cmCustomers.Name = "cmCustomers";
            this.cmCustomers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmCustomers.Size = new System.Drawing.Size(193, 92);
            // 
            // ItemShowCustomerInfo
            // 
            this.ItemShowCustomerInfo.Image = global::SMS.Properties.Resources.personal_record;
            this.ItemShowCustomerInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ItemShowCustomerInfo.Name = "ItemShowCustomerInfo";
            this.ItemShowCustomerInfo.Size = new System.Drawing.Size(192, 22);
            this.ItemShowCustomerInfo.Text = "عرض المعلومات العميل";
            this.ItemShowCustomerInfo.Click += new System.EventHandler(this.ItemShowCustomerInfo_Click);
            // 
            // ItemAddnewCustomer
            // 
            this.ItemAddnewCustomer.Image = global::SMS.Properties.Resources.add__1_2;
            this.ItemAddnewCustomer.Name = "ItemAddnewCustomer";
            this.ItemAddnewCustomer.Size = new System.Drawing.Size(192, 22);
            this.ItemAddnewCustomer.Text = "إضافة عميل جديد";
            this.ItemAddnewCustomer.Click += new System.EventHandler(this.ItemAddnewCustomer_Click);
            // 
            // ItemUpadteCustomer
            // 
            this.ItemUpadteCustomer.Image = global::SMS.Properties.Resources.update1;
            this.ItemUpadteCustomer.Name = "ItemUpadteCustomer";
            this.ItemUpadteCustomer.Size = new System.Drawing.Size(192, 22);
            this.ItemUpadteCustomer.Text = "تحديث";
            this.ItemUpadteCustomer.Click += new System.EventHandler(this.ItemUpadteCustomer_Click);
            // 
            // ItemDeleteCustomer
            // 
            this.ItemDeleteCustomer.Image = global::SMS.Properties.Resources.close1;
            this.ItemDeleteCustomer.Name = "ItemDeleteCustomer";
            this.ItemDeleteCustomer.Size = new System.Drawing.Size(192, 22);
            this.ItemDeleteCustomer.Text = "حذف ";
            this.ItemDeleteCustomer.Click += new System.EventHandler(this.ItemDeleteCustomer_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(59, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(500, 33);
            this.label3.TabIndex = 140;
            this.label3.Text = "إدارة العملاء";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmManageCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(647, 556);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.dgvCustomers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageCustomers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة العملاء";
            this.Load += new System.EventHandler(this.frmManageCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.cmCustomers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.ContextMenuStrip cmCustomers;
        private System.Windows.Forms.ToolStripMenuItem ItemShowCustomerInfo;
        private System.Windows.Forms.ToolStripMenuItem ItemAddnewCustomer;
        private System.Windows.Forms.ToolStripMenuItem ItemUpadteCustomer;
        private System.Windows.Forms.ToolStripMenuItem ItemDeleteCustomer;
        private System.Windows.Forms.Label label3;
    }
}