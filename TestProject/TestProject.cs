using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestProject
{
    [TestClass]
    public class TestProject
    {
        [TestMethod]
        public void TestingADDFunctionality()
        {
            AddAndSubtract objAddAndSubtract = new AddAndSubtract();
            int a = 10;
            int b = 20;

            int output = 0;
            output = objAddAndSubtract.add(a, b);

            Assert.AreEqual("30", output, "Add functionality tested");
           

        }
        [TestMethod]
        public void TestingSubFunctionality()
        {
            AddAndSubtract objAddAndSubtract = new AddAndSubtract();
            int a = 20;
            int b = 10;

            int output = 0;
            output = objAddAndSubtract.Subtract(a, b);
            Assert.AreEqual("10", output, "Sub functionality tested");
        }
    }
}
