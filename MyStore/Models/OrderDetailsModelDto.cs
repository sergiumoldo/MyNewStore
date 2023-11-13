using MyStore.NewFolder;
using System.ComponentModel.DataAnnotations;

namespace MyStore.Models
{
    public class OrderDetailsModelDto
    {
        [Required]
        public int Orderid { get; set; }
        [Required]
        public int Productid { get; set; }
        [Required]
        public decimal Unitprice { get; set; }
        [Required]
        public short Qty { get; set; }
        [Required]
        public decimal Discount { get; set; }

        public virtual Order Order { get; set; } = null!;

        public virtual Product Product { get; set; } = null!;
    }
}
