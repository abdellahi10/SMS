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

namespace SMS.Products
{
    public partial class frmAddNewEditProduct : Form
    {
      
        // Declare a delegate
        //public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        //public event DataBackEventHandler DataBack;

        public enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode;
        private int _ProductID = -1;
        ClsProduct _Product;
        public frmAddNewEditProduct()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;

        }

        public frmAddNewEditProduct(int ProductID)
        {
            InitializeComponent();
            _ProductID = ProductID;
            _Mode = enMode.Update;

        }

        private void _ResetDefualtValues()
        {
            //this will initialize the reset the defaule values
             _FillCategoriesInComoboBox();

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "إضافة منتج جديد ";
                _Product = new ClsProduct();
            }
            else
            {
                lblTitle.Text = "تحديث المنتج ";
            }

            //hide/show the remove linke incase there is no image for the person.
            llRemoveImage.Visible = (pbProductImage.ImageLocation != null);

            lblProductID.Text = "";
            txtProductName.Text = "";
            txtQuantity.Text = "";
            txtDescription.Text = "";
            txtPrice.Text = "";
            cbCategory.SelectedIndex = 0;
        }

        private void _FillCategoriesInComoboBox()
        {
            DataTable dtCategories = ClsCategory.GetAllCategories();

            foreach (DataRow row in dtCategories.Rows)
            {
                cbCategory.Items.Add(row["CategoryName"]);
            }
        }

        private void _LoadData()
        {

            _Product = ClsProduct.GetProductInfoByID(_ProductID);

            if (_Product == null)
            {
                MessageBox.Show("لايوجد معرف بهذا الرقم = " + _ProductID, "المنتج غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            //the following code will not be executed if the Product was not found
            lblProductID.Text = _Product.ProductID.ToString();

            txtProductName.Text = _Product.ProductName;
            txtDescription.Text = _Product.Description;
            txtQuantity.Text = _Product.QuantityStock.ToString();
            txtPrice.Text = _Product.Price.ToString();

            cbCategory.SelectedIndex = cbCategory.FindString(_Product.CategoryInfo.CategoryName);


            //load Product image incase it was set.
            if (_Product.ImagePath != "")
            {
                pbProductImage.ImageLocation = _Product.ImagePath;

            }

            //hide/show the remove linke incase there is no image for the Product.
            llRemoveImage.Visible = (_Product.ImagePath != "");

        }

        private void frmAddNewEditProduct_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private bool _HandleProductImage()
        {

            //this procedure will handle the Product image,
            //it will take care of deleting the old image from the folder
            //in case the image changed. and it will rename the new image with guid and 
            // place it in the images folder.


            //_Product.ImagePath contains the old Image, we check if it changed then we copy the new image
            if (_Product.ImagePath != pbProductImage.ImageLocation)
            {
                if (_Product.ImagePath != "")
                {
                    //first we delete the old image from the folder in case there is any.

                    try
                    {
                        File.Delete(_Product.ImagePath);
                    }
                    catch (IOException)
                    {
                        // We could not delete the file.
                        //log it later   
                    }
                }

                if (pbProductImage.ImageLocation != null)
                {
                    //then we copy the new image to the image folder after we rename it
                    string SourceImageFile = pbProductImage.ImageLocation.ToString();

                    if (ClsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile, "Product"))
                    {
                        pbProductImage.ImageLocation = SourceImageFile;
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

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                pbProductImage.Load(selectedFilePath);
                llRemoveImage.Visible = true;
                // ...
            }
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbProductImage.ImageLocation = null;
            llRemoveImage.Visible = false;
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

        private void txtQuantity_Validating(object sender, CancelEventArgs e)
        {
            if (txtQuantity.Text.Trim() == "")
            {
                errorProvider1.SetError(txtQuantity, "هذا الحقل مطلوب *");
                return;
            }

            //validate Quantity format
            if (!ClsValidation.IsNumber(txtQuantity.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtQuantity, "ادخل رقم صحيح");
            }
            else
            {
                errorProvider1.SetError(txtQuantity, null);
            };
        }

        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            if (txtPrice.Text.Trim() == "")
            {
                errorProvider1.SetError(txtPrice, "هذا الحقل مطلوب *");
                return;
            }

            //validate Price format
            if (!ClsValidation.ValidateFloat(txtPrice.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPrice, "ادخل سعر صحيح");
            }
            else
            {
                errorProvider1.SetError(txtPrice, null);
            };
        }

        private void txtProductName_Validating(object sender, CancelEventArgs e)
        {
            if (txtProductName.Text.Trim() == "")
            {
                errorProvider1.SetError(txtProductName, "هذا الحقل مطلوب *");
                e.Cancel = true;
                return;
            }

            //Make sure the Product Name is not used by another Product
            if (txtProductName.Text.Trim() != _Product.ProductName && ClsProduct.IsProductExist(txtProductName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtProductName, "هذاالاسم خاص بمنتج اخراستخدم خيره");

            }
            else
            {
                errorProvider1.SetError(txtProductName, null);
            }
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

            if (!_HandleProductImage())
                return;

            int CategoryID = ClsCategory.GetCategoryInfoByName(cbCategory.Text).CategoryID;

            _Product.ProductName = txtProductName.Text.Trim();
            _Product.QuantityStock = int.Parse(txtQuantity.Text);
            _Product.Price = (decimal)Convert.ToDecimal(txtPrice.Text);
            _Product.Description = txtDescription.Text.Trim();
            _Product.CategoryID =  CategoryID;


            if (pbProductImage.ImageLocation != null)
                _Product.ImagePath = pbProductImage.ImageLocation;
            else
                _Product.ImagePath = "";

            if (_Product.Save())
            {
                lblProductID.Text = _Product.ProductID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                lblTitle.Text = "تحديث المنتج";

                MessageBox.Show(".تم الحفظ بنجاح", "تم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // Trigger the event to send data back to the caller form.
                //DataBack?.Invoke(this, _Person.PersonID);
            }
            else
                MessageBox.Show("خطأ: لم يتم الحفظ هناك مشكلة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       



    }
}
