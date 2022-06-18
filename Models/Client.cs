using System;
using System.Collections.Generic;

namespace Mis_citas.Models
{
    public partial class Client
    {
        public long ClientId { get; set; }
        public string Name { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string? Cel { get; set; }
    }
}
