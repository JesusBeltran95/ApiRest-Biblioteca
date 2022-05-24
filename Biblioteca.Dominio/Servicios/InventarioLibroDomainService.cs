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
    internal class InventarioLibroDomainService : IInventarioLibroDomainService
    {
        private readonly BIblioteca20Context _context = new();

        public bool create(InventarionLibro inventarionLibro)
        {
            _context.InventarionLibros.Add(inventarionLibro);
            return _context.SaveChanges() > 0;
        }

        public bool Delete(int idinventariolibro)
        {
            var objeto = _context.InventarionLibros.Where(p => p.Id == idinventariolibro).FirstOrDefault();
            _context.InventarionLibros.Remove(objeto);
            return _context.SaveChanges() > 0;
        }

        public List<InventarionLibro> GetAll()
        {
            return _context.InventarionLibros.ToList();
        }

        public InventarionLibro GetById(int id)
        {
            return _context.InventarionLibros.Where(p => p.Id == id).FirstOrDefault();
        }

        public bool Update(InventarionLibro inventarionLibro)
        {
            var objeto = _context.InventarionLibros.Where(p => p.Id == inventarionLibro.Id).FirstOrDefault();
            _context.Entry(objeto).CurrentValues.SetValues(inventarionLibro);
            return _context.SaveChanges() > 0;
        }
    }
}
