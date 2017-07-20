
namespace HackathonDemo.Models
{
    public class Account
    {
        public string ShippingAddress { get; set; }

        public Product[] OrderList { get; set; }

        public string CustomerName { get; set; }

        public int CustomerId { get; set; }
    }
}