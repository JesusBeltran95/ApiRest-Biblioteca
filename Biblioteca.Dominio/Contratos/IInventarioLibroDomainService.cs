using Biblioteca.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dominio.Contratos
{
    public interface IInventarioLibroDomainService
    {
        bool create(InventarionLibro inventarionLibro);
        InventarionLibro GetById(int id);
        List<InventarionLibro> GetAll();
        bool Update(InventarionLibro inventarionLibro);
        bool Delete(int idinventariolibro);
    }
}
