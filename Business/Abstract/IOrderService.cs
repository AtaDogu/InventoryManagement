using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IOrderService
    {
        public IDataResult<List<Order>> GetAll();
        public IDataResult<Order> Get(int id);
        public IResult Add(Order order);
        public IResult Delete(Order order);
        public IResult Update(Order order);
    }
}
