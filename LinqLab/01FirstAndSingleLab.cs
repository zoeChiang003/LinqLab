using System.Collections.Generic;
using System.Linq;

namespace LinqLab
{
   public class FirstAndSingleLab
    {
        private static IEnumerable<Sample> Source { get; set; }

        public FirstAndSingleLab()
        {
            Source = new SampleDate().GetData();
        }

        public Sample UserNameEqualZoeWithFirst()
        {
            return null;
        }

        public Sample UserNameEqualAmyWithFirstOrDefault()
        {
            return null;
        }

        public Sample UserNameEqualAmyWithFirst()
        {
            return null;
        }

        public Sample UserNameEqualZoeWithSingle()
        {
            return null;
        }

        public Sample UserNameEqualStephenWithSingle()
        {
            return null;
        }
        public Sample UserNameEqualStephenWithSingleOrDefault()
        {
            return null;
        }

        public Sample UserNameEqualAmyWithSingleOrDefault()
        {
            return null;
        }
    }
}
