using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;


namespace Entities.Concrete
{
    public class Item:IEntity
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public long BrandId { get; set; }
        public long SupplierId { get; set; }
        public long OrderId { get; set; }
        public string? Sku { get; set; }
        public double Mrp { get; set; }
        public double Discount { get; set; }
        public double Price { get; set; }
        public short Quantity { get; set; }
        public short Sold { get; set; }
        public short Available { get; set; }
        public short Defective { get; set; }
        public long CreatedBy { get; set; }
        public long UpdatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}