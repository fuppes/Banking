using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.HardcodedData
{
    class Transaction
    {
        decimal Value { get; set; }
        User Recipient { get; set; }

        string Description { get; set; }
        DateTime DateTime { get; set; }



        public Transaction(decimal value, User recipient)
        {
            DateTime = DateTime.Now;
            this.Value = value;
            this.Recipient = recipient;
        }

        
    }
}
