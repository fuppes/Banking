using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Models
{
   public static class User
    {
        public static string Username {  get; set; } 
        public static string Password { get; set; }
        public static string IBAN { get; set; }
        public static double Accountbalance { get; set; }

    }
}
