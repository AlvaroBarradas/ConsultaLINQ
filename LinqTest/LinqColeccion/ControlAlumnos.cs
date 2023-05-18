using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqColeccion
{
    internal class ControlAlumnos
    {
        List<Carrera> carreras = new List<Carrera>();
        List<Alumno> alumnos = new List<Alumno>();

        public ControlAlumnos()
        {
            carreras.Add(new Carrera { IdCarrera = 1, Nombre = "Ingenieria de Software" });
            carreras.Add(new Carrera { IdCarrera = 2, Nombre = "Redes y servicio de computo"});

            alumnos.Add(new Alumno { IdAlumno = 1, Nombre = "Juan Perez Sanchez", Matricula = "s090032", Promedio = 8.9, IdCarrera = 1});
            alumnos.Add(new Alumno { IdAlumno = 2, Nombre = "Maria Rodriguez Martinez", Matricula = "s4324234", Promedio = 9.2, IdCarrera = 2 });
            alumnos.Add(new Alumno { IdAlumno = 3, Nombre = "Jose Trelles Jimenez", Matricula = "s2111111", Promedio = 6.5, IdCarrera = 2 });
        }
        public void obtenerAlumnosPorCarrera(int idCarrera)
        {
            IEnumerable<Alumno> resultado = from alumno in alumnos join carrera in carreras on alumno.IdCarrera equals carrera.IdCarrera where alumno.IdCarrera == idCarrera select new { alumno, carrera };
            foreach(Alumno alumno in resultado)
            {
                alumno.getDatosAlumno();
                carrera.getDatosCarrera();
            }
        }
    }
}
