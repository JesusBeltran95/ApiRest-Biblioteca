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
    internal class GeneroDomainService : IGeneroDomainService
    {
        private readonly BIblioteca20Context _context = new();
        public List<Genero> GetAll()
        {
            return _context.Generos.ToList();
        }

        public Genero GetById(int id)
        {
            return _context.Generos.Where(p => p.Id == id).FirstOrDefault();
        }
    }
}
