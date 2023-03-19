using System;
using System.Collections.Generic;
using Core.Entities;

namespace Entities.Concrete
{
    public partial class Vardiya : IEntity
    {
        public long Id { get; set; }
        public long? SicilNo { get; set; }
        public long? ShiftCode { get; set; }
        public string? ShiftStart { get; set; }
        public string? ShiftEnd { get; set; }
        public string? Author { get; set; }
        public long? WeeOfYear { get; set; }
        public string? CreateDate { get; set; }
    }
}
