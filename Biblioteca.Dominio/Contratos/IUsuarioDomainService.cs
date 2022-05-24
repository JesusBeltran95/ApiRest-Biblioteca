using Biblioteca.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dominio.Contratos
{
    public interface IUsuarioDomainService
    {
        bool create(Usuraio usuario);
        Usuraio GetById(int id);
        List<Usuraio> GetAll();
        bool Update(Usuraio usuario);
        bool Delete(int idusuario);
    }
}
