using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE_FM16.Entidades
{
    public class CRMPersonalFormularioRegistro
    {
        public int IdRegistro { get; set; }

        public string? Nombres { get; set; }
        public string? ApellidoPaterno { get; set; }
        public string? ApellidoMaterno { get; set; }
        public string? CURP { get; set; }
        public string? Telefono { get; set; }
        public string? PersonaInvita { get; set; }
        public string? PersonaDebajo { get; set; }
        public string? NoGrafica { get; set; }
        public string? CorreoElectronico { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdEstatusRegistro { get; set; }

    }
}
