using Biblioteca.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dominio.Contratos
{
    public interface IPrestamoDomainService
    {
        bool create(Prestamo prestamo);
        Prestamo GetById(int id);
        List<Prestamo> GetAll();
        bool Update(Prestamo prestamo);
        bool Delete(int idprestamo);
    }
}
