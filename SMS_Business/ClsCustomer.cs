using SMS_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SMS_Business
{
    public class ClsCustomer
    {
        enum enMode { Addnew = 0, Update = 1 }
        enMode _Mode = enMode.Addnew;

        public int CustomerID { set; get; }
        public int PersonID { set; get; }
        public int CreatedByUserID { set; get; }
        public DateTime CreatedDate { set; get; }

        public clsPerson PersonInfo;

        public string FullName; 

        public ClsCustomer()
        {
            CustomerID = -1;
            PersonID = -1;
            CreatedByUserID = -1;
            CreatedDate = DateTime.Now;

            _Mode = enMode.Addnew;
        }

        private ClsCustomer(int CustomerID, int PersonID, int CreatedByUserID, DateTime CeratedDate)
        {
            this.CustomerID = CustomerID;
            this.PersonID = PersonID;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CeratedDate;

            PersonInfo = clsPerson.GetPersonInfoByID(PersonID);
            FullName = PersonInfo.FirstName.Trim() + " " + PersonInfo.LastName.Trim();


            _Mode = enMode.Update;

        }

        public static ClsCustomer GetCustomerInfoByID(int CustomerID)
        {
            int PersonID = -1;
            int CreatedByUserID=-1;
            DateTime CeratedDate = DateTime.Now;

            if (ClsCustomerData.GetCustomerInfoByID(CustomerID, ref PersonID, ref CreatedByUserID, ref CeratedDate))
                return new
                    ClsCustomer(CustomerID, PersonID, CreatedByUserID, CeratedDate);
            else
                return null;

        }

        public static ClsCustomer GetCustomerInfoByPersonID(int PersonID)
        {
            int CustomerID = -1;
            int CreatedByUserID = -1;
            DateTime CeratedDate = DateTime.Now;

            if (ClsCustomerData.GetCustomerInfoByPersonID(PersonID, ref CustomerID, ref CreatedByUserID, ref CeratedDate))
                return new
                    ClsCustomer(CustomerID, PersonID, CreatedByUserID, CeratedDate);
            else
                return null;
        }

        private bool _AddNewCustomer()
        {
            this.CustomerID = ClsCustomerData.AddNewCustomer(this.PersonID, this.CreatedByUserID, this.CreatedDate);

            return (this.CustomerID != -1);
        }

        private bool _UpdateCustomer()
        {
            return ClsCustomerData.UpdateCustomer(this.CustomerID, this.PersonID, this.CreatedByUserID, this.CreatedDate);
        }

        public static DataTable GetAllCustomers()
        {
            return ClsCustomerData.GetAllCustomers();
        }

        public static bool DeleteCustomer(int CustomerID)
        {
           return ClsCustomerData.DeleteCustomer(CustomerID);
        }

        public static bool IsCustomerExist(int CustomerID)
        {
            return ClsCustomerData.IsCustomerExist(CustomerID);
        }

        public static bool IsThisPersonCustomer(int PersonID)
        {
            return ClsCustomerData.IsThisPersonCustomer(PersonID);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Addnew:
                    if (_AddNewCustomer())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    case enMode.Update:
                    return _UpdateCustomer();
            }

            return false;


        }

    }




}
