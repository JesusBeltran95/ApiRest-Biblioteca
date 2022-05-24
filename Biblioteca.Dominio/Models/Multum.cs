using System;
using System.Collections.Generic;

#nullable disable

namespace Biblioteca.Dominio.Models
{
    public partial class Multum
    {
        public Multum()
        {
            PersonaMultada = new HashSet<PersonaMultadum>();
        }

        public int Id { get; set; }
        public string TipoMulta { get; set; }
        public string Sancion { get; set; }

        public virtual ICollection<PersonaMultadum> PersonaMultada { get; set; }
    }
}
