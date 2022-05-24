using System;
using System.Collections.Generic;

#nullable disable

namespace Biblioteca.Dominio.Models
{
    public partial class PersonaMultadum
    {
        public int Id { get; set; }
        public int FkUsuario { get; set; }
        public int FkMulta { get; set; }
        public string Descripcion { get; set; }

        public virtual Multum FkMultaNavigation { get; set; }
        public virtual Usuraio FkUsuarioNavigation { get; set; }
    }
}
