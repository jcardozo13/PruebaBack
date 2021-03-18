using System;
using System.Linq;
using System.Collections.Generic;
using Datos.Contexto;
using Datos.DTO;
using Servicios.Interface;

namespace Servicios
{
    public class ServiciosDepartamentos : IServicioDepartamentos
    {
        readonly  DBContexto _context;
        public ServiciosDepartamentos(DBContexto context)
        {
            _context = context;
        }
        public List<DepartamentosDTO> DepartamentosTodos()
        {
            var lista = (from e in _context.Departamentos
                         select new DepartamentosDTO()
                         {
                             Id = e.Id,
                             Nombre = e.Nombre,

                         }).ToList();
            return lista;
        }
    }
}
