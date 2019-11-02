using System.Collections.Generic;

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
            return null;

            //var result = Source.OrderBy(d => d.Id).ToList();
            //return result;
        }

        public List<Sample> OrderByDescendingWithId()
        {
            return null;

            //var result = Source.OrderByDescending(d => d.Id).ToList();
            //return result;
        }

        public List<Sample> OrderByPriceAndThenOrderById()
        {
            return null;

            //var result = Source.OrderBy(d => d.Price).ThenBy(d=>d.Id).ToList();
            //return result;
        }
    }
}
