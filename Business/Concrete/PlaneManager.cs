using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class PlaneManager : IPlaneService
    {
        private readonly IPlaneDal _planeDal;
        private readonly IOperationClaimService _operationClaimService;
        public PlaneManager(IPlaneDal planeDal, IOperationClaimService operationClaimService)
        {
            _planeDal = planeDal;
            _operationClaimService = operationClaimService;
        }

        public Result Add(Plane plane, int userClaimId)
        {
            if (!IsAuthenticated(GetClaimIdWithDictionary("Yönetici"), userClaimId))
                return new ErrorResult(Messages.NotAuthorized);
            if (CheckIfAnyValueEmpty(plane))
                return new ErrorResult("Lütfen tüm verilerin eksiksiz olduğuna emin olunuz!");
            if (CheckIfSerialNumberExists(plane.SerialNumber))
                return new ErrorResult("Bu uçak zaten mevcut");
            _planeDal.Add(plane);
            return new SuccessResult($"{plane.SerialNumber} seri numaralı uçak eklendi.");

        }

        public Result Delete(int planeId, int userClaimId)
        {
            if (!IsAuthenticated(GetClaimIdWithDictionary("Yönetici"), userClaimId))
                return new ErrorResult(Messages.NotAuthorized);

            var plane = _planeDal.Get(p => p.PlaneId == planeId);

            if (plane == null)
                return new ErrorResult("Uçak Bulunamadı");
            _planeDal.Delete(plane);
            return new SuccessResult($"{plane.SerialNumber} seri numaralı uçak silindi");

        }

        public IDataResult<List<Plane>> GetAll(int baseId)
        {
            return new SuccessDataResult<List<Plane>>(_planeDal.GetAll(p => p.BaseId == baseId));
        }

        public IDataResult<List<string>> GetAllSerialNumber(int baseId)
        {
            var serailNumbers = new List<string>();
            foreach (var plane in GetAll(baseId).Data)
            {
                serailNumbers.Add(plane.SerialNumber + " (" + plane.PlaneType +")");
            }
            return new SuccessDataResult<List<string>>(serailNumbers);
        }

        public IDataResult<Plane> GetById(int planeId, int baseId)
        {
            return new SuccessDataResult<Plane>(_planeDal.Get(p => p.PlaneId == planeId && p.BaseId == baseId));
        }

        public Result Update(Plane plane, int userClaimId)
        {
            if (!IsAuthenticated(GetClaimIdWithDictionary("Yönetici"), userClaimId))
                return new ErrorResult(Messages.NotAuthorized);

            if (CheckIfAnyValueEmpty(plane))
                return new ErrorResult("Lütfen tüm verilerin eksiksiz olduğuna emin olunuz!");
            if (CheckIfSerialNumberExists(plane.SerialNumber))
                return new ErrorResult("Bu uçak zaten mevcut");
            _planeDal.Update(plane);
            return new SuccessResult("Kayıt Güncellendi.");
        }
        private bool CheckIfSerialNumberExists(string serialNumber)
        {
            var plane = _planeDal.Get(p => p.SerialNumber == serialNumber);
            if (plane != null)
                return true;
            return false;
        }
        private bool CheckIfAnyValueEmpty(Plane plane)
        {
            if (plane.PlaneType == string.Empty || plane.SerialNumber == string.Empty)
                return true;
            return false;
        }

        public IDataResult<Plane> GetBySerialNumber(string serialNumber, int baseId)
        {
            return new SuccessDataResult<Plane>(_planeDal.Get(p => p.SerialNumber == serialNumber && p.BaseId == baseId));
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
    }
}
