using MyStore.NewFolder;

namespace MyStore.MyStore.Data.Interfaces
{
    public interface IOrderDetailRepository
    {
        OrderDetail Add(OrderDetail category);
        int Delete(OrderDetail category);
        IEnumerable<OrderDetail> GetAll(int page);
        IQueryable<OrderDetail> GetAll();
        IQueryable<OrderDetail> GetAll(int page, string? text);
        OrderDetail? GetOrderDetailById(int id);
        OrderDetail Update(OrderDetail category);
    }
}
