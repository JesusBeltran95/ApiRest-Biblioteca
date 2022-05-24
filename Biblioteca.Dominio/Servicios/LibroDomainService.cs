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
    internal class LibroDomainService : ILibroDomainService
    {

        private readonly BIblioteca20Context _context = new();
        public bool create(Libro libro)
        {
            _context.Libros.Add(libro);
            return _context.SaveChanges() > 0;
        }

        public bool Delete(int idlibro)
        {
            var objeto = _context.Libros.Where(p => p.Id == idlibro).FirstOrDefault();
            _context.Libros.Remove(objeto);
            return _context.SaveChanges() > 0;
        }

        public List<Libro> GetAll()
        {
            return _context.Libros.ToList();
        }

        public Libro GetById(int id)
        {
            return _context.Libros.Where(p => p.Id == id).FirstOrDefault();
        }

        public bool Update(Libro libro)
        {
            var objeto = _context.Libros.Where(p => p.Id == libro.Id).FirstOrDefault();
            _context.Entry(objeto).CurrentValues.SetValues(libro);
            return _context.SaveChanges() > 0;
        }
    }
}
