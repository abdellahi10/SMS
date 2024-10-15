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

namespace SMS.People.Controls
{
    public partial class ctrlPersonCardWithFiltter : UserControl
    {
        public ctrlPersonCardWithFiltter()
        {
            InitializeComponent();
        }

        private enum enFind { ID, FirstName, LastName }
        enFind Find = enFind.ID;

        public int PersonID
        {
            get { return ctrlPersonCard1.Person.PersonID; } 
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValue.Text.Trim()) || !ClsValidation.IsWordOrNumber(txtValue.Text.Trim()))
                return;


            switch (Find)
            {
                case enFind.ID:
                    FindByID();
                    break;
                case enFind.FirstName:
                    FindByName();
                    break;
                case enFind.LastName:
                    FindByName(2);
                    break;
            }


            lblUpadtePerson.Visible = true;
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbFilterBy.SelectedIndex)
            {
                case 0:
                    Find = enFind.ID;
                    break;
                case 1:
                    Find = enFind.FirstName;
                    break;
                case 2:
                    Find = enFind.LastName;
                    break;
            }

        }

        private void ctrlPersonCardWithFiltter_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
        }

        void FindByID()
        {
            if (!ClsValidation.IsNumber(txtValue.Text.Trim()))
            {
                MessageBox.Show("أدخل رقم صحيح", "خطأ في الإدخال", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            ctrlPersonCard1.LoadInfo(Convert.ToInt32(txtValue.Text.Trim()));
        }

        void FindByName(byte Find = 1)
        {

            if (ClsValidation.IsNumber(txtValue.Text.Trim()))
            {
                MessageBox.Show("أدخل إسم صحيح", "خطأ في الإدخال", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            if(Find == 1)
                ctrlPersonCard1.LoadInfo(txtValue.Text.Trim(), 1);
            else
                ctrlPersonCard1.LoadInfo(txtValue.Text.Trim(), 2);

        }

        private void lblUpadtePerson_Click(object sender, EventArgs e)
        {
            frmAddnewUpdatePerson UpdatePerson = new frmAddnewUpdatePerson(ctrlPersonCard1.Person.PersonID);
            UpdatePerson.ShowDialog();
        }
        public bool isFound()
        {
            return ctrlPersonCard1.Person != null;
        }

        public void DisableFiltter()
        {
            gbFitter.Enabled = false;
        }

        public void FindPerson(int PersonID)
        {
            txtValue.Text = PersonID.ToString();
            btnFind_Click(this, null);
        }

    }

}