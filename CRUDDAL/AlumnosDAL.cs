using CRUDBOL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDDAL
{
    /// <summary>
    /// Clase para manejar las operaciones en la base de datos, tabla Alumnos
    /// </summary>
    public class AlumnosDAL
    {
        // Cadena de conexión a la base de datos
        private string constring = "Data Source=SIRIUSLS\\SQLEXPRESS;Initial Catalog=CRUD;Integrated Security=True;"; // reemplazar por su cadena de coneccion
        /// <summary>
        /// Inserta un nuevo alumno en la tabla Alumnos
        /// </summary>
        /// <param name="alumno">El objeto AlumnosBOL que contiene los datos del alumno</param>
        public void InsertarAlumnos(AlumnosBOL alumno)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                //Consulta sql para insertar a un nuevo alumno
                string query = "insert into Alumnos (Nombre, ApellidoPAT, ApellidoMAT, Email, NumeroMatricula) " +
                    "values (@Nombre, @ApellidoPAT, @ApellidoMAT, @Email , @NumeroMatricula)";
                using (SqlCommand cmd = new SqlCommand(query, con)) 
                {
                    //agrega parametros a la consulta
                    cmd.Parameters.AddWithValue("@Nombre", alumno.Nombre);
                    cmd.Parameters.AddWithValue("@ApellidoPAt", alumno.ApellidoPAt);
                    cmd.Parameters.AddWithValue("@ApellidoMat", alumno.ApellidoMat);
                    cmd.Parameters.AddWithValue("@Email", alumno.Email);
                    cmd.Parameters.AddWithValue("@NumeroMatricula", alumno.NumeroMatricula);
                    cmd.ExecuteNonQuery();//ejecutar la consulta
                }
            }
        }
        /// <summary>
        /// Modifica a un alumo existente
        /// </summary>
        /// <param name="alumno">El objeto AlumnosBOL que contiene los datos del alumno</param>
        public void ModificarAlumno(AlumnosBOL alumno) //Modificar Alumno
        {
                using (SqlConnection con = new SqlConnection(constring)) { 
                con.Open();
                //Consulta SQL para Modificar a un alumno segun su ID
                string query = "UPDATE Alumnos SET " +
                    "Nombre = @Nombre, " +
                    "ApellidoPAt = @ApellidoPAt, " +
                    "ApellidoMat = @ApellidoMat, " +
                    "Email = @Email, " +
                    "NumeroMatricula = @NumeroMatricula " +
                    "WHERE IDAlumno = @IDAlumno";
                using (SqlCommand cmb = new SqlCommand(query, con)) {
                    //agrega parametros a la consulta
                    cmb.Parameters.AddWithValue("@IDAlumno", alumno.IDAlumno);
                    cmb.Parameters.AddWithValue("@Nombre", alumno.Nombre);
                    cmb.Parameters.AddWithValue("@ApellidoPAt", alumno.ApellidoPAt);
                    cmb.Parameters.AddWithValue("@ApellidoMat", alumno.ApellidoMat);
                    cmb.Parameters.AddWithValue("@Email", alumno.Email);
                    cmb.Parameters.AddWithValue("@NumeroMatricula", alumno.NumeroMatricula);
                    cmb.ExecuteNonQuery(); // ejecuta la consulta
                }
            }
        }
        /// <summary>
        /// Elimina a un alumno de la base de datos
        /// </summary>
        /// <param name="IDAlumno"> La ID del alumno a eliminar</param>
        /// <returns></returns>
        public int EliminarAlumno(int IDAlumno)
        {
            int res = 0;
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                //Consulta Sql que elimina a un alumno segun su id
                string query = "DELETE from Alumnos " +
                    "WHERE IDAlumno=@IDAlumno";
                using (SqlCommand cmb = new SqlCommand (query, con))
                {
                    //agregar parametros a la consulta
                    cmb.Parameters.AddWithValue("@IDAlumno", IDAlumno);
                    res= cmb.ExecuteNonQuery(); //ejecuta la consulta
                }
            }
                return res; // Devolver el número de filas afectadas
        }
        /// <summary>
        /// Selecciona a todos los alumnos de la base de datos
        /// </summary>
        /// <returns>Una lista de objetos AlumnosBOL que representa todos los alumnos</returns>
        public List<AlumnosBOL> SeleccionaerTodos() //Listar Alumnos
        {
            List<AlumnosBOL> listaA = new List<AlumnosBOL>();

            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                //consulta sql que seleciona todos los datos de la tabla alumnos
                string query = "select " +
                    "IDAlumno, " +
                    "Nombre, " +
                    "ApellidoPAt, " +
                    "ApellidoMat, " +
                    "Email, " +
                    "NumeroMatricula " +
                    "FROM Alumnos";

                using (SqlCommand cmb = new SqlCommand(query, con))
                {
                    using (SqlDataReader dr = cmb.ExecuteReader())
                    {   
                        while (dr.Read())
                        {
                            // Crear una instancia de AslumosBOL y asignamos valores
                            AlumnosBOL alumnos = new AlumnosBOL();
                            alumnos.IDAlumno = dr.GetInt32(0);
                            alumnos.Nombre = dr.GetString(1);
                            alumnos.ApellidoPAt = dr.GetString(2);
                            alumnos.ApellidoMat = dr.GetString(3);
                            alumnos.Email = dr.GetString(4);
                            alumnos.NumeroMatricula = dr.GetString(5);
                            listaA.Add(alumnos); // agrega al alumo a la lista
                        }
                    }               
                }
            }
            return listaA; //retorna la lista con todos los alumos existentes
        }
        /// <summary>
        /// Selecciona a un alumno especifico de la base de datos
        /// </summary>
        /// <param name="IDAlumno">La ID del alumno a selccionar</param>
        /// <returns>El objeto AlumnosBOL correspondiente al alumno seleccionado</returns>
        public AlumnosBOL SeleccionarUno(int IDAlumno) //Listar datos de un alumno en especifico
        {
            AlumnosBOL alumno = null;

            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                //consulta sql que selecciona a un alumno segun su ID
                string query = "select " +
                    "IDAlumno, " +
                    "Nombre, " +
                    "ApellidoPAt, " +
                    "ApellidoMat, " +
                    "Email, " +
                    "NumeroMatricula " +
                    "FROM Alumnos " +
                    "WHERE IDAlumno=@IDAlumno";

                using (SqlCommand cmb = new SqlCommand(query, con))
                {

                    cmb.Parameters.AddWithValue("@IDAlumno", IDAlumno);
                    using (SqlDataReader dr = cmb.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            // Crear una nueva instancia de AlumnosBOL y asignar valores
                            alumno = new AlumnosBOL();
                            alumno.IDAlumno = dr.GetInt32(0);
                            alumno.Nombre = dr.GetString(1);
                            alumno.ApellidoPAt = dr.GetString(2);
                            alumno.ApellidoMat = dr.GetString(3);
                            alumno.Email = dr.GetString(4);
                            alumno.NumeroMatricula = dr.GetString(5);                         
                        }
                    }
                }
            }
            return alumno; // Devolver al alumno seleccionado o null si no encuentra
        }
        /// <summary>
        /// Verifica si un alumno ya existe en la base de datos
        /// </summary>
        /// <param name="alumnos"> El objeto AlumnosBOL que se verificara</param>
        /// <returns> True si e alumno existe, de lo contrario, false</returns>
        public bool ExisteCorreoONumeroMatricula(AlumnosBOL alumnos)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                // Consulta Sql para econtrar alumnos con el mismo Email o Numero de matricula
                string query = "SELECT COUNT(1) FROM Alumnos WHERE Email = @Email OR NumeroMatricula = @NumeroMatricula";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Email",alumnos.Email);
                    cmd.Parameters.AddWithValue("@NumeroMatricula", alumnos.NumeroMatricula);
                    int count = (int)cmd.ExecuteScalar(); // Ejecutar la consulta y obtener el conteo
                    return count > 0; // Devolver true si se encontraron asignaturas
                }
            }
        }

    }
}
