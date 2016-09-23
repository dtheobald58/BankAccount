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

            Console.Write("Hello Dan Gilbert,\n\nPlease choose an option below:\n");
            
            
        }


    }
}
