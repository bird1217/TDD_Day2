using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PotterShoppingCart;

namespace PotterShoppingCart.Tests
{
    [TestClass()]
    public class PotterShopping_Test
    {
        [TestMethod()]
        public void 第一集買一本_結帳金額為100元()
        {   
            //Assert
            var actual = 0;
            var expected = 100;
            Assert.AreEqual(expected, actual);
        }
    }
}