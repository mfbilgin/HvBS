using System.Collections.Generic;
using System.Linq;
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
            if (!IsAuthenticated(GetClaimIdWithDictionary("Yönetici"), userClaimId))
                return new ErrorResult(Messages.NotAuthorized);

            if (CheckIfTypeExist(maintenanceType.MaintenanceName))
                return new ErrorResult(Messages.MaintenanceTypeExist);

            _maintenanceTypeDal.Add(maintenanceType);
            return new SuccessResult(Messages.MaintenanceTypeAdded);
        }

        public Result Delete(MaintenanceType maintenanceType, int userClaimId)
        {
            if (!IsAuthenticated(GetClaimIdWithDictionary("Yönetici"), userClaimId))
                return new ErrorResult(Messages.NotAuthorized);

            _maintenanceTypeDal.Delete(maintenanceType);
            return new SuccessResult(Messages.MaintenanceTypeDeleted);
        }

        public Result DeleteAllByBaseId(int baseId)
        {
            var maintenanceTypes = GetAll(baseId).Data;
            foreach (var maintenanceType in maintenanceTypes)
                _maintenanceTypeDal.Delete(maintenanceType);
            return new SuccessResult();
        }

        public Result Update(MaintenanceType maintenanceType, int userClaimId)
        {
            if (!IsAuthenticated(GetClaimIdWithDictionary("Yönetici"), userClaimId))
                return new ErrorResult(Messages.NotAuthorized);

            _maintenanceTypeDal.Update(maintenanceType);
            return new SuccessResult(Messages.MaintenanceTypeUpdated);
        }

        public IDataResult<MaintenanceType> GetByMaintenanceName(string maintenanceName)
        {
            return new SuccessDataResult<MaintenanceType>(_maintenanceTypeDal.Get(type => type.MaintenanceName == maintenanceName));
        }

        public IDataResult<List<MaintenanceType>> GetAll(int baseId)
        {
            return new SuccessDataResult<List<MaintenanceType>>(_maintenanceTypeDal.GetAll(m => m.BaseId == baseId));
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
            var claims = new Dictionary<string, int>
            {
                { "Yönetici", _operationClaimService.GetByName("Yönetici").Data.OperationClaimId },
                { "Görevli", _operationClaimService.GetByName("Görevli").Data.OperationClaimId }
            };
            claims.TryGetValue(role, out var id);
            return id;
        }

        public IList<string> GetAllName(int baseId)
        {
            var names = new List<string>() { "Yok"};
            var maintenanceTypes = GetAll(baseId).Data;
            names.AddRange(maintenanceTypes.Select(maintenanceType => maintenanceType.MaintenanceName));
            return names;
        }
    }
}