﻿using MyStore.NewFolder;
using System.ComponentModel.DataAnnotations;

namespace MyStore.Models
{
    public class ProductModel
    {
        [Required]
        public int Productid { get; set; }
        [Required]
        [MinLength(5)]
        public string Productname { get; set; } = null!;

        public int Supplierid { get; set; }

        public int Categoryid { get; set; }

        public decimal Unitprice { get; set; }

        public bool Discontinued { get; set; }

        public virtual Category Category { get; set; } = null!;

        public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

        public virtual Supplier Supplier { get; set; } = null!;
    }
}
