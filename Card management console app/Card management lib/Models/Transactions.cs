
namespace Card_management_lib.Models
{
    public enum TransactionType
    {
        Deposit,
        Withdrawal,
        Transfer
    }

    public class Transactions
    {
        //private static int tid = 1000; 

        public string Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public TransactionType TransactionType { get; set; }
        public double Amount { get; set; }
        public string? Description { get; set; }
        public Accounts Account { get; set; }
      

        public Transactions()
        {
            //Id = "Txn" + tid++;
        }
        public void updateBalance()
        {
            if (TransactionType == TransactionType.Deposit)
            {
                Account.Balance += Amount;
            }
            else if (TransactionType == TransactionType.Withdrawal)
            {
                if (Account.Balance >= Amount)
                {
                    Account.Balance -= Amount;
                }
                else
                {
                    throw new InvalidOperationException("Insufficient funds for withdrawal.");
                }
            }
            else if (TransactionType == TransactionType.Transfer)
            {
                if (Account.Balance >= Amount)
                {
                    Account.Balance -= Amount;
                }
                else
                {
                    throw new InvalidOperationException("Insufficient funds for withdrawal.");
                }
            }

        }
    }
}

