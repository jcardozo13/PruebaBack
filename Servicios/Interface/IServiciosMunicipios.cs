using Datos.DTO;
using System.Collections.Generic;
using Servicios.DTO;



namespace Servicios.Interface
{
    public interface IServiciosMunicipios
    {
        /// <summary>
        /// Obtener todos los municipios
        /// </summary>
        /// <returns>Lista&lt;MunicipiosDTO&gt;.</returns>
        List<MunicipiosDTO> MunicipiosTodos();
        /// <summary>
        /// Guarda Municipio
        /// </summary>
        /// <param name="municipio">objeto municipio</param>
        /// <returns><c>true</c> respuesta objeto responseService <c>false</c> otherwise.</returns>
        ResponseService GuardarMunicipio(MunicipiosDTO municipio);

        /// <summary>
        /// Elimina Municipio
        /// </summary>
        /// <param name="idMunicipio">Id municipio a eliminar.</param>
        /// <returns><c>true</c>respuesta objeto responseService <c>false</c> otherwise.</returns>
        ResponseService EliminaMunicipio(int idMunicipio);
    }
}
