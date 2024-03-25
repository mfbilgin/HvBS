using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;
        private readonly IUserOperationClaimService _userOperationClaimService;
        private readonly IOperationClaimService _operationClaimService;
        public UserManager(IUserDal userDal, IUserOperationClaimService userOperationClaimService, IOperationClaimService operationClaimService)
        {
            _userDal = userDal;
            _userOperationClaimService = userOperationClaimService;
            _operationClaimService = operationClaimService;
        }

        public IResult Add(User user)
        {
            if (CheckIfUserExist(user.HvBSNumber))
            {
                return new ErrorResult(Messages.UserExist);
            }
            _userDal.Add(user);
            AddMangerClaimIfNotExist(user.HvBSNumber);
            return new SuccessResult(Messages.UserAdded);     
        }

        public IDataResult<List<User>> GetAll()
        {
           return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public IDataResult<User> GetByUserId(int userId)
        {
            return new SuccessDataResult<User>(_userDal.Get(user => user.UserId == userId));
        }

        public IDataResult<User> GetByHvBsNumber(string hvbsNumber)
        {
            return new SuccessDataResult<User>(_userDal.Get(user => user.HvBSNumber == hvbsNumber));
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.UserUpdated);
        }

        private void AddMangerClaimIfNotExist(string hvBsNumber)
        {
            var result = _userOperationClaimService.GetAll();
            if (result.Data.Count == 0)
            {
                _userOperationClaimService.Add(new UserOperationClaim()
                    {
                        UserId = GetByHvBsNumber(hvBsNumber).Data.UserId,
                        OperationClaimId = _operationClaimService.GetByName("Yönetici").Data.OperationClaimId,
                    }
                    );
            }
            else
            {
                _userOperationClaimService.Add(new UserOperationClaim()
                    {
                        UserId = GetByHvBsNumber(hvBsNumber).Data.UserId,
                        OperationClaimId = _operationClaimService.GetByName("Görevli").Data.OperationClaimId,
                    }
                );
            }
        }
        private bool CheckIfUserExist(string hvBsNumber)
        {
            var user = _userDal.Get(u => u.HvBSNumber == hvBsNumber);
            return user != null;
        }

        public IList<string> GetAllUserName()
        {
            List<string> userNames = new List<string>();
            List<User> users = GetAll().Data;
            foreach (User user in users)
            {
                userNames.Add(user.FirstName + " " + user.LastName);
            }
            return userNames;
        }
    }
}