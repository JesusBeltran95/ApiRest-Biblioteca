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
    public class GeneroAppService : IGeneroAppService
    {
        #region Variables
        private IGeneroDomainService _generoDomain;
        #endregion
        public List<GeneroDto> GetAll()
        {
            try
            {
                List<Genero> resultado = _generoDomain.GetAll();

                List<GeneroDto> generoDtos = new List<GeneroDto>();
                foreach(Genero entidad in resultado)
                {
                    GeneroDto dto = new GeneroDto();
                    dto.Id = entidad.Id;
                    dto.Nombre = entidad.Nombre;
                    dto.Descripcion = entidad.Descripcion;
                }
                return generoDtos;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public GeneroDto GetById(int id)
        {
            try
            {
                Genero entidad = new Genero();

                    GeneroDto dto = new GeneroDto();
                    dto.Id = entidad.Id;
                    dto.Nombre = entidad.Nombre;
                    dto.Descripcion= entidad.Descripcion;
                return dto;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
