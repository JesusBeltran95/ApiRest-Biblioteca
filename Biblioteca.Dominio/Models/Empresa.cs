using System;
using System.Collections.Generic;

#nullable disable

namespace Biblioteca.Dominio.Models
{
    public partial class Empresa
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Nit { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime HoraSalida { get; set; }
        public string Direccion { get; set; }
        public string Descripcion { get; set; }
        public int FkUsuario { get; set; }
        public int FkInventarioLibro { get; set; }

        public virtual InventarionLibro FkInventarioLibroNavigation { get; set; }
        public virtual Usuraio FkUsuarioNavigation { get; set; }
    }
}
