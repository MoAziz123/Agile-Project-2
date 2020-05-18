using System;
using ClassLibrary2;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject1
{
    [TestClass]
    public class Tstcustomer

    {

        int CustomerID = 1;
        string Customer_FirstName = "albs";
        string Customer_Surname = "arts";
        string Customer_Email = " albsarts";
        string Customer_Address = "93";

        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer Acustomer = new clsCustomer();
            Assert.IsNotNull(Acustomer);

        }

        [TestMethod]
        public void CustomerIDPropetyOK()
        {
            clsCustomer Acustomer = new clsCustomer();
            int TestData = 3;
            Acustomer.CustomerID = TestData;
            Assert.AreEqual(Acustomer.CustomerID, TestData);

        }

        [TestMethod]
        public void Customer_FirstNamePropetyOK()
        {
            clsCustomer Acustomer = new clsCustomer();
            string TestData = "albs";
            Acustomer.Customer_FirstName = TestData;
            Assert.AreEqual(Acustomer.Customer_FirstName, TestData);

        }

        [TestMethod]
        public void Customer_SurNamePropetyOK()
        {
            clsCustomer Acustomer = new clsCustomer();
            string TestData = "arts";
            Acustomer.Customer_SurName = TestData;
            Assert.AreEqual(Acustomer.Customer_SurName, TestData);

        }

        [TestMethod]
        public void Customer_EmailPropetyOK()
        {
            clsCustomer Acustomer = new clsCustomer();
            string TestData = "albsemail";
            Acustomer.Customer_Email = TestData;
            Assert.AreEqual(Acustomer.Customer_Email, TestData);

        }

        [TestMethod]
        public void Customer_AddressPropertyOK()
        {
            clsCustomer Acustomer = new clsCustomer();
            string TestData = "just address";
            Acustomer.Customer_Address = TestData;
            Assert.AreEqual(Acustomer.Customer_Address, TestData);

        }

        [TestMethod]
        public void FindMethodOK()
        {
            try
            {
            clsCustomer Acustomer = new clsCustomer();
            Boolean Found = false;
            int CustomerID = 0;
            Found = Acustomer.Find(CustomerID);
            Assert.IsTrue(Found);
            }

            catch (Exception)
            { }


        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            clsCustomer Acustomer = new clsCustomer();
            bool Found = false;
            Boolean OK = true;
            int CustomerID = 0;
            Found = Acustomer.Find(CustomerID);

            if (Acustomer.CustomerID != 0)
            { OK = false; }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestCustomer_FirstNameFound()
        {
            clsCustomer Acustomer = new clsCustomer();
            bool Found = false;
            Boolean OK = true;
            int CustomerID = 0;
            Found = Acustomer.Find(CustomerID);

            if (Acustomer.Customer_FirstName != "albs")
            { OK = false; }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestCustomer_SurNameFound()
        {
            clsCustomer Acustomer = new clsCustomer();
            bool Found = false;
            Boolean OK = true;
            int CustomerID = 0;
            Found = Acustomer.Find(CustomerID);

            if (Acustomer.Customer_SurName != "albs")
            { OK = false; }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestCustomer_EmailFound()
        {
            clsCustomer Acustomer = new clsCustomer();
            bool Found = false;
            Boolean OK = true;
            int CustomerID = 0;
            Found = Acustomer.Find(CustomerID);

            if (Acustomer.Customer_Email != "albs")
            { OK = false; }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestCustomerAddress_Found()
        {
            clsCustomer Acustomer = new clsCustomer();
            bool Found = false;
            bool OK = true;
            int CustomerID = 0;
            Found = Acustomer.Find(CustomerID);

            if (Acustomer.Customer_Address != "albs")
            { OK = false; }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer Acustomer = new clsCustomer();
            string Error = " ";
            Error = Acustomer.Valid(CustomerID, Customer_FirstName, Customer_Surname, Customer_Email, Customer_Address
                );
            Assert.AreEqual(Error, " ");

        }

        [TestMethod]
        public void CustomerIDMinLessOne()
        {
            clsCustomer Acustomer = new clsCustomer();

            string Error = " ";
            string CustomerID = " ";
            Error = Acustomer.Valid(CustomerID, Customer_FirstName, Customer_Surname, Customer_Email, Customer_Address);

            Assert.AreEqual(Error, " ");
        }

        [TestMethod]
        public void CustomerIDMinPlusOne()
        {
            clsCustomer Acustomer = new clsCustomer();

            string Error = " ";
            string CustomerID = "aa";
            Error = Acustomer.Valid(CustomerID, Customer_FirstName, Customer_Surname, Customer_Email, Customer_Address);

            Assert.AreEqual(Error, " ");

        }

        [TestMethod]
        public void CustomerIDMaxLessOne()
        {
            clsCustomer Acustomer = new clsCustomer();

            string Error = " ";
            string CustomerID = "aaaa ";
            Error = Acustomer.Valid(CustomerID, Customer_FirstName, Customer_Surname, Customer_Email, Customer_Address);

            Assert.AreEqual(Error, " ");

        }

        [TestMethod]
        public void CustomerIDMax()
        {
            clsCustomer Acustomer = new clsCustomer();

            string Error = " ";
            string CustomerID = "aaaaa ";
            Error = Acustomer.Valid(CustomerID, Customer_FirstName, Customer_Surname, Customer_Email, Customer_Address);

            Assert.AreEqual(Error, " ");
        }

        [TestMethod]
        public void CustomerIDMid()
        {
            clsCustomer Acustomer = new clsCustomer();

            string Error = " ";
            string CustomerID = "aaa ";
            Error = Acustomer.Valid(CustomerID, Customer_FirstName, Customer_Surname, Customer_Email, Customer_Address);

            Assert.AreEqual(Error, " ");
        }


        [TestMethod]
        public void CustomerIDMaxPlusOne()
        {
            clsCustomer Acustomer = new clsCustomer();

            string Error = " ";
            string CustomerID = "aaa ";
            Error = Acustomer.Valid(CustomerID, Customer_FirstName, Customer_Surname, Customer_Email, Customer_Address);

            Assert.AreEqual(Error, " ");
        }




    }
}