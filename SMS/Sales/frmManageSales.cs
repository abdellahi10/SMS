using SMS.Customers;
using SMS.Global_Classes;
using SMS.Products;
using SMS.Users;
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

namespace SMS.Sales
{
    public partial class frmManageSales : Form
    {

        ClsOrderItem _OrderItem;
        ClsOrder _Order;

        struct stSalesInfo
        {
            public int ItemID { get; set; }
            public int OrderID { get; set; }
            public int CustomerID { get; set; }
            public int ProductID { get; set; }
            public int? OrderStatus { get; set;}

           
             //public stSalesInfo(int OrderID, int CustomerID, int ProductID, int? OrderStatus)
             //{

             //   this.OrderID = OrderID;
             //   this.CustomerID = CustomerID;
             //   this.ProductID = ProductID;
             //   this.OrderStatus = OrderStatus;
             //}
        }

        stSalesInfo SalesInfo;

        enum enOrderStaus {Pennding, Shipped, Delivred }
         
        private DataTable _dtSales = ClsOrderItem.GetAllSales();

        DataTable EditData(DataTable data)
        {
            data.Columns[0].ColumnName = "رقم العملية";
            data.Columns[1].ColumnName = "رقم الطلب";
            data.Columns[2].ColumnName = "رقم البائع";
            data.Columns[3].ColumnName = "تاريخ الطلب";
            data.Columns[4].ColumnName = "إسم العميل";
            data.Columns[5].ColumnName = "إسم المنتج";
            data.Columns[6].ColumnName = "الكمية";
            data.Columns[7].ColumnName = "سعر المنتح";
            data.Columns[8].ColumnName = "السعر الإجمالي";
            data.Columns[9].ColumnName = "حالة الطلب";


            return data;
        }

        private void _RefereshSalesList()
        {


            _dtSales = EditData(ClsOrderItem.GetAllSales());


            dgvSales.DataSource = _dtSales;
            lblRecordsCount.Text = dgvSales.Rows.Count.ToString();
            cbFilterBy.SelectedIndex = 0;

            if (dgvSales.Rows.Count > 0)
            {

                dgvSales.DefaultCellStyle.Font = new Font("Arial", 10);
                dgvSales.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);


                // data.Columns[0].ColumnName = "رقم العملية";
                dgvSales.Columns[0].Width = 87;


                // data.Columns[1].ColumnName = "رقم الطلب";
                dgvSales.Columns[1].Width = 87;


                //  data.Columns[2].ColumnName = "رقم البائع";
                dgvSales.Columns[2].Width = 87;


                // data.Columns[3].ColumnName = "تاريخ الطلب";
                dgvSales.Columns[3].Width = 100;

                // data.Columns[4].ColumnName = "إسم العميل";
                dgvSales.Columns[4].Width = 150;

                //data.Columns[5].ColumnName = "إسم المنتج";
                dgvSales.Columns[5].Width = 150;

                //data.Columns[6].ColumnName = "الكمية";
                dgvSales.Columns[6].Width = 100;

                //data.Columns[7].ColumnName = "سعر المنتح";
                dgvSales.Columns[7].Width = 100;

                //data.Columns[8].ColumnName = "السعر الإجمالي";
                dgvSales.Columns[8].Width = 100;

                //data.Columns[9].ColumnName = "حالة الطلب";
                dgvSales.Columns[9].Width = 100;


            }
        }

        public frmManageSales()
        {
            InitializeComponent();
            SalesInfo = new stSalesInfo();
        }

