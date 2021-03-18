using System;
using System.Collections.Generic;
using System.Text;
using Datos.DTO;
using Servicios.DTO;
using Servicios.Interface;
using Datos.Contexto;
using System.Linq;
using Datos.Modelos;

namespace Servicios.Servicios
{
    public class ServiciosMunicipios : IServiciosMunicipios
    {
        readonly DBContexto _context;
        public ServiciosMunicipios(DBContexto context)
        {
            _context = context;
        }
        public ResponseService EliminaMunicipio(int idMunicipio)
        {
            try
            {
                var lq = _context.Municipios.FirstOrDefault(e => e.Id == idMunicipio);
                _context.Entry(lq).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                _context.SaveChanges();
                return new ResponseService() { Messages = null, StatusCode = System.Net.HttpStatusCode.OK, Success = true };
            }
            catch (Exception ex)
            {
                var message = new List<string>();
                message.Add(ex.Message);
                return new ResponseService() { Messages = message, StatusCode = System.Net.HttpStatusCode.InternalServerError, Success = false };
            }
        }

        public ResponseService GuardarMunicipio(MunicipiosDTO municipio)
        {
            var message = new List<string>();
            try
            {
                //validaos que el municipio no exista
                var municipioTemp = _context.Municipios.FirstOrDefault(e => e.Id == municipio.Id);

                if (municipioTemp  == null)
                {
                    municipioTemp = new Municipios();
                }

                municipioTemp.Nombre = municipio.Nombre;
                municipioTemp.DepartamentoId = municipio.IdDepartamento;
                municipioTemp.CodigoDane = municipio.CodigoDane;
                municipioTemp.Capital = municipio.Capital;                            

                if (municipioTemp.Id == 0)
                {
                    _context.Municipios.Add(municipioTemp);
                }
                else
                {
                    _context.Entry(municipioTemp).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }
                _context.SaveChanges();
                message.Add("Guardado Exitoso!");
                return new ResponseService() { Messages = message, StatusCode = System.Net.HttpStatusCode.OK, Success = true };
            }
            catch (Exception ex)
            {               
                message.Add(ex.Message);
                return new ResponseService() { Messages = message, StatusCode = System.Net.HttpStatusCode.InternalServerError, Success = false };
            }
        }

        public List<MunicipiosDTO> MunicipiosTodos()
        {
            var lista = (from e in _context.Municipios
                         select new MunicipiosDTO()
                         {
                             Id = e.Id,
                             Nombre = e.Nombre,
                             IdDepartamento = e.Departamento.Id,
                             NombreDepartamento = e.Departamento.Nombre,
                             CodigoDane = e.CodigoDane,
                             Capital = e.Capital                           
                   
                         }).ToList();
            return lista;
        }

   

    }
}
