using MyStore.MyStore.Data.Interfaces;
using MyStore.NewFolder;

namespace MyStore.MyStore.Data
{
    public class OrderDetailRepository: IOrderDetailRepository
    {
        private readonly StoreContext storeContext;

        public OrderDetailRepository(StoreContext storeContext)
        {
            this.storeContext = storeContext;   
        }

        public OrderDetail? GetOrderDetailById(int id)
        {
            return storeContext.OrderDetails.Find(id);
        }

        public OrderDetail Add(OrderDetail orderDetail)
        {
            var addedEntity = storeContext.OrderDetails.Add(orderDetail).Entity;
            storeContext.SaveChanges();
            return addedEntity;

        }

        public int Delete(OrderDetail orderDetail)
        {
            storeContext.OrderDetails.Remove(orderDetail);
            return storeContext.SaveChanges();
        }

        public OrderDetail Update(OrderDetail orderDetail)
        {
            var updatedEntity = storeContext.OrderDetails.Update(orderDetail).Entity;
            storeContext.SaveChanges();
            return updatedEntity;
        }

        public IEnumerable<OrderDetail> GetAll(int page)
        {
            var pageSize = 2;
            var orderDetails =
                 storeContext
                .OrderDetails
                .Skip(pageSize * (page - 1))
                .Take(pageSize)
                .ToList();

            return orderDetails;
        }


        public IQueryable<OrderDetail> GetAll(int page, string? text)
        {
            var pageSize = 2;

            var orderDetails = storeContext.OrderDetails.AsQueryable();

            if (!string.IsNullOrEmpty(text))
            {
                orderDetails = orderDetails.Where(x => x.Product.ToString().Contains(text));

            }

            orderDetails = orderDetails.Skip(pageSize * (page - 1))
                .Take(pageSize);

            return orderDetails;
        }

        public IQueryable<OrderDetail> GetAll()
        {
            return storeContext.OrderDetails;
        }
    }
}
