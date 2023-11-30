using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz10
{
    internal class Fabric
    {
        private Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();
        private int nextAccountNumber = 1;
        public int CreateAccount()
        {
            BankAccount newAccount = new BankAccount(nextAccountNumber, BankAccountType.Current);
            accounts.Add(nextAccountNumber, newAccount);
            nextAccountNumber++;
            return nextAccountNumber-1;
        }
        internal int CreateAccount(decimal initialBalance)
        {
            BankAccount newAccount = new BankAccount(nextAccountNumber, BankAccountType.Current, 34);
            accounts.Add(nextAccountNumber, newAccount);
            nextAccountNumber++;
            return nextAccountNumber - 1;
        }
        public void DeleteAccount(int accountNumber)
        {
            if(accounts.ContainsKey(accountNumber))
            {
                accounts.Remove(accountNumber);
            }
        }
    }
}
