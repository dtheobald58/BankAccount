using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace BankAccount
{
    public abstract class Account
    {
        //fields
        private string accountNum;
        protected string accountFirstName;
        protected string accountLastName;
        private double accountBalance;
        protected string accountType;


        //properties
        public double Balance
        {
            get { return this.accountBalance; }
            set { this.accountBalance = value; }
        }

        public string AccountNumber
        {
            get { return this.accountNum; }
            set { this.accountNum = value; }
        }
        //constructors
            //none since class is abstract       

        //methods

        public virtual string AccountSummary (string userAndAccType)
        {
            StreamReader reader = new StreamReader(userAndAccType + ".txt");
            string accSum = reader.ReadToEnd();
            return accSum;            
        }

        public void DisplayAccountInfo(string accountType)
        {
            if (accountType == "checking")
            {
                Console.Write("{0}, {1}\n\nChecking Account\n{2}\n\n", accountLastName, accountFirstName, accountNum);
            }
            else if (accountType == "savings")
            {
                Console.Write("{0}, {1}\n\nSavings Account\n{2}\n\n", accountLastName, accountFirstName, accountNum);
            }
            else if (accountType == "reserve")
            {
                Console.Write("{0}, {1}\n\nReserve Account\n{2}\n\n", accountLastName, accountFirstName, accountNum);
            }
        }
        
    }
}
