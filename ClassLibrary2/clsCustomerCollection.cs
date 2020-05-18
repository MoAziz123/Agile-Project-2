using System.Collections.Generic;
using ClassLibrary2;
using System;

namespace UnitTestProject1
{
    public class ClsCustomerCollection
    {
        public List<clsCustomer> mCustomerList;

        public List<clsCustomer> CustomerList { get {return mCustomerList; }  set {mCustomerList = value; } }
        public int Count { get { return mCustomerList.Count; }  set {; } }
        public List<clsCustomer> ThisCustomerPropertyOK { get; internal set; }
        public object ThisCustomer { get { return mThisCustomers; } set { mThisCustomers = value; } }

        public ClsCustomerCollection()
        {

        clsCustomer TestItem = new clsCustomer();

        TestItem.CustomerID = 0;
        TestItem.Customer_FirstName = "AirForce";
        TestItem.Customer_SurName = "alsb";
        TestItem.Customer_Email = "albs";
        TestItem.Customer_Address = "albs";


        mCustomerList.Add(TestItem);

        TestItem = new clsCustomer();
        TestItem.CustomerID = 0;
        TestItem.Customer_FirstName = "AirForce";
        TestItem.Customer_SurName = "alsb";
        TestItem.Customer_Email = "albs";
        TestItem.Customer_Address = "albs";

        mCustomerList.Add(TestItem);
        }

        public int Add()
        {
            mThisCustomers.CustomerID = 123;
            return mThisCustomers.CustomerID;
        }


        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomers = new clsCustomer();

    }
    


}