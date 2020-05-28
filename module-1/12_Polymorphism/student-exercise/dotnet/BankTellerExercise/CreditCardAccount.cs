using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    public class CreditCardAccount : IAccountable
    {

        public string AccountHolderName { get; private set; }
        public string AccountNumber { get; private set; }
        public int Debt { get; private set; }
        public int Balance
        {
            get
            {
                return Debt * -1;
            }
        }

        //-----CONSTRUCTORS---------------------------------------------------------------------------------------------

        public CreditCardAccount(string accountHolderName, string accountNumber)
        {
            AccountHolderName = accountHolderName;
            AccountNumber = accountNumber;
            Debt = 0;
        }

        //-----METHODS--------------------------------------------------------------------------------------------------

        public int Pay(int amountToPay)
        {
            Debt = Debt - amountToPay;
            
            return Debt;
        }
        public int Charge(int amountToCharge)
        {
            Debt += amountToCharge;
            return Debt;
        }

    }
}
