using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public  interface IPartStatusService
    {
        IResult Add(PartStatus partStatus,int claimId);
        IResult Update(PartStatus partStatus, int claimId);
        IResult Delete(PartStatus partStatus, int claimId);
        IDataResult<List<PartStatus>> GetAll();
    }
}
