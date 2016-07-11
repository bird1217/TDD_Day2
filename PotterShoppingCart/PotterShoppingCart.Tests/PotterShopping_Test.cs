using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PotterShoppingCart;
using ShoppingCartLibrary;

namespace PotterShoppingCart.Tests
{
    [TestClass()]
    public class PotterShopping_Test
    {
        [TestMethod()]
        public void 第一集買一本_結帳金額為100元()
        {
            //Arrange            
            var shoppingCart = new ShopppingCart();
            var book1 = new Book() { chapters = 1, Price = 100 };
            shoppingCart.Add(book1);

            //Act
            var actual = shoppingCart.CalculatePrice();

            //Assert
            var expected = 100;
            Assert.AreEqual(expected, actual);
        }
    }
}