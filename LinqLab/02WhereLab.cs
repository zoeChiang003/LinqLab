using System.Collections.Generic;
using System.Linq;

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
            return null;
        }

        public List<Sample> UserNameStartWithZ()
        {
            return null;
        }

        public List<Sample> UserNameContainWithK()
        {
            return null;
        }

        public List<Sample> UserNameIsDemoAndZoe()
        {
            return null;
        }

        public bool IfThereIsDataWithIdEqual99()
        {
            return false;
        }
    }
}
