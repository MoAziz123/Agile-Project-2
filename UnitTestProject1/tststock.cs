using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class tststock
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsAddress AnAddress = new clsAddress();
            Assert.IsNotNull(AnAddress);
        }
    }
}
