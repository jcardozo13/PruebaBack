using Datos.DTO;
using System.Collections.Generic;

namespace Servicios.Interface
{
    public interface IServicioDepartamentos
    {
        /// <summary>
        /// Obtener todos los departamentos
        /// </summary>
        /// <returns>Lista&lt;DeparatmentosDTO&gt;.</returns>
        List<DepartamentosDTO> DepartamentosTodos();
    }
}
