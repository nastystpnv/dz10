using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz10
{
    internal class Creator
    {
        private static Dictionary<int, Building> accounts = new Dictionary<int, Building>();
        private static int nextBuildingNumber = 1;

        internal static int CreateAccount(int buildingNumber, int high, int floor, int flat, int padic)
        {
            Building newAccount = new Building(buildingNumber, high, floor, flat, padic);
            accounts.Add(nextBuildingNumber, newAccount);
            nextBuildingNumber++;
            return nextBuildingNumber - 1;
        }

        internal static int CreateAccount()
        {
            Building newAccount = new Building(0, 0, 0, 0, 0);
            accounts.Add(nextBuildingNumber, newAccount);
            nextBuildingNumber++;
            return nextBuildingNumber - 1;
        }

        internal static void DeleteAccount(int accountNumber)
        {
            if (accounts.ContainsKey(accountNumber))
            {
                accounts.Remove(accountNumber);
            }
        }
    }
}

