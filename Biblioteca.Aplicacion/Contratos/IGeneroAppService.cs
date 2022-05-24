using Biblioteca.Aplicacion.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Aplicacion.Contratos
{
    public interface IGeneroAppService
    {
        public GeneroDto GetById(int id);
        public List<GeneroDto> GetAll();
    }
}
