using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{
    public class SkipAndTakeLab
    {
        private static IEnumerable<Sample> Source { get; set; }

        public SkipAndTakeLab()
        {
            Source = new SampleDate().GetData();
        }

        public List<Sample> SkipFiveData()
        {
            var result = Source.Skip(5).ToList();
            return result;
        }

        public List<Sample> GetFiveData()
        {
            var result = Source.Take(5).ToList();
            return result;
        }

        public List<Sample> SkipFiveDataAndGetTwoData()
        {
            var result = Source.Skip(5).Take(2).ToList();
            return result;
        }
    }
}
