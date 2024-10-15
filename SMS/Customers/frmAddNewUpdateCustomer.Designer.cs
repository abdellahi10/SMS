namespace SMS.Customers
{
    partial class frmAddNewUpdateCustomer
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlPersonCardWithFiltter1 = new SMS.People.Controls.ctrlPersonCardWithFiltter();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblUpdateCostomerTitle = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCraetedByUserID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(3, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(634, 43);
            this.lblTitle.TabIndex = 133;
            this.lblTitle.Tag = "تحديث معلومات المستخدم";
            this.lblTitle.Text = "إضافة عميل جديد ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(7, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(624, 436);
            this.tabControl1.TabIndex = 134;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Controls.Add(this.ctrlPersonCardWithFiltter1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(616, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "معلومات الشخص";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = global::SMS.Properties.Resources.image;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(24, 363);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(98, 41);
            this.btnNext.TabIndex = 18;
            this.btnNext.Text = "التالي       ";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlPersonCardWithFiltter1
            // 
            this.ctrlPersonCardWithFiltter1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCardWithFiltter1.Location = new System.Drawing.Point(9, 3);
            this.ctrlPersonCardWithFiltter1.Name = "ctrlPersonCardWithFiltter1";
            this.ctrlPersonCardWithFiltter1.Size = new System.Drawing.Size(603, 363);
            this.ctrlPersonCardWithFiltter1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblFullName);
            this.tabPage2.Controls.Add(this.lblUpdateCostomerTitle);
            this.tabPage2.Controls.Add(this.lblCustomerID);
            this.tabPage2.Controls.Add(this.lblDate);
            this.tabPage2.Controls.Add(this.lblCraetedByUserID);
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(616, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "معلومات العميل";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblFullName
            // 
            this.lblFullName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblFullName.Location = new System.Drawing.Point(125, 236);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFullName.Size = new System.Drawing.Size(214, 26);
            this.lblFullName.TabIndex = 140;
            this.lblFullName.Tag = "";
            this.lblFullName.Text = "N/A";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFullName.Visible = false;
            this.lblFullName.Click += new System.EventHandler(this.lblFullName_Click);
            // 
            // lblUpdateCostomerTitle
            // 
            this.lblUpdateCostomerTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateCostomerTitle.ForeColor = System.Drawing.Color.Black;
            this.lblUpdateCostomerTitle.Location = new System.Drawing.Point(345, 236);
            this.lblUpdateCostomerTitle.Name = "lblUpdateCostomerTitle";
            this.lblUpdateCostomerTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUpdateCostomerTitle.Size = new System.Drawing.Size(157, 26);
            this.lblUpdateCostomerTitle.TabIndex = 139;
            this.lblUpdateCostomerTitle.Tag = "";
            this.lblUpdateCostomerTitle.Text = "تحديث معلومات السيد:";
            this.lblUpdateCostomerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUpdateCostomerTitle.Visible = false;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.ForeColor = System.Drawing.Color.Black;
            this.lblCustomerID.Location = new System.Drawing.Point(314, 59);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCustomerID.Size = new System.Drawing.Size(147, 26);
            this.lblCustomerID.TabIndex = 137;
            this.lblCustomerID.Tag = "";
            this.lblCustomerID.Text = "N/A";
            this.lblCustomerID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(341, 99);
            this.lblDate.Name = "lblDate";
            this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDate.Size = new System.Drawing.Size(120, 24);
            this.lblDate.TabIndex = 136;
            this.lblDate.Tag = "";
            this.lblDate.Text = "00/00/0000";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCraetedByUserID
            // 
            this.lblCraetedByUserID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCraetedByUserID.ForeColor = System.Drawing.Color.Black;
            this.lblCraetedByUserID.Location = new System.Drawing.Point(314, 133);
            this.lblCraetedByUserID.Name = "lblCraetedByUserID";
            this.lblCraetedByUserID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCraetedByUserID.Size = new System.Drawing.Size(147, 26);
            this.lblCraetedByUserID.TabIndex = 134;
            this.lblCraetedByUserID.Tag = "تحديث معلومات المستخدم";
            this.lblCraetedByUserID.Text = "N/A";
            this.lblCraetedByUserID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::SMS.Properties.Resources.Save_322;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(509, 368);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 36);
            this.btnSave.TabIndex = 130;
            this.btnSave.Text = "حفظ         ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(468, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 22);
            this.label2.TabIndex = 121;
            this.label2.Text = "بواسطة المستخدم :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(468, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 120;
            this.label1.Text = "تاريخ الإنشاء :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(469, 63);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(67, 22);
            this.label22.TabIndex = 118;
            this.label22.Text = "المعرف :";
            // 
            // frmAddNewUpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 549);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddNewUpdateCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة / تعيل عميل";
            this.Load += new System.EventHandler(this.frmAddNewUpdateCustomer_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnNext;
        private People.Controls.ctrlPersonCardWithFiltter ctrlPersonCardWithFiltter1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblCraetedByUserID;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblUpdateCostomerTitle;
        private System.Windows.Forms.Label lblFullName;
    }
}