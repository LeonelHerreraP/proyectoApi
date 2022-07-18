using System;
using System.Collections.Generic;

namespace proyectoApi.Models
{
    public partial class Persona
    {
        public Persona()
        {
            Solicituds = new HashSet<Solicitud>();
        }

        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string? Pasaporte { get; set; }
        public string? Direccion { get; set; }
        public string? Sexo { get; set; }
        public string? Foto { get; set; }

        public virtual ICollection<Solicitud> Solicituds { get; set; }
    }
}
