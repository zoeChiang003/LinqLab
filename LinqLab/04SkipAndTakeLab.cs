using System.Collections.Generic;

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
            return null;
        }

        public List<Sample> GetFiveData()
        {
            return null;
        }

        public List<Sample> SkipFiveDataAndGetTwoData()
        {
            return null;
        }
    }
}
