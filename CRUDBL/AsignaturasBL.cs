using CRUDBOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace CRUDBL
{
    /// <summary>
    /// Clase que maneja la logica de negocios de las asignaturas
    /// </summary>
    public class AsignaturasBL
    {
        /// <summary>
        /// Inserta una nueva asignatura en el sistema. 
        /// </summary>
        /// <param name="asignaturas">Objeto que contiene la información de la asignatura a insertar.</param>
        /// <param name="errorMessage">Mensaje de error, si ocurre algún problema durante la inserción</param>
        /// <returns>Devuelve true si la asignatura se inserta correctamente, de lo contrario false.</returns>
        public static bool InsertarAsignatura(AsignaturasBOL asignaturas, out string errorMessage)
        {         
            try
			{
                //instancia la capa DAL
                CRUDDAL.AsignaturasDAL obj = new CRUDDAL.AsignaturasDAL(); 
                //Verifica si la asignatura existe llamando al metodo de AsignaturasDAL
                if (obj.ExisteAsignatura(asignaturas))
                {
                    errorMessage = "El nombre de asignatura ya existe";
                    return false;
                }
                //LLama al metodo de Insercion de la capa DAL
                obj.InsertarAsignaturas(asignaturas); // no hay errores
                errorMessage = string.Empty;
                return true; // Insercion exitosa 
			}
			catch (Exception x)
			{
                errorMessage = x.Message; // capturamos el mensaje de error
                return false;  // Insercion fallida
			} 
        }
        /// <summary>
        /// Selecciona todas las asignaturas disponibles.
        /// </summary>
        /// <returns>Una lista de objetos AsignaturasBOL que representan todas las asignaturas.
        /// retorna null si hay errores</returns>
        public static List<AsignaturasBOL> SeleccionarTodasAsignaturas()
        {
            List<AsignaturasBOL> listaA = new List<AsignaturasBOL>(); 
            try
            {
                //instancia la capa DAL
                CRUDDAL.AsignaturasDAL obj = new CRUDDAL.AsignaturasDAL();
                // llama al metodo de Seleccion de la capa DAL
                listaA = obj.SeleccionarTodos();
                return listaA; //Devuelve la lista de asignaturas
            }
            catch (Exception)
            {
                return null; // en caso de error, devuelve null
            }
        }
        /// <summary>
        /// Modifica una asignatura seleccionada
        /// </summary>
        /// <param name="asignaruras">Objeto que contiene la información actualizada de la asignatura.</param>
        /// <param name="errorMessage">Mensaje de error, si ocurre algún problema durante la modificación.</param>
        /// <returns>Devuelve true si la asignatura se modifica correctamente, de lo contrario false.</returns>
        public static bool ModificarAsignatura(AsignaturasBOL asignaruras, out string errorMessage)
        {
            
            try
            {
                //instancia la capa DAL
                CRUDDAL.AsignaturasDAL obj = new CRUDDAL.AsignaturasDAL(); 
                //llama al metodo de modificacion de a capa DAL.       
                obj.ModificarAsignatura(asignaruras);
                errorMessage = string.Empty; //No hay errores
                return true; //Modificacion exitosa
            }
            catch (Exception x)
            {
                errorMessage = x.Message; // capturamos el mensaje de error
                return false; // Modificacion fallida
            }
        }
        /// <summary>
        /// Elimina la asignatura seleccionada 
        /// </summary>
        /// <param name="CodigoAsignatura">Codigo de la asignatura a eiminar</param>
        /// <param name="errorMessage"> Mensaje de error, si ocurre algún problema durante la eliminación.</param>
        /// <returns>Devuelve true si la asignatura se elimina correctamente, de lo contrario false.</returns>
        public static bool EliminarAsignatura(int CodigoAsignatura, out string errorMessage)
        {
            try
            {
                //Instancia la capa DAL
                CRUDDAL.AsignaturasDAL obj = new CRUDDAL.AsignaturasDAL();
                // llama al metodo de eliminacion de la capa DAL
                obj.EliminarAsignatura(CodigoAsignatura);
                errorMessage = string.Empty; // No hay errores
                return true; // Eliminacion exitosa
            }
            catch (Exception x)
            {
                errorMessage = x.Message; // Captura el mensaje de error
                return false; // modificacion fallida
            }
        }
        /// <summary>
        /// Seleciona unaa asignatura especifica segun su codigo.
        /// </summary>
        /// <param name="CodigoAsignatura"> Codigo de la asignatura</param>
        /// <returns>Objeto AsignaturasBOL que representa la asignatura seleccionada. 
        /// Devuelve null si ocurre un error</returns>
        public static AsignaturasBOL SeleccionarUnaAsignatura(int CodigoAsignatura)
        {
            AsignaturasBOL asignaturas = new AsignaturasBOL();
            try
            {
                //Instancia la capa DAL
                CRUDDAL.AsignaturasDAL obj = new CRUDDAL.AsignaturasDAL();
                //llama al metodo de Seleccion especifica de la capa DAL
                asignaturas = obj.SeleccionarUnaAsignatura(CodigoAsignatura);
                return asignaturas; // Devuelve la asignatura seleccionada
            }
            catch (Exception)
            {
                return null; // En caso de error, devuelve null
            }
        }
    }
}
