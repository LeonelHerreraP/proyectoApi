using System;
using System.Collections.Generic;

namespace proyectoApi.Models
{
    public partial class Estado
    {
        public Estado()
        {
            Solicituds = new HashSet<Solicitud>();
        }

        public int Id { get; set; }
        public string? Estado1 { get; set; }

        public virtual ICollection<Solicitud> Solicituds { get; set; }
    }
}
