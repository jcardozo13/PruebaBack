using Microsoft.EntityFrameworkCore;
using Datos.Modelos;

namespace Datos.Contexto
{
    public class DBContexto : DbContext
    {
        public DBContexto(DbContextOptions<DBContexto> options)
            : base(options)
        { }
        public DbSet<Departamentos> Departamentos { get; set; }
        public DbSet<Municipios> Municipios { get; set; }
    }
}
