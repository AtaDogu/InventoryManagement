using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Order:IEntity
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public short Type { get; set; }
        public short Status { get; set; }
        public double SubTotal { get; set; }
        public double ItemDiscount { get; set; }
        public double Tax { get; set; }
        public double Shipping { get; set; }
        public double Total { get; set; }
        public string Promo { get; set; }
        public double Discount { get; set; }
        public double GrandTotal { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Description { get; set; }
    }
}