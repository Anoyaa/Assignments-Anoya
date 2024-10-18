
namespace Card_management_lib.Models
{
    public enum AccountType
    {
        Debit,
        Credits
    }

    public class Accounts
    {
        //private static int aid = 1000; 

        public string Id { get; set; }
        public string? AccountNumber { get; set; }
        public double Balance { get; set; }
        public AccountType Type { get; set; }
        public List<Transactions>? Transactions { get; set; }

        public Accounts()
        {
            //Id = "Acc" + aid++;
        }

       
    }
}

