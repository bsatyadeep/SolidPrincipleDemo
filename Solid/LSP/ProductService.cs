using System;

namespace Solid.LSP
{
    public interface IReadableProductService
    {
        Product Get();
    }

    public interface IWritableProductService
    {
        void Add(Product product);
    }

    public class ReadOnlyProductService : IReadableProductService
    {
        public Product Get()
        {
            Product product = new Product();
            //get product from database
            return product;
        }
    }

    public class ReadWriteProductService : IReadableProductService, IWritableProductService
    {
        public void Add(Product product)
        {
            //Add product to database
        }

        public Product Get()
        {
            Product product = new Product();
            //get product from database
            return product;
        }
    }
    public class ProductService
    {
    }
}
