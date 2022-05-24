using Biblioteca.Aplicacion.Contratos;
using Biblioteca.Aplicacion.Dto;
using Biblioteca.Dominio.Contratos;
using Biblioteca.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Aplicacion.Servicios
{
    public class LibroAppService : ILibroAppService
    {
        #region Variables
        private ILibroDomainService _libroDomain;
        #endregion
        
        public List<LibroDto> GetAll()
        {
            try
            {
                List<Libro> resultado = _libroDomain.GetAll();

                List<LibroDto> librodtos = new List<LibroDto>();
                foreach(Libro entidad in resultado)
                {
                    LibroDto dto = new LibroDto();
                    dto.IdLibro = entidad.Id;
                }
                return librodtos;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public LibroDto GetById(int id)
        {
            try
            {
                Libro entidad = _libroDomain.GetById(id);

                    LibroDto dto = new LibroDto();
                    dto.IdLibro = entidad.Id;
                return dto;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
