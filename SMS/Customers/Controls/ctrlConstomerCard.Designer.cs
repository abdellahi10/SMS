namespace SMS.Customers.Controls
{
    partial class ctrlConstomerCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlPersonCard1 = new SMS.People.Controls.ctrlPersonCard();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblCreatedDate);
            this.groupBox1.Controls.Add(this.lblCustomerID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(584, 67);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المعلومات العميل";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(158, 28);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 134;
            this.label4.Text = "تاريخ الإنشاء:";
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblCreatedDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblCreatedDate.ForeColor = System.Drawing.Color.Black;
            this.lblCreatedDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCreatedDate.Location = new System.Drawing.Point(24, 31);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(118, 18);
            this.lblCreatedDate.TabIndex = 135;
            this.lblCreatedDate.Text = "A/N";
            this.lblCreatedDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblCustomerID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblCustomerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCustomerID.Location = new System.Drawing.Point(299, 29);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(146, 18);
            this.lblCustomerID.TabIndex = 128;
            this.lblCustomerID.Text = "A/N";
            this.lblCustomerID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, 27);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 129;
            this.label1.Text = "معرف العميل:";
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCard1.Location = new System.Drawing.Point(3, 3);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(603, 280);
            this.ctrlPersonCard1.TabIndex = 0;
            // 
            // ctrlConstomerCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Name = "ctrlConstomerCard";
            this.Size = new System.Drawing.Size(610, 363);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private People.Controls.ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label label1;
    }
}
