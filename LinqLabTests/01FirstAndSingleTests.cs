using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinqLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpectedObjects;

namespace LinqLab.Tests
{
    [TestClass()]
    public class FirstAndSingleTests
    {

        [TestMethod()]
        public void UserNameEqualZoeWithFirstTest()
        {
            var expected =
                new Sample
                {
                    Id = 1,
                    UserName = "Zoe",
                    CreateTime = new DateTime(2016, 1, 20),
                    Price = 800,
                    Item = new List<int> { 97, 92, 81, 60 }
                }.ToExpectedObject();

            var actual = new FirstAndSingleLab().UserNameEqualZoeWithFirst();

            expected.ShouldEqual(actual);

        }

        [TestMethod()]
        public void UserNameEqualAmyWithFirstOrDefaultTest()
        {
            Sample expected = null;
            var actual = new FirstAndSingleLab().UserNameEqualAmyWithFirstOrDefault();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void UserNameEqualAmyWithFirstTest()
        {
            var actual = new FirstAndSingleLab().UserNameEqualAmyWithFirst();
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void UserNameEqualZoeWithSingleTest()
        {
            var actual = new FirstAndSingleLab().UserNameEqualZoeWithSingle();
        }

        [TestMethod()]
        public void UserNameEqualStephenWithSingleTest()
        {
            var expected =
                new Sample
                {
                    Id = 8,
                    UserName = "Stephen",
                    CreateTime = new DateTime(2016, 7, 20),
                    Price = 200,
                    Item = new List<int> { 92, 90, 83, 78 }
                }.ToExpectedObject();

            var actual = new FirstAndSingleLab().UserNameEqualStephenWithSingle();

            expected.ShouldEqual(actual);
        }

        [TestMethod()]
        public void UserNameEqualStephenWithSingleOrDefaultTest()
        {
            var expected =
                new Sample
                {
                    Id = 8,
                    UserName = "Stephen",
                    CreateTime = new DateTime(2016, 7, 20),
                    Price = 200,
                    Item = new List<int> { 92, 90, 83, 78 }
                }.ToExpectedObject();

            var actual = new FirstAndSingleLab().UserNameEqualStephenWithSingleOrDefault();

            expected.ShouldEqual(actual);
        }

        [TestMethod()]
        public void UserNameEqualAmyWithSingleOrDefaultTest()
        {
            Sample expected = null;

            var actual = new FirstAndSingleLab().UserNameEqualAmyWithSingleOrDefault();

            Assert.AreEqual(expected, actual);

        }
    }
}