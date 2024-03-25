using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBaseService
    {
        Result Add(Base @base,int userClaimId);
        Result AddWithoutAuthentication(Base @base);
        Result Update(Base @base,int userClaimId);
        Result Delete(Base @base,int userClaimId);
        IDataResult<List<Base>> GetAll();
        IList<string> GetAllBaseName();
        IDataResult<Base> GetByBaseName(string baseName);
        IList<string> GetPlaneNameByBase(Base @base);
    }
}