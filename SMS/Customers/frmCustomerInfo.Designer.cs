namespace SMS.Customers
{
    partial class frmCustomerInfo
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
            this.ctrlConstomerCard1 = new SMS.Customers.Controls.ctrlConstomerCard();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlConstomerCard1
            // 
            this.ctrlConstomerCard1.BackColor = System.Drawing.Color.White;
            this.ctrlConstomerCard1.Location = new System.Drawing.Point(-3, -1);
            this.ctrlConstomerCard1.Name = "ctrlConstomerCard1";
            this.ctrlConstomerCard1.Size = new System.Drawing.Size(610, 363);
            this.ctrlConstomerCard1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::SMS.Properties.Resources.close__1_1;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(498, 361);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 42);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "خروج      ";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmCustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(608, 414);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlConstomerCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCustomerInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = " المعلومات العميل";
            this.Load += new System.EventHandler(this.frmCustomerInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrlConstomerCard ctrlConstomerCard1;
        private System.Windows.Forms.Button btnClose;
    }
}