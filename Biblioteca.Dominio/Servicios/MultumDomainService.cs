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
    internal class MultumDomainService : IMultumDomainService
    {
        private readonly BIblioteca20Context _context = new();
        public bool create(Multum Multa)
        {
            _context.Multa.Add(Multa);
            return _context.SaveChanges() > 0;
        }

        public bool Delete(int idmulta)
        {
            var objeto = _context.Multa.Where(p => p.Id == idmulta).FirstOrDefault();
            _context.Multa.Remove(objeto);
            return _context.SaveChanges() > 0;
        }

        public List<Multum> GetAll()
        {
            return _context.Multa.ToList();
        }

        public Multum GetById(int id)
        {
            return _context.Multa.Where(p => p.Id == id).FirstOrDefault();
        }

        public bool Update(Multum multa)
        {
            var odjeto = _context.Multa.Where(p => p.Id == multa.Id).FirstOrDefault();
            _context.Entry(odjeto).CurrentValues.SetValues(multa);
            return _context.SaveChanges() > 0;
        }
    }
}
