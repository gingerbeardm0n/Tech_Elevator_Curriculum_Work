using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    class BankCustomer : IAccountable
    {
        List<IAccountable> bankAccounts = new List<IAccountable>();





        public int Balance { get; private set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsVip
        {
            get
            {
                int totalBalance = 0;
                foreach (IAccountable individualBalance in bankAccounts)
                {
                    totalBalance += individualBalance.Balance;
                }
                if (totalBalance >= 25000)
                {
                    return true;
                }
                return false;
            }
        }




    }
}
