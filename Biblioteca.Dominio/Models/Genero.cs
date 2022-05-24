using System;
using System.Collections.Generic;

#nullable disable

namespace Biblioteca.Dominio.Models
{
    public partial class Genero
    {
        public Genero()
        {
            Libros = new HashSet<Libro>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Libro> Libros { get; set; }
    }
}
