using SMS.Global_Classes;
using SMS.People;
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

namespace SMS.Customers
{
    public partial class frmAddNewUpdateCustomer : Form
    {
        enum enMode { Addnew = 0, Update = 1 }
        enMode _Mode;

        int _CustomerID;

        ClsCustomer _Customer = new ClsCustomer();

        public frmAddNewUpdateCustomer()
        {
            InitializeComponent();
            _Mode = enMode.Addnew;
        }

        public frmAddNewUpdateCustomer(int CustomerID)
        {
            InitializeComponent();
            _CustomerID = CustomerID;
            _Mode = enMode.Update;
        }

        void _ResetDefaultValues()
        {
            if (_Mode == enMode.Update)
                lblTitle.Text = "تحديث معلومات العميل";
            else
                lblTitle.Text = "إضافة عميل جديد";

            lblDate.Text = ClsFormat.ShortDate(DateTime.Now);
            lblCraetedByUserID.Text = clsGlobal.CurrentUser.UserID.ToString();

        }

        void LoadCustomerInfo()
        {

            _Customer = ClsCustomer.GetCustomerInfoByID(_CustomerID);

            if (_Customer == null)
            {
                MessageBox.Show($" في النظام [{_Customer}] لا يوجد عميل بهذاالمعرف", "لا يوجد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblCustomerID.Text = _Customer.CustomerID.ToString();
            lblDate.Text = _Customer.CreatedDate.ToString();
            lblCraetedByUserID.Text = _Customer.CreatedByUserID.ToString();

            ctrlPersonCardWithFiltter1.FindPerson(_Customer.PersonID);
            ctrlPersonCardWithFiltter1.DisableFiltter();
            lblUpdateCostomerTitle.Visible = true;

            lblFullName.Visible = true;
            lblUpdateCostomerTitle.Text = _Customer.PersonInfo.Gendor == 0 ? "تحديث معلومات السيد:" : "تحديث معلومات السيدة:";
            lblFullName.Text = _Customer.FullName.ToString();

            btnSave.Enabled = false;

        }

        private void frmAddNewUpdateCustomer_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
                LoadCustomerInfo();
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {

            
            if (tabControl1.SelectedIndex == 0 || _Mode == enMode.Update)
                return;

            if (!ctrlPersonCardWithFiltter1.isFound())
            {
                MessageBox.Show("! إبحث اولا عن الشخص المطلوب", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabControl1.DeselectTab(1);
                return;
            }
            else
            {
                if (ClsUser.IsPersonUser(ctrlPersonCardWithFiltter1.PersonID))
                {
                    MessageBox.Show("هذا لايمكنه ان يكون عميل بأي حال من الأحوال لأنه مستخدم", "هذا الإجراء مخالف للسياسات ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tabControl1.DeselectTab(1);
                    return;
                }

                if (ClsCustomer.IsThisPersonCustomer(ctrlPersonCardWithFiltter1.PersonID))
                {
                    MessageBox.Show("هذا الشخص لديه عميل بالفعل ولايمكن ربطه بحساب عميل آخر ", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tabControl1.DeselectTab(1);
                    return;
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /*if (!this.ValidateChildren())
            //{
            //    //Here we dont continue becuase the form is not valid
            //    MessageBox.Show("بعض الحقول لاتلتزم بالشروط\n!وجه الفأرة على الخانة الحمراء لترى الخطأ", "خطأ التحقق",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}*/

            _Customer.PersonID = ctrlPersonCardWithFiltter1.PersonID;
            _Customer.CreatedDate = Convert.ToDateTime(lblDate.Text);
            _Customer.CreatedByUserID = Convert.ToInt32(lblCraetedByUserID.Text);
            
            if (_Customer.Save())
            {
                lblCustomerID.Text = _Customer.CustomerID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                lblTitle.Text = "تحديث معلومات العميل";

                MessageBox.Show(".تم الجفظ بنجاح", "تم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show(".خطأ:لم يتم حفظ البيانات بنجاح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void lblFullName_Click(object sender, EventArgs e)
        {
            frmAddnewUpdatePerson UpdatePerson = new frmAddnewUpdatePerson(_Customer.PersonInfo.PersonID);
            UpdatePerson.ShowDialog();
        }
    }
}
