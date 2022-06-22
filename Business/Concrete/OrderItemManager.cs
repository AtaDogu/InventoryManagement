using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class OrderItemManager:IOrderItemService
    {
        private IOrderItemDal _orderItemDal;

        public OrderItemManager(IOrderItemDal orderItemDal)
        {
            _orderItemDal = orderItemDal;
        }

        public IDataResult<List<OrderItem>> GetAll()
        {
            return new SuccessDataResult<List<OrderItem>>(_orderItemDal.GetList().ToList());
        }

        public IDataResult<OrderItem> Get(int id)
        {
            return new SuccessDataResult<OrderItem>(_orderItemDal.Get(o => o.Id == id));
        }

        public IResult Add(OrderItem orderItem)
        {
            _orderItemDal.Add(orderItem);
            return new SuccessResult(Messages.OrderItemAdded);
        }

        public IResult Delete(OrderItem orderItem)
        {
            _orderItemDal.Delete(orderItem);
            return new SuccessResult(Messages.OrderItemDeleted);
        }

        public IResult Update(OrderItem orderItem)
        {
            _orderItemDal.Update(orderItem);
            return new SuccessResult(Messages.OrderItemUpdated);
        }
    }
}
