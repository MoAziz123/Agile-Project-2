using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary2;


namespace UnitTestProject1
{
    [TestClass]
    public class tststock
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStock AStock = new clsStock();
            Assert.IsNotNull(AStock);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            clsStock AStock = new clsStock();
            Boolean TestData = true;
            AStock.Active = TestData;
            Assert.AreEqual(AStock.Active, TestData);
        }

        [TestMethod]
        public void DataAddedPropertyOK()
        {
            clsStock AStock = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            AStock.DateAdded = TestData;
            Assert.AreEqual(AStock.DateAdded, TestData);
        }

        [TestMethod]
        public void AddressNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStock.AddressNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.AddressNo, TestData);
        }

        [TestMethod]
        public void CountyNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStock.CountyNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.CountyNo, TestData);
        }

        [TestMethod]
        public void HouseNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            AStock.HouseNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.HouseNo, TestData);
        }

        [TestMethod]
        public void PostCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "LE1 4AB";
            //assign the data to the property
            AStock.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.PostCode, TestData);
        }

        [TestMethod]
        public void StreetPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "Some Street";
            //assign the data to the property
            AStock.Street = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Street, TestData);
        }

        [TestMethod]
        public void TownPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "Leicester";
            //assign the data to the property
            AStock.Town = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Town, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsStock AStock = new clsStock();

            Boolean Found = false;
            Int32 ProductID = 1;

            Found = AStock.Find(ProductID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStockNotFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 ProductID = 21;
            Found = AStock.Find(ProductID);
            if (AStock.AddressNo != 21)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

    }
}