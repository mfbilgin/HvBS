    using Core.Entities.Concrete;
using Core.Utilities.Results;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);
        IResult Update(User user);
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetByHvBsNumber(string hvbsNumber);
        IDataResult<User> GetByUserId(int userId);
        IList<string> GetAllUserName();
    }
}