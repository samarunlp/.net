using Microsoft.EntityFrameworkCore;

namespace Escuela;
public class EscuelaContext : DbContext
{
    #nullable disable
    public DbSet<Alumno> Alumnos {get;set;} //cada vez que quiera crear una base
    public DbSet<Alumno> Examenes {get;set;} 
    #nullable restore
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
    {
        optionsBuilder.UseSqlite("data source=Escuela.sqlile"); 
    }
}
