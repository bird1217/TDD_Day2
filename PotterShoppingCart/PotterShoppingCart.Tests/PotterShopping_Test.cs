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

        [TestMethod()]
        public void 第一集買一本_第二集買一本_結帳金額為190元()
        {
            //Arrange            
            var shoppingCart = new ShopppingCart();
            var book1 = new Book() { chapters = 1, Price = 100 };
            var book2 = new Book() { chapters = 2, Price = 100 };
            shoppingCart.Add(book1);
            shoppingCart.Add(book2);

            //Act
            var actual = shoppingCart.CalculatePrice();

            //Assert
            var expected = 190;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 第一集買一本_第二集買一本_第三集買一本_結帳金額為270元()
        {
            //Arrange            
            var shoppingCart = new ShopppingCart();
            var book1 = new Book() { chapters = 1, Price = 100 };
            var book2 = new Book() { chapters = 2, Price = 100 };
            var book3 = new Book() { chapters = 3, Price = 100 };
            shoppingCart.Add(book1);
            shoppingCart.Add(book2);
            shoppingCart.Add(book3);

            //Act
            var actual = shoppingCart.CalculatePrice();

            //Assert
            var expected = 270;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 第一集買一本_第二集買一本_第三集買一本_第四集買一本_結帳金額為320元()
        {
            //Arrange            
            var shoppingCart = new ShopppingCart();
            var book1 = new Book() { chapters = 1, Price = 100 };
            var book2 = new Book() { chapters = 2, Price = 100 };
            var book3 = new Book() { chapters = 3, Price = 100 };
            var book4 = new Book() { chapters = 4, Price = 100 };
            shoppingCart.Add(book1);
            shoppingCart.Add(book2);
            shoppingCart.Add(book3);
            shoppingCart.Add(book4);

            //Act
            var actual = shoppingCart.CalculatePrice();

            //Assert
            var expected = 320;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void 一二三四五集各買了一本_結帳金額為375元()
        {
            //Arrange            
            var shoppingCart = new ShopppingCart();
            var book1 = new Book() { chapters = 1, Price = 100 };
            var book2 = new Book() { chapters = 2, Price = 100 };
            var book3 = new Book() { chapters = 3, Price = 100 };
            var book4 = new Book() { chapters = 4, Price = 100 };
            var book5 = new Book() { chapters = 5, Price = 100 };
            shoppingCart.Add(book1);
            shoppingCart.Add(book2);
            shoppingCart.Add(book3);
            shoppingCart.Add(book4);
            shoppingCart.Add(book5);

            //Act
            var actual = shoppingCart.CalculatePrice();

            //Assert
            var expected = 375;
            Assert.AreEqual(expected, actual);
        }
    }
}