using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class User
    {
        //Protected fields
       protected string username;
       protected string password;
       protected bool isAdmin;

        //Constructor
        public User(string username, string password, bool isAdmin)
        {
            this.username = username;
            this.password = password;
            this.isAdmin = isAdmin;
        }

        //Properties
        public string UserName
        {
            get { return username; }
        }

        public string PassWord
        {
            get { return password; }
        }

        public bool IsAdmin
        {
            get { return isAdmin; }
        }
    }
}
