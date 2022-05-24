using Biblioteca.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dominio.Contratos
{
    public interface IPersonaMultadumDomainService
    {
        bool create(PersonaMultadum personaMultada );
        PersonaMultadum GetById(int id);
        List<PersonaMultadum> GetAll();
        bool Update(PersonaMultadum personaMultada);
        bool Delete(int idpersonamultada);
    }
}
