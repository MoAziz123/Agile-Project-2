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
        public void Customer_IdOK()
        {
            //Assert.IsNotNull(order.Customer_Id);
            int testdata = 3;
            order.Customer_Id = testdata;
            Assert.AreEqual(order.Customer_Id, testdata);
        }
        [TestMethod]
        public void MinCustomer_Id()
        {
            int testdata = 1;
            order.Customer_Id = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.Customer_Id, order.Product_Id, order.Product_Name, order.Order_Quantity, order.Dispatch, order.Date_Ordered));
            
        }
        [TestMethod]
        public void MaxCustomer_Id()
        {
            int testdata = 500000;
            order.Customer_Id = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.Customer_Id, order.Product_Id, order.Product_Name, order.Order_Quantity, order.Dispatch, order.Date_Ordered));

        }
        [TestMethod]
        public void MaxMinus1Customer_Id()
        {
            int testdata = 49999;
            order.Customer_Id = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.Customer_Id, order.Product_Id, order.Product_Name, order.Order_Quantity, order.Dispatch, order.Date_Ordered));


        }
        [TestMethod]
        public void MinMinus1Customer_Id()
        {
            int testdata = 0;
            order.Customer_Id = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.Customer_Id, order.Product_Id, order.Product_Name, order.Order_Quantity, order.Dispatch, order.Date_Ordered));

        }
        [TestMethod]
        public void MaxPlus1Customer_Id()
        {
            int testdata = 500001;
            order.Customer_Id = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.Customer_Id, order.Product_Id, order.Product_Name, order.Order_Quantity, order.Dispatch, order.Date_Ordered));

        }
        [TestMethod]
        public void MinPlus1Customer_Id()
        {
            int testdata = 2;
            order.Customer_Id = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.Customer_Id, order.Product_Id, order.Product_Name, order.Order_Quantity, order.Dispatch, order.Date_Ordered));

        }
        [TestMethod]
        public void MidCustomer_Id()
        {
            int testdata = 25;
            order.Customer_Id = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.Customer_Id, order.Product_Id, order.Product_Name, order.Order_Quantity, order.Dispatch, order.Date_Ordered));

        }
        [TestMethod]
        public void ExtremeMinCustomer_Id()
        {
            int testdata = -200;
            order.Customer_Id = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.Customer_Id, order.Product_Id, order.Product_Name, order.Order_Quantity, order.Dispatch, order.Date_Ordered));

        }
        [TestMethod]
        public void ExtremeMaxCustomer_Id()
        {
            int testdata = 500000;
            order.Customer_Id = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.Customer_Id, order.Product_Id, order.Product_Name, order.Order_Quantity, order.Dispatch, order.Date_Ordered));

        }
       
        [TestMethod]
        public void Product_IdOK()
        {
            Assert.IsNotNull(order.Product_Id);
            int testdata = 4;
            order.Product_Id = testdata;
            Assert.AreEqual(order.Product_Id, testdata);
        }
        [TestMethod]
        public void MinProduct_Id()
        {
            int testdata = -5;
            order.Product_Id = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.Customer_Id, order.Product_Id, order.Product_Name, order.Order_Quantity, order.Dispatch, order.Date_Ordered));

        }
        [TestMethod]
        public void MaxProduct_Id()
        {
            int testdata = 50000;
            order.Product_Id = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.Customer_Id, order.Product_Id, order.Product_Name, order.Order_Quantity, order.Dispatch, order.Date_Ordered));

        }
        [TestMethod]
        public void MinMinus1Product_Id()
        {
            int testdata = 0;
            order.Product_Id = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.Customer_Id, order.Product_Id, order.Product_Name, order.Order_Quantity, order.Dispatch, order.Date_Ordered));

        }
        [TestMethod]
        public void MaxMinus1Product_Id()
        {
            int testdata = 49999;
            order.Product_Id = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.Customer_Id, order.Product_Id, order.Product_Name, order.Order_Quantity, order.Dispatch, order.Date_Ordered));

        }
        [TestMethod]
        public void MidProduct_Id()
        {
            int testdata = 25;
            order.Product_Id = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.Customer_Id, order.Product_Id, order.Product_Name, order.Order_Quantity, order.Dispatch, order.Date_Ordered));

        }
        [TestMethod]
        public void MinPlus1Product_Id()
        {
            int testdata = 2;
            order.Product_Id = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.Customer_Id, order.Product_Id, order.Product_Name, order.Order_Quantity, order.Dispatch, order.Date_Ordered));

        }
        [TestMethod]
        public void MaxPlus1Product_Id()
        {
            int testdata = 500001;
            order.Product_Id = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.Customer_Id, order.Product_Id, order.Product_Name, order.Order_Quantity, order.Dispatch, order.Date_Ordered));

        }
        [TestMethod]
        public void ExtremeMinProduct_Id()
        {
            int testdata = -200;
            order.Product_Id = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.Customer_Id, order.Product_Id, order.Product_Name, order.Order_Quantity, order.Dispatch, order.Date_Ordered));

        }
        [TestMethod]
        public void ExtremeMaxProduct_Id()
        {
            int testdata = int.MaxValue;
            order.Product_Id = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.Customer_Id, order.Product_Id, order.Product_Name, order.Order_Quantity, order.Dispatch, order.Date_Ordered));

        }
        [TestMethod]
        public void Product_NameOK()
        {
            Assert.IsNotNull(order.Product_Name);
            string testdata = "Gym Socks";
            order.Product_Name = testdata;
            Assert.AreEqual(order.Product_Name, testdata);

        }
        [TestMethod]
        public void MinProduct_Name()
        {
            string testdata = "A";
            order.Product_Name = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.Customer_Id, order.Product_Id, order.Product_Name, order.Order_Quantity, order.Dispatch, order.Date_Ordered));
        }
        [TestMethod]
        public void MaxProduct_Name()
        {
            string testdata = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            order.Product_Name = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.Customer_Id, order.Product_Id, order.Product_Name, order.Order_Quantity, order.Dispatch, order.Date_Ordered));
        }
        [TestMethod]
        public void MaxPlus1Product_Name()
        {
            string testdata = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            order.Product_Name = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.Customer_Id, order.Product_Id, order.Product_Name, order.Order_Quantity, order.Dispatch, order.Date_Ordered));
        }
        [TestMethod]
        public void MinPlus1Product_Name()
        {
            string testdata = "AA";
            order.Product_Name = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.Customer_Id, order.Product_Id, order.Product_Name, order.Order_Quantity, order.Dispatch, order.Date_Ordered));
        }
        [TestMethod]
        public void MaxMinus1Product_Name()
        {
            string testdata = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            order.Product_Name = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.Customer_Id, order.Product_Id, order.Product_Name, order.Order_Quantity, order.Dispatch, order.Date_Ordered));
        }
        [TestMethod]
        public void ExtremeMinProduct_Name()
        {
            string testdata = "";
            order.Product_Name = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.Customer_Id, order.Product_Id, order.Product_Name, order.Order_Quantity, order.Dispatch, order.Date_Ordered));
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
        public void MinOrder_Quantity()
        {
            int testdata = 1;
            order.Order_Quantity = testdata;
            string error = "";
            Assert.AreEqual(error, order.orderQuantityValid(order.Order_Quantity));
        }
        [TestMethod]
        public void MaxOrder_Quantity()
        {
            int testdata = 5000768;
            order.Order_Quantity = testdata;
            string error = "";
            Assert.AreEqual(error, order.orderQuantityValid(order.Order_Quantity));
        }
        [TestMethod]
        public void MaxPlus1Order_Quantity()
        {
            int testdata = 5000009;
            order.Order_Quantity = testdata;
            string error = "";
            Assert.AreEqual(error, order.orderQuantityValid(order.Order_Quantity));
        }
        [TestMethod]
        public void MaxMinus1Order_Quantity()
        {
            int testdata = 5000007;
            order.Order_Quantity = testdata;
            string error = "";
            Assert.AreEqual(error, order.orderQuantityValid(order.Order_Quantity));
        }
        public void MinMinus1Order_Quantity()
        {
            int testdata = 0;
            order.Order_Quantity = testdata;
            string error = "";
            Assert.AreEqual(error, order.orderQuantityValid(order.Order_Quantity));
        }
        [TestMethod]
        public void MinPlus1Order_Quantity()
        {
            int testdata = 2;
            order.Order_Quantity = testdata;
            string error = "";
            Assert.AreEqual(error, order.orderQuantityValid(order.Order_Quantity));
        }
        [TestMethod]
        public void ExtremeMinOrder_Quantity()
        {
            int testdata = 0;
            order.Order_Quantity = testdata;
            string error = "";
            Assert.AreEqual(error, order.orderQuantityValid(order.Order_Quantity));
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
            order.Dispatch = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.Customer_Id, order.Product_Id, order.Product_Name, order.Order_Quantity, order.Dispatch, order.Date_Ordered));
        }
        public void MaxDispatch()
        {
            bool testdata = true;
            order.Dispatch = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.Customer_Id, order.Product_Id, order.Product_Name, order.Order_Quantity, order.Dispatch, order.Date_Ordered));
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
        public void MinDateMinus1()
        {
            DateTime testdata = DateTime.Now.AddDays(-1);
            order.Date_Ordered = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.Customer_Id, order.Product_Id, order.Product_Name, order.Order_Quantity, order.Dispatch, order.Date_Ordered));
        }
        [TestMethod]
        public void MaxDate()
        {
            DateTime testdata = DateTime.Now;
            order.Date_Ordered = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.Customer_Id, order.Product_Id, order.Product_Name, order.Order_Quantity, order.Dispatch, order.Date_Ordered));
        }
        [TestMethod]
        public void MinDate()
        {
            DateTime testdata = DateTime.Now;
            order.Date_Ordered = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.Customer_Id, order.Product_Id, order.Product_Name, order.Order_Quantity, order.Dispatch, order.Date_Ordered));
        }
        [TestMethod]
        public void ExtremeMaxDate()
        {
            DateTime testdata = DateTime.Now.AddYears(3000);
            order.Date_Ordered = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.Customer_Id, order.Product_Id, order.Product_Name, order.Order_Quantity, order.Dispatch, order.Date_Ordered));
        }
        [TestMethod]
        public void ExtremeMinDate()
        {
            DateTime testdata = DateTime.Now.AddYears(-3000);
            order.Date_Ordered = testdata;
            string error = "";
            Assert.AreEqual(error, order.valid(order.Customer_Id, order.Product_Id, order.Product_Name, order.Order_Quantity, order.Dispatch, order.Date_Ordered));
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
           Assert.AreEqual(Error, order.valid(1, 1, "product",2, true, DateTime.Today));
        }
        [TestMethod]
        public void Customer_IdValid()
        {
            string Error = "";
            Assert.AreEqual(Error, order.customerIDvalid(4));
        }
        [TestMethod]
        public void Product_IdValid()
        {
            string Error = "";
            Assert.AreEqual(Error, order.productIDvalid(4));
        }
        [TestMethod]
        public void Product_NameValid()
        {
            string Error = "";
            Assert.AreEqual(Error, order.productNamevalid("uoiew"));

        }
        [TestMethod]
        public void Order_QuantityValid()
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
            Assert.AreEqual(Error, order.valid(4, 4, "jfe", 3, true, DateTime.Now.Date));
        }
        

    }
}
