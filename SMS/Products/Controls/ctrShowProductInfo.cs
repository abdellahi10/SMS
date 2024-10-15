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

namespace SMS.Products.Controls
{
    public partial class ctrShowProductInfo : UserControl
    {
        public ctrShowProductInfo()
        {
            InitializeComponent();
        }

        // int _ProductID = 5;

        public  void LoadInfo(int ProductID)
        {
            ClsProduct product = ClsProduct.GetProductInfoByID(ProductID);

            if(product == null)
            {
                MessageBox.Show("هذا المنتج غير موجود", "غير موجود", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            lblID.Text = product.ProductID.ToString();
            lblCategory.Text = product.CategoryInfo.CategoryName;
            lblName.Text = product.ProductName;
            lblQuantity.Text = product.QuantityStock.ToString();
            lblPrice.Text = product.Price.ToString();
            lblDescription.Text = product.Description;
            if (File.Exists(product.ImagePath))
            {
                pictureBox1.Load(product.ImagePath);
            }
            else
            {
                pictureBox1.Image = Resources.Applications_64;
            }


        }

      
    }
}
