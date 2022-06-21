using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class OrderItem:IEntity      
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public long ItemId { get; set; }
        public long OrderId { get; set; }
        public string Sku { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public short Quantity { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Description { get; set; }
    }
}