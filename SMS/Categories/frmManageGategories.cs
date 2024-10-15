using SMS.Products;
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

namespace SMS.Categories
{
    public partial class frmManageGategories : Form
    {
        private int _GategoryID = -1;

        private DataTable _dtGategories = ClsCategory.GetAllCategories();

        DataTable EditData(DataTable data)
        {
            data.Columns[0].ColumnName = "المعرف";
            data.Columns[1].ColumnName = "الإسم";
           
            return data;
        }

        private void _RefereshGategoryList()
        {

            _dtGategories = EditData(ClsCategory.GetAllCategories());

            dgvGategories.DataSource = _dtGategories;
            lblRecordsCount.Text = dgvGategories.Rows.Count.ToString();
            cbFilterBy.SelectedIndex = 0;

            if (dgvGategories.Rows.Count > 0)
            {

                dgvGategories.DefaultCellStyle.Font = new Font("Arial", 12);
                dgvGategories.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);


                // dgvProducts.Columns[0].HeaderText = "المعرف";
                dgvGategories.Columns[0].Width = 250;

                // dgvProducts.Columns[1].HeaderText = "الإسم";
                 dgvGategories.Columns[1].Width = 250;
            }

        }

        public frmManageGategories()
        {
            InitializeComponent();
        }

        private void frmManageGategories_Load(object sender, EventArgs e)
        {
            _RefereshGategoryList();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "المعرف":
                    FilterColumn = "المعرف";
                    break;

                case "الإسم":
                    FilterColumn = "الإسم";
                    break;
                default:
                    FilterColumn = "لاشيء";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (string.IsNullOrEmpty(txtFilterValue.Text) || FilterColumn == "لاشيء")
            {
                _dtGategories.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvGategories.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "المعرف" || FilterColumn == "الكمية" || FilterColumn == "السعر")
                //in this case we deal with integer not string.

                _dtGategories.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtGategories.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = dgvGategories.Rows.Count.ToString();
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

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {

            bool isDigit = cbFilterBy.Text == "المعرف";


            if (!char.IsLetterOrDigit(e.KeyChar))
                e.Handled = true;


            if (isDigit)
            {
                e.Handled = !char.IsDigit(e.KeyChar);
            }

        }

        private void dgvGategories_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            _GategoryID = Convert.ToInt32(dgvGategories.CurrentRow.Cells[0].Value);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmManageProducts ManageProducts = new frmManageProducts();
            ManageProducts.ShowDialog();
        }

        private void ItemAddnewCategory_Click(object sender, EventArgs e)
        {
            frmAddNewCategory addNewCategory = new frmAddNewCategory();
            addNewCategory.ShowDialog();
            _RefereshGategoryList();
        }

        private void ItemUpdateCategory_Click(object sender, EventArgs e)
        {
            frmAddNewCategory UpdateCategory = new frmAddNewCategory(_GategoryID);
            UpdateCategory.ShowDialog();
            _RefereshGategoryList();

        }

        private void ItemDeleteCategory_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد أنك ترغب في حذف هذاالصنف", "!انتبه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (ClsProduct.isThisCategoryConnectedWithProduct(_GategoryID))
                {
                    MessageBox.Show("!لايمكنك حذف هذا الصنف لأنه مرتبط ببعض المنتجات", "!انتبه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (ClsCategory.DeleteCategory(_GategoryID))
                {
                    MessageBox.Show("تم حذف الصنف بنجاح", "تم العملية بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("هناك مشكلة تواصل مع المطور", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                _RefereshGategoryList();
            }




        }
    }
}
