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

namespace SMS.People
{
    public partial class frmManagePeople : Form
    {

        private int _PersonID = -1;
        private DataTable _dtPeople;  /* = clsPerson.GetAllPeople();*/
        DataTable EditData(DataTable data)
        {


            data.Columns[0].ColumnName = "المعرف";
            data.Columns[1].ColumnName = "الإسم";
            data.Columns[2].ColumnName = "الإسم العائلي";
            data.Columns[3].ColumnName = "الجنس";
            data.Columns[4].ColumnName = "رقم الهاتف";
            data.Columns[5].ColumnName = "البريد الإلكتروني";


            return data;
        }
        private void _RefereshPeopleList()
        {
            _dtPeople = EditData(clsPerson.GetAllPeople());

            dgvPepeole.DataSource = _dtPeople;
            lblRecordsCount.Text = dgvPepeole.Rows.Count.ToString();
            cbFilterBy.SelectedIndex = 0;

            if (dgvPepeole.Rows.Count > 0)
            {

                dgvPepeole.DefaultCellStyle.Font = new Font("Arial", 10);
                dgvPepeole.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);


                // "المعرف";
                dgvPepeole.Columns[0].Width = 87;
                // "الإسم";
                dgvPepeole.Columns[1].Width = 120;
                // "الإسم العائلي";
                dgvPepeole.Columns[2].Width = 120;
                // "الجنس";
                dgvPepeole.Columns[3].Width = 100;
                // "رقم الهاتف";
                dgvPepeole.Columns[4].Width = 140;
                // "البريد الإلكتروني";
                dgvPepeole.Columns[5].Width = 270;
            }
            else
            {
                MessageBox.Show("لا توجد بيانات لعرضها", "لم يتم العثور البيانات", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        public frmManagePeople()
        {
            InitializeComponent();
        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            _RefereshPeopleList();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            //Map Selected Filter to real Column name 
            switch (cbFilterBy.Text)
            {
                case "المعرف":
                    FilterColumn = "المعرف";
                    break;

                case "الإسم":
                    FilterColumn = "الإسم";
                    break;

                case "الإسم العائلي":
                    FilterColumn = "الإسم العائلي";
                    break;

                case "الجنس":
                    FilterColumn = "الجنس";
                    break;

                case "رقم الهاتف":
                    FilterColumn = "رقم الهاتف";
                    break;

                case "البريد الإلكتروني":
                    FilterColumn = "البريد الإلكتروني";
                    break;

                default:
                    FilterColumn = "لاشيء";
                    break;
            }


            //Reset the filters in case nothing selected or filter value conains nothing.
            if (string.IsNullOrEmpty(txtFilterValue.Text) || FilterColumn == "لاشيء")
            {
                _dtPeople.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvPepeole.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "المعرف" || FilterColumn == "رقم الهاتف")
                //in this case we deal with integer not string.
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = dgvPepeole.Rows.Count.ToString();

        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "لاشيء");

            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isDigit = cbFilterBy.Text == "المعرف" || cbFilterBy.Text == "رقم الهاتف";

            if (!char.IsLetterOrDigit(e.KeyChar))
                e.Handled = true;


            if (isDigit)
            {
                e.Handled = !char.IsDigit(e.KeyChar);
            }

        }

        private void dgvPepeole_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            _PersonID = Convert.ToInt32(dgvPepeole.CurrentRow.Cells[0].Value);
        }

        private void ItemPersonInfo_Click(object sender, EventArgs e)
        {
            frmPersonInfo PersonInfo = new frmPersonInfo(_PersonID);
            PersonInfo.ShowDialog();
        }

        private void ItemAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddnewUpdatePerson AddNewPerson = new frmAddnewUpdatePerson();
            AddNewPerson.ShowDialog();
            _RefereshPeopleList();
        }

        private void ItemUpdatePerson_Click(object sender, EventArgs e)
        {
            frmAddnewUpdatePerson UpdatePerson = new frmAddnewUpdatePerson(_PersonID);
            UpdatePerson.ShowDialog();
            _RefereshPeopleList();
        }

        private void ItemDeletePerson_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("هل أنت متأكد أنك تريد حذف هذا الشخص من النظام؟", "متأكد؟", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if(ClsUser.IsPersonUser(_PersonID) || ClsCustomer.IsThisPersonCustomer(_PersonID))
                {
                    MessageBox.Show("!لايمكنك حذف هذا الشخص لأن هناك معلومات مرتبطة به", "غير مسموح؟",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                    return;
                }

                if (clsPerson.DeletePerson(_PersonID))
                {
                    MessageBox.Show("!تم الحذف بنجاح", "تم",
                       MessageBoxButtons.YesNo, MessageBoxIcon.None);

                    _RefereshPeopleList();
                }
                else
                {
                    MessageBox.Show("لم يتم الحذف بنجاح هناك مشكلة", "خطأ",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }

            }

        }

   
    }
}
