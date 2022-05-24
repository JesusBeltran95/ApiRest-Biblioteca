using Biblioteca.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dominio.Contratos
{
    public interface IReservaDomainService
    {
        bool create(Reserva reserva);
        Reserva GetById(int id);
        List<Reserva> GetAll();
        bool Update(Reserva reserva);
        bool Delete(int idreserva);
    }
}
