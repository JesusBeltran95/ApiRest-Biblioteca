using Biblioteca.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dominio.Contratos
{
    public interface IGeneroDomainService
    {
        Genero GetById(int id);
        List<Genero> GetAll();

    }
}
