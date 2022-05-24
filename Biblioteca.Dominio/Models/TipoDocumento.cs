using System;
using System.Collections.Generic;

#nullable disable

namespace Biblioteca.Dominio.Models
{
    public partial class TipoDocumento
    {
        public TipoDocumento()
        {
            Personas = new HashSet<Persona>();
        }

        public int Id { get; set; }
        public string Siglas { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Persona> Personas { get; set; }
    }
}
