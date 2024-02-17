using CORE_FM16.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE_FM16.Repositorio.Interfaces
{
    public interface IPersonalFormularioRegistro
    {
        Task<List<CRMPersonalFormularioRegistro>> GetPersonalFormularioRegistro(string accion);
    }
}
