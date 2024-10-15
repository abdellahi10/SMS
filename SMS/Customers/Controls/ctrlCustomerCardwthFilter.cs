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
    public partial class ctrlCustomerCardwthFilter : UserControl
    {
        public ctrlCustomerCardwthFilter()
        {
            InitializeComponent();
        }

        private enum enFind { ID, FullName }
        enFind Find = enFind.ID;

        ClsCustomer Customer;


        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValue.Text.Trim()) || !ClsValidation.IsWordOrNumber(txtValue.Text.Trim()))
                return;


            switch (Find)
            {
                case enFind.ID:
                    FindByID();
                    break;
                case enFind.FullName:
                    FindByFullName();
                    break;
               
            }


            lblUpadtePerson.Visible = true;
        }

        private void FindByID()
        {
            if (!ClsCustomer.IsCustomerExist(Convert.ToInt32(txtValue.Text.Trim())))
            {
                // MessageBox
            }



        }

        private void FindByFullName()
        {
            throw new NotImplementedException();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            Find = cbFilterBy.SelectedIndex == 0 ? enFind.ID : enFind.FullName;
        }
    }
}
