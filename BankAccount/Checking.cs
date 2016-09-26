using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccount
{
    class Checking : Account , IMenu
    {
        //constructors
        public Checking(string firstName, string lastName, string accType, string accNum, double accBal)
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
            Console.Clear();
            Console.WriteLine("Current account balance: $" + Balance + "\n");
            Console.WriteLine("Please enter the amount you are depositing.\n");
            double addToAcc = double.Parse(Console.ReadLine());
            Console.Write("\nCurrent transaction: ");
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("+$" + addToAcc + "\n"); Console.ForegroundColor = ConsoleColor.White;
            Balance += addToAcc;
            Console.WriteLine("New checking account balance: $" + Balance);
            Console.ReadLine();
        }

        public void Withdraw()
        {
            Console.Clear();
            Console.WriteLine("Current account balance: " + Balance + "\n");
            Console.WriteLine("Please enter the amount you are withdrawing.\n");
            double subFromAcc = double.Parse(Console.ReadLine());
            Console.Write("\nCurrent transaction: ");
            Console.ForegroundColor = ConsoleColor.Red; Console.Write("-$" + subFromAcc + "\n"); Console.ForegroundColor = ConsoleColor.White;
            Balance -= subFromAcc;
            Console.WriteLine("New checking account balance: $" + Balance);
            Console.ReadLine();
        }
    }
}
