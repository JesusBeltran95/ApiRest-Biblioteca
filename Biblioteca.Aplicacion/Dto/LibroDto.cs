using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Aplicacion.Dto
{
    public class LibroDto
    {
        public int IdLibro { get; set; }
        public Byte[] Portada { get; set; }
        public string Titulo { get; set; }
        public string Editorial { get; set; }
        public string Autor { get; set; }
        public string AnioEdicion { get; set; }
        public decimal Precio { get; set; }
        public int FkGenero { get; set; }

    }
}
