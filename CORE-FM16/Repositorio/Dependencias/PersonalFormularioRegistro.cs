using CORE_FM16.Entidades;
using CORE_FM16.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE_FM16.Repositorio.Dependencias
{
    public class PersonalFormularioRegistro : IPersonalFormularioRegistro
    {
        public async Task<List<CRMPersonalFormularioRegistro>> GetPersonalFormularioRegistro(string accion)
        {
            await Task.Delay(100);
            List<CRMPersonalFormularioRegistro> lst = new List<CRMPersonalFormularioRegistro>();

            return lst;
        }
    }
}
