using SMS.People.Controls;
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
    public partial class frmManageCustomers : Form
    {

        private int _CustomeID = -1;

        private DataTable _dtCustomers; 
        DataTable EditData(DataTable data)
        {
            data.Columns[0].ColumnName = "المعرف";
            data.Columns[1].ColumnName = "الإسم الكامل";
            data.Columns[2].ColumnName = "الجنس";
            data.Columns[3].ColumnName = "تاريخ الإنشاء";
            return data;
        }

        private void _RefereshCustomersList()
        {
            _dtCustomers = EditData(ClsCustomer.GetAllCustomers());

            dgvCustomers.DataSource = _dtCustomers;
            lblRecordsCount.Text = dgvCustomers.Rows.Count.ToString();
            cbFilterBy.SelectedIndex = 0;

            if (dgvCustomers.Rows.Count > 0)
            {

                dgvCustomers.DefaultCellStyle.Font = new Font("Arial", 12);
                dgvCustomers.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);


                // "المعرف";
                dgvCustomers.Columns[0].Width = 100;
                // "الإسم الكامل";
                dgvCustomers.Columns[1].Width = 210;
                // "الجنس";
                dgvCustomers.Columns[2].Width = 100;
                // "تاريخ الإنشاء";
                dgvCustomers.Columns[3].Width = 170;
            }
            else
            {
                MessageBox.Show("لا توجد بيانات لعرضها", "لم يتم العثور البيانات", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        public frmManageCustomers()
        {
            InitializeComponent();
        }

        private void frmManageCustomers_Load(object sender, EventArgs e)
        {
            _RefereshCustomersList();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //StringBuilder sFilterColumn = new StringBuilder();

            //Map Selected Filter to real Column name 
            switch (cbFilterBy.Text)
            {
                case "المعرف":
                    FilterColumn = "المعرف";
                    break;

                case "الإسم الكامل":
                    FilterColumn = "الإسم الكامل";
                    break;

                case "الجنس":
                    FilterColumn = "الجنس";
                    break;

                case "تاريخ الإنشاء":
                    FilterColumn = "تاريخ الإنشاء";
                    break;

                default:
                    FilterColumn = "لاشيء";
                    break;
            }


            //Reset the filters in case nothing selected or filter value conains nothing.
            if (string.IsNullOrEmpty(txtFilterValue.Text) || FilterColumn == "لاشيء")
            {
                _dtCustomers.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvCustomers.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "المعرف" /*|| FilterColumn == "تاريخ الإنشاء"*/)
                //in this case we deal with integer not string.
                _dtCustomers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtCustomers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = dgvCustomers.Rows.Count.ToString();
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

        private void dgvCustomers_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            _CustomeID = Convert.ToInt32(dgvCustomers.CurrentRow.Cells[0].Value);
        }

        private void ItemShowCustomerInfo_Click(object sender, EventArgs e)
        {
            frmCustomerInfo CustomerInfo = new frmCustomerInfo(_CustomeID);
            CustomerInfo.ShowDialog();
        }

        private void ItemAddnewCustomer_Click(object sender, EventArgs e)
        {
            frmAddNewUpdateCustomer AddNewCutomer = new frmAddNewUpdateCustomer();
            AddNewCutomer.ShowDialog();
            _RefereshCustomersList();
        }

        private void ItemUpadteCustomer_Click(object sender, EventArgs e)
        {
            frmAddNewUpdateCustomer UpdateCustomer = new frmAddNewUpdateCustomer(_CustomeID);
            UpdateCustomer.ShowDialog();
            _RefereshCustomersList();
        }

        private void ItemDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد أنك تريد حذف هذا العميل من النظام؟", "متأكد؟",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                // Consider By Growing The Sysytem or Maybe in The Future the User Could Intigrate With Crtain Data
                // or Manipulate some Validation Users

                if (!ClsCustomer.IsCustomerExist(_CustomeID))
                {
                    MessageBox.Show("!لايمكنك حذف هذا العميل لأن هناك معلومات مرتبطة به", "غير مسموح؟",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                    return;
                }

                if (ClsCustomer.DeleteCustomer(_CustomeID))
                {
                    MessageBox.Show("!تم الحذف بنجاح", "تم",
                       MessageBoxButtons.YesNo, MessageBoxIcon.None);

                    _RefereshCustomersList();
                }
                else
                {
                    MessageBox.Show("لم يتم الحذف بنجاح هناك مشكلة", "خطأ",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }

            }
        }
    }
}
