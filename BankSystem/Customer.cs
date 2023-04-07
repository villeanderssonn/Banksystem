using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class Customer : User
    {
        public Customer(string username, string password, bool isAdmin) : base(username, password, isAdmin)
        {

        }
    }
}
