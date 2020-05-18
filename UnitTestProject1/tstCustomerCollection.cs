using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ClassLibrary2;

namespace UnitTestProject1
{
    [TestClass]
    public class TstCustomerCollection
    {
        private object TestItem;

        public List<clsCustomer> TestCustomer { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            ClsCustomerCollection AllCustomers = new ClsCustomerCollection();
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            ClsCustomerCollection AllCustomers = new ClsCustomerCollection();

            List<clsCustomer> TestList = new List<clsCustomer>();

            clsCustomer TestItem = new clsCustomer();

            TestItem.CustomerID = 0;
            TestItem.Customer_FirstName = "albs";
            TestItem.Customer_SurName = "albs";
            TestItem.Customer_Email = "albsemail";
            TestItem.Customer_Address = "albsaddress";

            TestList.Add(TestItem);

            AllCustomers.CustomerList = TestList;

            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            ClsCustomerCollection AllCustomers = new ClsCustomerCollection();
            int SomeCount = 2;
            AllCustomers.Count = SomeCount;
            Assert.AreEqual(AllCustomers.Count, SomeCount);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            ClsCustomerCollection AllCustomers = new ClsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.CustomerID = 0;
            TestItem.Customer_FirstName = "albs";
            TestItem.Customer_SurName = "albs";
            TestItem.Customer_Email = "albsemail";
            TestItem.Customer_Address = "albsaddress";
            TestList.Add(TestItem);
            AllCustomers.ThisCustomerPropertyOK = TestCustomer;
            Assert.AreEqual(AllCustomers.ThisCustomerPropertyOK, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            ClsCustomerCollection AllCustomers = new ClsCustomerCollection();

            List<clsCustomer> TestList = new List<clsCustomer>();

            clsCustomer TestItem = new clsCustomer();

            TestItem.CustomerID = 0;
            TestItem.Customer_FirstName = "albs";
            TestItem.Customer_SurName = "albs";
            TestItem.Customer_Email = "albsemail";
            TestItem.Customer_Address = "albsaddress";
            TestList.Add(TestItem);

            AllCustomers.CustomerList = TestList;

            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoRecordsPresent()
        {
            ClsCustomerCollection AllCustomers = new ClsCustomerCollection();

            Assert.AreEqual(AllCustomers.Count, 2);



        }


        [TestMethod]
        public void AddMethodOK()
        {
            ClsCustomerCollection AllCustomers = new ClsCustomerCollection();
            int PrimaryKey = 0;
            TestItem.CustomerID = 0;
            TestItem.Customer_FirstName = "albs";
            TestItem.Customer_SurName = "albs";
            TestItem.Customer_Email = "albsemail";
            TestItem.Customer_Address = "albsaddress";
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }


    }
}
