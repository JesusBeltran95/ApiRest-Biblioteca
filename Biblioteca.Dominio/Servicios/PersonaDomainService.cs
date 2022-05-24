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
    internal class PersonaDomainService : IPersonaDomainService
    {
        private readonly BIblioteca20Context _context = new();
        public bool create(Persona persona)
        {
            _context.Personas.Add(persona);
            return _context.SaveChanges() > 0;
        }

        public bool Delete(int idpersona)
        {
            var objeto = _context.Personas.Where(p => p.Id == idpersona).FirstOrDefault();
            _context.Personas.Remove(objeto);
            return _context.SaveChanges() > 0;
        }

        public List<Persona> GetAll()
        {
            return _context.Personas.ToList();
        }

        public Persona GetById(int id)
        {
            return _context.Personas.Where(p => p.Id == id).FirstOrDefault();
        }

        public bool Update(Persona persona)
        {
            var objeto = _context.Personas.Where(p => p.Id == persona.Id).FirstOrDefault();
            _context.Entry(objeto).CurrentValues.SetValues(persona);
            return _context.SaveChanges() > 0;
        }
    }
}
