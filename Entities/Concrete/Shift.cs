using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Shift
    {
        public long Id { get; set; }
        public long? ShiftCode { get; set; }
        public string? ShiftName { get; set; }
    }
}
