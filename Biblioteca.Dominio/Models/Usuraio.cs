using System;
using System.Collections.Generic;

#nullable disable

namespace Biblioteca.Dominio.Models
{
    public partial class Usuraio
    {
        public Usuraio()
        {
            Empresas = new HashSet<Empresa>();
            PersonaMultada = new HashSet<PersonaMultadum>();
            Prestamos = new HashSet<Prestamo>();
            Reservas = new HashSet<Reserva>();
            Venta = new HashSet<Ventum>();
        }

        public int Id { get; set; }
        public int FkPresona { get; set; }
        public int FkRol { get; set; }

        public virtual Persona FkPresonaNavigation { get; set; }
        public virtual Rol FkRolNavigation { get; set; }
        public virtual ICollection<Empresa> Empresas { get; set; }
        public virtual ICollection<PersonaMultadum> PersonaMultada { get; set; }
        public virtual ICollection<Prestamo> Prestamos { get; set; }
        public virtual ICollection<Reserva> Reservas { get; set; }
        public virtual ICollection<Ventum> Venta { get; set; }
    }
}
