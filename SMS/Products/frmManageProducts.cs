using SMS.Sales;
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

namespace SMS.Products
{
    public partial class frmManageProducts : Form
    {
        private int _ProductID = -1;
        int _Quantity =-1;
        private DataTable _dtProducts = ClsProduct.GetAllProducts();

        DataTable EditData(DataTable data)
        {
            data.Columns[0].ColumnName = "المعرف";
            data.Columns[1].ColumnName = "الإسم";
            data.Columns[2].ColumnName = "الوصف";
            data.Columns[3].ColumnName = "الكمية";
            data.Columns[4].ColumnName = "السعر";
            data.Columns[5].ColumnName = "الصنف";


            return data;
        }

        private void _RefereshProductList()
        {
           

            _dtProducts = EditData(ClsProduct.GetAllProducts());
           

            dgvProducts.DataSource = _dtProducts;
            lblRecordsCount.Text = dgvProducts.Rows.Count.ToString();
            cbFilterBy.SelectedIndex = 0;

            if (dgvProducts.Rows.Count > 0)
            {

                dgvProducts.DefaultCellStyle.Font = new Font("Arial", 10);
                dgvProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);


                // dgvProducts.Columns[0].HeaderText = "المعرف";
                dgvProducts.Columns[0].Width = 87;


                // dgvProducts.Columns[1].HeaderText = "الإسم";
                dgvProducts.Columns[1].Width = 150;


                // dgvProducts.Columns[2].HeaderText = "الوصف";
                dgvProducts.Columns[2].Width = 250;


                // dgvProducts.Columns[3].HeaderText = "الكمية";
                dgvProducts.Columns[3].Width = 100;


                // dgvProducts.Columns[4].HeaderText = "السعر";

                // dgvProducts.Columns[5].HeaderText = "الصنف";
                dgvProducts.Columns[5].Width = 150;
            }
        }

        public frmManageProducts()
        {
            InitializeComponent();
        }

        private void frmManageProducts_Load(object sender, EventArgs e)
        {
            //ctrShowProductInfo1.LoadInfo(78);
            _RefereshProductList();

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

                case "الإسم":
                    FilterColumn = "الإسم";
                    break;

                case "الوصف":
                    FilterColumn = "الوصف";
                    break;

                case "الكمية":
                    FilterColumn = "الكمية";
                    break;

                case "السعر":
                    FilterColumn = "السعر";
                    break;

                case "الصنف":
                    FilterColumn = "الصنف";
                    break;

                default:
                    FilterColumn = "لاشيء";
                    break;

            }


            //Reset the filters in case nothing selected or filter value conains nothing.
            if (string.IsNullOrEmpty(txtFilterValue.Text) || FilterColumn == "لاشيء")
            {
                _dtProducts.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvProducts.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "المعرف" || FilterColumn == "الكمية" || FilterColumn == "السعر")
                //in this case we deal with integer not string.

                _dtProducts.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtProducts.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = dgvProducts.Rows.Count.ToString();
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
            bool isDigit = cbFilterBy.Text == "المعرف" || cbFilterBy.Text == "الكمية" || cbFilterBy.Text == "السعر";


            if (!char.IsLetterOrDigit(e.KeyChar))
                e.Handled = true;


            if (isDigit)
            {
                e.Handled = !char.IsDigit(e.KeyChar);
            }



        }

        private void ItemAddNew_Click(object sender, EventArgs e)
        {
            frmAddNewEditProduct AddNewProduct = new frmAddNewEditProduct();
            AddNewProduct.ShowDialog();
            _RefereshProductList();


        }

        private void ItemEdit_Click(object sender, EventArgs e)
        {
            frmAddNewEditProduct EditProduct = new frmAddNewEditProduct((int)dgvProducts.CurrentRow.Cells[0].Value);
            EditProduct.ShowDialog();
            _RefereshProductList();

        }

        private void dgvProducts_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            _ProductID = Convert.ToInt32(dgvProducts.CurrentRow.Cells[0].Value);
            _Quantity = Convert.ToInt32(dgvProducts.CurrentRow.Cells[3].Value);
           
        }

        private void ItemProductInfo_Click(object sender, EventArgs e)
        {
            frmShowProductInfo showProductInfo = new frmShowProductInfo(_ProductID);
            showProductInfo.ShowDialog();
        }

        private void ItemDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("هل انت متأكد أنك ترغب في حذف هذا المنتج", "!انتبه",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (ClsOrderItem.isItemIncludeThisProduct(_ProductID))
                {
                    MessageBox.Show("لايمكنك حذف هذا المنتج لأنه مرتبط ببعض الفواتير ", "!انتبه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (ClsProduct.DeleteProduct(_ProductID))
                {
                    MessageBox.Show("تم حذف المنتج بنجاح", "تم العملية بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("هناك مشكلة تواصل مع المطور", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                _RefereshProductList();

            }

        }

        private void SellProduct_Click(object sender, EventArgs e)
        {
            frmAddNewSale newSale = new frmAddNewSale(_ProductID);
            newSale.ShowDialog();
            _RefereshProductList();
        }

        private void cmsProducts_Opening(object sender, CancelEventArgs e)
        {
            if (_Quantity < 1)
                SellProduct.Enabled = false;
            else
                SellProduct.Enabled = true;

        }
    }
}
