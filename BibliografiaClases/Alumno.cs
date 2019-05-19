using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliografiaClases
{
    class Alumno
    {
        public enum TipoDocumento
        {
            pasaporte,
            cedula
        }
        public string nro_documento { get; set; }
        public TipoDocumento tipo_documento { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fecha_nac { get; set; }
        public string direccion { get; set; }
        public string telefono{ get; set; }
        public string email { get; set; }

        public static List<Alumno> listaAlumno = new List<Alumno>();

        public static void AgregarAlumno(Alumno a)
        {
            listaAlumno.Add(a);
        }

        public static void EliminarAlumno(Alumno a)
        {
            listaAlumno.Remove(a);
        }

        public static List<Alumno> ObtenerAlumno()
        {
            return listaAlumno;
        }

        public override string ToString()
        {
            return this.nombre;
        }

    }
}
