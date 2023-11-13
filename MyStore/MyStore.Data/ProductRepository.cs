using MyStore.MyStore.Data.Interfaces;
using MyStore.NewFolder;

namespace MyStore.MyStore.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext storeContext;

        public ProductRepository(StoreContext storeContext)
        {
            this.storeContext = storeContext;
        }
    
        public Product Add(Product product)
        {
            var productToAdd = storeContext.Products.Add(product).Entity;
            storeContext.SaveChanges();
            return productToAdd;
        }

        public int Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll(int page)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Product> GetAll(int page, string? text)
        {
            throw new NotImplementedException();
        }

        public Product? GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public Product Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
