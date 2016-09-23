using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccount
{
    class Savings : Account , IMenu
    {
        //constructors
        public Savings(string firstName, string lastName, string accType, string accNum, double accBal)
        {
            accountFirstName = firstName;
            accountLastName = lastName;
            accountType = accType;
            AccountNumber = accNum;
            Balance = accBal;
        }

        //methods
        public void Deposit()
        {
            Console.WriteLine("Current account balance: $" + Balance + "\n");
            Console.WriteLine("Please enter the amount you are depositing.\n");
            double addToAcc = double.Parse(Console.ReadLine());
            Console.Write("\nCurrent transaction: ");
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("+$" + addToAcc + "\n"); Console.ForegroundColor = ConsoleColor.White;
            Balance += addToAcc;
            Console.WriteLine("New savings account balance: $" + Balance);    
        }

        public void Withdraw()
        {
            Console.WriteLine("Current account balance: $" + Balance + "\n");
            Console.WriteLine("Please enter the amount you are withdrawing.\n");
            double subFromAcc = double.Parse(Console.ReadLine());
            Console.Write("\nCurrent transaction: ");
            Console.ForegroundColor = ConsoleColor.Red; Console.Write("-$" + subFromAcc + "\n"); Console.ForegroundColor = ConsoleColor.White;
            Balance -= subFromAcc;
            Console.WriteLine("New savings account balance: $" + Balance);
        }
    }
}
