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
        }

        public List<Sample> OrderByDescendingWithId()
        {
            return null;
        }

        public List<Sample> OrderByPriceAndThenOrderById()
        {
            return null;
        }
    }
}
