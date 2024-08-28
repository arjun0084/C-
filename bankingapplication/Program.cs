
//This code is written by Kshitij Lavhe on 28 Aug 2024
//This code demonstrates the basic functionality of bank account 

namespace bankingapplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input;
            Account ac = null;  //declaring an null obj (constructor is not called) to check wether ac is creted or not
            do            //loop for constantly providing menu
            {

                Console.WriteLine("---------------------------------");
                Console.WriteLine("Banking application");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("\n1. Create Account");
                Console.WriteLine("2. Display account info");
                Console.WriteLine("3. Deposit Amount");
                Console.WriteLine("4. Withdraw Amount");
                Console.WriteLine("5. Quit");
                Console.Write(">> ");
                input = int.Parse(Console.ReadLine());
                switch (input)               // to handle the input
                {
                    case 1:
                        Console.Write("Enter account no: ");
                        int no=int.Parse(Console.ReadLine());
                        Console.Write("Enter account name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter account opening balance: ");
                        int bal = int.Parse(Console.ReadLine());
                        
                        ac =new Account(no, name, bal);      //constructor called and parameters passed
                        Console.WriteLine("\n\nAccount has benn created Suessfully\n\n");
                        break;
                    case 2:
                        if (ac != null)             // to check wether account is created or not
                        {
                            Console.WriteLine("\n\nAccount no : {0}", ac.Ac_no);  //using getter
                            Console.WriteLine("Account owner: {0}", ac.Name);
                            Console.WriteLine("Account Balance: {0}\n\n", ac.Balance);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\n\ncreate an account first\n\n");
                            break;
                        }
                    case 3:
                        if (ac != null)
                        {
                            Console.Write("Enter amount to deposit: ");
                            double amt = double.Parse(Console.ReadLine());
                            ac.Deposit(amt);        // function called as balance is private and to keep it read only setter is not declared
                            Console.WriteLine("\n\nDeposit Sucessful\nCurrent Balance: {0}\n\n", ac.Balance);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\n\ncreate an account first\n\n");
                            break;
                        }
                    case 4:
                        if (ac != null)
                        {
                            Console.Write("Enter amt to withdraw: ");
                            double amt = double.Parse(Console.ReadLine());
                            if (amt > ac.Balance)
                            {
                                Console.WriteLine("\n\nInsufficient balance :(\n\n");
                                break;

                            }
                            else
                            {
                                ac.Withdraw(amt);       // function called as balance is private and to keep it read only setter is not declared
                                Console.WriteLine("\n\nWithdrawal susessful\nCurrent Balance: {0}\n\n", ac.Balance);
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n\ncreate an account first\n\n");
                            break;
                        }
                    default:    //handels invalid inputs from user
                        Console.WriteLine("\n\nEnter valid Input\n\n");
                        break;



                }
            }
            while (input !=5);   //exit whtn input is 5

            


        }
    }
}
