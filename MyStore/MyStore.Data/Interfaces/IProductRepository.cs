using MyStore.NewFolder;

namespace MyStore.MyStore.Data.Interfaces
{
    public interface IProductRepository
    {
        Product Add(Product product);
        int Delete(Product product);
        IEnumerable<Product> GetAll(int page);
        IQueryable<Product> GetAll();
        IQueryable<Product> GetAll(int page, string? text);
        Product? GetProductById(int id);
        Product Update(Product product);
    }
}
