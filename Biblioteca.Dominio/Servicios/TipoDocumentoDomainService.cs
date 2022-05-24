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
    internal class TipoDocumentoDomainService : ITipoDocumentoDomainService
    {
        private readonly BIblioteca20Context _context = new();

        public List<TipoDocumento> GetAll()
        {
            return _context.TipoDocumentos.ToList();
        }

        public TipoDocumento GetById(int id)
        {
            return _context.TipoDocumentos.Where(p => p.Id == id).FirstOrDefault();
        }
    }
}
