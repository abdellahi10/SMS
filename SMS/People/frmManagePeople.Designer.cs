namespace SMS.People
{
    partial class frmManagePeople
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
            this.dgvPepeole = new System.Windows.Forms.DataGridView();
            this.CmsPeople = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ItemPersonInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemAddNewPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemUpdatePerson = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemDeletePerson = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPepeole)).BeginInit();
            this.CmsPeople.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(872, 553);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "#";
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Font = new System.Drawing.Font("Arial", 12F);
            this.txtFilterValue.Location = new System.Drawing.Point(184, 206);
            this.txtFilterValue.Multiline = true;
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
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
            "الإسم",
            "الإسم العائلي",
            "الجنس",
            "رقم الهاتف",
            "البريد الإلكتروني"});
            this.cbFilterBy.Location = new System.Drawing.Point(57, 206);
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
            this.label1.Location = new System.Drawing.Point(11, 209);
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
            this.lblRecordsCount.Location = new System.Drawing.Point(856, 553);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(19, 22);
            this.lblRecordsCount.TabIndex = 8;
            this.lblRecordsCount.Text = "0";
            // 
            // dgvPepeole
            // 
            this.dgvPepeole.AllowUserToAddRows = false;
            this.dgvPepeole.AllowUserToDeleteRows = false;
            this.dgvPepeole.BackgroundColor = System.Drawing.Color.White;
            this.dgvPepeole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPepeole.ContextMenuStrip = this.CmsPeople;
            this.dgvPepeole.Location = new System.Drawing.Point(11, 244);
            this.dgvPepeole.Name = "dgvPepeole";
            this.dgvPepeole.ReadOnly = true;
            this.dgvPepeole.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvPepeole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPepeole.Size = new System.Drawing.Size(880, 306);
            this.dgvPepeole.TabIndex = 7;
            this.dgvPepeole.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPepeole_CellMouseDown);
            // 
            // CmsPeople
            // 
            this.CmsPeople.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemPersonInfo,
            this.ItemAddNewPerson,
            this.ItemUpdatePerson,
            this.ItemDeletePerson});
            this.CmsPeople.Name = "CmsPeople";
            this.CmsPeople.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmsPeople.Size = new System.Drawing.Size(170, 92);
            // 
            // ItemPersonInfo
            // 
            this.ItemPersonInfo.Image = global::SMS.Properties.Resources.personal_record1;
            this.ItemPersonInfo.Name = "ItemPersonInfo";
            this.ItemPersonInfo.Size = new System.Drawing.Size(169, 22);
            this.ItemPersonInfo.Text = "عرض المعلومات";
            this.ItemPersonInfo.Click += new System.EventHandler(this.ItemPersonInfo_Click);
            // 
            // ItemAddNewPerson
            // 
            this.ItemAddNewPerson.Image = global::SMS.Properties.Resources.add__1_3;
            this.ItemAddNewPerson.Name = "ItemAddNewPerson";
            this.ItemAddNewPerson.Size = new System.Drawing.Size(169, 22);
            this.ItemAddNewPerson.Text = "إضافة شخص جديد ";
            this.ItemAddNewPerson.Click += new System.EventHandler(this.ItemAddNewPerson_Click);
            // 
            // ItemUpdatePerson
            // 
            this.ItemUpdatePerson.Image = global::SMS.Properties.Resources.update2;
            this.ItemUpdatePerson.Name = "ItemUpdatePerson";
            this.ItemUpdatePerson.Size = new System.Drawing.Size(169, 22);
            this.ItemUpdatePerson.Text = "تعديل ";
            this.ItemUpdatePerson.Click += new System.EventHandler(this.ItemUpdatePerson_Click);
            // 
            // ItemDeletePerson
            // 
            this.ItemDeletePerson.Image = global::SMS.Properties.Resources.close2;
            this.ItemDeletePerson.Name = "ItemDeletePerson";
            this.ItemDeletePerson.Size = new System.Drawing.Size(169, 22);
            this.ItemDeletePerson.Text = "حذف ";
            this.ItemDeletePerson.Click += new System.EventHandler(this.ItemDeletePerson_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(178, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(500, 33);
            this.label3.TabIndex = 141;
            this.label3.Text = "ادارة الأشخاص";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmManagePeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(898, 585);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.dgvPepeole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManagePeople";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة الأشخاص";
            this.Load += new System.EventHandler(this.frmManagePeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPepeole)).EndInit();
            this.CmsPeople.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.DataGridView dgvPepeole;
        private System.Windows.Forms.ContextMenuStrip CmsPeople;
        private System.Windows.Forms.ToolStripMenuItem ItemPersonInfo;
        private System.Windows.Forms.ToolStripMenuItem ItemAddNewPerson;
        private System.Windows.Forms.ToolStripMenuItem ItemUpdatePerson;
        private System.Windows.Forms.ToolStripMenuItem ItemDeletePerson;
        private System.Windows.Forms.Label label3;
    }
}