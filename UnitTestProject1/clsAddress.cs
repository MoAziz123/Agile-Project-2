using System;

namespace UnitTestProject1
{
    internal class clsAddress
    {
        public bool Active { get; internal set; }
        public DateTime DateAdded { get; internal set; }
        public int AddressNo { get; internal set; }
        public int CountyNo { get; internal set; }
        public string HouseNo { get; internal set; }
        public string PostCode { get; internal set; }
        public string Street { get; internal set; }
        public string Town { get; internal set; }
    }
}