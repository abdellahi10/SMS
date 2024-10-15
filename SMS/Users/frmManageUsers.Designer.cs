namespace SMS.Users
{
    partial class frmManageUsers
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.cmbUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ItemShowUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemAddNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemUpdateUser = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.cmbUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(569, 525);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "#";
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Font = new System.Drawing.Font("Arial", 12F);
            this.txtFilterValue.Location = new System.Drawing.Point(192, 177);
            this.txtFilterValue.Multiline = true;
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFilterValue.Size = new System.Drawing.Size(137, 26);
            this.txtFilterValue.TabIndex = 17;
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
            "الصلاحيات",
            "الوضع الحالي"});
            this.cbFilterBy.Location = new System.Drawing.Point(65, 177);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(121, 26);
            this.cbFilterBy.TabIndex = 16;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 180);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = ":فلترة";
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecordsCount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRecordsCount.Location = new System.Drawing.Point(553, 525);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(19, 22);
            this.lblRecordsCount.TabIndex = 14;
            this.lblRecordsCount.Text = "0";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.ContextMenuStrip = this.cmbUsers;
            this.dgvUsers.Location = new System.Drawing.Point(5, 215);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(583, 306);
            this.dgvUsers.TabIndex = 13;
            this.dgvUsers.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUsers_CellMouseDown);
            // 
            // cmbUsers
            // 
            this.cmbUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemShowUserInfo,
            this.ItemAddNewUser,
            this.ItemUpdateUser,
            this.ItemDeleteUser});
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbUsers.Size = new System.Drawing.Size(208, 92);
            // 
            // ItemShowUserInfo
            // 
            this.ItemShowUserInfo.Image = global::SMS.Properties.Resources.personal_record__1_1;
            this.ItemShowUserInfo.Name = "ItemShowUserInfo";
            this.ItemShowUserInfo.Size = new System.Drawing.Size(207, 22);
            this.ItemShowUserInfo.Text = "عرض المعلومات المستخدم";
            this.ItemShowUserInfo.Click += new System.EventHandler(this.ItemShowUserInfo_Click);
            // 
            // ItemAddNewUser
            // 
            this.ItemAddNewUser.Image = global::SMS.Properties.Resources.add__1_6;
            this.ItemAddNewUser.Name = "ItemAddNewUser";
            this.ItemAddNewUser.Size = new System.Drawing.Size(207, 22);
            this.ItemAddNewUser.Text = "إضافة مستخدم جديد";
            this.ItemAddNewUser.Click += new System.EventHandler(this.ItemAddNewUser_Click);
            // 
            // ItemUpdateUser
            // 
            this.ItemUpdateUser.Image = global::SMS.Properties.Resources.update5;
            this.ItemUpdateUser.Name = "ItemUpdateUser";
            this.ItemUpdateUser.Size = new System.Drawing.Size(207, 22);
            this.ItemUpdateUser.Text = "تحديث";
            this.ItemUpdateUser.Click += new System.EventHandler(this.ItemUpdateUser_Click);
            // 
            // ItemDeleteUser
            // 
            this.ItemDeleteUser.Image = global::SMS.Properties.Resources.close4;
            this.ItemDeleteUser.Name = "ItemDeleteUser";
            this.ItemDeleteUser.Size = new System.Drawing.Size(207, 22);
            this.ItemDeleteUser.Text = "حذف ";
            this.ItemDeleteUser.Click += new System.EventHandler(this.ItemDeleteUser_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(32, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(500, 33);
            this.label3.TabIndex = 143;
            this.label3.Text = "إدارة المستخدمين";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(592, 556);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.dgvUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageUsers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة المستخدمين";
            this.Load += new System.EventHandler(this.frmManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.cmbUsers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.ContextMenuStrip cmbUsers;
        private System.Windows.Forms.ToolStripMenuItem ItemShowUserInfo;
        private System.Windows.Forms.ToolStripMenuItem ItemAddNewUser;
        private System.Windows.Forms.ToolStripMenuItem ItemUpdateUser;
        private System.Windows.Forms.ToolStripMenuItem ItemDeleteUser;
        private System.Windows.Forms.Label label3;
    }
}