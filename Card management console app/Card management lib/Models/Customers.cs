
namespace Card_management_lib.Models
{
    public class Customers
    {
        //private static int cid = 1000; 

        public string Id { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerEmail { get; set; }
        public string? CustomerPhone { get; set; }
        public string? CustomerAddress { get; set; }
        public List<Accounts> Account { get; set; }

        public Customers()
        {
            //id = "cust" + cid++;
        }

    }
}

