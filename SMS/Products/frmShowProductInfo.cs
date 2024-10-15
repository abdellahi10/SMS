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
    public partial class frmShowProductInfo : Form
    {
        int ProductID = -1;

        public frmShowProductInfo(int ProductID)
        {
            InitializeComponent();
            this.ProductID = ProductID;
        }

        private void frmShowProductInfo_Load(object sender, EventArgs e)
        {
            
            ctrShowProductInfo1.LoadInfo(this.ProductID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
