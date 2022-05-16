using Microsoft.EntityFrameworkCore;

namespace Escuela;
public class EscuelaContext : DbContext
{
    //los carga el entituFrameworkCore, para sacar los warning usamos #nullable porque no es responsabilidad nuestra ese null
    #nullable disable
    public DbSet<Alumno> Alumnos {get;set;} //cada vez que quiera crear una base
    public DbSet<Alumno> Examenes {get;set;} 
    #nullable restore
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //cual es la base de dato de archivo fisico
    {
        optionsBuilder.UseSqlite("data source=Escuela.sqlile"); // es lo que va entre parentesis string de conexion
    }
}
