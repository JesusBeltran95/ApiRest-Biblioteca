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
    internal class PersonaMultadumDomainService : IPersonaMultadumDomainService
    {
        private readonly BIblioteca20Context _context = new();

        public bool create(PersonaMultadum personaMultada)
        {
            _context.PersonaMultada.Add(personaMultada);
            return _context.SaveChanges() > 0;
        }

        public bool Delete(int idpersonamultada)
        {
            var objeto = _context.PersonaMultada.Where(p => p.Id == idpersonamultada).FirstOrDefault();
            _context.PersonaMultada.Remove(objeto);
            return _context.SaveChanges() > 0;
        }

        public List<PersonaMultadum> GetAll()
        {
            return _context.PersonaMultada.ToList();
        }

        public PersonaMultadum GetById(int id)
        {
            return _context.PersonaMultada.Where(p => p.Id == id).FirstOrDefault();
        }

        public bool Update(PersonaMultadum personaMultada)
        {
            var objeto = _context.PersonaMultada.Where(p => p.Id == personaMultada.Id).FirstOrDefault();
            _context.Entry(objeto).CurrentValues.SetValues(personaMultada);
            return _context.SaveChanges() > 0;
        }
    }
}
