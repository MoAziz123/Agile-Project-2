using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary2;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class tstStockCollection
    {

        //constructor for the class
        public clsStockCollection col;
        public tstStockCollection()
        {
            //create the item of test data
            col = new clsStockCollection();
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.Product_ID = 1;
            TestItem.Product_Name = "PP";
            TestItem.Product_Type = "PP";
            TestItem.Quantity = 250;
            TestItem.Price = 25.99;
            //add item to the test list
            /*col.mStockList.add(TestItem);
            //re initialise the object for some new data
            TestItem = new clsStock();
            //set its properties
            TestItem.Product_ID = 2;
            TestItem.Product_Name = "PP1";
            TestItem.Product_Type = "PP1";
            TestItem.Quantity = 259;
            TestItem.Price = 29.99;
            //add the item to the test list
            mStockList.add(TestItem);*/
        }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the StockCollection class
            clsStockCollection AllStock = new clsStockCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStock);
        }

        [TestMethod]
        public void StockListOK()
        {
            //create an instance of the class
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to the property in this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.Product_ID = 1;
            TestItem.Product_Name = "ProtienPowder";
            TestItem.Product_Type = "PP";
            TestItem.Product_Description = "25grams of protien per scoop";
            TestItem.Quantity = 21;
            TestItem.Price = 49.99;
            //add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllStock.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.StockList, TestList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign
            Int32 SomeCount = 2;
            //assign the data to the property
            AllStock.Count = SomeCount;
        }

        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //create an instance of the class
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestStock = new clsStock();
            //Set the properties of the test object
            TestStock.Product_ID = 1;
            TestStock.Product_Name = "ProtienPowder";
            TestStock.Product_Type = "PP";
            TestStock.Product_Description = "25grams of protien per scoop";
            TestStock.Quantity = 21;
            TestStock.Price = 49.99;
            //assign the data to the property
            AllStock.ThisStock = TestStock;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to the property in this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.Product_ID = 1;
            TestItem.Product_Name = "ProtienPowder";
            TestItem.Product_Type = "PP";
            TestItem.Product_Description = "25grams of protien per scoop";
            TestItem.Quantity = 21;
            TestItem.Price = 49.99;
            //add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllStock.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }


        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create an instance of the class we want to create 
            clsStockCollection AllStock = new clsStockCollection();
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, 2);
        }
    }
}
