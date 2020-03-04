using ClassLibrary2;
using System;

namespace UnitTestProject1
{
    public class clsStock
    {
        private int mProduct_ID;
        private string mProduct_Name;
        private string mProduct_Type;
        private string mProduct_Description;
        private int mQuantity;

        public int Product_ID
        {
            get
            {
                return mProduct_ID;
            }
            set
            {
                mProduct_ID = value;
            }
        }

        public string Product_Name
        {
            get
            {
                return mProduct_Name;
            }
            set
            {
                mProduct_Name = value;
            }

        public string Product_Type
        {
            get
            {
                return mProduct_Type;
            }
            set
            {
                mProduct_Type = value;
            }
        }

        public string Product_Description
        {
            get
            {
                return mProduct_Description;
            }
            set
            {
                mProduct_Description = value;
            }
        }

        public int Quantity
        {
            get
            {
                return mQuantity
    
            }
            set
            {
                mQuantity = value;
            }
        }

        public bool Find(int Product_ID)
        {
            //create an instance of the data connetion
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the product_ID  to search for
            DB.AddParameter("@Product_ID", Product_ID);
            //execute the stored procedure
            DB.Execute("");
            //if one record is found (there should be either one or zero!!)
            if (DB.Count == 1) ;
            {
                //copy the data from the database to the private data members
                mProduct_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Product_ID"]);
                mProduct_Name = Convert.ToString(DB.DataTable.Rows[0]["Product_Name"]);
                mProduct_Type = Convert.ToString(DB.DataTable.Rows[0]["Product_Type"]);
                mProduct_Description = Convert.ToString(DB.DataTable.Rows[0]["Product_Description"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                //return that everything worked OK
                return true;
            }
	            // if no records was found
	        else
	        {
                //return false indicating a problem
                return false;
            }
        }



    }
}