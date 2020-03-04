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
        public void TestProduct_ID()
        {
            //create an instance of the class we want
            clsStock Stock = new clsStock();
            //bool var to store the result of search
            Boolean Found = false;
            //Boolean varaible to record if data is OK
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 Product_ID = 21;
            //call method
            Found = Stock.Find(Product_ID);
            //check the product id
            if (Stock.Product_ID != 21)
            {
                OK = false;
            }   
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProduct_Name()
        {
            //Create instance of the class we want to create
            clsStock Stock = new clsStock();
            //boolean var to store searhc result
            Boolean Found = true;
            //bool var to record if data is OK
            Boolean OK = true;
            //Create some test data
            String Product_Name = "2kg Protein powder";
            //call the method
            Found = Stock.Find(1);
            //check the name
            if (Stock.Product_Name != "2kg Protein powder")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }
}