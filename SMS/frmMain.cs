using SMS.Categories;
using SMS.Customers;
using SMS.Global_Classes;
using SMS.Login;
using SMS.People;
using SMS.Products;
using SMS.Sales;
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

namespace SMS
{
    public partial class frmMain : Form
    {
        frmLogin _frmLogin;
       // private frmMain frm;

        public frmMain(frmLogin frm)
        {
            InitializeComponent();
            _frmLogin = frm;
        }


        private void ItemAddNewProduct_Click(object sender, EventArgs e)
        {
            frmAddNewEditProduct AddNewProduct = new frmAddNewEditProduct();
            AddNewProduct.ShowDialog();
        }

        private void ItemManageProducts_Click(object sender, EventArgs e)
        {
            frmManageProducts ManageProducts = new frmManageProducts();
            ManageProducts.ShowDialog();
        }

        private void ItemManageCategories_Click(object sender, EventArgs e)
        {
            frmManageGategories manageGategories = new frmManageGategories();
            manageGategories.ShowDialog();
        }

        private void ItemAddnewCategory_Click(object sender, EventArgs e)
        {
            frmAddNewCategory addNewCategory = new frmAddNewCategory();
            addNewCategory.ShowDialog();
        }

        private void ItemPepole_Click(object sender, EventArgs e)
        {
            frmManagePeople ManagePeople = new frmManagePeople();
            ManagePeople.ShowDialog();
        }

        private void ItemUsers_Click(object sender, EventArgs e)
        {
            frmManageUsers ManageUsers = new frmManageUsers();
            ManageUsers.ShowDialog();

        }

        private void ItemCustomers_Click(object sender, EventArgs e)
        {
            frmManageCustomers ManageCustomers = new frmManageCustomers();
            ManageCustomers.ShowDialog();
        }

        private void ItemSales_Click(object sender, EventArgs e)
        {
            frmManageSales manageSales = new frmManageSales();
            manageSales.ShowDialog();
        }

        private void ItemMyInfo_Click(object sender, EventArgs e)
        {
            frmUserInfo UserInfo = new frmUserInfo(clsGlobal.CurrentUser.UserID);
            UserInfo.ShowDialog();
        }

        private void ItemChangPassword_Click(object sender, EventArgs e)
        {
            frmChangePassword ChangePassword = new frmChangePassword(clsGlobal.CurrentUser.UserID);
            ChangePassword.ShowDialog();
        }

        private void ItemSignOut_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            int[] MainRepo = ClsOrderItem.GetMainReoprt();
            

            lblPeople.Text = MainRepo[0].ToString();
            lblUsers.Text = MainRepo[1].ToString();
            lblCutomers.Text = MainRepo[2].ToString();
            lblProsucts.Text = MainRepo[3].ToString();
            lblOrders.Text = MainRepo[4].ToString();
            lblSales.Text = MainRepo[4].ToString();


        }


    }
}
