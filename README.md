Bank system cs is the main program.

The Run method is the main entry point of the program. It prompts the user to enter a username and password, and checks if the entered credentials are valid by searching a list of User objects for a match. If the credentials are valid, the user is logged in and directed to either the LoggedIn method or the AdminMenu method, depending on whether the user is an admin or not. 

The InitiateUsers method adds two default users to the list of users: an admin user with the username "admin" and password "password", and a non-admin user with the username "customer" and password "password". 

The LoggedIn method is called after the user has successfully logged in. If the user is an admin, it directs the user to the AdminMenu method. If the user is not an admin, it directs the user to the UserMenu method. 

The UserMenu method presents the user with a menu of options, including the ability to open a bank account or list existing bank accounts.

The AdminMenu method presents the admin user with the option to create a new user. 

The OpenBankAccount method prompts the user to enter a name for a new bank account, and the CreateUser method prompts the user to enter details for a new user, including the user's username,password, and whether the user is an admin or not.

The Signout method logs the user out of the program and returns to the login screen. 

The PrintBankAccount method lists all of the bank accounts that the user has created.



The User class has three protected fields: username, password, and isAdmin. These fields are marked as protected, which means that they are only accessible within the User class and any classes that derive from it (such as the Admin class).

The User class also has a constructor that takes three arguments: username, password, and isAdmin. These arguments are used to initialize the corresponding fields.

The User class also has three properties: UserName, PassWord, and IsAdmin. These properties provide read-only access to the corresponding fields. This means that the values of the fields can be accessed from outside the User class, but they cannot be modified.

The User class is intended to represent a user of a bank system, and the Admin class is derived from it to represent an administrator. The isAdmin field is used to differentiate between regular users and administrators.