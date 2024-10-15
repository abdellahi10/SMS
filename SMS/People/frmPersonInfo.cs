using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.People
{
    public partial class frmPersonInfo : Form
    {
        int _PersonID = -1;

        public frmPersonInfo(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        private void frmPersonInfo_Load(object sender, EventArgs e)
        {
            ctrlPersonInfo1.LoadInfo(_PersonID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
