using System;
using System.Text;
using System.Collections.Generic;
using ClassLibrary2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    /// <summary>
    /// Summary description for tstOrderCollection
    /// </summary>
    [TestClass]
    public class tstOrderCollection
    {
        public clsOrderCollection col;
        public tstOrderCollection()
        {
            col = new clsOrderCollection();
            

        }

        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection ordercol = new clsOrderCollection();
            Assert.IsNotNull(ordercol);
        }
        [TestMethod]
        public void CountOK()
        {
            clsOrderCollection ordercol = new clsOrderCollection();
            int test = 5;
            ordercol.count = test;
            Assert.AreEqual(ordercol.count, test);

        }
        [TestMethod]
        public void ListOK()
        {
            clsOrderCollection order = new clsOrderCollection();
            clsOrder test = new clsOrder(1, 1, "broduct", true, 4, DateTime.Today);
            Assert.IsNotNull(order.list);

        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection col = new clsOrderCollection();
            List<clsOrder> list = new List<clsOrder>();
            clsOrder order = new clsOrder();
            order.Customer_Id = 1;
            order.Product_Id = 1;
            order.Product_Name = "product";
            order.Order_Quantity = 4;
            order.Dispatch = true;
            order.Date_Ordered = DateTime.Today;
            list.Add(order);
            col.list = list;
            Assert.AreEqual(col.list.Count, list.Count);
        }
        [TestMethod]
        public void DBCountOKNotNull()
        {
            clsDataConnection cl = new clsDataConnection();
            Assert.IsNotNull(cl.Count);

        }
        [TestMethod]
        public void AddOK()
        {
            clsOrderCollection ordercol = new clsOrderCollection();
            clsOrder test = new clsOrder(1, 10, "product", false, 3, DateTime.Today);
            ordercol.mthisorder = test;
            ordercol.Add();
            Assert.IsTrue(ordercol.mthisorder.find(10));   
                }
        [TestMethod]
        public void DeleteOK()
        {
            clsOrderCollection ordercol = new clsOrderCollection();
            ordercol.mthisorder = ordercol.list[0];
            int key = ordercol.list[0].Product_Id;
            ordercol.Delete();
            bool test = ordercol.mthisorder.find(key);
            Assert.IsFalse(test);

        }
        [TestMethod]
        public void UpdateOK()
        {
            clsOrderCollection col = new clsOrderCollection();
            clsDataConnection db = new clsDataConnection();
            clsOrder order = new clsOrder();
            order.Product_Id = 1;
            order.Customer_Id = 1;
            order.Date_Ordered = DateTime.Today;
            order.Dispatch = true;
            order.Order_Quantity = 4;
            order.Product_Name = "Gym gloves";
            col.mthisorder = order;
            col.Add();
            int key = order.Product_Id;
            clsOrder test = new clsOrder();
            test.Product_Id = key;
            test.Customer_Id = 2;
            test.Date_Ordered = DateTime.Today;
            test.Dispatch = false;
            test.Product_Name = "boxes";
            test.Order_Quantity = 5;
            col.mthisorder = test;
            col.Update();
            Assert.AreEqual(test.find(key), true);

        }
        [TestMethod]
        public void FilterOK()
        {
            string data = "Gym";
            clsOrderCollection order = new clsOrderCollection();
            clsOrderCollection test = new clsOrderCollection();
            clsDataConnection db = new clsDataConnection();
            order.Filter(data);
            order.PopulateList(db);
            test.Filter(data);
            test.PopulateList(db);
            Assert.AreEqual(order.list.Count, test.list.Count);
            
            
        }
        [TestMethod]
        public void FindOneOK()
        {
            int data = 5;
            clsOrder order = new clsOrder();
            clsOrder test = new clsOrder();
            Assert.AreEqual(order.find(data), test.find(data));
            
        }
    }
}
