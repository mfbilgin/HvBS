using Core.Entities.Abstract;
using System;

namespace Entities.Concrete
{
    public class Record : IEntity
    {
        public int RecordId { get; set; }
        public int BaseId { get; set; }
        public int CompletedUserId { get; set; }
        public string AircraftSerialNumber { get; set; }
        public string Trouble { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime EstimatedEndDate { get; set; }
        public DateTime CompleteDate { get; set; }
        public string ReasonOfWaiting { get; set; }
        public string PartsNeed { get; set; }
        public string StaffOfRecording { get; set; }
        public string StaffOfIdentifyTrouble { get; set; }
        public string MaintenanceChief { get; set; }
        public string MaintenanceTypes { get; set; }
        public bool IsEmergency { get; set; }
        public bool IsWaiting { get; set; }
        public bool IsCompleted { get; set; }

    }
}
