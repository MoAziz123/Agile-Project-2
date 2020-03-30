using ClassLibrary2;
using System;
using System.Collections.Generic;

namespace ClassLibrary2
{
    public class clsStockCollection
    {
        public List<clsStock> StockList { get; set; }
        public int Count { get; set; }
        public clsStock ThisStock { get; set; }
    }
}