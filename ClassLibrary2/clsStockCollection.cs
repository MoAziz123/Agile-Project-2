using ClassLibrary2;
using System;
using System.Collections.Generic;


namespace ClassLibrary2
{
    public class clsStockCollection
    {
        private List<clsStock> mStockList;
        private clsStock mThisStock;

        //constructor for the class
        public clsStockCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //defining mStockList
            mStockList = new List<clsStock>();
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank stock
                clsStock Stock = new clsStock();
                //read in the fields from the current records
                Stock.Product_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Product_ID"]);
                Stock.Product_Name = Convert.ToString(DB.DataTable.Rows[Index]["Product_Name"]);
                Stock.Product_Type = Convert.ToString(DB.DataTable.Rows[Index]["Product_Type"]);
                Stock.Product_Description = Convert.ToString(DB.DataTable.Rows[Index]["Product_Description"]);
                Stock.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                Stock.Price = Convert.ToDouble(DB.DataTable.Rows[Index]["Price"]);
                //add the records to the private data mamber
                mStockList.Add(Stock);
                //point at the next record
                Index++;
            }
        }


        //public property for Stock list
        public List<clsStock> StockList
        {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                return mStockList.Count;
            }
            set
            {
                //worry about this later
            }
        }
        public clsStock ThisStock
        {
            get
            {
                return mThisStock;
            }
            set
            {
                mThisStock = value;
            }
        }

        public int Add()
        {
            //connect to Database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters
            DB.AddParameter("@Product_ID", mThisStock.Product_ID);
            DB.AddParameter("@Product_Name", mThisStock.Product_Name);
            DB.AddParameter("@Product_Type", mThisStock.Product_Type);
            DB.AddParameter("@Product_Description", mThisStock.Product_Description);
            DB.AddParameter("@Qunatity", mThisStock.Quantity);
            DB.AddParameter("@Price", mThisStock.Price);
            //execute the query returning the primary key value
            return DB.Execute()

        }
    }



}