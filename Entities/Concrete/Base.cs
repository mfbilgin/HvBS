using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Base : IEntity
    {
        public int BaseId{ get; set; }
        public string BaseName { get; set; }
        public string AuthorizedStaffOnBase { get; set; }
        public string AircraftOnBase { get; set; }
    }
}