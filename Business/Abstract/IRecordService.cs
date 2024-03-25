using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IRecordService
    {
        Result Add(Record record,int userClaimId);
        Result Update(Record record);
        Result Delete(Record record);
        IResult DeleteAllByBaseId(int baseId);

        DataResult<List<Record>> GetAll(int baseId);
        DataResult<List<Record>> GetAllEmergencyRecord(int baseId);
        DataResult<List<Record>> GetAllWaitingRecord(int baseId);
        DataResult<List<Record>> GetAllContinuingRecord(int baseId);
        DataResult<List<Record>> GetAllCompletedRecord(int baseId);

        DataResult<List<Record>> GetAllEmergencyRecordInLastTime(int baseId, int hour);
        DataResult<List<Record>> GetAllWaitingRecordInLastTime(int baseId, int hour);
        DataResult<List<Record>> GetAllContinuingRecordInLastTime(int baseId, int hour);
        DataResult<List<Record>> GetAllCompletedRecordInLastTime(int baseId, int hour);

        DataResult<List<Record>> GetAllCompletedRecordByCompletedUser(int baseId,int userId);
        DataResult<List<Record>> GetAllCompletedRecordByMaintenanceChef(int baseId,string chef);

        DataResult<Record> GetByAircraftNumberAndTrouble(string aircraftNumber,string trouble);

        


    }
}
