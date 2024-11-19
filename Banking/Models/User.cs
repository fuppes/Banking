using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Models
{
   public class User
    {
        public string Username {  get; set; } 
        public string Password { get; set; }
        public string IBAN { get; set; }
        public double Accountbalance { get; set; }


    }
}
