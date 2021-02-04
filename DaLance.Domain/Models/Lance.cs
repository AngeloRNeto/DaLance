using System;
using System.Collections.Generic;
using System.Text;

namespace DaLance.Domain.Models
{
    public class Lance : BaseEntity
    {
        public virtual Produto produto { get; set; }
        public virtual Usuario usuario { get; set; }
        public double valor { get; set; }
    }
}
