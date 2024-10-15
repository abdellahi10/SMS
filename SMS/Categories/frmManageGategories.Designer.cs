﻿namespace SMS.Categories
{
    partial class frmManageGategories
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
            this.dgvGategories = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.ItemAddnewCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemUpdateCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemDeleteCategory = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGategories)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(535, 493);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "#";
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Font = new System.Drawing.Font("Arial", 12F);
            this.txtFilterValue.Location = new System.Drawing.Point(180, 146);
            this.txtFilterValue.Multiline = true;
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
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
            "المعرف",
            "الإسم"});
            this.cbFilterBy.Location = new System.Drawing.Point(53, 146);
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
            this.label1.Location = new System.Drawing.Point(7, 149);
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
            this.lblRecordsCount.Location = new System.Drawing.Point(510, 493);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(19, 22);
            this.lblRecordsCount.TabIndex = 8;
            this.lblRecordsCount.Text = "0";
            // 
            // dgvGategories
            // 
            this.dgvGategories.AllowUserToAddRows = false;
            this.dgvGategories.AllowUserToDeleteRows = false;
            this.dgvGategories.BackgroundColor = System.Drawing.Color.White;
            this.dgvGategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGategories.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvGategories.Location = new System.Drawing.Point(7, 184);
            this.dgvGategories.Name = "dgvGategories";
            this.dgvGategories.ReadOnly = true;
            this.dgvGategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGategories.Size = new System.Drawing.Size(544, 306);
            this.dgvGategories.TabIndex = 7;
            this.dgvGategories.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvGategories_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemAddnewCategory,
            this.ItemUpdateCategory,
            this.ItemDeleteCategory});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(165, 70);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Lime;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.DarkGray;
            this.linkLabel1.Location = new System.Drawing.Point(468, 154);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.linkLabel1.Size = new System.Drawing.Size(87, 19);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "إدارة المنتجات ";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(7, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(500, 33);
            this.label3.TabIndex = 139;
            this.label3.Text = "إدارة الأصناف";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemAddnewCategory
            // 
            this.ItemAddnewCategory.Image = global::SMS.Properties.Resources.add__1_;
            this.ItemAddnewCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ItemAddnewCategory.Name = "ItemAddnewCategory";
            this.ItemAddnewCategory.Size = new System.Drawing.Size(164, 22);
            this.ItemAddnewCategory.Text = "إضافة صنف جديد ";
            this.ItemAddnewCategory.Click += new System.EventHandler(this.ItemAddnewCategory_Click);
            // 
            // ItemUpdateCategory
            // 
            this.ItemUpdateCategory.Image = global::SMS.Properties.Resources.update;
            this.ItemUpdateCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ItemUpdateCategory.Name = "ItemUpdateCategory";
            this.ItemUpdateCategory.Size = new System.Drawing.Size(164, 22);
            this.ItemUpdateCategory.Text = "تعديل الصنف";
            this.ItemUpdateCategory.Click += new System.EventHandler(this.ItemUpdateCategory_Click);
            // 
            // ItemDeleteCategory
            // 
            this.ItemDeleteCategory.Image = global::SMS.Properties.Resources.close;
            this.ItemDeleteCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ItemDeleteCategory.Name = "ItemDeleteCategory";
            this.ItemDeleteCategory.Size = new System.Drawing.Size(164, 22);
            this.ItemDeleteCategory.Text = "حذف الصنف";
            this.ItemDeleteCategory.Click += new System.EventHandler(this.ItemDeleteCategory_Click);
            // 
            // frmManageGategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(566, 523);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.dgvGategories);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageGategories";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة الأصناف";
            this.Load += new System.EventHandler(this.frmManageGategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGategories)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.DataGridView dgvGategories;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ItemAddnewCategory;
        private System.Windows.Forms.ToolStripMenuItem ItemUpdateCategory;
        private System.Windows.Forms.ToolStripMenuItem ItemDeleteCategory;
        private System.Windows.Forms.Label label3;
    }
}