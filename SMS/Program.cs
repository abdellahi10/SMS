using SMS.Categories;
using SMS.Customers;
using SMS.Login;
using SMS.People;
using SMS.Products;
using SMS.Sales;
using SMS.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());

            //Application.Run(new frmManageSales());
        }
    }
}
