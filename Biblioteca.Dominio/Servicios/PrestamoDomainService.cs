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
    internal class PrestamoDomainService : IPrestamoDomainService
    {
        private readonly BIblioteca20Context _context = new();
        public bool create(Prestamo prestamo)
        {
            _context.Prestamos.Add(prestamo);
            return _context.SaveChanges() > 0;
        }

        public bool Delete(int idprestamo)
        {
            var objeto = _context.Prestamos.Where(p => p.Id == idprestamo).FirstOrDefault();
            _context.Prestamos.Remove(objeto);
            return _context.SaveChanges() > 0;        
        }

        public List<Prestamo> GetAll()
        {
            return _context.Prestamos.ToList();
        }

        public Prestamo GetById(int id)
        {
            return _context.Prestamos.Where(p => p.Id == id).FirstOrDefault();
        }

        public bool Update(Prestamo prestamo)
        {
            var objeto = _context.Prestamos.Where(p => p.Id == prestamo.Id).FirstOrDefault();
            _context.Entry(objeto).CurrentValues.SetValues(prestamo);
            return _context.SaveChanges() > 0;
        }
    }
}
