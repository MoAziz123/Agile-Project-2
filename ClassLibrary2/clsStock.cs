using ClassLibrary2;
using System;

namespace ClassLibrary2
{
    public class clsStock
    {
        private int mProduct_ID;
        private string mProduct_Name;
        private string mProduct_Type;
        private string mProduct_Description;
        private int mQuantity;
        private double mPrice;

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

        public int Quantity {
            get
            {
                return mQuantity;
            }
            set {
                mQuantity = value;
            }        
        }

        public double Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }

        public bool Find(int Product_ID)
        {
        
            //create an instance of the data connetion
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the product_ID  to search for
            DB.AddParameter("@Product_ID", Product_ID);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByProduct_ID");
            //if one record is found (there should be either one or zero!!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mProduct_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Product_ID"]);
                mProduct_Name = Convert.ToString(DB.DataTable.Rows[0]["Product_Name"]);
                mProduct_Type = Convert.ToString(DB.DataTable.Rows[0]["Product_Type"]);
                mProduct_Description = Convert.ToString(DB.DataTable.Rows[0]["Product_Description"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Product_Quantity"]);
                //return that everything worked OK
                return true;
            }
	            // if no records was found
	        else
	        {
                //return false indicating a problem
                return false;
            }

            /*
            mProduct_ID = 21;
            mProduct_Name = "PP";
            mProduct_Type = "PP";
            mProduct_Description = "Protein powder";
            mQuantity = 250;
            
            return true;
            */
        }


        public string Valid(Int32 Product_ID,
            string Product_Name,
            string Product_Type,
            string Product_Descriptoion,
            Int32 Quantity)
        {
            //creating a string var to store the error
            String Error = "";
            //if the ProductID is blank
            if (Product_ID == 0)
            {
                //recording error for Product_ID 
                Error = Error + "Product_ID can not be blank";
            }
            if (Product_Name == "")
            {
                //recording error for Product_Name
                Error = Error + "Product_Name can not be blank";
            }
            if (Product_Type == "")
            {
                //recording error for Product_Type
                Error = Error + "Product_Type can not be blank";
            }
            if (Product_Descriptoion == "")
            {
                //recording error for Product_Description
                Error = Error + "Product_Description can not be blank";
            }
            if (Quantity == -1)
            {
                //recording error for Quantity
                Error = Error + "Quantiy can not be negative";
            }
            if (Product_ID > 1000000)
            {
                //recording error for Product_ID 
                Error = Error + "Product_ID can not be that big";
            }
            if (Product_Name.Length > 51)
            {
                //recording error for Product_Name 
                Error = Error + "Product_Name can not be that big";
            }
            if (Product_Type.Length > 51)
            {
                //recording error for Product_Type
                Error = Error + "Product_Type can not be that big";
            }
            if (Quantity > 1000000)
            {
                //recording error for Product_Quantity
                Error = Error + "Quantity can not be that big";
            }
            return Error;
            //return "";
        }

    }
}