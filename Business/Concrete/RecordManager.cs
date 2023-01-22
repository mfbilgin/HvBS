using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Business.Constants;
using Core.Utilities.IoC;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class RecordManager : IRecordService
    {
        private readonly IRecordDal _recordDal;
        private readonly IOperationClaimService _operationClaimService;

        public RecordManager(IRecordDal recordDal, IOperationClaimService operationClaimService)
        {
            _recordDal = recordDal;
            _operationClaimService = operationClaimService;
        }


        public Result Add(Record record,int userClaimId)
        {
            //Check the authorization
            if (!IsAuthenticated(GetClaimIdWithDictionary("Görevli"), userClaimId))
                return new ErrorResult(Messages.NotAuthorized);
            //Check if exist
            if (!CheckIfRecordExist(record.AircraftSerialNumber, record.Trouble))
                return new ErrorResult(Messages.RecordAlreadyExist);
            //Add the record
            _recordDal.Add(record);
            return new SuccessResult(Messages.RecordAdded);
        }


        public Result Update(Record record, int userClaimId)
        {
            if (!IsAuthenticated(GetClaimIdWithDictionary("Görevli"), userClaimId))
                return new ErrorResult(Messages.NotAuthorized);
            
            _recordDal.Update(record);
            return new SuccessResult(Messages.RecordUpdated);
        }

        public Result Delete(Record record,int userClaimId)
        {
            if (!IsAuthenticated(GetClaimIdWithDictionary("Görevli"), userClaimId))
                return new ErrorResult(Messages.NotAuthorized);


            _recordDal.Delete(record);
            return new SuccessResult(Messages.RecordDeleted);
        }

        public DataResult<List<Record>> GetAll()
        {
            return new SuccessDataResult<List<Record>>(_recordDal.GetAll());
        }

        public DataResult<List<Record>> GetAllEmergencyRecord()
        {
            return new SuccessDataResult<List<Record>>(_recordDal.GetAll(record => record.IsEmergency));
        }

        public DataResult<List<Record>> GetAllWaitingRecord()
        {
            return new SuccessDataResult<List<Record>>(_recordDal.GetAll(record => record.IsWaiting));
        }

        public DataResult<List<Record>> GetAllContinuingRecord()
        {
            return new SuccessDataResult<List<Record>>(_recordDal.GetAll(record => !record.IsWaiting && !record.IsCompleted));
        }

        public DataResult<List<Record>> GetAllCompletedRecord()
        {
            return new SuccessDataResult<List<Record>>(_recordDal.GetAll(record => record.IsCompleted));
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

        public DataResult<Record> GetByAircraftNumberAndTrouble(string aircraftNumber, string trouble)
        {
            return new SuccessDataResult<Record>(_recordDal.Get(record => record.AircraftSerialNumber == aircraftNumber && record.Trouble == trouble));
        }
        public bool CheckIfRecordExist(string aircraftNumber,string trouble)
        {
            var result = _recordDal.Get(record => record.AircraftSerialNumber == aircraftNumber && record.Trouble == trouble);
            if (result != null) return false;
            return true;
        }
    }
}