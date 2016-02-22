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
    }
}
