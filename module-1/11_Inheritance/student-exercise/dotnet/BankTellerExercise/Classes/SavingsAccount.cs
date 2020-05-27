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
            Balance = Balance - amountToWithdraw;
            if (amountToWithdraw > Balance)
            {
                Balance = Balance;
                return Balance;
            }

            else if (Balance < 150 && amountToWithdraw < 150)
            {
                Balance -= 2;
                return Balance;
            }
            
            return Balance;
        }
    }
}
