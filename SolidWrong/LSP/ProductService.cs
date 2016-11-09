using System;

namespace SolidWrong.LSP
{
    public class ProductService
    {
        public virtual void Add(Product product)
        {
            //add product to database
        }

        public Product Get()
        {
            Product product = new Product();
            //get the product from database
            return product;
        }
    }

    public class ReadOnlyProductService : ProductService
    {
        public override void Add(Product product)
        {
            throw new InvalidOperationException();
        }
    }
}
