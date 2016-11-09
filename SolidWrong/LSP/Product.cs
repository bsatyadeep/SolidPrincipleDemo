namespace SolidWrong.LSP
{
    public class Product
    {
        private double productPrice;

        public double getPrice(int discountCode)
        {
            if (discountCode == 1)
            {
                return productPrice = (productPrice / 10); //remove 10% from product price
            }
            return productPrice;
        }
    }
}
