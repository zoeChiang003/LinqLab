﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public class WhereTests
    {
       
        [TestMethod()]
        public void IdMoreThan8Test()
        {
            var expected = new List<Sample>
            {
                new Sample{Id = 9,UserName = "Bill",CreateTime = new DateTime(2016,8,20),Price = 2000,Item = new List<int> {68, 79, 88, 92}},
                new Sample{Id = 10,UserName = "Kyo",CreateTime = new DateTime(2016,1,20),Price = 9572,Item = new List<int> {99, 82, 81, 79}}
            }.ToExpectedObject();

            var actual = new WhereLab().IdMoreThan8();

            expected.ShouldEqual(actual.ToList());
        }

        [TestMethod()]
        public void UserNameStartWithZTest()
        {
            var expected = new List<Sample>
            {
                new Sample{Id = 1,UserName = "Zoe",CreateTime = new DateTime(2016,1,20),Price = 800,Item = new List<int> {97, 92, 81, 60}},
                new Sample{Id = 5,UserName = "Zoe",CreateTime = new DateTime(2016,4,20),Price = 100,Item = new List<int> {35, 72, 91, 70}},
                new Sample{Id = 6,UserName = "Zoe",CreateTime = new DateTime(2016,5,20),Price = 8990,Item = new List<int> {99, 86, 90, 94}},
                new Sample{Id = 7,UserName = "Zoe",CreateTime = new DateTime(2016,6,20),Price = 2000,Item = new List<int> {93, 92, 80, 87}},
            }.ToExpectedObject();

            var actual = new WhereLab().UserNameStartWithZ();

            expected.ShouldEqual(actual.ToList());
        }

        [TestMethod()]
        public void UserNameContainWithKTest()
        {
            var expected = new List<Sample>
            {
                new Sample{Id = 10,UserName = "Kyo",CreateTime = new DateTime(2016,1,20),Price = 9572,Item = new List<int> {99, 82, 81, 79}},
            }.ToExpectedObject();

            var actual = new WhereLab().UserNameContainWithK();

            expected.ShouldEqual(actual.ToList());
        }

        [TestMethod()]
        public void UserNameIsDemoAndZoeTest()
        {
            var expected = new List<Sample>
            {
                new Sample{Id = 1,UserName = "Zoe",CreateTime = new DateTime(2016,1,20),Price = 800,Item = new List<int> {97, 92, 81, 60}},
                new Sample{Id = 2,UserName = "Demo",CreateTime = new DateTime(2016,2,20),Price = 1800,Item = new List<int> {75, 84, 91, 39}},
                new Sample{Id = 3,UserName = "Demo",CreateTime = new DateTime(2016,3,20),Price = 2000,Item = new List<int> {88, 94, 65, 91}},
                new Sample{Id = 4,UserName = "Demo",CreateTime = new DateTime(2016,3,20),Price = 600,Item = new List<int> {97, 89, 85, 82}},
                new Sample{Id = 5,UserName = "Zoe",CreateTime = new DateTime(2016,4,20),Price = 100,Item = new List<int> {35, 72, 91, 70}},
                new Sample{Id = 6,UserName = "Zoe",CreateTime = new DateTime(2016,5,20),Price = 8990,Item = new List<int> {99, 86, 90, 94}},
                new Sample{Id = 7,UserName = "Zoe",CreateTime = new DateTime(2016,6,20),Price = 2000,Item = new List<int> {93, 92, 80, 87}},
            }.ToExpectedObject();

            var actual = new WhereLab().UserNameIsDemoAndZoe();

            expected.ShouldEqual(actual.ToList());
        }

        [TestMethod()]
        public void IfThereIsDataWithIdEqual99Test()
        {
            var expected = false;

            var actual = new WhereLab().IfThereIsDataWithIdEqual99();

            Assert.AreEqual(expected, actual);
        }
    }
}