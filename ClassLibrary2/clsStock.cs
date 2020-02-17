using System;

namespace ClassLibrary2
{
    public class clsStock
    {
        public bool Active { get;  set; }
        public DateTime DateAdded { get;  set; }
        public int AddressNo { get;  set; }
        public int CountyNo { get;  set; }
        public string HouseNo { get;  set; }
        public string PostCode { get;  set; }
        public string Street { get;  set; }
        public string Town { get;  set; }


        public bool Find(int ProductID)
        {
            ProductID = 21;
            return true;
        }
    }

    


}