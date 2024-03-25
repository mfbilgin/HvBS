using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class MaintenanceType : IEntity
    {
        public int  MaintenanceTypeId { get; set; }
        public int BaseId { get; set; }
        public string MaintenanceName { get; set; }
        public string MaintenancePeriot { get; set; }
        public string Definition { get; set; }
        public string ToDoDuringMaintenance { get; set; }
    }
}