using SMS.Customers;
using SMS.Global_Classes;
using SMS.People.Controls;
using SMS.Properties;
using SMS_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.Sales
{
    public partial class frmAddNewSale : Form
    {
        int _productID = -1;
        ClsProduct _product;
        ClsOrderItem _orderItem = new ClsOrderItem();
        ClsOrder _order = new ClsOrder();
        decimal _TotalPrice = 0;

        public frmAddNewSale(int ProductID)
        {
            InitializeComponent();
            _productID = ProductID;
            _product = ClsProduct.GetProductInfoByID(_productID);
        }

        void _fillCombobox()
        {
            for (int i = 0; i <= _product.QuantityStock; i++)
            {
                cmProductQuantity.Items.Add(i);
            }
        }

        void LoadProducImage()
        {
            if (File.Exists(_product.ImagePath))
            {
                pcProductImage.Load(_product.ImagePath);
            }
            else
            {
                // Fix it later with Design Time
                pcProductImage.Image = Resources.Male_512;
            }
        }

        void LoadCutomerImage(string ImagePath)
        {
            if (File.Exists(ImagePath))
            {
                pcCustomerImage.Load(ImagePath);
            }
            else
            {
                // Fix it later with Design Time
                pcCustomerImage.Image = Resources.Male_512;
            }

        }

        void _restDefaultValue()
        {
            if (_product == null)
                return;

           
            lblProductID.Text = _product.ProductID.ToString();
            lblProductDecscription.Text = _product.Description;
            lblProductPrice.Text = Convert.ToInt32(_product.Price).ToString();
            _fillCombobox();
            lblOderDate.Text = DateTime.Now.ToString();
            // This Must be Fixed When When add Loggin Sreen Should add Logged in User ID
            lblOrderedByUserID.Text = clsGlobal.CurrentUser.UserID.ToString();
            LoadProducImage();

            // Page 1 Values
            lblPage1UserID.Text = lblOrderedByUserID.Text;
            lblPage1DateID.Text = lblOderDate.Text;


        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            frmFindCustomer findCustomer = new frmFindCustomer();
            findCustomer.DataBack += FindCustomer_DataBack;  // Subscribe to the Event
            findCustomer.ShowDialog();
        }

        private void FindCustomer_DataBack(object sender, int CustomerID, string ImagePath)
        {

            lblPage1CutomerID.Text = CustomerID.ToString();
            lblCustomerID.Text = lblPage1CutomerID.Text;
            LoadCutomerImage(ImagePath);
            btnNext.Enabled = true;
            
        }

        private void frmAddNewSale_Load(object sender, EventArgs e)
        {
            _restDefaultValue();
        }

        private void cmProductQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            _TotalPrice = (Convert.ToInt32(cmProductQuantity.Text) * _product.Price);
            lblTotalPrice.Text = Convert.ToInt32(_TotalPrice).ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            { 
            
                _orderItem.OrderID = _order.OrderID;
                _orderItem.ProductID = _productID;
                _orderItem.Quantity = Convert.ToInt32(cmProductQuantity.Text);
                _orderItem.ItemPrice = Convert.ToDouble(_product.Price);
                _orderItem.TotalAmount = Convert.ToDouble(_TotalPrice);
                
                _product.QuantityStock -= _orderItem.Quantity;
                
            if (_orderItem.Save() && _product.Save())
            {
                lblOrderID.Text = _order.OrderID.ToString();
               
                MessageBox.Show(".تم الجفظ بنجاح", "تم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show(".خطأ:لم يتم حفظ البيانات بنجاح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch
            {
                _product.QuantityStock += _orderItem.Quantity;
                MessageBox.Show(".حدث خطأ ما في حفظ البيانات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (tabControl1.SelectedIndex == 0 || btnNext.Enabled == false)
            {
                MessageBox.Show("حدد العميل صاحب الطلب ", "إجراء ضروري", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabControl1.DeselectTab(1);
                return;
            }

            

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            _order.CustomerID = Convert.ToInt32(lblCustomerID.Text);
            _order.OrderDate = DateTime.Now;
            _order.OrderedByUserID = Convert.ToInt32(lblOrderedByUserID.Text);
            _order.Status = 0;

            if (_order.Save())
            {
                lblPage1OrderID.Text = _order.OrderID.ToString();
                lblOrderID.Text = lblPage1OrderID.Text;

                MessageBox.Show(".تمت عمليةالطلب بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tabControl1.SelectedTab = tabPage2;
            }
            else
                MessageBox.Show(".حدث خطأ ما في العملية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

      
    }
    
}
