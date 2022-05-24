﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Biblioteca.Dominio.Models
{
    public partial class Rol
    {
        public Rol()
        {
            Usuraios = new HashSet<Usuraio>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Usuraio> Usuraios { get; set; }
    }
}
