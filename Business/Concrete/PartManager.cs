using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class PartManager : IPartService
    {
        private readonly IPartStatusDal _partStatusDal;
        private readonly IOperationClaimService _operationClaimService;

        public PartManager(IPartStatusDal partStatusDal, IOperationClaimService operationClaimService)
        {
            _partStatusDal = partStatusDal;
            _operationClaimService = operationClaimService;
        }

        public IResult Add(Part partStatus, int claimId)
        {
            if (!IsAuthenticated(GetClaimIdWithDictionary("Yönetici"), claimId))
                return new ErrorResult(Messages.NotAuthorized);
            if (!CheckIfRecordExist(partStatus.PartNumber, partStatus.PartName))
                return new ErrorResult(Messages.PartStatusAlreadyExist);

            _partStatusDal.Add(partStatus);
            return new SuccessResult(Messages.PartStatusAdded);
            
        }

        public IResult Delete(Part partStatus, int claimId)
        {
            if (!IsAuthenticated(GetClaimIdWithDictionary("Yönetici"), claimId))
                return new ErrorResult(Messages.NotAuthorized);
            _partStatusDal.Delete(partStatus);
            return new SuccessResult(Messages.PartStatusDeleted);
        }

        public IResult DeleteAllByBaseId(int baseId)
        {
            var parts = GetAll(baseId).Data;
            foreach (var part in parts)
                _partStatusDal.Delete(part);
            return new SuccessResult();
        }

        public IDataResult<List<Part>> GetAll(int baseId)
        {
            return new SuccessDataResult<List<Part>>(_partStatusDal.GetAll(p => p.BaseId == baseId));
        }

        public IResult Update(Part partStatus, int claimId)
        {
            if (!IsAuthenticated(GetClaimIdWithDictionary("Yönetici"), claimId))
                return new ErrorResult(Messages.NotAuthorized);
            _partStatusDal.Update(partStatus);
            return new SuccessResult(Messages.PartStatusUpdated);
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

        private bool CheckIfRecordExist(string partNumber, string aircraftNumber)
        {
            var result = _partStatusDal.Get(record => record.PartNumber == partNumber && record.PartName == aircraftNumber);
            return result == null;
        }

        public IDataResult<Part> GetByPartNumberAndWaitingAircraftNumber(string partNumber, string waitingAircraftNumber)
        {
            return new SuccessDataResult<Part>(_partStatusDal.Get(part => part.PartNumber == partNumber && part.PartName == waitingAircraftNumber));
        }

        public IList<string> GetAllPartNames(int baseId)
        {
            var names = new List<string>() { "Yok" };
            var parts = GetAll(baseId).Data;
            names.AddRange(parts.Select(part => part.PartName));
            return names;
        }
    }
}
