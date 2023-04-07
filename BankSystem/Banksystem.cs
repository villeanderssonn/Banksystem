using System.Threading;
namespace BankSystem
{
    internal class Banksystem
    {
        User loggedIn;
        List<User> userList = new List<User>();
        public void Run()
        {
            int count = 0;
            InitiateUsers();
            Console.WriteLine("Welcome to our Bank");
            do
            {
                Console.WriteLine("Enter Username:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter Password:");
                string pass = Console.ReadLine();

                User temp = userList.Find(x => x.UserName == name && x.PassWord == pass);

                if (userList.Contains(temp))
                {
                    loggedIn = temp;
                    Console.Clear();
                    LoggedIn();
                    break;
                }
                else
                {
                    Console.WriteLine("Fel användarnamn eller lösenord");
                    count++;
                }
            } while (count < 3);
            if (count == 3)
            {
                Console.Clear();
                Console.WriteLine("För många inloggnings försök! Stänger programmet.");
            }
        }

        //Lägger till användare i listan userList
        public void InitiateUsers()
        {
            userList.Add(new User("admin", "password", true));
            userList.Add(new User("customer", "password", false));
        }

        public void LoggedIn()
        {
            Console.Clear();
            Console.WriteLine($"You are now logged in as {loggedIn.UserName}");

            if (loggedIn.IsAdmin)
            {
                AdminMenu();
            }
            else
            {
                UserMenu();
            }
        }

        public void UserMenu()
        {
            
            Console.WriteLine("Welcome to the Customer Menu");
            Console.WriteLine("To open a bank account, insert the command OB, to list all your existing bank accounts, insert LB");
            string usercommand = Console.ReadLine();
            switch (usercommand.ToLower())
            {
                case "ob":
                     OpenBankAccount();
                    break;
                case "lb":
                    PrintBankAccount();
                    break;
                case "exit":
                    Signout();
                    break;
                default:
                    Console.WriteLine("Command not valid");
                    break;
            }
        }

        public void AdminMenu()
        {
            bool signIn = true;
            while (signIn)
            {
                Console.WriteLine("Welcome to the Admin Menu");
                Console.WriteLine("To Create a user, input command: CU");
                string usercommand = Console.ReadLine();
                switch (usercommand.ToLower())
                {
                    case "cu":
                        CreateUser();
                        break;
                    case "exit":
                        Signout();
                        signIn = false;
                        break;
                    default:
                        Console.WriteLine("Command not valid");
                        break;
                }
            }
        }

        public void OpenBankAccount()
        {
            Console.WriteLine("What do you want the account name to be?");
            string name = Console.ReadLine();
            //Customer loggedIn = (Customer)loggedIn;
        }

        public void CreateUser()
        {
            Console.WriteLine("Select user type, U = User, A = Admin");
            string userCommand = Console.ReadLine();
            bool isAdmin = default;
            switch (userCommand.ToLower())
            {
                case "a":
                    isAdmin = true;
                    break;
                case "u":
                    isAdmin = false;
                    break;
                case "exit":
                    Signout();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Command not valid");
                    break;
            }
            var userRole = isAdmin ? "Admin" : "User";
            Console.WriteLine($"To create a new {userRole}, Please input the Username");
            string newUsername = Console.ReadLine();
            Console.WriteLine("Now, input the users password");
            string newPassword = Console.ReadLine();
            userList.Add(new User(newUsername, newPassword, isAdmin));
            Console.Clear();
            Console.WriteLine($"{userRole} {newUsername} with password {newPassword} has been created");
            Thread.Sleep(3000);
            Console.Clear();
        }

        public void Signout()
        {
            Console.Clear();
            Console.WriteLine("Signing off...");
            Thread.Sleep(1500);
            Console.Clear();
            Run();
        }

        public void PrintBankAccount()
        {
            Console.WriteLine("Printing bank accounts");
        }
    }
}
