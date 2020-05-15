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
        public void MinCustomerID()
        {
            int testdata = 1;
            order.Customer_Id = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.CustomerID, order.ProductID, order.ProductName, order.OrderQuantity, order.Dispatch, order.DateAdded));
            
        }
        [TestMethod]
        public void MaxCustomerID()
        {
            int testdata = 500000;
            order.Customer_Id = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.CustomerID, order.ProductID, order.ProductName, order.OrderQuantity, order.Dispatch, order.DateAdded));

        }
        [TestMethod]
        public void MaxMinus1CustomerID()
        {
            int testdata = 49999;
            order.Customer_Id = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.CustomerID, order.ProductID, order.ProductName, order.OrderQuantity, order.Dispatch, order.DateAdded));


        }
        [TestMethod]
        public void MinMinus1CustomerID()
        {
            int testdata = 0;
            order.Customer_Id = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.CustomerID, order.ProductID, order.ProductName, order.OrderQuantity, order.Dispatch, order.DateAdded));

        }
        [TestMethod]
        public void MaxPlus1CustomerID()
        {
            int testdata = 500001;
            order.Customer_Id = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.CustomerID, order.ProductID, order.ProductName, order.OrderQuantity, order.Dispatch, order.DateAdded));

        }
        [TestMethod]
        public void MinPlus1CustomerID()
        {
            int testdata = 2;
            order.Customer_Id = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.CustomerID, order.ProductID, order.ProductName, order.OrderQuantity, order.Dispatch, order.DateAdded));

        }
        [TestMethod]
        public void MidCustomerID()
        {
            int testdata = 25;
            order.Customer_Id = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.CustomerID, order.ProductID, order.ProductName, order.OrderQuantity, order.Dispatch, order.DateAdded));

        }
        [TestMethod]
        public void ExtremeMinCustomerID()
        {
            int testdata = -200;
            order.Customer_Id = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.CustomerID, order.ProductID, order.ProductName, order.OrderQuantity, order.Dispatch, order.DateAdded));

        }
        [TestMethod]
        public void ExtremeMaxCustomerID()
        {
            int testdata = 500000;
            order.Customer_Id = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.CustomerID, order.ProductID, order.ProductName, order.OrderQuantity, order.Dispatch, order.DateAdded));

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
        public void MinProductID()
        {
            int testdata = -5;
            order.Product_Id = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.CustomerID, order.ProductID, order.ProductName, order.OrderQuantity, order.Dispatch, order.DateAdded));

        }
        [TestMethod]
        public void MaxProductID()
        {
            int testdata = 50000;
            order.Product_Id = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.CustomerID, order.ProductID, order.ProductName, order.OrderQuantity, order.Dispatch, order.DateAdded));

        }
        [TestMethod]
        public void MinMinus1ProductID()
        {
            int testdata = 0;
            order.Product_Id = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.CustomerID, order.ProductID, order.ProductName, order.OrderQuantity, order.Dispatch, order.DateAdded));

        }
        [TestMethod]
        public void MaxMinus1ProductID()
        {
            int testdata = 49999;
            order.Product_Id = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.CustomerID, order.ProductID, order.ProductName, order.OrderQuantity, order.Dispatch, order.DateAdded));

        }
        [TestMethod]
        public void MidProductID()
        {
            int testdata = 25;
            order.Product_Id = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.CustomerID, order.ProductID, order.ProductName, order.OrderQuantity, order.Dispatch, order.DateAdded));

        }
        [TestMethod]
        public void MinPlus1ProductID()
        {
            int testdata = 2;
            order.Product_Id = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.CustomerID, order.ProductID, order.ProductName, order.OrderQuantity, order.Dispatch, order.DateAdded));

        }
        [TestMethod]
        public void MaxPlus1ProductID()
        {
            int testdata = 500001;
            order.Product_Id = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.CustomerID, order.ProductID, order.ProductName, order.OrderQuantity, order.Dispatch, order.DateAdded));

        }
        [TestMethod]
        public void ExtremeMinProductID()
        {
            int testdata = -200;
            order.Product_Id = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.CustomerID, order.ProductID, order.ProductName, order.OrderQuantity, order.Dispatch, order.DateAdded));

        }
        [TestMethod]
        public void ExtremeMaxProductID()
        {
            int testdata = int.MaxValue;
            order.Product_Id = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.CustomerID, order.ProductID, order.ProductName, order.OrderQuantity, order.Dispatch, order.DateAdded));

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
        public void MinProductName()
        {
            string testdata = "A";
            order.ProductName = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.CustomerID, order.ProductID, order.ProductName, order.OrderQuantity, order.Dispatch, order.DateAdded));
        }
        [TestMethod]
        public void MaxProductName()
        {
            string testdata = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            order.ProductName = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.CustomerID, order.ProductID, order.ProductName, order.OrderQuantity, order.Dispatch, order.DateAdded));
        }
        [TestMethod]
        public void MaxPlus1ProductName()
        {
            string testdata = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            order.ProductName = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.CustomerID, order.ProductID, order.ProductName, order.OrderQuantity, order.Dispatch, order.DateAdded));
        }
        [TestMethod]
        public void MinPlus1ProductName()
        {
            string testdata = "AA";
            order.ProductName = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.CustomerID, order.ProductID, order.ProductName, order.OrderQuantity, order.Dispatch, order.DateAdded));
        }
        [TestMethod]
        public void MaxMinus1ProductName()
        {
            string testdata = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            order.ProductName = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.CustomerID, order.ProductID, order.ProductName, order.OrderQuantity, order.Dispatch, order.DateAdded));
        }
        [TestMethod]
        public void ExtremeMinProductName()
        {
            string testdata = "";
            order.ProductName = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.CustomerID, order.ProductID, order.ProductName, order.OrderQuantity, order.Dispatch, order.DateAdded));
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
        public void MinOrderQuantity()
        {
            int testdata = 1;
            order.Order_Quantity = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.CustomerID, order.ProductID, order.ProductName, order.OrderQuantity, order.Dispatch, order.DateAdded));
        }
        [TestMethod]
        public void MaxOrderQuantity()
        {
            int testdata = 5000000768;
            order.Order_Quantity = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.CustomerID, order.ProductID, order.ProductName, order.OrderQuantity, order.Dispatch, order.DateAdded));
        }
        [TestMethod]
        public void MaxPlus1OrderQuantity()
        {
            int testdata = 5000000769;
            order.Order_Quantity = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.CustomerID, order.ProductID, order.ProductName, order.OrderQuantity, order.Dispatch, order.DateAdded));
        }
        [TestMethod]
        public void MaxMinus1OrderQuantity()
        {
            int testdata = 5000000767;
            order.Order_Quantity = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.CustomerID, order.ProductID, order.ProductName, order.OrderQuantity, order.Dispatch, order.DateAdded));
        }
        public void MinMinus1OrderQuantity()
        {
            int testdata = 0;
            order.Order_Quantity = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.CustomerID, order.ProductID, order.ProductName, order.OrderQuantity, order.Dispatch, order.DateAdded));
        }
        [TestMethod]
        public void MinPlus1OrderQuantity()
        {
            int testdata = 2;
            order.Order_Quantity = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.CustomerID, order.ProductID, order.ProductName, order.OrderQuantity, order.Dispatch, order.DateAdded));
        }
        [TestMethod]
        public void ExtremeMinOrderQuantity()
        {
            int testdata = 0;
            order.Order_Quantity = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.CustomerID, order.ProductID, order.ProductName, order.OrderQuantity, order.Dispatch, order.DateAdded));
        }
        [TestMethod]
        public void DispatchOK()
        {
            Assert.IsNotNull(order.Dispatch);
            bool testdata = true;
            order.Dispatch = testdata;
            Assert.AreEqual(order.Dispatch, testdata);

        }
        public void MinDispatch()
        {
            bool testdata = false;
            order.Dispatch - testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.CustomerID, order.ProductID, order.ProductName, order.OrderQuantity, order.Dispatch, order.DateAdded));
        }
        public void MaxDispatch()
        {
            bool testdata = true;
            order.Dispatch - testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.CustomerID, order.ProductID, order.ProductName, order.OrderQuantity, order.Dispatch, order.DateAdded));
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
        public void MinDate()
        {
            DateTime testdata = DateTime.Now.AddDays(-1);
            order.Date_Ordered = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.CustomerID, order.ProductID, order.ProductName, order.OrderQuantity, order.Dispatch, order.DateAdded));
        }
        [TestMethod]
        public void MaxDate()
        {
            DateTime testdata = DateTime.Now;
            order.Date_Ordered = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.CustomerID, order.ProductID, order.ProductName, order.OrderQuantity, order.Dispatch, order.DateAdded));
        }
        [TestMethod]
        public void MinDate()
        {
            DateTime testdata = DateTime.Now;
            order.Date_Ordered = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.CustomerID, order.ProductID, order.ProductName, order.OrderQuantity, order.Dispatch, order.DateAdded));
        }
        [TestMethod]
        public void ExtremeMaxDate()
        {
            DateTime testdata = DateTime.Now.AddYears(3000);
            order.Date_Ordered = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.CustomerID, order.ProductID, order.ProductName, order.OrderQuantity, order.Dispatch, order.DateAdded));
        }
        [TestMethod]
        public void ExtremeMinDate()
        {
            DateTime testdata = DateTime.Now.AddYears(-3000);
            order.Date_Ordered = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.CustomerID, order.ProductID, order.ProductName, order.OrderQuantity, order.Dispatch, order.DateAdded));
        }
        [TestMethod]
        public void FindOK()
        {
            Assert.IsTrue(order.find(4));
            
        }

        [TestMethod]
        public void ValidOK()
        {

           string Error = "";
           Assert.AreEqual(Error, order.valid(1, 1, "product", true, 2, DateTime.Today));
        }
        [TestMethod]
        public void CustomerIDValid()
        {
            string Error = "";
            Assert.AreEqual(Error, order.customerIDvalid(4));
        }
        [TestMethod]
        public void ProductIDValid()
        {
            string Error = "";
            Assert.AreEqual(Error, order.productIDvalid(4));
        }
        [TestMethod]
        public void ProductNameValid()
        {
            string Error = "";
            Assert.AreEqual(Error, order.productNamevalid("uoiew"));

        }
        [TestMethod]
        public void OrderQuantityValid()
        {
            string Error = "";
            Assert.AreEqual(Error, order.orderQuantityValid(2));
        }
        [TestMethod]
        public void DispatchValid()
        {
            string Error = "";
            Assert.AreEqual(Error, order.dispatchValid(true));

        }
        [TestMethod]
        public void DateValid()
        {
            string Error = "";
            Assert.AreEqual(Error, order.dateTimevalid(DateTime.Now.Date));

        }
        [TestMethod]
        public void OrderValid()
        {
            string Error = "";
            Assert.AreEqual(Error, order.valid(4, 4, "jfe", true, 3, DateTime.Now.Date));
        }
        

    }
}
