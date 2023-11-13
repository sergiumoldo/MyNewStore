using MyStore.NewFolder;

namespace MyStore.MyStore.Services.Interfaces
{
    public interface IOrderDetailService
    {
        IEnumerable<OrderDetail> GetOrderDetails(int page);
        IEnumerable<OrderDetail> GetOrderDetails(int page, string? text);
        OrderDetail? GetOrderDetail(int id);
        OrderDetail InsertNew(OrderDetail category);
        bool IsDuplicate(string Categoryname);
        int Remove(OrderDetail category);
        OrderDetail Update(OrderDetail category);
    }
}
