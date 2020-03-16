using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary2;

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

        //checking properties

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
        public void PriceOK()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //Create some test data to assign to the property
            double TestData = 25.99;
            //assign the data to property
            Stock.Price = TestData;
        }


        //Testing the find method

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
            Int32 Product_ID = 1;
            //Invoke the method
            Found = Stock.Find(Product_ID);
            //Check Product_ID
            if (Stock.Product_ID != 1)
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
            Int32 Product_ID = 1;
            //Invoke the method
            Found = Stock.Find(Product_ID);
            //Check Product_ID
            if (Stock.Product_Name != "2x 5kg plate")
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
            Int32 Product_ID = 1;
            //Invoke the method
            Found = Stock.Find(Product_ID);
            //Check Product_ID
            if (Stock.Product_Type != "Weights")
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
            Int32 Product_ID = 1;
            //Invoke the method
            Found = Stock.Find(Product_ID);
            //Check Product_ID
            if (Stock.Product_Description != "Two plates that weigh 5kg (each) can be used on all sort of barbells. This inclides  the 7ft barbells commonlly used for bench pressing. It can even be used on dumbbells")
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
            Int32 Product_ID = 1;
            //Invoke the method
            Found = Stock.Find(Product_ID);
            //Check Product_ID
            if (Stock.Quantity != 259)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        //validation method testing
        
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

        [TestMethod]
        public void ProductIDMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //String var to store error message
            string Error = "";
            //Redefine var that is getting tested
            Product_ID = 0;
            //invoke the method
            Error = Stock.Valid(Product_ID, Product_Name, Product_Type, Product_Description, Quantity);
            //test to se that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMin()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //String var to store error message
            string Error = "";
            //Redefine var that is getting tested
            Product_ID = 1; // should be ok
            //invoke the method
            Error = Stock.Valid(Product_ID, Product_Name, Product_Type, Product_Description, Quantity);
            //test to se that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //String var to store error message
            string Error = "";
            //Redefine var that is getting tested
            Product_ID = 11;
            //invoke the method
            Error = Stock.Valid(Product_ID, Product_Name, Product_Type, Product_Description, Quantity);
            //test to se that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //String var to store error message
            string Error = "";
            //Redefine var that is getting tested
            Product_ID = 255;
            //invoke the method
            Error = Stock.Valid(Product_ID, Product_Name, Product_Type, Product_Description, Quantity);
            //test to se that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMax()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //String var to store error message
            string Error = "";
            //Redefine var that is getting tested
            Product_ID = 256;
            //invoke the method
            Error = Stock.Valid(Product_ID, Product_Name, Product_Type, Product_Description, Quantity);
            //test to se that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMid()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //String var to store error message
            string Error = "";
            //Redefine var that is getting tested
            Product_ID = 128;
            //invoke the method
            Error = Stock.Valid(Product_ID, Product_Name, Product_Type, Product_Description, Quantity);
            //test to se that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //String var to store error message
            string Error = "";
            //Redefine var that is getting tested
            Product_Name = "";
            //invoke the method
            Error = Stock.Valid(Product_ID, Product_Name, Product_Type, Product_Description, Quantity);
            //test to se that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMin()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //String var to store error message
            string Error = "";
            //Redefine var that is getting tested
            Product_Name = "a";
            //invoke the method
            Error = Stock.Valid(Product_ID, Product_Name, Product_Type, Product_Description, Quantity);
            //test to se that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //String var to store error message
            string Error = "";
            //Redefine var that is getting tested
            Product_Name = "aa";
            //invoke the method
            Error = Stock.Valid(Product_ID, Product_Name, Product_Type, Product_Description, Quantity);
            //test to se that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //String var to store error message
            string Error = "";
            //Redefine var that is getting tested
            Product_Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = Stock.Valid(Product_ID, Product_Name, Product_Type, Product_Description, Quantity);
            //test to se that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMax()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //String var to store error message
            string Error = "";
            //Redefine var that is getting tested
            Product_Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = Stock.Valid(Product_ID, Product_Name, Product_Type, Product_Description, Quantity);
            //test to se that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMid()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //String var to store error message
            string Error = "";
            //Redefine var that is getting tested
            Product_Name = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = Stock.Valid(Product_ID, Product_Name, Product_Type, Product_Description, Quantity);
            //test to se that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductTypeMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //String var to store error message
            string Error = "";
            //Redefine var that is getting tested
            Product_Type = "";
            //invoke the method
            Error = Stock.Valid(Product_ID, Product_Name, Product_Type, Product_Description, Quantity);
            //test to se that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductTypeMin()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //String var to store error message
            string Error = "";
            //Redefine var that is getting tested
            Product_Type = "a";
            //invoke the method
            Error = Stock.Valid(Product_ID, Product_Name, Product_Type, Product_Description, Quantity);
            //test to se that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductTypeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //String var to store error message
            string Error = "";
            //Redefine var that is getting tested
            Product_Type = "aa";
            //invoke the method
            Error = Stock.Valid(Product_ID, Product_Name, Product_Type, Product_Description, Quantity);
            //test to se that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductTypeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //String var to store error message
            string Error = "";
            //Redefine var that is getting tested
            Product_Type = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = Stock.Valid(Product_ID, Product_Name, Product_Type, Product_Description, Quantity);
            //test to se that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductTypeMax()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //String var to store error message
            string Error = "";
            //Redefine var that is getting tested
            Product_Type = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = Stock.Valid(Product_ID, Product_Name, Product_Type, Product_Description, Quantity);
            //test to se that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductTypeMid()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //String var to store error message
            string Error = "";
            //Redefine var that is getting tested
            Product_Type = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = Stock.Valid(Product_ID, Product_Name, Product_Type, Product_Description, Quantity);
            //test to se that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptionMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //String var to store error message
            string Error = "";
            //Redefine var that is getting tested
            Product_Description = "";
            //invoke the method
            Error = Stock.Valid(Product_ID, Product_Name, Product_Type, Product_Description, Quantity);
            //test to se that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptionMin()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //String var to store error message
            string Error = "";
            //Redefine var that is getting tested
            Product_Description = "a";
            //invoke the method
            Error = Stock.Valid(Product_ID, Product_Name, Product_Type, Product_Description, Quantity);
            //test to se that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptionMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //String var to store error message
            string Error = "";
            //Redefine var that is getting tested
            Product_Description = "aa";
            //invoke the method
            Error = Stock.Valid(Product_ID, Product_Name, Product_Type, Product_Description, Quantity);
            //test to se that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptionMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //String var to store error message
            string Error = "";
            //Redefine var that is getting tested
            Product_Description = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = Stock.Valid(Product_ID, Product_Name, Product_Type, Product_Description, Quantity);
            //test to se that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptionMax()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //String var to store error message
            string Error = "";
            //Redefine var that is getting tested
            Product_Description = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = Stock.Valid(Product_ID, Product_Name, Product_Type, Product_Description, Quantity);
            //test to se that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptionMid()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //String var to store error message
            string Error = "";
            //Redefine var that is getting tested
            Product_Description = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = Stock.Valid(Product_ID, Product_Name, Product_Type, Product_Description, Quantity);
            //test to se that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductQuantityMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //String var to store error message
            string Error = "";
            //Redefine var that is getting tested
            Quantity = -1;
            //invoke the method
            Error = Stock.Valid(Product_ID, Product_Name, Product_Type, Product_Description, Quantity);
            //test to se that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductQuantityMin()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //String var to store error message
            string Error = "";
            //Redefine var that is getting tested
            Quantity = 0;
            //invoke the method
            Error = Stock.Valid(Product_ID, Product_Name, Product_Type, Product_Description, Quantity);
            //test to se that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductQuantityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //String var to store error message
            string Error = "";
            //Redefine var that is getting tested
            Quantity = 1;
            //invoke the method
            Error = Stock.Valid(Product_ID, Product_Name, Product_Type, Product_Description, Quantity);
            //test to se that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductQuantityMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //String var to store error message
            string Error = "";
            //Redefine var that is getting tested
            Quantity = 254;
            //invoke the method
            Error = Stock.Valid(Product_ID, Product_Name, Product_Type, Product_Description, Quantity);
            //test to se that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductQuantityMax()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //String var to store error message
            string Error = "";
            //Redefine var that is getting tested
            Quantity = 255;
            //invoke the method
            Error = Stock.Valid(Product_ID, Product_Name, Product_Type, Product_Description, Quantity);
            //test to se that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductQuantityMid()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //String var to store error message
            string Error = "";
            //Redefine var that is getting tested
            Quantity = 128;
            //invoke the method
            Error = Stock.Valid(Product_ID, Product_Name, Product_Type, Product_Description, Quantity);
            //test to se that the result is correct
            Assert.AreEqual(Error, "");
        }

    }
}