using Core.Entities.Concrete;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IOperationClaimService
    {
        IDataResult<OperationClaim> GetByName(string name);
    }
}