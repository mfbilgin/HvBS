using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public  interface IPartService
    {
        IResult Add(Part part,int claimId);
        IResult Update(Part part, int claimId);
        IResult Delete(Part part, int claimId);
        IResult DeleteAllByBaseId(int baseId);
        IDataResult<List<Part>> GetAll(int baseId);
        IList<string> GetAllPartNames(int baseId);
        IDataResult<Part> GetByPartNumberAndWaitingAircraftNumber(string partNumber,string waitingAircraftNumber);
    }
}
