using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IOrderItemService
    {
        public IDataResult<List<OrderItem>> GetAll();
        public IDataResult<OrderItem>Get(int id);
        public IResult Add(OrderItem orderItem);
        public IResult Delete(OrderItem orderItem);
        public IResult Update(OrderItem orderItem);
    }
}
