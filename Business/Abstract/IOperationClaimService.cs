using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IOperationClaimService
    {
        public IDataResult<List<OperationClaim>> GetAll();
        public IDataResult<OperationClaim>Get(int id);
        public IResult Add(OperationClaim operationClaim);
        public IResult Delete(OperationClaim operationClaim);
        public IResult Update(OperationClaim operationClaim);
    }
}
