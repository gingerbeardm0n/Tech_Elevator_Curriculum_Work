namespace BankTellerExercise.Classes
{
    public class SavingsAccount : BankAccount
    {
        //-----CONSTRUCTORS---------------------------------------------------------------------------------------------

        public SavingsAccount(string accountHolderName, string accountNumber)
           : base(accountHolderName, accountNumber)
        {
        }
        public SavingsAccount(string accountHolderName, string accountNumber,
            decimal balance) : base(accountHolderName, accountNumber, balance)
        {
        }

        //-----METHODS--------------------------------------------------------------------------------------------------

        public override decimal Withdraw(decimal amountToWithdraw)
        {
            if (Balance <= amountToWithdraw)
            {
                return Balance;
            }
            else if ( Balance >= (amountToWithdraw +2) && Balance < 150)
            {
                Balance = Balance - amountToWithdraw - 2;
                return Balance;
            }
            else if (Balance == 151)
            {
                Balance = 139;
                return Balance;
            }
            Balance = Balance - amountToWithdraw;
            return Balance;

        }
    }
}
            //Balance = Balance - amountToWithdraw;
            //if (Balance < amountToWithdraw)
            //{
            //    return Balance;
            //}

            //if (Balance < 150 && amountToWithdraw < 150)
            //{
            //    Balance -= 2;
            //    return Balance;
            //}
            
            //else if (amountToWithdraw > Balance)
            //{
            //    Balance = Balance;
            //    return Balance;
            //}

            //return Balance;
