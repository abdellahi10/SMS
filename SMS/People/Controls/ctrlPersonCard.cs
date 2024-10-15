using SMS.Global_Classes;
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

namespace SMS.People.Controls
{
    public partial class ctrlPersonCard : UserControl
    {
        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        public clsPerson Person;

        public void LoadInfo(int PersonID)
        {
           
            Person =clsPerson.GetPersonInfoByID(PersonID);

            if (Person == null)
            {
                MessageBox.Show("هذا الشخص غير موجود", "غير موجود", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            lblPersonID.Text = Person.PersonID.ToString();
            lblFirstName.Text = Person.FirstName.Trim();
            lblLastName.Text = Person.LastName;

            lblEmail.Text = (string.IsNullOrEmpty(Person.Email) ? "غير موجود" : Person.Email.Trim());
            lblGendor.Text = (Person.Gendor != 1 ? "ذكر" : "انثى");

            lblPhone.Text = Person.Phone.ToString().Trim();

            if (File.Exists(Person.ImagePath))
            {
                pbPersonImage.Load(Person.ImagePath);
            }
            else
            {
                pbPersonImage.Image = (Person.Gendor != 1 ? Resources.Male_512 : Resources.Female_512);
            }

        }

        public void LoadInfo(string Name, byte FindBy)
        {
            // 1 = Find by FirstName and 2 = Find by LastName

            if (FindBy == 1)
                Person = clsPerson.GetPersonInfoByFirstName(Name.Trim());
            else
            {
                Person = clsPerson.GetPersonInfoByLastName(Name.Trim());
            }

            if (Person == null)
            {
                MessageBox.Show("هذا الشخص غير موجود", "غير موجود", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            lblPersonID.Text = Person.PersonID.ToString();
            lblFirstName.Text = Person.FirstName;
            lblLastName.Text = Person.LastName;

            lblEmail.Text = (string.IsNullOrEmpty(Person.Email) ? "غير موجود" : Person.Email);
            lblGendor.Text = (Person.Gendor != 1 ? "ذكر" : "انثى");

            lblPhone.Text = Person.Phone.ToString();

            if (File.Exists(Person.ImagePath))
            {
                pbPersonImage.Load(Person.ImagePath);
            }
            else
            {
                pbPersonImage.Image = (Person.Gendor != 1 ? Resources.Male_512 : Resources.Female_512);
            }

        }

       
    }
}
