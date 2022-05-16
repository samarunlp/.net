using Escuela;
using (var context = new EscuelaContext())
{
    context.Database.EnsureCreated(); //si no existe la base de datos, la crea de acuerdo al modelo
}
