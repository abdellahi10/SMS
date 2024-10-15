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
    public class ClsOrderItem 
    {
        enum enMode { Addnew = 0, Update = 1 }
        enMode _Mode = enMode.Addnew;

        public int ItemID;
        public int OrderID;
        public int ProductID;
        public int Quantity;
        public double ItemPrice;
        public double TotalAmount;

        public ClsOrder OrderInfo;
        public ClsProduct ProductInfo;

        public ClsOrderItem()
        {
            ItemID = -1;
            OrderID = -1;
            ProductID = -1;
            Quantity = 0;
            ItemPrice = 0;
            TotalAmount = 0;

            _Mode = enMode.Addnew;
        }

        private ClsOrderItem(int ItemID, int OrderID, int ProductID, int Quantity, double ItemPrice, double TotalAmount)
        {
            this.ItemID = ItemID;
            this.OrderID = OrderID;
            this.ProductID = ProductID;
            this.Quantity = Quantity;
            this.ItemPrice = ItemPrice;
            this.TotalAmount = TotalAmount;

            OrderInfo = ClsOrder.GetOrderInfoByID(OrderID);
            ProductInfo = ClsProduct.GetProductInfoByID(ProductID);

            _Mode = enMode.Update;
        }

        public static ClsOrderItem GetOrderItemInfoByID(int ItemID)
        {
            int OrderID = -1;
            int ProductID = -1;
            int Quantity = 0;
            double ItemPrice = 0;
            double TotalAmount = 0;

            bool isFound = ClsOrderItemData.GetOrderItemInfoByID(ItemID, ref OrderID, ref ProductID, ref Quantity, ref ItemPrice, ref TotalAmount);

            return isFound ? new ClsOrderItem(ItemID, OrderID, ProductID, Quantity, ItemPrice, TotalAmount) : null;
        }

        public static bool isItemIncludeThisProduct(int ProductID)
        {
            return ClsOrderItemData.isItemIncludeThisProduct(ProductID);
        }

        private bool _AddNewItem()
        {
            this.ItemID = ClsOrderItemData.AddNewItem(this.OrderID, this.ProductID, this.Quantity, this.ItemPrice, this.TotalAmount);

            return (this.ItemID != -1);
        }

        private bool _UpdateItem()
        {
            return ClsOrderItemData.UpdateItem(this.ItemID, this.OrderID, this.ProductID, this.Quantity, this.ItemPrice, this.TotalAmount);
        }

        public static DataTable GetAllItems()
        {
           return ClsOrderItemData.GetAllItems();
        }

        public static DataTable GetAllSales()
        {
            return ClsOrderItemData.GetAllSales();
        }

        public static int[] GetMainReoprt()
        {
            return ClsOrderItemData.GetMainReoprt();
        }

        public bool Save()
        {
          
            switch (_Mode)
            {
                case enMode.Addnew:
                    if (_AddNewItem())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateItem();
            }

            return false;

        }




    }
}
