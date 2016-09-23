using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    interface IMenu
    {
        //Show the current balance, ask the user how much they are depositing,
        //and show the new balance after the deposit.
        void Deposit();

        //Show the current balance, ask the user how much they are withdrawing,
        //and show the new balance after the withdrawal.
        void Withdraw();
    }
}
