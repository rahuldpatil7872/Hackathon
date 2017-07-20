using System.Collections.Generic;

namespace HackathonDemo.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductTitle { get; set; }

        public string Image { get; set; }

        public decimal Price { get; set; }

        public List<string> Size { get; set; }

        public string Colour { get; set; }

        public string Details { get; set; }

        public string LookAfterMe { get; set; }

        public bool IsReturned { get; set; }
    }
}