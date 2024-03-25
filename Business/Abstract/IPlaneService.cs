using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IPlaneService
    {
        Result Add(Plane plane, int userClaimId);
        Result Update(Plane plane, int userClaimId);
        Result Delete(int planeId, int userClaimId);
        IDataResult<List<Plane>> GetAll(int baseId);
        IDataResult<List<string>> GetAllSerialNumber(int baseId);
        IDataResult<Plane>GetBySerialNumber(string serialNumber, int baseId);
        IDataResult<Plane> GetById(int planeId,int baseId);
    }
}
