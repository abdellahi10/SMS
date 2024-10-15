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

namespace SMS.Customers.Controls
{
    public partial class ctrlConstomerCard : UserControl
    {
        public ctrlConstomerCard()
        {
            InitializeComponent();
        }

        ClsCustomer _Customer = new ClsCustomer();

        public void LoadCustomerInfo(int CustomerID)
        {
            _Customer = ClsCustomer.GetCustomerInfoByID(CustomerID);
            

            if (_Customer == null)
            {
                MessageBox.Show("هذا العميل غير موجود", "غير موجود", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            // Should Use Try-Cacth to Validate ctrlPersonCard1. But Ensure There no User without Person Connected Person
            ctrlPersonCard1.LoadInfo(_Customer.PersonID);

            lblCustomerID.Text = _Customer.CustomerID.ToString();
            lblCreatedDate.Text = ClsFormat.ShortDate(_Customer.CreatedDate);

        }

    }
}
