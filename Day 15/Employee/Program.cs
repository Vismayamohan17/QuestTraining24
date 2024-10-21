using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Account
    {
        public int id { get; set; }
        public string name { get; set; }
        public double balance { get; set; }
    }
    class Transaction
    {
        public int id { get; set; }
        public int fromAccntId { get; set; }
        public int toAccntId { get; set; }
        public double amount { get; set; }
        public DateTime DateTime { get; set; }
    }
    internal class Program
    {
       
        static void Main(string[] args)
        {
            var Transactions = new List<Transaction>()
            {
                new Transaction {id=1,fromAccntId = 1, toAccntId = 3, amount = 40000 , DateTime = DateTime.Now},
                new Transaction {id=2,fromAccntId = 2, toAccntId = 1, amount = 10000 , DateTime = DateTime.Now}
            };

            var Account = new List<Account>()
            {
                new Account {id=1,name = "abc" , balance = 60000 },
                new Account {id=2,name = "xyz" , balance = 20000 }
            };

            var accntWithTranscation = Account
                .Join(
                    Transactions,
                    a => a.id,
                    t => t.id,
                    (a, t) => new
                    {
                        Amount = t.amount,
                        FromAccount = t.fromAccntId,
                        ToAccount = t.toAccntId,
                        Date = t.DateTime,
                    }
                );
            foreach (var item in accntWithTranscation)
            {
                Console.WriteLine($"{item.Amount}rs transferred from accountid {item.FromAccount} to accountid {item.ToAccount} on {item.Date}");
            }


        }
    }
}
