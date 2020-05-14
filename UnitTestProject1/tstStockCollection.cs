using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary2;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class tstStockCollection
    {

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
            TestItem.Product_Name = "2x 5kg plate";
            TestItem.Product_Type = "Weights";
            TestItem.Product_Description = "Two plates that weigh 5kg (each) can be used on all sort of barbells. This inclides  the 7ft barbells commonlly used for bench pressing. It can even be used on dumbbells";
            TestItem.Quantity = 259;
            TestItem.Price = 50;
            //add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllStock.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.StockList, TestList);
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
            TestStock.Product_Name = "2x 5kg plate";
            TestStock.Product_Type = "Weights";
            TestStock.Product_Description = "Two plates that weigh 5kg (each) can be used on all sort of barbells. This inclides  the 7ft barbells commonlly used for bench pressing. It can even be used on dumbbells";
            TestStock.Quantity = 259;
            TestStock.Price = 50;
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
            TestItem.Product_Name = "2x 5kg plate";
            TestItem.Product_Type = "Weights";
            TestItem.Product_Description = "Two plates that weigh 5kg (each) can be used on all sort of barbells. This inclides  the 7ft barbells commonlly used for bench pressing. It can even be used on dumbbells";
            TestItem.Quantity = 259;
            TestItem.Price = 50;
            //add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllStock.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            
            //create instance of the collection
            clsStockCollection AllStock = new clsStockCollection();
            //creating an item of test data
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            //Adding test data
            TestItem.Product_ID = 2;
            TestItem.Product_Name = "Protien Powder 2kg WHEY";
            TestItem.Product_Type = "Protien powder";
            TestItem.Product_Description = "Each scoop contains 24grams of protien out of the total 31 grams. The protien is from a whey source (dairy).";
            TestItem.Quantity = 250;
            TestItem.Price = 55;
            //set ThisStock to testitems
            AllStock.ThisStock = TestItem;
            //add the records
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.Product_ID = PrimaryKey;
            //find the recrods to verify it worked
            AllStock.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void AddDeleteOK()
        {

            //create instance of the collection
            clsStockCollection AllStock = new clsStockCollection();
            //creating an item of test data
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            //Adding test data
            TestItem.Product_ID = 2;
            TestItem.Product_Name = "Protien Powder 2kg WHEY";
            TestItem.Product_Type = "Protien powder";
            TestItem.Product_Description = "Each scoop contains 24grams of protien out of the total 31 grams. The protien is from a whey source (dairy).";
            TestItem.Quantity = 250;
            TestItem.Price = 55;
            //set ThisStock to testitems
            AllStock.ThisStock = TestItem;
            //add the records
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.Product_ID = PrimaryKey;
            //find the recrods to verify it worked
            AllStock.ThisStock.Find(PrimaryKey);

            AllStock.Delete();

            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);

            Assert.IsFalse(Found);
        }

    }
}