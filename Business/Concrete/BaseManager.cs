using System.Collections.Generic;
using System.Linq;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BaseManager : IBaseService
    {
        private readonly IBaseDal _baseDal;
        private readonly IOperationClaimService _operationClaimService;
        private readonly IMaintenanceTypeService _maintenanceTypeService;
        private readonly IPartService _partService;
        private readonly IRecordService _recordService;

        public BaseManager(IBaseDal baseDal, IOperationClaimService operationClaimService,
            IMaintenanceTypeService maintenanceTypeService, IPartService partService, IRecordService recordService)
        {
            _baseDal = baseDal;
            _operationClaimService = operationClaimService;
            _maintenanceTypeService = maintenanceTypeService;
            _partService = partService;
            _recordService = recordService;
        }

        public Result Add(Base @base, int userClaimId)
        {
            if (!IsAuthenticated(GetClaimIdWithDictionary("Yönetici"), userClaimId))
                return new ErrorResult(Messages.NotAuthorized);
            if (CheckIfBaseExist(@base.BaseName))
                return new ErrorResult(Messages.BaseExist);
            if (CheckIfValueEmpty(@base))
                return new ErrorResult("Tüm alanların dolu olduğuna emin olunuz!.");
            _baseDal.Add(@base);
            return new SuccessResult(Messages.BaseAdded);
        }

        public Result AddWithoutAuthentication(Base @base)
        {
            if (CheckIfBaseExist(@base.BaseName))
                return new ErrorResult(Messages.BaseExist);
            if (CheckIfValueEmpty(@base))
                return new ErrorResult("Tüm alanların dolu olduğuna emin olunuz!.");
            _baseDal.Add(@base);
            return new SuccessResult(Messages.BaseAdded);
        }

        private static bool CheckIfValueEmpty(Base @base)
        {
            return @base.BaseName == string.Empty || @base.AircraftOnBase == string.Empty ||
                   @base.AuthorizedStaffOnBase == string.Empty;
        }

        public Result Delete(Base @base, int userClaimId)
        {
            if (!IsAuthenticated(GetClaimIdWithDictionary("Yönetici"), userClaimId))
                return new ErrorResult(Messages.NotAuthorized);
            var baseId = @base.BaseId;
            _recordService.DeleteAllByBaseId(baseId);
            _partService.DeleteAllByBaseId(baseId);
            _maintenanceTypeService.DeleteAllByBaseId(baseId);
            _baseDal.Delete(@base);
            return new SuccessResult(Messages.BaseDeleted);
        }

        public Result Update(Base @base, int userClaimId)
        {
            if (!IsAuthenticated(GetClaimIdWithDictionary("Yönetici"), userClaimId))
                return new ErrorResult(Messages.NotAuthorized);
            _baseDal.Update(@base);
            return new SuccessResult(Messages.BaseUpdated);
        }


        public IDataResult<List<Base>> GetAll()
        {
            return new SuccessDataResult<List<Base>>(_baseDal.GetAll());
        }

        public IDataResult<Base> GetByBaseName(string baseName)
        {
            return new SuccessDataResult<Base>(_baseDal.Get(@base => @base.BaseName == baseName));
        }

        private bool CheckIfBaseExist(string baseName)
        {
            var @base = _baseDal.Get(b => b.BaseName == baseName);
            return @base != null;
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

        public IList<string> GetPlaneNameByBase(Base @base)
        {
            return @base.AircraftOnBase.Split(',').ToList();
        }

        public IList<string> GetAllBaseName()
        {
            List<string> names = new List<string>();
            List<Base> bases = GetAll().Data;
            foreach (Base @base in bases)
            {
                names.Add(@base.BaseName);
            }

            return names;
        }
    }
}