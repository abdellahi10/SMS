using SMS.Global_Classes;
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

namespace SMS.Users
{
    public partial class frmChangePassword : Form
    {

        int _userID;
        ClsUser _user;
        public frmChangePassword(int User)
        {
            InitializeComponent();
            _userID = User;
        }

        void _ResetDefulatValues()
        {
            txtCurrentPassword.Text = "";
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtCurrentPassword.Focus();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _ResetDefulatValues();

            _user = ClsUser.GetUserInfoByID(_userID);

            if(_user == null)
            {
                MessageBox.Show($" [{_userID}] لم يتم العثور المستخدم رقم  ",
                   "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

                return;
            }

            ctrlUserCard1.LoadUserInfo(_userID);
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtCurrentPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "خانة كلمة السر الحالية لايمكن أن تكون فارغة");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, null);
            };


            if (_user.Password.Trim() != ClsCrypto.EcryptByHash(txtCurrentPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "كلمة السر الحالية غير صحيحة!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, null);
            };
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword, "خانة كلمة السر الجديدة لايمكن أن تكون فارغة");
            }
            else
            {
                errorProvider1.SetError(txtNewPassword, null);
            };
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPassword.Text.Trim() != txtNewPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "تأكيد كلمة السر لا تطابق كلمة السر الجديدة");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("بعض الحقول لاتلتزم بالشروط\n!وجه الفأرة على الخانة الحمراء لترى الخطأ", "خطأ التحقق",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _user.Password = ClsCrypto.EcryptByHash(txtNewPassword.Text);

            if (_user.Save())
            {
                MessageBox.Show("تم تغيير كلمة السر بنجاح",
                   "تمت.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ResetDefulatValues();
            }
            else
            {
                MessageBox.Show("حدث خطأ, لم يتم تغير كلمة المرور.",
                   "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
