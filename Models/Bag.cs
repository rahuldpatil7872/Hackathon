using System.Collections.Generic;

namespace HackathonDemo.Models
{
    public class Bag
    {
        public int CustomerId { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}