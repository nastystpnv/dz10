using System;

namespace dz10
{
    
    internal enum BankAccountType
    {
        Current,
        Saving
    }
    internal class BankAccount
    {
        private int Account_number;
        private double Balance;
        private BankAccountType Type;
        private int Generic;
        static Random r = new Random();
        private static int generic_number = r.Next(999, 10000);
        public BankAccount(int account_number, BankAccountType type)
        {
            this.Account_number = account_number;
            Balance = 0;
            Type = type;
            Generic = generic_number++;
        }
        public BankAccount(int account_number, BankAccountType type, double balance)
        {
            this.Account_number = account_number;
            Balance = balance;
            Type = type;
            Generic = generic_number++;
        }

        public double PutOnAccount(double balance)
        {
            Console.Write("введите сумму для пополнения ");
            double temp = Convert.ToDouble(Console.ReadLine());
            return balance + temp;
        }
        public double WithdrawFromAccount(double balance)
        {
            Console.Write("введите сумму для снятия ");
            double temp = Convert.ToDouble(Console.ReadLine());
            if (balance >= temp)
            { return balance - temp; }
            else
            { Console.WriteLine("на вашем счёте недостаточно средств!"); return balance; }
        }
        public void Transfer(BankAccount destinationAccount, double amount)
        {
            Console.Write("введите сумму для перевода: ");
            double transferAmount = Convert.ToDouble(Console.ReadLine());

            if (this.Balance >= transferAmount)
            {
                this.Balance -= transferAmount;
                destinationAccount.Balance += transferAmount;
                Console.WriteLine($"перевод успешен! Сумма {transferAmount}$ переведена со счёта {destinationAccount.Account_number} на счёт {destinationAccount.Account_number}");
            }
            else
            {
                Console.WriteLine("на вашем счёте недостаточно средств для перевода.");
            }
            Console.ReadKey();
        }
        public int GetAccountNumber()
        {
            return Account_number;
        }
        public static bool operator ==(BankAccount a, BankAccount b)
        {      
            if (a.Account_number == b.Account_number && a.Balance == b.Balance && a.Type == b.Type && a.Generic == b.Generic)
                return true;
            return false;
        }
        public static bool operator !=(BankAccount a, BankAccount b)
        {
            return !(a == b);  
        }
        public static bool operator >(BankAccount a, BankAccount b)
        {
            return (a.Balance> b.Balance);
        }
        public static bool operator <(BankAccount a, BankAccount b)
        {
            return !(a > b);
        }
        public static bool operator >=(BankAccount a, BankAccount b)
        {
            return (a == b || a>b);
        }
        public static bool operator <=(BankAccount a, BankAccount b)
        {
            return (a == b || a < b);
        }
        public static BankAccount operator +(BankAccount a, BankAccount b)
        {
            a.Balance += b.Balance;
            return a;
        }
        public static BankAccount operator -(BankAccount a, BankAccount b)
        {
            a.Balance -= b.Balance;
            return a;
        }
        public static BankAccount operator ++(BankAccount a)
        {
            a.Balance++;
            return a;
        }
        public static BankAccount operator --(BankAccount a)
        {
            a.Balance--;
            return a;
        }
    }
    
}
