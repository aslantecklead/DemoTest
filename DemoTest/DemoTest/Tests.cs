using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTest
{
    [TestFixture]
    internal class Tests
    {
        [Test]
        public void CountEmployees_ReturnCorrectNumverOfEmployees()
        {
            var finctional = new Functions();
            int result = finctional.CountEmployees();
            Assert.That(Equals(2, result));
        }

        //[Test]
    }
}
