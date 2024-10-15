using SMS_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SMS.Categories
{
    public partial class frmAddNewCategory : Form
    {
        enum enMode {AddNew, Update }
        enMode _Mode;

        ClsCategory _Category;

        int _CategoryID = -1;

        public frmAddNewCategory()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddNewCategory(int CategoryID)
        {
            InitializeComponent();
            _CategoryID = CategoryID;
            _Mode = enMode.Update;
        }

        private void _ResetDefualtValues()
        {
           
            if (_Mode == enMode.AddNew)
            {
                this.Text = "إضافة صنف جديد";
               _Category = new ClsCategory();
            }
            else
            {
                this.Text = "تحديث الصنف ";
            }

            groupBox1.Text = this.Text;

            lblCategoryID.Text = "";
            txtCategoryName.Text = "";
        }

        private void _LoadData()
        {

            _Category = ClsCategory.GetCategoryInfoByID(_CategoryID);

            if (_Category == null)
            {
                MessageBox.Show("لايوجد معرف بهذا الرقم = " + _CategoryID, "الصنف غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lblCategoryID.Text = _Category.CategoryID.ToString();
            txtCategoryName.Text = _Category.CategoryName.ToString();
        }

        private void frmAddNewCategory_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoryName.Text))
            {
                MessageBox.Show("!خانة الإسم لايجب أن تكون فارغة", "تحقق من الأخطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Category.CategoryName = txtCategoryName.Text;

            if (_Category.Save())
            {
                lblCategoryID.Text = _Category.CategoryID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                this.Text = "تحديث المنتج";

                MessageBox.Show(".تم الحفظ بنجاح", "تم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // Trigger the event to send data back to the caller form.
                //DataBack?.Invoke(this, _Person.PersonID);
            }
            else
                MessageBox.Show("خطأ: لم يتم الحفظ هناك مشكلة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            groupBox1.Text = this.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
