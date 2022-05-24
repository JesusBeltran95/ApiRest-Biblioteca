using Biblioteca.Dominio.Contratos;
using Biblioteca.Dominio.DataAccess;
using Biblioteca.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dominio.Servicios
{
    internal class ReservaDomainService : IReservaDomainService
    {
        private readonly BIblioteca20Context _context = new();

        public bool create(Reserva reserva)
        {
            _context.Reservas.Add(reserva);
            return _context.SaveChanges() > 0;
        }

        public bool Delete(int idreserva)
        {
            var objeto = _context.Reservas.Where(p => p.Id == idreserva).FirstOrDefault();
            _context.Reservas.Remove(objeto);
            return _context.SaveChanges() > 0;
        }

        public List<Reserva> GetAll()
        {
            return _context.Reservas.ToList();
        }

        public Reserva GetById(int id)
        {
            return _context.Reservas.Where(p => p.Id == id).FirstOrDefault();

        }

        public bool Update(Reserva reserva)
        {
            var objeto = _context.Reservas.Where(p => p.Id == reserva.Id).FirstOrDefault();
            _context.Entry(objeto).CurrentValues.SetValues(reserva);
            return _context.SaveChanges() > 0;
        }
    }
}
