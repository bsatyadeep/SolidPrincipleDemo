using System;

namespace SolidWrong.SRP
{
    public class Product
    {
        public int StockLevel { get; set; }

        public void CheckStockLevel()
        {

        }
        public bool StockLow()
        {
            return StockLevel < 5;
        }
        public void ShowStockAlert()
        {
            Console.WriteLine("Stock is low ({0})", StockLevel);
        }
    }
}
