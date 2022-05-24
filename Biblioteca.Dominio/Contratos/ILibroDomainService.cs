using Biblioteca.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dominio.Contratos
{
    public interface ILibroDomainService
    {
        bool create(Libro libro);
        Libro GetById(int id);
        List<Libro> GetAll();
        bool Update(Libro libro);
        bool Delete(int idlibro);

    }
}
