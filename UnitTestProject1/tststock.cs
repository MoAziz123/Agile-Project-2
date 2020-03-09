using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class tststock
    {
        Int32 Product_ID = 1;
        string Product_Name = "2.2kg protien powder";
        string Product_Type = "Protien powder";
        string Product_Description = "PP";
        Int32 Quantity = 250;

        [TestMethod]
        public void InstanceOK()
        {
            clsStock Stock = new clsStock();
            Assert.IsNotNull(Stock);
        }

        [TestMethod]
        public void AddedProduct_IDOK()
        {
            clsStock Stock = new clsStock();
            Int32 TestData = 1;
            Stock.Product_ID = TestData;
            Assert.AreEqual(Stock.Product_ID, TestData);
        }

        [TestMethod]
        public void Product_NameOK()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //create some test data to assign to the property
            String TestData = "2kg protien powder";
            //assign the data to the property
            Stock.Product_Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Stock.Product_Name, TestData);
        }

        [TestMethod]
        public void Product_TypeyOK()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //create some test data to assign to the property
            String TestData = "Protien Poweder";
            //assign the data to the property
            Stock.Product_Type = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Stock.Product_Type, TestData);
        }

        [TestMethod]
        public void Product_DescriptionOK()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //create some test data to assign to the property
            string TestData = "25gram of protien per scoop, which contains 30grams.";
            //assign the data to the property
            Stock.Product_Description = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Stock.Product_Description, TestData);
        }

        [TestMethod]
        public void QuantityOK()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 259;
            //assign the data to the property
            Stock.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Stock.Quantity, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //Create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //Boolean var to store the validation result
            Boolean Found = false;
            //create some test data to use with the method
            Int32 Product_ID = 1;
            //Invoke the method
            Found = Stock.Find(Product_ID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestProductIDFound()
        {
            //Create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //Boolean var to store the validation result
            Boolean Found = false;
            //Boolean var to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Product_ID = 21;
            //Invoke the method
            Found = Stock.Find(Product_ID);
            //Check Product_ID
            if (Stock.Product_ID != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductNameFound()
        {
            //Create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //Boolean var to store the validation result
            Boolean Found = false;
            //Boolean var to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Product_ID = 21;
            //Invoke the method
            Found = Stock.Find(Product_ID);
            //Check Product_ID
            if (Stock.Product_Name != "PP")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductTypeFound()
        {
            //Create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //Boolean var to store the validation result
            Boolean Found = false;
            //Boolean var to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Product_ID = 21;
            //Invoke the method
            Found = Stock.Find(Product_ID);
            //Check Product_ID
            if (Stock.Product_Type != "PP")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductDescriptionFound()
        {
            //Create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //Boolean var to store the validation result
            Boolean Found = false;
            //Boolean var to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Product_ID = 21;
            //Invoke the method
            Found = Stock.Find(Product_ID);
            //Check Product_ID
            if (Stock.Product_Description != "Protein powder")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestQuantityFound()
        {
            //Create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //Boolean var to store the validation result
            Boolean Found = false;
            //Boolean var to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Product_ID = 21;
            //Invoke the method
            Found = Stock.Find(Product_ID);
            //Check Product_ID
            if (Stock.Quantity != 250)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        /*
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the stock class
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            Error = Stock.Valid(Product_ID, Product_Name, Product_Type, Product_Description, Quantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        */

    }
}