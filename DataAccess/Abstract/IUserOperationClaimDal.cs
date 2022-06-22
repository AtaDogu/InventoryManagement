using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using Core.Entities.Concrete;
using DataAccess.Concrete.EntityFramework.Contexts;

namespace DataAccess.Abstract
{
    public interface IUserOperationClaimDal:IEntityRepository<UserOperationClaim>
    {
    }
}
