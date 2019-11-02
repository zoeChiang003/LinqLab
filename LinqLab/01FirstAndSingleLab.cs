using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var result = Source.Where(d => d.UserName == "Zoe").First();
            return result;
        }

        public Sample UserNameEqualAmyWithFirstOrDefault()
        {
            var result = Source.Where(d => d.UserName == "Amy").FirstOrDefault();
            return result;
        }

        public Sample UserNameEqualAmyWithFirst()
        {
            var result = Source.Where(d => d.UserName == "Amy").First();
            return result;
        }

        public Sample UserNameEqualZoeWithSingle()
        {
            var result = Source.Where(d => d.UserName == "Zoe").Single();
            return result;
        }

        public Sample UserNameEqualStephenWithSingle()
        {
            var result = Source.Where(d => d.UserName == "Stephen").Single();
            return result;
        }
        public Sample UserNameEqualStephenWithSingleOrDefault()
        {
            var result = Source.Where(d => d.UserName == "Stephen").SingleOrDefault();
            return result;
        }

        public Sample UserNameEqualAmyWithSingleOrDefault()
        {
            var result = Source.Where(d => d.UserName == "Amy").SingleOrDefault();
            return result;
        }
    }
}
