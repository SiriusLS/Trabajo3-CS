using CRUDBOL;
using CRUDDAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace CRUDBL
{
	/// <summary>
	/// Clase que maneja la logica de negocios de los alumnos
	/// </summary>
    public class AlumnosBL
    {
        /// <summary>
        /// Ingresa a un nuevo alumno al sistema 
        /// </summary>
        /// <param name="alumnos"> objeto que contiene la informacion del alumno a agrgar</param>
        /// <param name="errorMessage"> Mensaje de error, si ocurre algún problema durante la inserción</param>
        /// <returns> Retorna true si la asignatura se Inserto correctamente, de lo contrario, false</returns>
        public static bool Insertar(AlumnosBOL alumnos, out string errorMessage)
        {	
			try
			{
                //instancia la capa DAL
                CRUDDAL.AlumnosDAL obj = new CRUDDAL.AlumnosDAL();
                //Verifica si el aalumno existe llamando al metodo de la capa DAL
                if (obj.ExisteCorreoONumeroMatricula(alumnos))
                {
                    errorMessage = "El correo o número de matrícula ya están registrados.";
                    return false;
                }
				//llama al metodo de insercion de la capa dal
                obj.InsertarAlumnos(alumnos);
                errorMessage = string.Empty; // no hay errores, todo god
                return true; // insercion exitosa
			}
			catch (Exception x)
			{
                errorMessage = x.Message; // capturamos el mensaje de error, todo mal
                return false; // Insercion fallida F
			}
        }
        /// <summary>
        /// Modifica a un alumo existente en la base de datos
        /// </summary>
        /// <param name="alumnos">Objeto que contiene la información actualizada del alumno.</param>
        /// <param name="errorMessage"> Mensaje de error, si ocurre algún problema durante la inserción</param>
        /// <returns> Devueve true si la modificacion es exitosa, de lo contrario, false</returns>
        public static bool Modificar(AlumnosBOL alumnos, out string errorMessage)
		{
			try
			{
                //instancia la capa DAL
                CRUDDAL.AlumnosDAL obj = new CRUDDAL.AlumnosDAL();  
				//LLama al metodo de modificacion de la capa DAL
                obj.ModificarAlumno(alumnos);

                errorMessage = string.Empty; // No hay errores, todo bien
				return true; // Modificacion exitosa
            }
			catch (Exception x )
			{
				errorMessage = x.Message; // Capturamos el mensaje de error
				return false; // modificacion fallida
			}
		}

        /// <summary>
        /// Elimina a un alumno existente
        /// </summary>
        /// <param name="IDAlumno"> ID del alumno a eliminar</param>
        /// <param name="errorMessage"> Mensaje de error, si ocurre algún problema durante la inserción</param>
        /// <returns> Retorna true si el alumno fue eliminado exitosamente, de lo contrario, false</returns>
        public static bool Eliminar(int IDAlumno, out string errorMessage)
		{
			try
			{
                //instancia la capa DAL
                CRUDDAL.AlumnosDAL obj = new CRUDDAL.AlumnosDAL();
				//llama al metodo de eliminacion de la capa DAL
				obj.EliminarAlumno(IDAlumno);
				errorMessage = string.Empty; // NO HAY ERRORES
				return true; // Eliminacion exitosa
            }
			catch (Exception x)
			{
				errorMessage=x.Message; // capturamos el mensaje de error
				return false; // eliminacion fallida
			}
		}
        /// <summary>
        /// Selecciona todos los alumnos
        /// </summary>
        /// <returns> Una lista de objetos UsuariosBOL que representa todos los usuarios
        /// Retorna false si hay errores.</returns>
        public static List<AlumnosBOL> SeleccionarTodos()
		{
            List<AlumnosBOL> listaA = new List<AlumnosBOL>();
			try
			{
                //instancia la capa DAL
                CRUDDAL.AlumnosDAL obj = new CRUDDAL.AlumnosDAL();
                // LLama al metodo de selecciontodos de la capa DAL
				listaA= obj.SeleccionaerTodos();
                return listaA; // retorna la lista de alumnos
			}
			catch (Exception)
			{
				return null; // en caso de error, retorna null
			}
        }
        /// <summary>
        /// Selecciona a un alumno segun su ID
        /// </summary>
        /// <param name="IDAlumno"> ID del alumno a seleccionar</param>
        /// <returns>objeto AlumnosBOL que reprecenta al alumno seleccionado
        /// retorna null si hay errores</returns>
		public static AlumnosBOL SeleccionarUno(int IDAlumno)
		{
			AlumnosBOL alumno = new AlumnosBOL();
			try
			{
                // instancia de la capa DAL
				CRUDDAL.AlumnosDAL obj = new CRUDDAL.AlumnosDAL();
                //llama al metodo de selecion unica de la capa DAL
				alumno = obj.SeleccionarUno(IDAlumno);				
				return alumno; // retorna al alumno seleccionado
			}
			catch (Exception)
			{               
                return null; // En caso de error, retorna null
			}
		}
    }
}
