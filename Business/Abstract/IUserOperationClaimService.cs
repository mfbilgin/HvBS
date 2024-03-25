using System.Collections.Generic;
using Core.Entities.Concrete;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IUserOperationClaimService
    {
        IResult Add(UserOperationClaim userOperationClaim);
        IDataResult<UserOperationClaim> GetByUserId(int userId);
        IDataResult<List<UserOperationClaim>> GetAll();

    }
}