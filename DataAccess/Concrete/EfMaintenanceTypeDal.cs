using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfMaintenanceTypeDal : EfEntityRepositoryBase<MaintenanceType,HvBSDataBaseContext>,IMaintenanceTypeDal
    {
        
    }
}