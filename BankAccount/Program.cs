using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Savings DGilbertSavings = new Savings("Dan", "Gilbert", "savings", "1029384756", 4700000000);
            Checking DGilbertChecking = new Checking("Dan", "Gilbert", "checking", "1290347856", 20000000);
            Reserve DGilbertReserve = new Reserve("Dan", "Gilbert", "reserve", "2109438765", 12500000);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Hello Dan Gilbert,\n\nPlease choose an account below:\n\n");
                Console.WriteLine("Checking Account \t[Enter \"1\"]");
                Console.WriteLine("Reserve Account \t[Enter \"2\"]");
                Console.WriteLine("Savings Account \t[Enter \"3\"]");
                Console.WriteLine("Exit \t\t\t[Enter \"0\"]");

                int accChoice = int.Parse(Console.ReadLine());

                if (accChoice == 1)
                {
                    Console.Clear();
                    DGilbertChecking.DisplayAccountInfo("checking");
                    Console.WriteLine("Account Summary [Enter \"1\"]");
                    Console.WriteLine("Deposit \t[Enter \"2\"]");
                    Console.WriteLine("Withdraw \t[Enter \"3\"]");
                    int accAction = int.Parse(Console.ReadLine());
                    if (accAction == 1)
                    {
                        Console.Clear();
                        Console.WriteLine(DGilbertChecking.AccountSummary("DGilbertChecking"));
                        Console.ReadLine();
                    }
                    else if (accAction == 2)
                    {
                        DGilbertChecking.Deposit();
                    }
                    else if (accAction == 3)
                    {
                        DGilbertChecking.Withdraw();
                    }

                }
                else if (accChoice == 2)
                {
                    Console.Clear();
                    DGilbertChecking.DisplayAccountInfo("reserve");
                    Console.WriteLine("Account Summary [Enter \"1\"]");
                    Console.WriteLine("Deposit \t[Enter \"2\"]");
                    Console.WriteLine("Withdraw \t[Enter \"3\"]");
                    int accAction = int.Parse(Console.ReadLine());
                    if (accAction == 1)
                    {
                        Console.Clear();
                        Console.WriteLine(DGilbertReserve.AccountSummary("DGilbertReserve"));
                        Console.ReadLine();
                    }
                    else if (accAction == 2)
                    {
                        DGilbertReserve.Deposit();
                    }
                    else if (accAction == 3)
                    {
                        DGilbertReserve.Withdraw();
                    }
                }
                else if (accChoice == 3)
                {
                    Console.Clear();
                    DGilbertChecking.DisplayAccountInfo("savings");
                    Console.WriteLine("Account Summary [Enter \"1\"]");
                    Console.WriteLine("Deposit \t[Enter \"2\"]");
                    Console.WriteLine("Withdraw \t[Enter \"3\"]");
                    int accAction = int.Parse(Console.ReadLine());
                    if (accAction == 1)
                    {
                        Console.ReadLine();
                        Console.WriteLine(DGilbertSavings.AccountSummary("DGilbertSavings"));
                        Console.ReadLine();
                    }
                    else if (accAction == 2)
                    {
                        DGilbertSavings.Deposit();
                    }
                    else if (accAction == 3)
                    {
                        DGilbertSavings.Withdraw();
                    }
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            
            

        }


    }
}
