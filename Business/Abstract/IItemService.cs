using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IItemService
    {
        public IDataResult<List<Item>> GetAll();
        public IDataResult<Item> Get(int id);
        public IResult Add(Item item);
        public IResult Delete(Item item);
        public IResult Update(Item item);
    }
}
