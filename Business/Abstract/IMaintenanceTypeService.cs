using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IMaintenanceTypeService
    {
        Result Add(MaintenanceType maintenanceType,int userClaimId);
        Result Delete(MaintenanceType maintenanceType,int userClaimId);
        Result DeleteAllByBaseId(int baseId);
        Result Update(MaintenanceType maintenanceType,int userClaimId);
        
        IDataResult<MaintenanceType> GetByMaintenanceName(string maintenanceName);
        IDataResult<List<MaintenanceType>> GetAll(int baseId);
        IList<string> GetAllName(int baseId);

    }
}