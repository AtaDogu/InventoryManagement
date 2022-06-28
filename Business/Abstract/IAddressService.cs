using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IAddressService
    {
        public IDataResult<List<Address>> GetList();
        public IDataResult<Address> Get(int id);
        public IResult Add(Address address);
        public IResult Delete(Address address);
        public IResult Update(Address address);
    }
}
