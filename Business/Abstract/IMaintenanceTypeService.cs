using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IMaintenanceTypeService
    {
        Result Add(MaintenanceType maintenanceType,int userClaimId);
        Result Delete(MaintenanceType maintenanceType,int userClaimId);
        Result Update(MaintenanceType maintenanceType,int userClaimId);
        IDataResult<MaintenanceType> GetByMaintenanceName(string maintenanceName);

    }
}