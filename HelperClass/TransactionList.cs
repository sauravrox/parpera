using Parpera.HelperClass;

namespace Parpera.HelperClass
{
    public class TransactionList
    {
        public List<Transaction> Transactions { get; set; } = new List<Transaction>
        {
            new Transaction { ID = 11, Datetime = DateTime.Parse("2020-09-08T16:34:23Z"), Description = "Bank Deposit", Amount = 500.00m, Status = "Completed" },
            new Transaction { ID = 10, Datetime = DateTime.Parse("2020-09-08T09:02:23Z"), Description = "Transfer to James", Amount = -20.00m, Status = "Pending" },
            new Transaction { ID = 9, Datetime = DateTime.Parse("2020-09-07T21:52:23Z"), Description = "ATM withdrawal", Amount = -20.00m, Status = "Completed" },
            new Transaction { ID = 8, Datetime = DateTime.Parse("2020-09-06T10:32:23Z"), Description = "Google Subscription", Amount = -15.00m, Status = "Completed" },
            new Transaction { ID = 7, Datetime = DateTime.Parse("2020-09-06T07:33:23Z"), Description = "Apple Store", Amount = -2000.00m, Status = "Cancelled" },
            new Transaction { ID = 6, Datetime = DateTime.Parse("2020-08-23T17:39:23Z"), Description = "Mini Mart", Amount = -23.76m, Status = "Completed" },
            new Transaction { ID = 5, Datetime = DateTime.Parse("2020-08-16T21:06:23Z"), Description = "Mini Mart", Amount = -56.43m, Status = "Completed" },
            new Transaction { ID = 4, Datetime = DateTime.Parse("2020-06-15T18:17:23Z"), Description = "Country Railways", Amount = -167.78m, Status = "Completed" },
            new Transaction { ID = 3, Datetime = DateTime.Parse("2020-04-09T16:26:23Z"), Description = "Refund", Amount = 30.00m, Status = "Completed" },
            new Transaction { ID = 2, Datetime = DateTime.Parse("2020-04-01T12:47:23Z"), Description = "Amazon Online", Amount = -30.00m, Status = "Completed" },
            new Transaction { ID = 1, Datetime = DateTime.Parse("2020-03-30T23:53:23Z"), Description = "Bank Deposit", Amount = 500.00m, Status = "Completed" }
        };
        public static List<Transaction> GetTransactions()
        {
            return new TransactionList().Transactions;
        }
    }

    
}
