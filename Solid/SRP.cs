using System;

namespace Solid
{
    public class StockChecker
    {
        public int StockLevel { get; set; }

        public void CheckStockLevel()
        {

        }
    }

    public class StockLevelChecker
    {
        public bool StockLow(StockChecker stockChecker)
        {
            return stockChecker.StockLevel < 5;
        }
    }

    public class StockAlerter
    {
        public void ShowStockAlert(StockChecker stockChecker)
        {
            Console.WriteLine("Stock is low ({0})", stockChecker.StockLevel);
        }
    }
}
