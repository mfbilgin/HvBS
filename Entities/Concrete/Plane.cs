using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Plane : IEntity
    {
        public int PlaneId { get; set; }
        public int BaseId { get; set; }
        public string PlaneType { get; set; }
        public string SerialNumber { get; set; }

    }
}
