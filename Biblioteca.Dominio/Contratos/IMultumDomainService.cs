using Biblioteca.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dominio.Contratos
{
    public interface IMultumDomainService
    {
        bool create(Multum Multa);
        Multum GetById(int id);
        List<Multum> GetAll();
        bool Update(Multum multa);
        bool Delete(int idmulta);
    }
}
