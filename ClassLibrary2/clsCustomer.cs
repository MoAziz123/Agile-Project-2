using System;

namespace ClassLibrary2
{
    public class clsCustomer
    {
        private int mCustomerID;
        private string mCustomer_FirstName;
        private string mCustomer_SurName;
        private string mCustomer_Email;
        private string mCustomer_Address;




        public int CustomerID  { get { return mCustomerID; } set { mCustomerID = value; } }
        public string Customer_FirstName { get { return mCustomer_FirstName; } set { mCustomer_FirstName = value; } }
        public string Customer_SurName { get { return mCustomer_SurName; } set { mCustomer_SurName = value; } }
        public string Customer_Email { get { return mCustomer_Email; } set { mCustomer_Email = value; } }
        public string Customer_Address { get { return mCustomer_Address; } set { mCustomer_Address = value; } }

        public bool Find(int customerID)
        {
            clsDataConnection db = new clsDataConnection();
            db.AddParameter("@CustomerID", CustomerID);
            db.Execute("sproc_tblCustomer_FilterByCustomerID");
            if (db.Count == 1)
            {
                mCustomerID = Convert.ToInt32(db.DataTable.Rows[0]["CustomerID"]);
                mCustomer_FirstName= Convert.ToString(db.DataTable.Rows[0]["Customer_FirstName"]);
                mCustomer_SurName = Convert.ToString(db.DataTable.Rows[0]["Customer_SurName"]);
                mCustomer_Email = Convert.ToString(db.DataTable.Rows[0]["Cusomtomer_Email"]);
                mCustomer_Address = Convert.ToString(db.DataTable.Rows[0]["Customer_Address"]);

                return true;
            }
            else
            {
                return false;
            }
            
        }

        /**public string Valid(int customerID, string customer_FirstName, string customer_Surname, string customer_Email, string customer_Address)
        {
            return " ";
        }**/
        
        public string Valid(string customerID, string customer_FirstName, string customer_Surname, string customer_Email, string customer_Address)
        {
            string Error = " ";
            if (customerID.Length == 0)
            {
                Error = Error + " The Customer ID may not be blank: "
                ;
            }
            if (customerID.Length > 6)
            {
                Error = Error + " The Customer ID must be less than 6 characters: "
                ;
            }
                return Error;
        }
        


    }
}