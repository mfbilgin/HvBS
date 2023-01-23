using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class MaintenanceTypeManager : IMaintenanceTypeService
    {
        private readonly IMaintenanceTypeDal _maintenanceTypeDal;
        private readonly IOperationClaimService _operationClaimService;

        public MaintenanceTypeManager(IMaintenanceTypeDal maintenanceTypeDal,
            IOperationClaimService operationClaimService)
        {
            _maintenanceTypeDal = maintenanceTypeDal;
            _operationClaimService = operationClaimService;
        }

        public Result Add(MaintenanceType maintenanceType, int userClaimId)
        {
            if (!IsAuthenticated(GetClaimIdWithDictionary("Görevli"), userClaimId))
                return new ErrorResult(Messages.NotAuthorized);

            if (CheckIfTypeExist(maintenanceType.MaintenanceName))
                return new ErrorResult(Messages.MaintenanceTypeExist);

            _maintenanceTypeDal.Add(maintenanceType);
            return new SuccessResult(Messages.MaintenanceTypeAdded);
        }

        public Result Delete(MaintenanceType maintenanceType, int userClaimId)
        {
            if (!IsAuthenticated(GetClaimIdWithDictionary("Görevli"), userClaimId))
                return new ErrorResult(Messages.NotAuthorized);

            _maintenanceTypeDal.Delete(maintenanceType);
            return new SuccessResult(Messages.MaintenanceTypeDeleted);
        }

        public Result Update(MaintenanceType maintenanceType, int userClaimId)
        {
            if (!IsAuthenticated(GetClaimIdWithDictionary("Görevli"), userClaimId))
                return new ErrorResult(Messages.NotAuthorized);

            _maintenanceTypeDal.Update(maintenanceType);
            return new SuccessResult(Messages.MaintenanceTypeUpdated);
        }

        public IDataResult<MaintenanceType> GetByMaintenanceName(string maintenanceName)
        {
            return new SuccessDataResult<MaintenanceType>(_maintenanceTypeDal.Get(type => type.MaintenanceName == maintenanceName));
        }

        private bool CheckIfTypeExist(string typeName)
        {
            MaintenanceType maintenanceType = _maintenanceTypeDal.Get(type => type.MaintenanceName == typeName);
            return maintenanceType != null;
        }

        private bool IsAuthenticated(int claimId, int authenticateClaimId)
        {
            return claimId == authenticateClaimId;
        }

        private int GetClaimIdWithDictionary(string role)
        {
            Dictionary<string, int> claims = new Dictionary<string, int>();
            int id = 0;
            claims.Add("Yönetici", _operationClaimService.GetByName("Yönetici").Data.OperationClaimId);
            claims.Add("Görevli", _operationClaimService.GetByName("Görevli").Data.OperationClaimId);
            claims.TryGetValue(role, out id);
            return id;
        }
    }
}