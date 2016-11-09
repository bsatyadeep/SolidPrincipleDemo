namespace Solid.DSP
{
    public interface ITransferSource
    {
        void RemoveFunds(decimal withdrawl);
    }
    public interface ITransferDestination
    {
        void AddFunds(decimal deposit);
    }
    public class BankAccount : ITransferSource, ITransferDestination
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
        public ITransferSource Source { get; set; }
        public ITransferDestination Destination { get; set; }
        public decimal Amount { get; set; }

        public void Transfer()
        {
            Source.RemoveFunds(Amount);
            Destination.AddFunds(Amount);
        }
    }
    class Dsp
    {
    }
}
