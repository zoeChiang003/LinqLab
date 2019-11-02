﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{
    public class WhereLab
    {
        private static IEnumerable<Sample> Source { get; set; }
        public WhereLab()
        {
            Source = new SampleDate().GetData();
        }
        public List<Sample> IdMoreThan8()
        {
            var result = Source.Where(d => d.Id > 8).ToList();
            return result;
        }

        public List<Sample> UserNameStartWithZ()
        {
            var result = Source.Where(d => d.UserName.StartsWith("Z")).ToList();
            return result;
        }

        public List<Sample> UserNameContainWithK()
        {
            var result = Source.Where(d => d.UserName.Contains("K")).ToList();
            return result;
        }

        public List<Sample> UserNameIsDemoAndZoe()
        {
            var whereStr = new[] {"Demo","Zoe" };
            var result = Source.Where(d => whereStr.Contains(d.UserName)).ToList();
            return result;
        }

        public bool IfThereIsDataWithIdEqual99()
        {
            var result = Source.Any(d => d.Id == 99);
            //var result = Source.FirstOrDefault(d => d.Id == 99) != null;

            return result;
        }
    }
}