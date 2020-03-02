using System;
using ClassLibrary2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class tstorder
    {
        public clsOrder order;
        public tstorder()
        {
            order = new clsOrder();
            //Test Data
            order.Customer_Id = 1;
            order.Product_Id = 1;
            order.Product_Name = "gym shorts";
            order.Dispatch = true;
            order.Order_Quantity= 5;
            order.Date_Ordered = DateTime.Now;

        }
        [TestMethod]
        public void InstanceOK()
        {
            Assert.IsNotNull(order);
            
        }
        [TestMethod]
        public void CustomerIDOK()
        {
            //Assert.IsNotNull(order.Customer_Id);
            int testdata = 3;
            order.Customer_Id = testdata;
            Assert.AreEqual(order.Customer_Id, testdata);
        }
        [TestMethod]
        public void ProductIDOK()
        {
            Assert.IsNotNull(order.Product_Id);
            int testdata = 4;
            order.Product_Id = testdata;
            Assert.AreEqual(order.Product_Id, testdata);
        }
        [TestMethod]
        public void ProductNameOK()
        {
            Assert.IsNotNull(order.Product_Name);
            string testdata = "Gym Socks";
            order.Product_Name = testdata;
            Assert.AreEqual(order.Product_Name, testdata);

        }
        [TestMethod]
        public void Order_QuantityOK()
        {
            Assert.IsNotNull(order.Order_Quantity);
            int testdata = 14;
            order.Order_Quantity = testdata;
            Assert.AreEqual(order.Order_Quantity, testdata);
        }
        [TestMethod]
        public void DispatchOK()
        {
            Assert.IsNotNull(order.Dispatch);
            bool testdata = true;
            order.Dispatch = testdata;
            Assert.AreEqual(order.Dispatch, testdata);

        }
        [TestMethod]
        public void DateOK()
        {
            
            Assert.IsNotNull(order.Date_Ordered);
            DateTime testdata = DateTime.Now.AddHours(4.00);
            order.Date_Ordered = testdata;
            Assert.AreEqual(order.Date_Ordered, testdata);
        }
        [TestMethod]
        public void FindOK()
        {
            Assert.IsTrue(order.find(4));
            
        }
    }
}
