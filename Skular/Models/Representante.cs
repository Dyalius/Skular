using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Skular.Models
{
    public class Representante
    {
        public int Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Parentesco { get; set; }
        public int telefono { get; set; }
        public ICollection<Alumno> Alumnos { get; set; }
    }
}