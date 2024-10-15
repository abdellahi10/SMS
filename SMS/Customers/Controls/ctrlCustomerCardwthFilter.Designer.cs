namespace SMS.Customers.Controls
{
    partial class ctrlCustomerCardwthFilter
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
            this.lblUpadtePerson = new System.Windows.Forms.Label();
            this.ctrlPersonCard1 = new SMS.People.Controls.ctrlPersonCard();
            this.gbFitter = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.gbFitter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUpadtePerson
            // 
            this.lblUpadtePerson.AutoSize = true;
            this.lblUpadtePerson.BackColor = System.Drawing.Color.Transparent;
            this.lblUpadtePerson.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpadtePerson.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUpadtePerson.Location = new System.Drawing.Point(164, 135);
            this.lblUpadtePerson.Name = "lblUpadtePerson";
            this.lblUpadtePerson.Size = new System.Drawing.Size(87, 17);
            this.lblUpadtePerson.TabIndex = 5;
            this.lblUpadtePerson.Text = "تعديل المعلومات";
            this.lblUpadtePerson.Visible = false;
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCard1.Location = new System.Drawing.Point(18, 114);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(605, 279);
            this.ctrlPersonCard1.TabIndex = 4;
            // 
            // gbFitter
            // 
            this.gbFitter.Controls.Add(this.btnFind);
            this.gbFitter.Controls.Add(this.label1);
            this.gbFitter.Controls.Add(this.txtValue);
            this.gbFitter.Controls.Add(this.cbFilterBy);
            this.gbFitter.Location = new System.Drawing.Point(21, 37);
            this.gbFitter.Name = "gbFitter";
            this.gbFitter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbFitter.Size = new System.Drawing.Size(592, 71);
            this.gbFitter.TabIndex = 3;
            this.gbFitter.TabStop = false;
            this.gbFitter.Text = "فلترة ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(512, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "فلترة بواسطة:";
            // 
            // txtValue
            // 
            this.txtValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.Location = new System.Drawing.Point(118, 25);
            this.txtValue.Multiline = true;
            this.txtValue.Name = "txtValue";
            this.txtValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtValue.Size = new System.Drawing.Size(197, 26);
            this.txtValue.TabIndex = 15;
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "المعرف",
            "الإسم الكامل"});
            this.cbFilterBy.Location = new System.Drawing.Point(321, 25);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbFilterBy.Size = new System.Drawing.Size(176, 26);
            this.cbFilterBy.TabIndex = 14;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // btnFind
            // 
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Image = global::SMS.Properties.Resources.SearchPerson;
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.Location = new System.Drawing.Point(17, 19);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(83, 38);
            this.btnFind.TabIndex = 17;
            this.btnFind.Text = "بحث         ";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // ctrlCustomerCardwthFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblUpadtePerson);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Controls.Add(this.gbFitter);
            this.Name = "ctrlCustomerCardwthFilter";
            this.Size = new System.Drawing.Size(640, 401);
            this.gbFitter.ResumeLayout(false);
            this.gbFitter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpadtePerson;
        private People.Controls.ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.GroupBox gbFitter;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.ComboBox cbFilterBy;
    }
}
