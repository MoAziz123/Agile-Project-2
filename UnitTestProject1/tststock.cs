using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class tststock
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsAddress AnAddress = new clsAddress();
            Assert.IsNotNull(AnAddress);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            clsAddress AnAddress = new clsAddress();
            Boolean TestData = true;
            AnAddress.Active = TestData;
            Assert.AreEqual(AnAddress.Active, TestData);
        }

        [TestMethod]
        public void DataAddedPropertyOK()
        {
            clsAddress AnAddress = new clsAddress();
            DateTime TestData = DateTime.Now.Date;
            AnAddress.DateAdded = TestData;
            Assert.AreEqual(AnAddress.DateAdded, TestData);
        }

        [TestMethod]
        public void AddressNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnAddress.AddressNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.AddressNo, TestData);
        }

        [TestMethod]
        public void CountyNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnAddress.CountyNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.CountyNo, TestData);
        }

        [TestMethod]
        public void HouseNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            AnAddress.HouseNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.HouseNo, TestData);
        }

        [TestMethod]
        public void PostCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property
            string TestData = "LE1 4AB";
            //assign the data to the property
            AnAddress.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.PostCode, TestData);
        }

        [TestMethod]
        public void StreetPropertyOK()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property
            string TestData = "Some Street";
            //assign the data to the property
            AnAddress.Street = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.Street, TestData);
        }

        [TestMethod]
        public void TownPropertyOK()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property
            string TestData = "Leicester";
            //assign the data to the property
            AnAddress.Town = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.Town, TestData);
        }

    }
}