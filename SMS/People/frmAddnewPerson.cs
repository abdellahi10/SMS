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

namespace SMS.People
{
    public partial class frmAddnewUpdatePerson : Form
    {

        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        public enum enMode { AddNew = 0, Update = 1 };
        public enum enGendor { Male = 0, Female = 1 };

        private enMode _Mode;
        private int _PersonID = -1;
        clsPerson _Person;

        public frmAddnewUpdatePerson()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddnewUpdatePerson(int PersonID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _PersonID = PersonID;
        }

        private void _ResetDefualtValues()
        {
            //this will initialize the reset the defaule values

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "إضافة شخص جديد";
                _Person = new clsPerson();
            }
            else
            {
                lblTitle.Text = "تعديل";
            }

            //set default image for the person.
            if (rbMale.Checked)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;

            //hide/show the remove linke incase there is no image for the person.
            llRemoveImage.Visible = (pbPersonImage.ImageLocation != null);

            txtFirstName.Text = "";
            txtLastName.Text = "";
            rbMale.Checked = true;
            txtPhone.Text = "";
            txtEmail.Text = "";
        }

        private void _LoadData()
        {

            _Person = clsPerson.GetPersonInfoByID(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("لا يوجد شخص يحمل هذاالمعرف:  " + _PersonID, "غير موجود!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            //the following code will not be executed if the person was not found
            lblPersonID.Text = _PersonID.ToString();
            txtFirstName.Text = _Person.FirstName;
            txtLastName.Text = _Person.LastName;

            if (_Person.Gendor == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            txtPhone.Text = _Person.Phone;
            txtEmail.Text = _Person.Email;


            //load person image incase it was set.
            if (_Person.ImagePath != "")
            {
                pbPersonImage.ImageLocation = _Person.ImagePath;

            }

            //hide/show the remove linke incase there is no image for the person.
            llRemoveImage.Visible = (_Person.ImagePath != "");

        }

        private void frmAddnewUpdatePerson_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private bool _HandlePersonImage()
        {

            //this procedure will handle the person image,
            //it will take care of deleting the old image from the folder
            //in case the image changed. and it will rename the new image with guid and 
            //place it in the images folder.


            //_Person.ImagePath contains the old Image, we check if it changed then we copy the new image
            if (_Person.ImagePath != pbPersonImage.ImageLocation)
            {
                if (_Person.ImagePath != "")
                {
                    //first we delete the old image from the folder in case there is any.

                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (IOException)
                    {
                        // We could not delete the file.
                        //log it later   
                    }
                }

                if (pbPersonImage.ImageLocation != null)
                {
                    //then we copy the new image to the image folder after we rename it
                    string SourceImageFile = pbPersonImage.ImageLocation.ToString();

                    if (ClsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile,"Images"))
                    {
                        pbPersonImage.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("بعض الحقول لاتلتزم بالشروط\n!وجه الفأرة على الخانة الحمراء لترى الخطأ", "خطأ التحقق",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (!_HandlePersonImage())
                return;


            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.LastName = txtLastName.Text.Trim();
            _Person.Email = txtEmail.Text.Trim();
            _Person.Phone = txtPhone.Text.Trim();

            if (rbMale.Checked)
                _Person.Gendor = (short)enGendor.Male;
            else
                _Person.Gendor = (short)enGendor.Female;


            if (pbPersonImage.ImageLocation != null)
                _Person.ImagePath = pbPersonImage.ImageLocation;
            else
                _Person.ImagePath = "";

            if (_Person.Save())
            {
                lblPersonID.Text = _Person.PersonID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                lblTitle.Text = "تعديل الشخص";

                MessageBox.Show(".تم الجفظ بنجاح", "تم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // Trigger the event to send data back to the caller form.
                DataBack?.Invoke(this, _Person.PersonID);
            }
            else
                MessageBox.Show(".خطأ:لم يتم حفظ البيانات بنجاح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                pbPersonImage.Load(selectedFilePath);
                llRemoveImage.Visible = true;
                // ...
            }
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.ImageLocation = null;

            if (rbMale.Checked)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;

            llRemoveImage.Visible = false;
        }

        private void rbFemale_Click(object sender, EventArgs e)
        {
            //change the defualt image to female incase there is no image set.
            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources.Female_512;
        }

        private void rbMale_Click(object sender, EventArgs e)
        {
            //change the defualt image to male incase there is no image set.
            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources.Male_512;
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {

            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            TextBox Temp = ((TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "هذا الحقل مطلوب *");
            }
            else
            {
                // e.Cancel = true;
                errorProvider1.SetError(Temp, null);
            }

        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text.Trim() == "")
            {
                errorProvider1.SetError(txtEmail, "هذا الحقل مطلوب *");
                return;
            }
               

            //validate email format
            if (!ClsValidation.ValidateEmail(txtEmail.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "عنوان البريد الإلكتروني غير صالح!");
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            };
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (txtPhone.Text.Trim() == "")
            {
                errorProvider1.SetError(txtPhone, "هذا الحقل مطلوب *");
                return;
            }

            //validate Phone format
            if (!ClsValidation.IsNumber(txtPhone.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPhone, "ادخل رقم صحيح");
            }
            else
            {
                errorProvider1.SetError(txtPhone, null);
            };
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblPersonID_Click(object sender, EventArgs e)
        {

        }
    }
}
