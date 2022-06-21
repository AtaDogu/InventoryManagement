using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class ProductMeta:IEntity
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public string Key { get; set; }
        public string Description { get; set; }

    }
}