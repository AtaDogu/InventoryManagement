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
    public class AddressManager:IAddressService
    {
        private IAddressDal _addressDal;

        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }

        public IDataResult<List<Address>> GetList()
        {
            return new SuccessDataResult<List<Address>>(_addressDal.GetList().ToList());
        }

        public IDataResult<Address> Get(int id)
        {
            return new SuccessDataResult<Address>(_addressDal.Get(a => a.Id == id));
        }

        public IResult Add(Address address)
        {
            _addressDal.Add(address);
            return new SuccessResult(Messages.AddressAdded);
        }

        public IResult Delete(Address address)
        {
            _addressDal.Delete(address);
            return new SuccessResult(Messages.AddressDeleted);
        }

        public IResult Update(Address address)
        {
            _addressDal.Update(address);
            return new SuccessResult(Messages.AddressUpdated);
        }
    }
}
