using SMS.Global_Classes;
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
    public partial class frmFindCustomer : Form
    {
        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int CustomerID, string ImagePath);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        public frmFindCustomer()
        {
            InitializeComponent();
        }

        ClsCustomer _customer;

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValue.Text.Trim()) || !ClsValidation.IsWordOrNumber(txtValue.Text.Trim()))
                return;

            int CutomerID = Convert.ToInt32(txtValue.Text.Trim());

            if (!ClsCustomer.IsCustomerExist(CutomerID))
            {
                MessageBox.Show("لا يوجد عميل بهذا الرقم في النظام", "غير موجود", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }


            _customer = ClsCustomer.GetCustomerInfoByID(CutomerID);
            ctrlPersonCard1.LoadInfo(_customer.PersonID);

            btnAdd.Enabled = true;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Trigger the event to send data back to the caller form.
            DataBack?.Invoke(this, _customer.CustomerID, _customer.PersonInfo.ImagePath);
            this.Close();
        }
    }
}
