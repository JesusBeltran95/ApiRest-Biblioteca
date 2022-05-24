using System;
using System.Collections.Generic;

#nullable disable

namespace Biblioteca.Dominio.Models
{
    public partial class Prestamo
    {
        public Prestamo()
        {
            InventarionLibros = new HashSet<InventarionLibro>();
        }

        public int Id { get; set; }
        public DateTime FehcaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public string EstadoLibro { get; set; }
        public int FkUsuario { get; set; }
        public int FkLibro { get; set; }

        public virtual Libro FkLibroNavigation { get; set; }
        public virtual Usuraio FkUsuarioNavigation { get; set; }
        public virtual ICollection<InventarionLibro> InventarionLibros { get; set; }
    }
}
