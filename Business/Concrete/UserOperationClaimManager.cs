using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class UserOperationClaimManager : IUserOperationClaimService
    {
        private readonly IUserOperationClaimDal _userOperationClaimDal;

        public UserOperationClaimManager(IUserOperationClaimDal userOperationClaimDal)
        {
            _userOperationClaimDal = userOperationClaimDal;
        }

        public IResult Add(UserOperationClaim companyOperationClaim)
        {
            _userOperationClaimDal.Add(companyOperationClaim);
            return new SuccessResult(Messages.ClaimAdded);

        }

        public IDataResult<List<UserOperationClaim>> GetByClaimId(int claimId)
        {
            return new SuccessDataResult<List<UserOperationClaim>>(
                _userOperationClaimDal.GetAll(claim => claim.OperationClaimId == claimId));
        }

        public IDataResult<List<UserOperationClaim>> GetAll()
        {
            return new SuccessDataResult<List<UserOperationClaim>>(_userOperationClaimDal.GetAll());
        }

        public IDataResult<UserOperationClaim> GetByUserId(int userId)
        {
            return new SuccessDataResult<UserOperationClaim>(_userOperationClaimDal.Get(claim => claim.UserId == userId)) ;
        }
    }
}