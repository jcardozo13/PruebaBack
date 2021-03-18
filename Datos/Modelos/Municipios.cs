namespace Datos.Modelos
{
    public class Municipios
    {
        public int Id { get; set; }      
        public string Nombre { get; set; }
        public int DepartamentoId { get; set; }
        public bool Capital { get; set; }
        public string CodigoDane { get; set; }       
        public Departamentos Departamento { get; set; }
        
    }
}
