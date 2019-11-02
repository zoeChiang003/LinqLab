using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            //var result = Source.GroupBy(d => d.UserName).ToList();
            //return result;
        }

        public IEnumerable<IGrouping<TempObj, Sample>> GroupByUserNameAndCreateTime()
        {
            return null;

            //var result = Source.ToList().GroupBy(d => new TempObj()
            //{
            //    UserName = d.UserName,
            //    CreateTime = d.CreateTime
            //});
            //return result;
        }
    }
}
