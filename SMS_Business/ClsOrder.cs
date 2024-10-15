using SMS_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Business
{
    public class ClsOrder
    {
        private enum enMode { Addnew = 0, Update = 1 }
        enMode _Mode = enMode.Addnew;

       // enum enOrderStatus { Pending = 1, Shipped = 2, Delivered = 3 }
       // enOrderStatus _OrderStatus = enOrderStatus.Pending;

        public int OrderID;
        public int CustomerID;
        public DateTime OrderDate;
        public int OrderedByUserID;
        public byte Status;
        public ClsCustomer CustomerInfo;

        public ClsOrder()
        {

            OrderID = -1;
            OrderedByUserID = -1;
            CustomerID = -1;
            OrderDate = DateTime.Now;
            Status = 0;

            _Mode = enMode.Addnew;
        }

        private ClsOrder(int OrderID, int CustomerID, DateTime OrderDate, int OrderedByUserID, byte Status)
        {
            this.OrderID = OrderID;
            this.CustomerID = CustomerID;
            this.OrderDate = OrderDate;
            this.Status = Status;
            this.OrderedByUserID = OrderedByUserID;
            CustomerInfo = ClsCustomer.GetCustomerInfoByID(CustomerID);
            _Mode = enMode.Update;
        }

        public static ClsOrder GetOrderInfoByID(int OrderID)
        {
            int CustomerID = -1;
            DateTime OrderDate = DateTime.Now;
            int OrderedByUserID = -1;
            byte Status = 0;

            bool IsFound = ClsOrderData.GetOrderInfoByID(OrderID, ref CustomerID, ref OrderDate, ref OrderedByUserID, ref Status);

            return IsFound ? new ClsOrder(OrderID, CustomerID, OrderDate, OrderedByUserID, Status) : null;

        }

        private bool _AddNewOrder()
        {
            this.OrderID = ClsOrderData.AddNewOrder(this.CustomerID, this.OrderDate, this.OrderedByUserID,this.Status);

            return (this.OrderID != -1);
        }

        private bool _UpdateOrder()
        {
            return ClsOrderData.UpdateOrder(this.OrderID, this.CustomerID, this.OrderDate, this.OrderedByUserID, this.Status);
        }

        public static DataTable GetAllOrders()
        {
            return ClsOrderData.GetAllOrders();
        }

        public static DataTable GetAllCustomerOrders(int CustomerID)
        {
            return ClsOrderData.GetAllCustomerOrders(CustomerID);
        }

        public static bool IsOrderExist(int OrderID)
        {
            return ClsOrderData.IsOrderExist(OrderID);
        }

        public static bool IsCustomerExist(int CustomerID)
        {
            return ClsOrderData.IsCustomerHasOrder(CustomerID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Addnew:
                    if (_AddNewOrder())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return _UpdateOrder();
            }

            return false;
        }




    }
}
