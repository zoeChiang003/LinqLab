using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpectedObjects;

namespace LinqLab.Tests
{
    [TestClass()]
    public class GroupByTests
    {
        [TestMethod()]
        public void GroupByUserNameTest()
        {
            var expected =
                new Dictionary<string, int>()
                {
                    {"Zoe", 4},
                    {"Demo", 3},
                    {"Stephen", 1},
                    {"Bill", 1},
                    {"Kyo", 1}
                }.ToExpectedObject();

            var actual = new GroupByLab().GroupByUserName();

            expected.ShouldEqual(actual.ToDictionary(d => d.Key, d => d.Count()));
        }

        [TestMethod()]
        public void GroupByUserNameAndCreateTimeTest()
        {
            var expected =
                new List<string>()
                {
                    {"Zoe2016-01-20"},
                    {"Demo2016-02-20"},
                    {"Demo2016-03-20"},
                    {"Demo2016-03-20"},
                    {"Zoe2016-04-20"},
                    {"Zoe2016-05-20"},
                    {"Zoe2016-06-20"},
                    {"Stephen2016-07-20"},
                    {"Bill2016-08-20"},
                    {"Kyo2016-01-20"},
                }.ToExpectedObject();

            var actual = new GroupByLab().GroupByUserNameAndCreateTime();

            expected.ShouldEqual(actual.Select(d => d.Key.UserName + "" + d.Key.CreateTime.ToString("yyyy-MM-dd")).ToList());

        }
    }
}