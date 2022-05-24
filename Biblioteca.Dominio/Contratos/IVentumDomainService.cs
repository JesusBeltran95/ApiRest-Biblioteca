using Biblioteca.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dominio.Contratos
{
    public interface IVentumDomainService
    {
        bool create(Ventum venta);
        Ventum GetById(int id);
        List<Ventum> GetAll();
        bool Update(Ventum venta);
        bool Delete(int idventa);
    }
}
