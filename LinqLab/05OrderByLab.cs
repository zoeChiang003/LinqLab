using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{
    public class OrderByLab
    {
        private static IEnumerable<Sample> Source { get; set; }
        public OrderByLab()
        {
            Source = new SampleDate().GetData();
        }

        public List<Sample> OrderByWithId()
        {
            var result = Source.OrderBy(d => d.Id).ToList();
            return result;
        }

        public List<Sample> OrderByDescendingWithId()
        {
            var result = Source.OrderByDescending(d => d.Id).ToList();
            return result;
        }

        public List<Sample> OrderByPriceAndThenOrderById()
        {
            var result = Source.OrderBy(d => d.Price).ThenBy(d=>d.Id).ToList();
            return result;
        }
    }
}
