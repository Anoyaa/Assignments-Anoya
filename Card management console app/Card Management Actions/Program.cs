using Microsoft.EntityFrameworkCore;
using Card_management_lib.Models;


public class Program
{
    public static void Main()
    {
        using (var context = new CardManagementDbContext())
        {
            var cust = new Customers
            {   

                Id="Cust"+getCId().ToString(),
                CustomerName = "Akhil",
                CustomerEmail = "aaa@gmail.com",
                CustomerPhone = "9054267589",
                Account = new List<Accounts>
                {
                    new Accounts { Id="Acc"+getAId().ToString() , AccountNumber = "23000", Balance = 1000.00 },


                    //new Accounts { Id="Acc"+getAId()+1.ToString() ,AccountNumber = "25000", Balance = 500.00 }
                }
            };

            context.Customers.Add(cust);
            context.SaveChanges();




            var transact = new Transactions()
            {
                Id="Txn"+getTId().ToString() ,
                TransactionDate = DateTime.Now,
                TransactionType = TransactionType.Withdrawal,
                Amount = 1000,
                Account = cust.Account[0]

            };
            


            context.Transactions.Add(transact);
            transact.updateBalance();
            context.SaveChanges();


            var cust2 = new Customers
            {
                Id = "Cust" + getCId().ToString(),
                CustomerName = "Anil",
                CustomerEmail = "aba@gmail.com",
                CustomerPhone = "9054269589",
                Account = new List<Accounts>
                {
                    new Accounts { Id="Acc"+getAId().ToString(),AccountNumber = "23000", Balance = 1000.00 },
                    //new Accounts {Id="Acc"+getAId().ToString(), AccountNumber = "25000", Balance = 500.00 }
                }
            };

            context.Customers.Add(cust2);
            context.SaveChanges();
            var transact1 = new Transactions()
            {
                Id="Txn"+getTId().ToString(),
                TransactionDate = DateTime.Now,
                TransactionType = TransactionType.Deposit,
                Amount = 100,
                Account = cust2.Account[0]

            };
            context.Transactions.Add(transact1);
            transact1.updateBalance();
            context.SaveChanges();

            int getCId()
            {

                return context.Customers.Any()?
                int.Parse(context.Customers.OrderByDescending(cust => cust.Id).First().Id.Substring(4)) + 1 : 1001;
            }


            int getAId()
            {

                return context.Accounts.Any() ?
                int.Parse(context.Accounts.OrderByDescending(cust => cust.Id).First().Id.Substring(3)) + 1 : 1001;
            }


            int getTId()
            {

                return context.Transactions.Any() ?
                int.Parse(context.Transactions.OrderByDescending(cust => cust.Id).First().Id.Substring(3)) + 1 : 1001;
            }


            static void DisplayCustomerDetails(string customerId)
            {
                using (var context = new CardManagementDbContext())
                {
                    var customer = context.Customers
                        .Include(c => c.Account)
                        .FirstOrDefault(c => c.Id == customerId);

                    if (customer != null)
                    {
                        Console.WriteLine($"Customer Id: {customer.Id}");
                        Console.WriteLine($"Name: {customer.CustomerName}");
                        Console.WriteLine($"Email: {customer.CustomerEmail}");
                        Console.WriteLine($"Phone: {customer.CustomerPhone}");
                        Console.WriteLine($"Address: {customer.CustomerAddress}");
                        Console.WriteLine("Accounts:");
                        foreach (var account in customer.Account)
                        {
                            Console.WriteLine($"  Account Id: {account.Id}, Account Number: {account.AccountNumber}, Balance: {account.Balance:C}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Customer with Id = {customerId} not found.");
                    }
                }
                
            }


            static void DisplayAccountDetails(string accountId)
            {
                using (var context = new CardManagementDbContext())

                {
                    var account = context.Accounts
                        .Include(a => a.Transactions)
                        .FirstOrDefault(a => a.Id == accountId);

                    if (account != null)
                    {
                        Console.WriteLine($"Account Id: {account.Id}");
                        Console.WriteLine($"Account Number: {account.AccountNumber}");
                        Console.WriteLine($"Balance: {account.Balance:C}");
                        Console.WriteLine($"Account Type: {account.Type}");
                        if (account.Transactions != null && account.Transactions.Count > 0)
                        {
                            Console.WriteLine("Transactions:");
                            foreach (var transaction in account.Transactions)
                            {
                                Console.WriteLine($"  Transaction Id: {transaction.Id}, Type: {transaction.TransactionType}, Amount: {transaction.Amount:C}, Date: {transaction.TransactionDate}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No transactions available for this account.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Account with Id = {accountId} not found.");
                    }
                }
                
            }
            DisplayAccountDetails("Acc1001");
            DisplayCustomerDetails("Cust1001");

        }
    }
}
