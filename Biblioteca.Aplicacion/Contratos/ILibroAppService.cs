using Biblioteca.Aplicacion.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Aplicacion.Contratos
{
    public interface ILibroAppService
    {
        public LibroDto GetById(int id);
        public List<LibroDto> GetAll();
    }
}
