using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IRecordService
    {
        Result Add(Record record,int userClaimId);
        Result Update(Record record,int userClaimId);
        Result Delete(Record record,int userClaimId);
        DataResult<List<Record>> GetAll();
        DataResult<List<Record>> GetAllEmergencyRecord();
        DataResult<List<Record>> GetAllWaitingRecord();
        DataResult<List<Record>> GetAllContinuingRecord();
        DataResult<List<Record>> GetAllCompletedRecord();
        DataResult<Record> GetByAircraftNumberAndTrouble(string aircraftNumber,string trouble);
        


    }
}
