using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Skular.Models
{
    public class Alumno
    {
        public int Ciscolar { get; set; }
        public int Cedularepresentante { get; set; }
        public virtual Representante Representante { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public int Sexo { get; set; }
    }
}