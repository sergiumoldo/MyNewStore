using MyStore.Data;
using MyStore.MyStore.Data.Interfaces;
using MyStore.MyStore.Services.Interfaces;
using MyStore.NewFolder;

namespace MyStore.MyStore.Services
{
    public class OrderDetailService : IOrderDetailService
    {
        private readonly IOrderDetailRepository orderDetailRepository;

        public OrderDetailService(IOrderDetailRepository orderDetailRepository)
        {
            this.orderDetailRepository = orderDetailRepository;
        }

        public OrderDetail? GetOrderDetail(int id)
        {
            var existingOrderDetail = orderDetailRepository.GetOrderDetailById(id);
            return existingOrderDetail;
        }


        public IEnumerable<OrderDetail> GetOrderDetails(int page)
        {

            return orderDetailRepository.GetAll(page);
        }

        public IEnumerable<OrderDetail> GetOrderDetails(int page, string text)
        {

            return orderDetailRepository.GetAll(page, text);
        }

        public OrderDetail InsertNew(OrderDetail orderDetail)
        {

            return orderDetailRepository.Add(orderDetail);
        }


        public int Remove(OrderDetail orderDetail)
        {
            return orderDetailRepository.Delete(orderDetail);
        }

        public OrderDetail Update(OrderDetail orderDetail)
        {
            return orderDetailRepository.Update(orderDetail);
        }

        public bool IsDuplicate(string orderDetail)
        {
            var orderDetails = orderDetailRepository.GetAll();//1
            orderDetails = orderDetails.Where(x => x.Product.ToString() == orderDetail);//2
            orderDetails.Where(x => x.Product.ToString().Contains("x"));//3

            return orderDetails.Any();
        }
    }
}
