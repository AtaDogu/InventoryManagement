using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IUserOperationClaimService
    {
        public IDataResult<List<UserOperationClaim>> GetAll();
        public IDataResult<UserOperationClaim>Get(int id);
        public IResult Add(UserOperationClaim userOperationClaim);
        public IResult Update(UserOperationClaim userOperationClaim);
        public IResult Delete (UserOperationClaim userOperationClaim);
    }
}
