using System;
using ClassLibrary2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class I want to create.
            clsStaff AStaffMember = new clsStaff();
            //Test to see if it exists.
            Assert.IsNotNull(AStaffMember);
        }
    }
}
