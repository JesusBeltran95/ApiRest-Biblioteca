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
    internal class VentumDomainService : IVentumDomainService
    {
        private readonly BIblioteca20Context _context = new();
        public bool create(Ventum venta)
        {
            _context.Venta.Add(venta);
            return _context.SaveChanges() > 0;
        }

        public bool Delete(int idventa)
        {
            var objeto = _context.Venta.Where(p => p.Id == idventa).FirstOrDefault();
            _context.Venta.Remove(objeto);
            return _context.SaveChanges() > 0;
        }

        public List<Ventum> GetAll()
        {
            return _context.Venta.ToList();
        }

        public Ventum GetById(int id)
        {
            return _context.Venta.Where(p => p.Id == id).FirstOrDefault();
        }

        public bool Update(Ventum venta)
        {
            var objeto = _context.Venta.Where(p => p.Id == venta.Id).FirstOrDefault();
            _context.Entry(objeto).CurrentValues.SetValues(venta);
            return _context.SaveChanges() > 0;
        }
    }
}
