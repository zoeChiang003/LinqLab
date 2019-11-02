using System.Collections.Generic;

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
            //var result = Source.Where(d => d.UserName == "Zoe").First();
            //return result;
        }

        public Sample UserNameEqualAmyWithFirstOrDefault()
        {
            return null;

            //var result = Source.Where(d => d.UserName == "Amy").FirstOrDefault();
            //return result;
        }

        public Sample UserNameEqualAmyWithFirst()
        {
            return null;

            //var result = Source.Where(d => d.UserName == "Amy").First();
            //return result;
        }

        public Sample UserNameEqualZoeWithSingle()
        {
            return null;

            //var result = Source.Where(d => d.UserName == "Zoe").Single();
            //return result;
        }

        public Sample UserNameEqualStephenWithSingle()
        {
            //var result = Source.Where(d => d.UserName == "Stephen").Single();
            //return result;
        }
        public Sample UserNameEqualStephenWithSingleOrDefault()
        {
            //var result = Source.Where(d => d.UserName == "Stephen").SingleOrDefault();
            //return result;
        }

        public Sample UserNameEqualAmyWithSingleOrDefault()
        {
            return null;

            //var result = Source.Where(d => d.UserName == "Amy").SingleOrDefault();
            //return result;
        }
    }
}
