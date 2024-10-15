namespace SMS.Products
{
    partial class frmShowProductInfo
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
            this.ctrShowProductInfo1 = new SMS.Products.Controls.ctrShowProductInfo();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrShowProductInfo1
            // 
            this.ctrShowProductInfo1.BackColor = System.Drawing.Color.White;
            this.ctrShowProductInfo1.Location = new System.Drawing.Point(2, 1);
            this.ctrShowProductInfo1.Name = "ctrShowProductInfo1";
            this.ctrShowProductInfo1.Size = new System.Drawing.Size(710, 297);
            this.ctrShowProductInfo1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.Image = global::SMS.Properties.Resources.close__1_4;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(12, 294);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 44);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "خروج       ";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmShowProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(713, 345);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrShowProductInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowProductInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "معلومات المنتج";
            this.Load += new System.EventHandler(this.frmShowProductInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrShowProductInfo ctrShowProductInfo1;
        private System.Windows.Forms.Button btnClose;
    }
}