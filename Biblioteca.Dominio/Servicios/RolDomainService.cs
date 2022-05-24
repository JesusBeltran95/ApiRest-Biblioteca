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
    internal class RolDomainService : IRolDomainService
    {
        private readonly BIblioteca20Context _context = new();
        public List<Rol> GetAll()
        {
            return _context.Rols.ToList();
        }

        public Rol GetById(int id)
        {
            return _context.Rols.Where(p => p.Id == id).FirstOrDefault();
        }
    }
}
