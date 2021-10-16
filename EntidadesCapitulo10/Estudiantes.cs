using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Capitulo10y12.EntidadesCapitulo10
{
    public class Estudiantes
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Matricula { get; set; }
        public string Curso { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaIngreso { get; set; } = DateTime.Now;
        public DateTime FechaEgreso { get; set; }
        public float Calificacion { get; set; }
        public ArrayList RecordCalificaciones { get; set; }
        public string NombreMadre { get; set; }
        public string NombrePadre { get; set; }
        public string NombreTutor { get; set; }
    }
}
