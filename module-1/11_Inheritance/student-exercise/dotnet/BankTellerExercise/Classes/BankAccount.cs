namespace BankTellerExercise.Classes
{
    public class BankAccount
    {
        public string AccountHolderName { get; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        //-----CONSTRUCTORS---------------------------------------------------------------------------------------------

        public BankAccount(string accountHolderName, string accountNumber)
        {
            Balance = 0;
            AccountHolderName = accountHolderName;
            AccountNumber = accountNumber;
        }
        public BankAccount(string accountHolderName, string accountNumber, decimal balance)
        {
            Balance = balance;
            AccountHolderName = accountHolderName;
            AccountNumber = accountNumber;
        }

        //-----METHODS--------------------------------------------------------------------------------------------------

        public virtual decimal Deposit(decimal amountToDeposit)
        {
            Balance += amountToDeposit;
            return Balance;
        }
        public virtual decimal Withdraw(decimal amountToWithdraw)
        {
            Balance -= amountToWithdraw;
            return Balance;
        }





    }
}
