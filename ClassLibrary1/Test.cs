using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Application;

namespace Tests
{
    [TestFixture]
    public class RepositoryTest
    {
        [Test]
        public void TestCanGetSteak()
        {
            DishRepository repo = new DishRepository();
            string name = repo.GetDishName("evening", 1);
            Assert.AreEqual("steak", name);
        }
        [Test]
        public void TestCanGetToast()
        {
            DishRepository repo = new DishRepository();
            string name = repo.GetDishName("morning", 2);
            Assert.AreEqual("toast", name);
        }

        [Test]
        public void TestIsValidMorningOrder()
        {
            OrderHandler oh = new OrderHandler();
            string input = "morning,1,2,3,3";
            Assert.AreEqual(true, oh.ValidateOrder(input));
        }

        [Test]
        public void TestIsInvalidMorningOrder()
        {
            OrderHandler oh = new OrderHandler();
            string input = "morning,1,2,2,3,3";
            Assert.AreEqual(false, oh.ValidateOrder(input));
        }
        [Test]
        public void TestIsValidEveningOrder()
        {
            OrderHandler oh = new OrderHandler();
            string input = "evening,1,2,2,3,4";
            Assert.AreEqual(true, oh.ValidateOrder(input));
        }
        [Test]
        public void TestIsInvalidEveningOrder()
        {
            OrderHandler oh = new OrderHandler();
            string input = "evening,1,2,2,3,3,4";
            Assert.AreEqual(false, oh.ValidateOrder(input));
        }
    }
}
