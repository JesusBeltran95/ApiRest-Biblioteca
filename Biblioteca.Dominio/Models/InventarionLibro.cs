using System;
using System.Collections.Generic;

#nullable disable

namespace Biblioteca.Dominio.Models
{
    public partial class InventarionLibro
    {
        public InventarionLibro()
        {
            Empresas = new HashSet<Empresa>();
        }

        public int Id { get; set; }
        public DateTime FechaEntradaLibro { get; set; }
        public DateTime FechaSalidaLibro { get; set; }
        public int Isbn { get; set; }
        public int FkLibro { get; set; }
        public int FkPrestamo { get; set; }
        public bool Prestamo { get; set; }
        public int FkVenta { get; set; }
        public bool Vendido { get; set; }
        public int FkReserva { get; set; }
        public bool Reservado { get; set; }

        public virtual Libro FkLibroNavigation { get; set; }
        public virtual Prestamo FkPrestamoNavigation { get; set; }
        public virtual Reserva FkReservaNavigation { get; set; }
        public virtual Ventum FkVentaNavigation { get; set; }
        public virtual ICollection<Empresa> Empresas { get; set; }
    }
}
