using SMS_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SMS_Business
{
    public class ClsCategory
    {
        enum enMode { Addnew = 0, Update = 1 }
        enMode _Mode = enMode.Addnew;

        public int CategoryID { set; get; }
        public string CategoryName { set; get; }

        public ClsCategory()
        {
            CategoryID = -1;
            CategoryName = string.Empty;

            _Mode = enMode.Addnew;
        }
        public ClsCategory(int CategoryID, string CategoryName)
        {
            this.CategoryID = CategoryID;
            this.CategoryName = CategoryName;

            _Mode = enMode.Update;
        }
       
        public static ClsCategory GetCategoryInfoByID(int CategoryID)
        {
            string CategoryName = string.Empty;

            if (ClsCategoryData.GetCategoryInfoByID(CategoryID, ref CategoryName))
                return
                        new ClsCategory(CategoryID, CategoryName);
            else
                return null;

        }
        public static ClsCategory GetCategoryInfoByName(string CategoryName)
        {
            int CategoryID = -1;

            if (ClsCategoryData.GetCategoryInfoByName(CategoryName, ref CategoryID))
                return
                        new ClsCategory(CategoryID, CategoryName);
            else
                return null;
        }
        private bool _AddNewCategory()
        {
            this.CategoryID = ClsCategoryData.AddNewCategory(this.CategoryName);

            return (this.CategoryID != -1);
        }
        private bool _UpdateCategory()
        {
            return ClsCategoryData.UpdateCategory(this.CategoryID, this.CategoryName);
        }
        public static DataTable GetAllCategories()
        {
            return ClsCategoryData.GetAllCategories();
        }
        public static bool DeleteCategory(int CategoryID)
        {
            return ClsCategoryData.DeleteCategory(CategoryID);
        }
        public static bool IsCategoryExist(int CategoryID)
        {
            return ClsCategoryData.IsCategoryExist(CategoryID);
        }
        public static bool IsCategoryExist(string CategoryName)
        {
            return ClsCategoryData.IsCategoryExist(CategoryName);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Addnew:
                    if (_AddNewCategory())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateCategory();

            }


            return false;

        }


    }
}
