using SMS.Global_Classes;
using SMS_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.Users
{
    public partial class frmAddNewUpdateUser : Form
    {
       

        enum enMode { Addnew = 0, Update = 1 }
        enMode _Mode;

        //  bool IsValidate = true;
        int _UserID;

        ClsUser _User = new ClsUser();

        public frmAddNewUpdateUser()
        {
            InitializeComponent(); 
            _Mode = enMode.Addnew;
        }

        public frmAddNewUpdateUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _Mode = enMode.Update;
        }

        void _ResetDefaultValues()
        {
            if (_Mode == enMode.Update)
                lblTitle.Text = "تحديث معلومات المستخدم";
            else
                lblTitle.Text = "إضافة مستخدم جديد";

            txtUserName.Text = string.Empty;
            cbUserRole.SelectedIndex = 0;
            txtPassword.Text = string.Empty;
            rbnYes.Checked = true;

        }

        void LoadUserInfo()
        {

            _User = ClsUser.GetUserInfoByID(_UserID);

            if(_User == null)
            {
                MessageBox.Show($" في النظام [{_UserID}] لا يوجد مستخدم بهذاالمعرف", "لا يوجد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblUserID.Text = _User.UserID.ToString();
            txtUserName.Text = _User.UserName.ToString();
            cbUserRole.SelectedIndex = _User.UserRole;
            txtPassword.Enabled = false;
            if (_User.IsActive)
                rbnYes.Checked = true;
            else
                rbnNo.Checked = true;

            ctrlPersonCardWithFiltter1.FindPerson(_User.PersonInfo.PersonID);
            ctrlPersonCardWithFiltter1.DisableFiltter();
        }

        private void frmAddNewUpdateUser_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
                LoadUserInfo();

        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (tabControl1.SelectedIndex == 0 || _Mode == enMode.Update)
                return;

            if (!ctrlPersonCardWithFiltter1.isFound())
            {
                MessageBox.Show("! إبحث اولا عن الشخص المطلوب", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabControl1.DeselectTab(1);
              //  IsValidate = false;
                return;
            }
            else
            {

                if (ClsCustomer.IsThisPersonCustomer(ctrlPersonCardWithFiltter1.PersonID))
                {
                    MessageBox.Show("هذا الشخص لايمكنه ان يكون مستخدم بأي حال من الأحوال لأنه عميل", "هذا الإجراء مخالف للسياسات ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tabControl1.DeselectTab(1);
                    return;
                }

                if (ClsUser.IsPersonUser(ctrlPersonCardWithFiltter1.PersonID))
                {
                    MessageBox.Show("هذا الشخص لديه مستخدم بالفعل ولايمكن ربطه بحساب آخر ", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tabControl1.DeselectTab(1);
                    return;
                }
              //  IsValidate = true;
            }


        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (!IsValidate)
            //    return;

            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("بعض الحقول لاتلتزم بالشروط\n!وجه الفأرة على الخانة الحمراء لترى الخطأ", "خطأ التحقق",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.PersonID = ctrlPersonCardWithFiltter1.PersonID; 
            _User.UserName = txtUserName.Text;
            _User.UserRole = (byte)cbUserRole.SelectedIndex;
            _User.Password = ClsCrypto.EcryptByHash(txtPassword.Text);
            _User.IsActive = rbnYes.Checked ? true : false;


            if (_User.Save())
            {
                lblUserID.Text = _User.UserID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                lblTitle.Text = "تحديث معلومات المستخدم";

                MessageBox.Show(".تم الجفظ بنجاح", "تم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show(".خطأ:لم يتم حفظ البيانات بنجاح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);




        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            if (!txtPassword.Enabled)
                return;

            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            TextBox Temp = ((TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "هذا الحقل مطلوب *");
            }
            else
            {
                errorProvider1.SetError(Temp, null);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (_Mode == enMode.Update)
                return;

            if (ClsUser.IsUserExist(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "لايمكنك استخدام هذا الإسم فهو يتبع لمستخدم آخر");
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            }
        }

        
    }
}
