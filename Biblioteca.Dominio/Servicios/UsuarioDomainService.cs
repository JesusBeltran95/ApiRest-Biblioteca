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
    internal class UsuarioDomainService : IUsuarioDomainService
    {
        private readonly BIblioteca20Context _context = new();
        public bool create(Usuraio usuario)
        {
            _context.Usuraios.Add(usuario);
            return _context.SaveChanges() > 0;
        }

        public bool Delete(int idusuario)
        {
            var objeto = _context.Usuraios.Where(p => p.Id == idusuario).FirstOrDefault();
            _context.Usuraios.Remove(objeto);
            return _context.SaveChanges() > 0;
        }

        public List<Usuraio> GetAll()
        {
            return _context.Usuraios.ToList();
        }

        public Usuraio GetById(int id)
        {
            return _context.Usuraios.Where(p => p.Id == id).FirstOrDefault();
        }

        public bool Update(Usuraio usuario)
        {
            var objeto = _context.Usuraios.Where(p => p.Id == usuario.Id).FirstOrDefault();
            _context.Entry(objeto).CurrentValues.SetValues(usuario);
            return _context.SaveChanges() > 0;
        }
    }
}
