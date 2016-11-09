namespace SolidWrong.DSP
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public void AddFunds(decimal deposit)
        {
            Balance += deposit;
        }

        public void RemoveFunds(decimal withdrawl)
        {
            Balance -= withdrawl;
        }
    }

    public class TransferManager
    {
        public BankAccount Source { get; set; }
        public BankAccount Destination { get; set; }
        public decimal Amount { get; set; }

        public void Transfer()
        {
            Source.RemoveFunds(Amount);
            Destination.AddFunds(Amount);
        }
    }
}
