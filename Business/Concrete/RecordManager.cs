using Business.Abstract;
using System;
using System.Collections.Generic;
using Business.Constants;
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


        public Result Add(Record record, int userClaimId)
        {
            //Check the authorization
            if (!IsAuthenticated(GetClaimIdWithDictionary("Görevli"), userClaimId))
                return new ErrorResult("Kayıt ekleme işlemini yalnızca görevliler yapabilir!");
            //Check the trouble is null
            if (record.Trouble.Length <= 10)
                return new ErrorResult("Arıza bilgisini en az 10 karakter uzunluğunda giriniz!");
            //Check if exist
            if (!CheckIfRecordExist(record.AircraftSerialNumber, record.Trouble))
                return new ErrorResult(Messages.RecordAlreadyExist);
            //Add the record
            _recordDal.Add(record);
            return new SuccessResult(Messages.RecordAdded);
        }


        public Result Update(Record record)
        {
            _recordDal.Update(record);
            return new SuccessResult(Messages.RecordUpdated);
        }

        public Result Delete(Record record)
        {
            _recordDal.Delete(record);
            return new SuccessResult(Messages.RecordDeleted);
        }

        public IResult DeleteAllByBaseId(int baseId)
        {
            var records = GetAll(baseId).Data;
            foreach (var record in records)
                _recordDal.Delete(record);
            return new SuccessResult();
        }

        public DataResult<List<Record>> GetAll(int baseId)
        {
            return new SuccessDataResult<List<Record>>(_recordDal.GetAll(record => record.BaseId == baseId));
        }

        public DataResult<List<Record>> GetAllEmergencyRecord(int baseId)
        {
            return new SuccessDataResult<List<Record>>(_recordDal.GetAll(record =>
                record.IsEmergency && record.BaseId == baseId));
        }

        public DataResult<List<Record>> GetAllWaitingRecord(int baseId)
        {
            return new SuccessDataResult<List<Record>>(_recordDal.GetAll(record =>
                record.IsWaiting && record.BaseId == baseId));
        }

        public DataResult<List<Record>> GetAllContinuingRecord(int baseId)
        {
            return new SuccessDataResult<List<Record>>(_recordDal.GetAll(record =>
                !record.IsWaiting && !record.IsCompleted && record.BaseId == baseId));
        }

        public DataResult<List<Record>> GetAllCompletedRecord(int baseId)
        {
            return new SuccessDataResult<List<Record>>(_recordDal.GetAll(record =>
                record.IsCompleted && record.BaseId == baseId));
        }

        public DataResult<List<Record>> GetAllCompletedRecordByCompletedUser(int baseId, int userId)
        {
            return new SuccessDataResult<List<Record>>(_recordDal.GetAll(record =>
                record.IsCompleted && record.CompletedUserId == userId && record.BaseId == baseId
                && record.CompleteDate >= DateTime.Now.AddHours(-24)));
        }

        public DataResult<List<Record>> GetAllCompletedRecordByMaintenanceChef(int baseId, string chef)
        {
            return new SuccessDataResult<List<Record>>(_recordDal.GetAll(record =>
                record.IsCompleted && record.MaintenanceChief == chef && record.BaseId == baseId
                && record.CompleteDate >= DateTime.Now.AddHours(-24)));
        }



        public DataResult<Record> GetByAircraftNumberAndTrouble(string aircraftNumber, string trouble)
        {
            return new SuccessDataResult<Record>(_recordDal.Get(record =>
                record.AircraftSerialNumber == aircraftNumber && record.Trouble == trouble));
        }


        public DataResult<List<Record>> GetAllWaitingRecordInLastTime(int baseId, int hour)
        {
            return new SuccessDataResult<List<Record>>(_recordDal.GetAll(record =>
                record.IsWaiting && record.BaseId == baseId && record.RegisterDate >= DateTime.Now.AddHours(-hour)));
        }

        public DataResult<List<Record>> GetAllContinuingRecordInLastTime(int baseId, int hour)
        {
            return new SuccessDataResult<List<Record>>(_recordDal.GetAll(record =>
              !record.IsWaiting && !record.IsCompleted && record.BaseId == baseId && record.RegisterDate >= DateTime.Now.AddHours(-hour)));
        }

        public DataResult<List<Record>> GetAllCompletedRecordInLastTime(int baseId, int hour)
        {
            return new SuccessDataResult<List<Record>>(_recordDal.GetAll(record =>
                record.IsCompleted && record.BaseId == baseId
                    && record.CompleteDate >= DateTime.Now.AddHours(-hour)));
        }

        public DataResult<List<Record>> GetAllEmergencyRecordInLastTime(int baseId, int hour)
        {
            return new SuccessDataResult<List<Record>>(_recordDal.GetAll(record =>
               record.IsEmergency && record.BaseId == baseId &&
                (record.RegisterDate >= DateTime.Now.AddHours(-hour) || record.CompleteDate >= DateTime.Now.AddHours(-hour)

               )));
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
        private bool CheckIfRecordExist(string aircraftNumber, string trouble)
        {
            var result = _recordDal.Get(record =>
                record.AircraftSerialNumber == aircraftNumber && record.Trouble == trouble);
            return result == null;
        }

    }
}