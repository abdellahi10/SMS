using SMS_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Business
{
    public class ClsProduct
    {

        enum enMode { Addnew = 0, Update = 1 }
        enMode _Mode = enMode.Addnew;

        public int ProductID { set; get; }
        public int CategoryID { set; get; }
        public string ProductName { set; get; }
        public string Description { set; get; }
        public int QuantityStock { set; get; }
        public decimal Price { set; get; }
        public string ImagePath { set; get; }

        public ClsCategory CategoryInfo; 

        public ClsProduct()
        {
            ProductID = -1;
            CategoryID = -1;
            ProductName = string.Empty;
            Description = string.Empty;
            QuantityStock = 0;
            Price = 0;
            ImagePath = string.Empty;

            _Mode = enMode.Addnew;
        }

        private ClsProduct(int ProductID, int CategoryID,
             string ProductName, string Description, int QuantityStock, decimal Price, string ImagePath)
        {
            this.ProductID = ProductID;
            this.CategoryID = CategoryID;
            this.ProductName = ProductName;
            this.Description = Description;
            this.QuantityStock = QuantityStock;
            this.Price = Price;
            this.ImagePath = ImagePath;

            CategoryInfo = ClsCategory.GetCategoryInfoByID(CategoryID);

            _Mode = enMode.Update;
        }

        public static ClsProduct GetProductInfoByID(int ProductID)
        {
            int CategoryID = -1;
            string ProductName = string.Empty;
            string Description = string.Empty;
            int QuantityStock = 0;
            decimal Price = 0;
            string ImagePath = string.Empty;

            bool IsFound = ClsProductData.GetProductInfoByID(ProductID, ref CategoryID, ref ProductName,ref Description, ref QuantityStock, ref Price, ref ImagePath);

            return IsFound ? new ClsProduct(ProductID, CategoryID, ProductName, Description, QuantityStock, Price, ImagePath) : null;
        }

        public static ClsProduct GetProductInfoByName(string ProductName)
        {
            int CategoryID = -1;
            string Description = string.Empty;
            int ProductID = -1;
            int QuantityStock = 0;
            decimal Price = 0;
            string ImagePath = string.Empty;

            bool IsFoun = ClsProductData.GetProductInfoByName(ProductName,ref ProductID, ref Description, ref CategoryID, ref QuantityStock, ref Price, ref ImagePath);

            return IsFoun ? new ClsProduct(ProductID, CategoryID, ProductName, Description, QuantityStock, Price, ImagePath) : null;
        }

        private bool _AddNewProduct()
        {
            this.ProductID = ClsProductData.AddNewProduct(this.CategoryID, this.ProductName, this.Description, this.QuantityStock, this.Price, this.ImagePath);

            return (this.ProductID != -1);
        }

        private bool _UpdateProduct()
        {
            return ClsProductData.UpdateProduct(this.ProductID, this.CategoryID,
                this.ProductName, this.Description, this.QuantityStock, this.Price, this.ImagePath);
        }

        public static DataTable GetAllProducts()
        {
            return ClsProductData.GetAllProducts();
        }

        public static bool DeleteProduct(int ProductID)
        {
           return ClsProductData.DeleteProduct(ProductID);
        }

        public static bool IsProductExist(int ProductID)
        {
            return ClsProductData.IsProductExist(ProductID);
        }

        public static bool IsProductExist(string ProductName)
        {
            return ClsProductData.IsProductExist(ProductName);
        }

        public static bool isThisCategoryConnectedWithProduct(int CategoryID)
        {
            return ClsProductData.isThisCategoryConnectedWithProduct(CategoryID);
        }

        public bool Save()
        {
            switch (_Mode)
            {

                case enMode.Addnew:
                    if (_AddNewProduct())
                    {
                        _Mode = enMode.Update;
                        return true; 
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateProduct();

            }

            return false;
        }


    }

}
