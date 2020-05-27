namespace BankTellerExercise.Classes
{
    public class CheckingAccount : BankAccount
    {


        //-----CONSTRUCTORS---------------------------------------------------------------------------------------------

        public CheckingAccount(string accountHolderName, string accountNumber)
            : base(accountHolderName, accountNumber)
        {
        }

        public CheckingAccount(string accountHolderName, string accountNumber,
            decimal balance) : base(accountHolderName, accountNumber, balance)
        {
        }



        //-----METHODS--------------------------------------------------------------------------------------------------

        public override decimal Withdraw(decimal amountToWithdraw)
        {
            

            if (Balance < 0 && Balance > -100)
            {
                Balance = Balance - amountToWithdraw - 10;
                return Balance;
            }
            else if (Balance <= -100)
            {
                return Balance;
            }
            Balance = Balance - amountToWithdraw;
            return Balance;
        }




    }
}
