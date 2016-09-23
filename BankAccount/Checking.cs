using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccount
{
    class Checking : Account
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
        public override void Deposit()
        {
            Console.WriteLine("Current account balance: $" + Balance + "\n");
            Console.WriteLine("Please enter the amount you are depositing.\n");
            double addToAcc = double.Parse(Console.ReadLine());
            Console.WriteLine("\nCurrent transaction: +$" + addToAcc);
            Balance += addToAcc;
            Console.WriteLine("New checking account balance: $" + Balance);
        }

        public override void Withdraw()
        {
            throw new NotImplementedException();
        }
    }
}
