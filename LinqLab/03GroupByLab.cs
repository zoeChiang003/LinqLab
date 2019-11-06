using System.Collections.Generic;
using System.Linq;

namespace LinqLab
{

    public class GroupByLab
    {
        private static IEnumerable<Sample> Source { get; set; }
        public GroupByLab()
        {
            Source = new SampleDate().GetData();
        }
        public IList<IGrouping<string, Sample>> GroupByUserName()
        {
            return null;
        }

        public IEnumerable<IGrouping<TempObj, Sample>> GroupByUserNameAndCreateTime()
        {
            return null;
        }
    }
}
