using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class PartStatusManager : IPartStatusService
    {
        private readonly IPartStatusDal _partStatusDal;
        private readonly IOperationClaimService _operationClaimService;

        public PartStatusManager(IPartStatusDal partStatusDal, IOperationClaimService operationClaimService)
        {
            _partStatusDal = partStatusDal;
            _operationClaimService = operationClaimService;
        }

        public IResult Add(PartStatus partStatus, int claimId)
        {
            if (!IsAuthenticated(GetClaimIdWithDictionary("Görevli"), claimId))
                return new ErrorResult(Messages.NotAuthorized);
            if (!CheckIfRecordExist(partStatus.PartNumber, partStatus.WaitingAircraftNumber))
                return new ErrorResult(Messages.PartStatusAlreadyExist);

            _partStatusDal.Add(partStatus);
            return new SuccessResult(Messages.PartStatusAdded);
            
        }

        public IResult Delete(PartStatus partStatus, int claimId)
        {
            if (!IsAuthenticated(GetClaimIdWithDictionary("Görevli"), claimId))
                return new ErrorResult(Messages.NotAuthorized);
            _partStatusDal.Delete(partStatus);
            return new SuccessResult(Messages.PartStatusDeleted);
        }

        public IDataResult<List<PartStatus>> GetAll()
        {
            return new SuccessDataResult<List<PartStatus>>(_partStatusDal.GetAll());
        }

        public IResult Update(PartStatus partStatus, int claimId)
        {
            if (!IsAuthenticated(GetClaimIdWithDictionary("Görevli"), claimId))
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
            Dictionary<string, int> claims = new Dictionary<string, int>();
            int id = 0;
            claims.Add("Yönetici", _operationClaimService.GetByName("Yönetici").Data.OperationClaimId);
            claims.Add("Görevli", _operationClaimService.GetByName("Görevli").Data.OperationClaimId);
            claims.TryGetValue(role, out id);
            return id;
        }
        public bool CheckIfRecordExist(string partNumber, string aircraftNumber)
        {
            var result = _partStatusDal.Get(record => record.PartNumber == partNumber && record.WaitingAircraftNumber == aircraftNumber);
            if (result != null) return false;
            return true;
        }
    }
}
