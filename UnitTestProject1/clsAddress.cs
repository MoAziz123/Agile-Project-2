using System;

namespace UnitTestProject1
{
    internal class clsAddress
    {
        public bool Active 
        { get; internal set; }
        public DateTime DateAdded { get; internal set; }
        public int AddressNo 
        {
            get
            {
                return mAddressNo;
            }
            set
            {
                mAddressNo = value;
            }
        }
        public int CountyNo { get; internal set; }
        public string HouseNo { get; internal set; }
        public string PostCode { get; internal set; }
        public string Street { get; internal set; }
        public string Town { get; internal set; }

        internal bool Find(int addressNo)
        {
            mAddressNo = 21;
            return true;
        }
    }
}