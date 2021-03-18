using System.Collections.Generic;

namespace Datos.Modelos
{
    public class Departamentos
    {
        public Departamentos()
        {
            Municipios = new HashSet<Municipios>();
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<Municipios> Municipios { get; set; }
    }
}
