using System;
using System.Collections.Generic;

#nullable disable

namespace Biblioteca.Dominio.Models
{
    public partial class Persona
    {
        public Persona()
        {
            Usuraios = new HashSet<Usuraio>();
        }

        public int Id { get; set; }
        public int FkTipoDocumento { get; set; }
        public int Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Genero { get; set; }
        public string TelCel { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }

        public virtual TipoDocumento FkTipoDocumentoNavigation { get; set; }
        public virtual ICollection<Usuraio> Usuraios { get; set; }
    }
}
