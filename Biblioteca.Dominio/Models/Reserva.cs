using System;
using System.Collections.Generic;

#nullable disable

namespace Biblioteca.Dominio.Models
{
    public partial class Reserva
    {
        public Reserva()
        {
            InventarionLibros = new HashSet<InventarionLibro>();
        }

        public int Id { get; set; }
        public DateTime FehcaPrestamo { get; set; }
        public int FkUsuario { get; set; }
        public int FkLibro { get; set; }
        public string Descripcion { get; set; }

        public virtual Libro FkLibroNavigation { get; set; }
        public virtual Usuraio FkUsuarioNavigation { get; set; }
        public virtual ICollection<InventarionLibro> InventarionLibros { get; set; }
    }
}
