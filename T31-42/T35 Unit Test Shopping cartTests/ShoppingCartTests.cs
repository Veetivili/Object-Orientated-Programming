using Microsoft.VisualStudio.TestTools.UnitTesting;
using T35_Unit_Test_Shopping_cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace T35_Unit_Test_Shopping_cart.Tests
{
    [TestClass()]
    public class ShoppingCartTests
    {
        ShoppingCart cart = new ShoppingCart();
        
        public List<Product> products = new List<Product>();
        [TestMethod()]
        public void ShowProductsTest()
        {
            var result = products.Count;
            var expected = 0;
            Assert.AreEqual(expected, result);
            Console.WriteLine(cart.ShowProducts());
        }
        [TestMethod()]
        public void ShowProductsTest1()
        {
            products.Add(new Product("Milk", 1.4F));
            var result1 = products.Count;
            var expected = 1;
            double Total = products.Sum(item => item.Price);
            var expected_price = 1.4F;
            Assert.AreEqual(expected_price, Total);
            Assert.AreEqual(expected, result1);
        }
        [TestMethod()]
        public void ShowProductsTest2()
        {
            products.Add(new Product("Milk", 1.4F));
            products.Add(new Product("Bread", 2.2F));
            var result2 = products.Count;
            var expected = 2;
            double Total = products.Sum(item => item.Price);
            var expected_price = 3.6F;
            Assert.AreEqual(expected_price, Total);
            Assert.AreEqual(expected, result2);
        }
        [TestMethod()]
        public void ShowProductsTest3()
        {
            products.Add(new Product("Milk", 1.4F));
            products.Add(new Product("Bread", 2.2F));
            products.Add(new Product("Butter", 3.2F));
            var result3 = products.Count;
            var expected = 3;
            double Total = products.Sum(item => item.Price);
            var expected_price = 6.8F;
            Assert.AreEqual(expected_price, Total);
            Assert.AreEqual(expected, result3);
        }
        [TestMethod()]
        public void ShowProductsTest4()
        {
            products.Add(new Product("Milk", 1.4F));
            products.Add(new Product("Bread", 2.2F));
            products.Add(new Product("Butter", 3.2F));
            products.Add(new Product("Cheese", 4.2F));
            var result4 = products.Count;
            var expected = 4;
            double Total = products.Sum(item => item.Price);
            var expected_price = 11.0F;
            Assert.AreEqual(expected_price, Total);
            Assert.AreEqual(expected, result4);
        }
    }
  

}