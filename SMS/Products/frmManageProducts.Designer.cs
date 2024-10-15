namespace SMS.Products
{
    partial class frmManageProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageProducts));
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.cmsProducts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemAddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.SellProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemProductInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.cmsProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.ContextMenuStrip = this.cmsProducts;
            resources.ApplyResources(this.dgvProducts, "dgvProducts");
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProducts_CellMouseDown);
            // 
            // cmsProducts
            // 
            this.cmsProducts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemProductInfo,
            this.toolStripSeparator1,
            this.SellProduct,
            this.toolStripSeparator2,
            this.ItemAddNew,
            this.ItemEdit,
            this.ItemDelete});
            this.cmsProducts.Name = "cmsProducts";
            resources.ApplyResources(this.cmsProducts, "cmsProducts");
            this.cmsProducts.Opening += new System.ComponentModel.CancelEventHandler(this.cmsProducts_Opening);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // lblRecordsCount
            // 
            resources.ApplyResources(this.lblRecordsCount, "lblRecordsCount");
            this.lblRecordsCount.Name = "lblRecordsCount";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cbFilterBy
            // 
            resources.ApplyResources(this.cbFilterBy, "cbFilterBy");
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            resources.GetString("cbFilterBy.Items"),
            resources.GetString("cbFilterBy.Items1"),
            resources.GetString("cbFilterBy.Items2"),
            resources.GetString("cbFilterBy.Items3"),
            resources.GetString("cbFilterBy.Items4"),
            resources.GetString("cbFilterBy.Items5"),
            resources.GetString("cbFilterBy.Items6")});
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            resources.ApplyResources(this.txtFilterValue, "txtFilterValue");
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // ItemDelete
            // 
            this.ItemDelete.Image = global::SMS.Properties.Resources.close3;
            this.ItemDelete.Name = "ItemDelete";
            resources.ApplyResources(this.ItemDelete, "ItemDelete");
            this.ItemDelete.Click += new System.EventHandler(this.ItemDelete_Click);
            // 
            // ItemEdit
            // 
            this.ItemEdit.Image = global::SMS.Properties.Resources.update4;
            this.ItemEdit.Name = "ItemEdit";
            resources.ApplyResources(this.ItemEdit, "ItemEdit");
            this.ItemEdit.Click += new System.EventHandler(this.ItemEdit_Click);
            // 
            // ItemAddNew
            // 
            this.ItemAddNew.Image = global::SMS.Properties.Resources.add__1_5;
            this.ItemAddNew.Name = "ItemAddNew";
            resources.ApplyResources(this.ItemAddNew, "ItemAddNew");
            this.ItemAddNew.Click += new System.EventHandler(this.ItemAddNew_Click);
            // 
            // SellProduct
            // 
            this.SellProduct.Image = global::SMS.Properties.Resources.credit_cards__1_;
            this.SellProduct.Name = "SellProduct";
            resources.ApplyResources(this.SellProduct, "SellProduct");
            this.SellProduct.Click += new System.EventHandler(this.SellProduct_Click);
            // 
            // ItemProductInfo
            // 
            this.ItemProductInfo.Image = global::SMS.Properties.Resources.personal_record2;
            this.ItemProductInfo.Name = "ItemProductInfo";
            resources.ApplyResources(this.ItemProductInfo, "ItemProductInfo");
            this.ItemProductInfo.Click += new System.EventHandler(this.ItemProductInfo_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Name = "label3";
            // 
            // frmManageProducts
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.dgvProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageProducts";
            this.Load += new System.EventHandler(this.frmManageProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.cmsProducts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip cmsProducts;
        private System.Windows.Forms.ToolStripMenuItem ItemProductInfo;
        private System.Windows.Forms.ToolStripMenuItem ItemAddNew;
        private System.Windows.Forms.ToolStripMenuItem ItemEdit;
        private System.Windows.Forms.ToolStripMenuItem ItemDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SellProduct;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label label3;
    }
}