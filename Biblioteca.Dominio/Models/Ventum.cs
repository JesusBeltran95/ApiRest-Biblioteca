using System;
using System.Collections.Generic;

#nullable disable

namespace Biblioteca.Dominio.Models
{
    public partial class Ventum
    {
        public Ventum()
        {
            InventarionLibros = new HashSet<InventarionLibro>();
        }

        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        public int FkUsuario { get; set; }
        public int FkLibro { get; set; }
        public string FormaDePago { get; set; }

        public virtual Usuraio FkLibro1 { get; set; }
        public virtual Libro FkLibroNavigation { get; set; }
        public virtual ICollection<InventarionLibro> InventarionLibros { get; set; }
    }
}
