using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Part : IEntity
    {
        public int PartId { get; set; }
        public int BaseId { get; set; }
        public string PartNumber { get; set; }
        public string PartName { get; set; }
        public bool StockStatus { get; set; }
    }
}
