using Banking.HardcodedData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Models
{
    static class HardcodedData
    {
        public static List<User> GetUsers()
        {
            List<User> users = new List<User>();
            User user = new User();
            user.UserName = "Harald";
            user.IBan = "DE02120300000000202051";
            users.Add(user);



            return users;



        }

        public static List<Transaction> GetTransactions()
        {
            var users = GetUsers();
            List<Transaction> transactions = new List<Transaction>();

            foreach (var user in users)
            {
                Random rand = new Random();
                var value = rand.Next(0, 5000);
                Transaction transaction = new Transaction(value, user);
                transactions.Add(transaction);
            }
            
            return transactions;

        }

    }
}
