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
    public partial class frmManageUsers : Form
    {
        private int _UserID = -1;

        private DataTable _dtUsers;  /* = clsPerson.GetAllPeople();*/
        DataTable EditData(DataTable data)
        {
            data.Columns[0].ColumnName = "المعرف";
            data.Columns[1].ColumnName = "الإسم الكامل";
            data.Columns[2].ColumnName = "الصلاحيات";
            data.Columns[3].ColumnName = "الوضع الحالي";
            return data;
        }

        private void _RefereshUsersList()
        {
            _dtUsers = EditData(ClsUser.GetAllUsers());

            dgvUsers.DataSource = _dtUsers;
            lblRecordsCount.Text = dgvUsers.Rows.Count.ToString();
            cbFilterBy.SelectedIndex = 0;

            if (dgvUsers.Rows.Count > 0)
            {

                dgvUsers.DefaultCellStyle.Font = new Font("Arial", 12);
                dgvUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);


                // "المعرف";
                dgvUsers.Columns[0].Width = 100;
                // "الإسم الكامل";
                dgvUsers.Columns[1].Width = 200;
                // "الصلاحيات";
                dgvUsers.Columns[2].Width = 120;
                // "الوضع الحالي";
                dgvUsers.Columns[3].Width = 120;
            }
            else
            {
                MessageBox.Show("لا توجد بيانات لعرضها", "لم يتم العثور البيانات", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        public frmManageUsers()
        {
            InitializeComponent();
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _RefereshUsersList();
            
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            //Map Selected Filter to real Column name 
            switch (cbFilterBy.Text)
            {
                case "المعرف":
                    FilterColumn = "المعرف";
                    break;

                case "الإسم الكامل":
                    FilterColumn = "الإسم الكامل";
                    break;

                case "الصلاحيات":
                    FilterColumn = "الصلاحيات";
                    break;

                case "الوضع الحالي":
                    FilterColumn = "الوضع الحالي";
                    break;

                default:
                    FilterColumn = "لاشيء";
                    break;
            }


            //Reset the filters in case nothing selected or filter value conains nothing.
            if (string.IsNullOrEmpty(txtFilterValue.Text) || FilterColumn == "لاشيء")
            {
                _dtUsers.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvUsers.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "المعرف" /*|| FilterColumn == "الصلاحيات"*/)
                //in this case we deal with integer not string.
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = dgvUsers.Rows.Count.ToString();
        }

        private void ItemShowUserInfo_Click(object sender, EventArgs e)
        {
            frmUserInfo UserInfo = new frmUserInfo(_UserID);
            UserInfo.ShowDialog();
        }

        private void dgvUsers_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            _UserID = Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value);
        }

        private void ItemAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddNewUpdateUser AddNewUser = new frmAddNewUpdateUser();
            AddNewUser.ShowDialog();
            _RefereshUsersList();

        }

        private void ItemUpdateUser_Click(object sender, EventArgs e)
        {
            frmAddNewUpdateUser UpdateUser = new frmAddNewUpdateUser(_UserID);
            UpdateUser.ShowDialog();
            _RefereshUsersList();

        }

        private void ItemDeleteUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد أنك تريد حذف هذا المستخدم من النظام؟", "متأكد؟",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                // Consider By Growing The Sysytem or Maybe in The Future the User Could Intigrate With Crtain Data
                // or Manipulate some Validation Users

                /*if ()
                {
                    MessageBox.Show("!لايمكنك حذف هذا المستخدم لأن هناك معلومات مرتبطة به", "غير مسموح؟",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                    return;
                }*/

                if (ClsUser.DeleteUser(_UserID))
                {
                    MessageBox.Show("!تم الحذف بنجاح", "تم",
                       MessageBoxButtons.YesNo, MessageBoxIcon.None);

                    _RefereshUsersList();
                }
                else
                {
                    MessageBox.Show("لم يتم الحذف بنجاح هناك مشكلة", "خطأ",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }

            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "لاشيء");

            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }
    }
}
