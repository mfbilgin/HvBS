using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class PartStatus : IEntity
    {
        public int PartStatusId { get; set; }
        public string PartNumber { get; set; }
        public string WaitingAircraftNumber { get; set; }
        public bool StockStatus { get; set; }
    }
}
