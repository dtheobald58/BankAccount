using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccount
{
    class Reserve : Account
    {
        //constructors
        public Reserve(string firstName, string lastName, string accType, string accNum, double accBal)
        {
            accountFirstName = firstName;
            accountLastName = lastName;
            accountType = accType;
            AccountNumber = accNum;
            Balance = accBal;
        }

        //methods
        public override void Deposit()
        {
            Console.WriteLine("Current account balance: $" + Balance + "\n");
            Console.WriteLine("Please enter the amount you are depositing.\n");
            double addToAcc = double.Parse(Console.ReadLine());
            Console.WriteLine("\nCurrent transaction: +$" + addToAcc);
            Balance += addToAcc;
            Console.WriteLine("New reserve account balance: $" + Balance);
        }

        public override void Withdraw()
        {
            Console.WriteLine("Current account balance: " + Balance + "\n");
            Console.WriteLine("Please enter the amount you are withdrawing.\n");
            double subFromAcc = double.Parse(Console.ReadLine());
            Console.WriteLine("\nCurrent transaction: -$" + subFromAcc);
            Balance -= subFromAcc;
            Console.WriteLine("New reserve account balance: $" + Balance);
        }
    }
}
