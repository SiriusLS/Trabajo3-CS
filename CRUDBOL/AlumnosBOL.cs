using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDBOL
{
    /// <summary>
    /// Clase que representa la entidad Alumnos en la capa de negocio (BOL).
    /// Contiene las propiedades básicas de un alumno, como ID, nombre, apellidos, email y número de matrícula.
    /// </summary>
    public class AlumnosBOL
    {
        public int IDAlumno { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPAt { get; set; }
        public string ApellidoMat { get; set; }
        public string Email { get; set; }
        public string NumeroMatricula { get; set; }
    }
}
