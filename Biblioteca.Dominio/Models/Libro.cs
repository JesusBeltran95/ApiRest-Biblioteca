using System;
using System.Collections.Generic;

#nullable disable

namespace Biblioteca.Dominio.Models
{
    public partial class Libro
    {
        public Libro()
        {
            InventarionLibros = new HashSet<InventarionLibro>();
            Prestamos = new HashSet<Prestamo>();
            Reservas = new HashSet<Reserva>();
            Venta = new HashSet<Ventum>();
        }

        public int Id { get; set; }
        public byte[] Portada { get; set; }
        public string Titulo { get; set; }
        public string Editorial { get; set; }
        public string Autor { get; set; }
        public string AnioEdicion { get; set; }
        public decimal Precio { get; set; }
        public int FkGenero { get; set; }

        public virtual Genero FkGeneroNavigation { get; set; }
        public virtual ICollection<InventarionLibro> InventarionLibros { get; set; }
        public virtual ICollection<Prestamo> Prestamos { get; set; }
        public virtual ICollection<Reserva> Reservas { get; set; }
        public virtual ICollection<Ventum> Venta { get; set; }
    }
}
