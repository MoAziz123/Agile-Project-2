﻿using ClassLibrary2;
using System;
using System.Collections.Generic;


namespace ClassLibrary2
{
    public class clsStockCollection
    {
        private List<clsStock> mStockList;

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
        public clsStock ThisStock { get; set; }
    }

}