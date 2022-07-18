using System;
using System.Collections.Generic;

namespace proyectoApi.Models
{
    public partial class Solicitud
    {
        public int Id { get; set; }
        public int? PersonaId { get; set; }
        public int? EstadoId { get; set; }
        public DateTime? FechaCreacion { get; set; }

        public virtual Estado? Estado { get; set; }
        public virtual Persona? Persona { get; set; }
    }
}
