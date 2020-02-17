using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class tstorder
    {
        public clsOrder order;
        public tstorder()
        {
            clsOrder order = new clsOrder();
            
        }
        [TestMethod]
        public void InstanceOK()
        {
            Assert.IsNotNull(this.order);
        }
        [TestMethod]
        public void CustomerIDOK()
        {

        }
        public void ProductIDOK()
        {

        }
        public void ProductNameOK()
        {

        }
        public void Order_QuantityOK()
        {

        }
        public void DispatchOK()
        {

        }
        public void DateOK()
        {

        }
    }
}