        private void frmManageSales_Load(object sender, EventArgs e)
        {
            _RefereshSalesList();

        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            //Map Selected Filter to real Column name 
            switch (cbFilterBy.Text)
            {
                case "رقم العملية":
                    FilterColumn = "رقم العملية";
                    break;

                case "رقم الطلب":
                    FilterColumn = "رقم الطلب";
                    break;

                case "رقم البائع":
                    FilterColumn = "رقم البائع";
                    break;

                case "تاريخ الطلب":
                    FilterColumn = "تاريخ الطلب";
                    break;

                case "إسم العميل":
                    FilterColumn = "إسم العميل";
                    break;

                case "إسم المنتج":
                    FilterColumn = "إسم المنتج";
                    break;

                case "حالة الطلب":
                    FilterColumn = "حالة الطلب";
                    break;

                default:
                    FilterColumn = "لاشيء";
                    break;

            }


            //Reset the filters in case nothing selected or filter value conains nothing.
            if (string.IsNullOrEmpty(txtFilterValue.Text) || FilterColumn == "لاشيء")
            {
                _dtSales.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvSales.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "رقم العملية" || FilterColumn == "رقم الطلب" || FilterColumn == "رقم البائع")
                //in this case we deal with integer not string.
                _dtSales.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtSales.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = dgvSales.Rows.Count.ToString();
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
            bool isDigit = cbFilterBy.Text == "رقم العملية" || cbFilterBy.Text == "رقم الطلب" || cbFilterBy.Text == "رقم البائع";


            if (!char.IsLetterOrDigit(e.KeyChar))
                e.Handled = true;


            if (isDigit)
            {
                e.Handled = !char.IsDigit(e.KeyChar);
            }


        }

        private void cmsSales_Opening(object sender, CancelEventArgs e)
        {
            switch (SalesInfo.OrderStatus)
            {

                case 0:
                    sItemShipped.Enabled = true;
                    sItemDelivered.Enabled = false;
                    break;
                case 1:
                    sItemShipped.Enabled = false;
                    sItemDelivered.Enabled = true;
                    break;
                case 2:
                    sItemDelivered.Enabled = false;
                    sItemShipped.Enabled = false;
                    break;
            }
           
        }

        private void dgvSales_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (e.Button != MouseButtons.Right)
            //    return;
            SalesInfo.ItemID = Convert.ToInt32(dgvSales.CurrentRow.Cells[0].Value);
            SalesInfo.OrderID = Convert.ToInt32(dgvSales.CurrentRow.Cells[1].Value);
            string StatusValue = dgvSales.CurrentRow.Cells[9].Value.ToString();
            SalesInfo.CustomerID = Convert.ToInt32(dgvSales.CurrentRow.Cells[1].Value);

            SalesInfo.OrderStatus = StatusValue == "قيد الأنتظار" ? 0 : StatusValue == "تم الشحن" ? 1 : 2;
        }

        void ManageOrderStatus(byte OrderStaus)
        {
            _Order = ClsOrder.GetOrderInfoByID(SalesInfo.OrderID);
            if (_Order == null)
                return;

            _Order.Status = OrderStaus;

            if (_Order.Save())
            {
                MessageBox.Show(".تم شحن الطلبية بنجاح", "تم الشحن", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(".خطأ:لم يتم الشحن بنجاح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            _RefereshSalesList();

        }

        private void sItemShipped_Click(object sender, EventArgs e)
        {
            ManageOrderStatus((byte)enOrderStaus.Shipped);
        }

        private void sItemDelivered_Click(object sender, EventArgs e)
        {
            ManageOrderStatus((byte)enOrderStaus.Delivred);
        }

        private void ItemCustomerInfo_Click(object sender, EventArgs e)
        {
            _OrderItem = ClsOrderItem.GetOrderItemInfoByID(SalesInfo.ItemID);
            frmCustomerInfo ShowCustomerInfo = new frmCustomerInfo(_OrderItem.OrderInfo.CustomerID);
            ShowCustomerInfo.ShowDialog();
        }

        private void ItemProductInfo_Click(object sender, EventArgs e)
        {
            _OrderItem = ClsOrderItem.GetOrderItemInfoByID(SalesInfo.ItemID);
            frmShowProductInfo ShowProductInfo = new frmShowProductInfo(_OrderItem.ProductID);
            ShowProductInfo.ShowDialog();
        }

        private void ItemSellerInfo_Click(object sender, EventArgs e)
        {
            frmUserInfo SellerInfo = new frmUserInfo(clsGlobal.CurrentUser.UserID);
            SellerInfo.ShowDialog();
        }
    }
}
