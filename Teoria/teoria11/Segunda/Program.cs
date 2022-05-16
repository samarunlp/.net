using Escuela;
/*using (var context = new EscuelaContext())
{
    context.Database.EnsureCreated(); //si no existe la base de datos, la crea de acuerdo al modelo
    EscuelaInit.Inicializar(context);
}*/

//consulta
/*using Escuela;
using (var db = new EscuelaContext())
{
  var query = db.Alumnos.Join(db.Examenes,
               a => a.Id,
               e => e.AlumnoId,
               (a, e) => new
               {
                   Alumno = a.Nombre,
                   Materia = e.Materia,
                   Nota = e.Nota
               });
  foreach (var obj in query)
  {
      Console.WriteLine(obj);
  }
}
*/

//agregando registros
using (var db = new EscuelaContext())
{
  //Agregamos un nuevo alumno
  var alumno = new Alumno() { Nombre = "Pablo" }; // el Id será establecido por SQLite
    //general alumno, guardarlo-->aparece
  db.Add(alumno); // se agregará realmente con el db.SaveChanges()
    //dentro de alumno ya hay un valor
  db.SaveChanges(); //actualiza la base de datos. SQlite establece el valor de alumno.Id

  // Agregamos un examen para el nuevo alumno
  var examen = new Examen()
  {
      AlumnoId = alumno.Id,
      Materia = "Historia",
      Nota = 9.5
  };
  db.Add(examen);
  db.SaveChanges();
}

//Borrar y modificar registros
using (var db = new EscuelaContext())
{
  //borramos de la tabla Alumnos el registro con Id=3
  var alumnoBorrar = db.Alumnos.Where(a => a.Id == 3).SingleOrDefault();
    //si encuentra mas de uno, toma el primero
  if (alumnoBorrar != null) 
  {
      db.Remove(alumnoBorrar); //se borra realmente con el db.SaveChanges()
  }

  //La nota en Inglés del alumno id=1 es un 5. La cambiamos a 7.5
  var examenModificar = db.Examenes.Where(
                           e => e.AlumnoId == 1 && e.Materia == "Inglés").SingleOrDefault();
  if (examenModificar != null)
  {
      examenModificar.Nota = 7.5; //se modifica el registro en memoria
  }

  db.SaveChanges(); //actualiza la base de datos.
}
