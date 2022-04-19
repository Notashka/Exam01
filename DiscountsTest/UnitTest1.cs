using System;
using Discounts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiscountsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()]
        public void TestDiscount()
        {
            int count = 3, AllSum = 260, expected = 247;
            int actual = DiscPrice.Discount(count, AllSum);
            Assert.AreEqual(expected, actual);
        }
        public void DiscountTest2()
        {
            int count = 5, AllSum = 695, expected = 625;
            int actual = DiscPrice.Discount(count, AllSum);
            Assert.AreEqual(expected, actual);
        }
        public void DiscountTest3()
        {
            int count = 10, AllSum = 1000, expected = 850;
            int actual = DiscPrice.Discount(count, AllSum);
            Assert.AreEqual(expected, actual);
        }
    }
}
