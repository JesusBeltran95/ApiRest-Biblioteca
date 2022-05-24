using Biblioteca.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dominio.Contratos
{
    public interface IPersonaDomainService
    {
        bool create(Persona persona);
        Persona GetById(int id);
        List<Persona> GetAll();
        bool Update(Persona persona);
        bool Delete(int idpersona);
    }
}
