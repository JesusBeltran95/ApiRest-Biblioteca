using Biblioteca.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dominio.Contratos
{
    public interface IRolDomainService
    {
        Rol GetById(int id);
        List<Rol> GetAll();
    }
}
