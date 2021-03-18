using System;
using System.Collections.Generic;
using System.Text;
using Datos.DTO;
using Datos.Contexto;
using System.Linq;

namespace Datos.Validaciones
{
    public class validaciones
    {
        readonly DBContexto _context;
        public List<string> ValidaMunicipio(MunicipiosDTO municipio)
        {
            List<string> messageResults = new List<string>();
            if (municipio.Capital)
            {
              
            }
            return messageResults;
        }
    }
}
