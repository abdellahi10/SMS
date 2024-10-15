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

namespace SMS.Users.Controls
{
    public partial class ctrlUserCard : UserControl
    {

       
        public ctrlUserCard()
        {
            InitializeComponent();
        }

        ClsUser User = new ClsUser();

        public void LoadUserInfo(int UserID)
        {
            User = ClsUser.GetUserInfoByID(UserID);

            if (User == null)
            {
                MessageBox.Show("هذا المستخدم غير موجود", "غير موجود", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            // Should Use Try-Cacth to Validate ctrlPersonCard1. But Ensure There no User without Person Connected Person
            ctrlPersonCard1.LoadInfo(User.PersonID);

            lblUserID.Text = User.UserID.ToString();
            lblUsername.Text = User.UserName;
            lblUserRole.Text = User.UserRole == 0 ? "مستخدم عادي" : "مدير";
            lblIsActive.Text = User.IsActive ? "نشط" : "مقيد";

        }

        public void LoadUserInfo(string UserName)
        {
            User = ClsUser.GetUserInfoByUserName(UserName);

            if (User == null)
            {
                MessageBox.Show("هذا المستخدم غير موجود", "غير موجود", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            // Should Use Try-Cacth to Validate ctrlPersonCard1. But Ensure There no User without Person Connected Person
            ctrlPersonCard1.LoadInfo(User.PersonID);

            lblUserID.Text = User.UserID.ToString();
            lblUsername.Text = User.UserName;
            lblUserRole.Text = User.UserRole == 0 ? "مستخدم عادي" : "مدير";
            lblIsActive.Text = User.IsActive ? "نشط"  : "مقيد";
            
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
