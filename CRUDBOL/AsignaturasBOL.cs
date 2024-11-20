using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDBOL
{
    /// <summary>
    /// Clase que representa la entidad Asignaturas en la capa de negocio (BOL).
    /// Contiene las propiedades básicas de una asignatura como: CodigoAsignatura, NombreAsignatura y Creditos, asi como los tipos de datos corespondientes
    /// </summary>
    public class AsignaturasBOL
    {
        public int CodigoAsignatura {  get; set; }
        public string NombreAsignatura { get; set; }
        public int Creditos {  get; set; }
    }
}
