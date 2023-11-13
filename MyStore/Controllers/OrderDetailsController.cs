using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyStore.Helpers;
using MyStore.Models;
using MyStore.MyStore.Services.Interfaces;
using MyStore.NewFolder;
using MyStore.Services;

namespace MyStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        private readonly IOrderDetailService orderDetailService;

        public OrderDetailsController(IOrderDetailService orderDetailService)
        {

            this.orderDetailService = orderDetailService;
        }

        

    }
}
