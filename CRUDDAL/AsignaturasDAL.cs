using CRUDBOL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace CRUDDAL
{
    /// <summary>
    /// Clase para manejar las operaciones en la base de datos, tabla Asignaturas
    /// </summary>
    public class AsignaturasDAL
    {
        // Cadena de conexión a la base de datos
        private string constring = "Data Source=SIRIUSLS\\SQLEXPRESS;Initial Catalog=CRUD;Integrated Security=True;"; // reemplazar por su cadena de coneccion


        /// <summary>
        /// Inserta una nueva asignatura en la tabla Asignaturas
        /// </summary>
        /// <param name="asignatura">El objeto AsignaturasBOL que contiene los datos de la asignatura</param>
        public void InsertarAsignaturas(AsignaturasBOL asignatura)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                //Comando sql para insertar una nueva asignatura
                string query = "insert into Asignaturas " +
                    "( NombreAsignatura, Creditos) " +
                    "VALUES (@NombreAsignatura, @Creditos)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    //agrega parametros a la consulta
                    cmd.Parameters.AddWithValue("@NombreAsignatura", asignatura.NombreAsignatura);
                    cmd.Parameters.AddWithValue("@Creditos", asignatura.Creditos);
                    cmd.ExecuteNonQuery();//ejecutar la consulta
                }
            }
        }
        /// <summary>
        /// Modifica una asignatura existente
        /// </summary>
        /// <param name="asignatura">El objeto AsignaturasBOL que contiene los datos de la asignatura</param>
        public void ModificarAsignatura(AsignaturasBOL asignatura)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                //Comando SQL para modificar una asignatura segun el Codigo asignatura
                string query = "UPDATE Asignaturas " +
                    "SET NombreAsignatura = @NombreAsignatura, " +
                    "Creditos = @Creditos " +
                    "WHERE CodigoAsignatura = @CodigoAsignatura";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    
                    //Agregar parametros a la consulta
                    cmd.Parameters.AddWithValue("@NombreAsignatura", asignatura.NombreAsignatura);
                    cmd.Parameters.AddWithValue("@Creditos", asignatura.Creditos);
                    cmd.Parameters.AddWithValue("@CodigoAsignatura", asignatura.CodigoAsignatura);
                    cmd.ExecuteNonQuery(); // ejecutar la consulta
                }
            }
        }


        /// <summary>
        /// Elimina una asignatura de la base de datos
        /// </summary>
        /// <param name="CodigoAsignatura">El código de la asignatura a eliminar.</param>
        /// <returns>El número de filas afectadas.</returns>
        public int EliminarAsignatura(int CodigoAsignatura)
        {
            int res = 0;
            //consulta sql para eliminar una asignatura
            string query = "DELETE FROM Asignaturas " +
                "WHERE CodigoAsignatura = @CodigoAsignatura";
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open(); 
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    //Agregar parametros a la consulta
                    cmd.Parameters.AddWithValue("@CodigoAsignatura", CodigoAsignatura);
                    res = cmd.ExecuteNonQuery(); //Se ejecuta la consulta
                }
            }
            return res; // Devolver el número de filas afectadas
        }
        /// <summary>
        ///  Selecciona todas las asignaturas de la base de datos
        /// </summary>
        /// <returns>Una lista de objetos AsignaturasBOL que representan todas las asignaturas.</returns>
        public List<AsignaturasBOL> SeleccionarTodos()
        {
            List<AsignaturasBOL> asignaturas = new List<AsignaturasBOL>();
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                // Consulta SQL para seleccionar todas las asignaturas
                string query = "SELECT CodigoAsignatura, " +
               "NombreAsignatura, " +
               "Creditos FROM Asignaturas ";    
                using (SqlCommand cmd = new SqlCommand(query, con)) 
                {
                    using(SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            // Crear una nueva instancia de AsignaturasBOL y asignar valores
                            AsignaturasBOL asignatura = new AsignaturasBOL ();
                            asignatura.CodigoAsignatura = dr.GetInt32(0);
                            asignatura.NombreAsignatura=dr.GetString(1);
                            asignatura.Creditos = dr.GetInt32(2);
                            asignaturas.Add(asignatura); // Agregar la asignatura a la lista
                        }
                    }
                }
            }
            return asignaturas; // Devolver la lista de asignaturas
        }

        /// <summary>
        /// Selecciona una asignatura específica de la base de datos.
        /// </summary>
        /// <param name="CodigoAsignatura"> El código de la asignatura a seleccionar</param>
        /// <returns>El objeto AsignaturasBOL correspondiente a la asignatura seleccionada.</returns>
        public AsignaturasBOL SeleccionarUnaAsignatura(int CodigoAsignatura)
        {
            AsignaturasBOL asignatura = null;
            
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                string query = "SELECT CodigoAsignatura, " +
               "NombreAsignatura, " +
               "Creditos FROM Asignaturas " +
               "WHERE CodigoAsignatura = @CodigoAsignatura ";
                // Consulta SQL para seleccionar una asignatura por su código
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@CodigoAsignatura", CodigoAsignatura);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            // Crear una nueva instancia de AsignaturasBOL y asignar valores
                            asignatura = new AsignaturasBOL();
                            asignatura.CodigoAsignatura = dr.GetInt32(0);
                            asignatura.NombreAsignatura = dr.GetString(1);
                            asignatura.Creditos = dr.GetInt32(2);
                            
                        }
                    }
                }
            }
            return asignatura; // Devolver la asignatura seleccionada o null si no se encontró
        }
        /// <summary>
        /// Verifica si una asignatura existe en la base de datos
        /// </summary>
        /// <param name="asignaturas">El objeto AsignaturasBOL que se va a verificar.</param>
        /// <returns>True si la asignatura existe, de lo contrario, false.</returns>
        public bool ExisteAsignatura(AsignaturasBOL asignaturas)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                // Consulta SQL para contar las asignaturas con el mismo nombre
                string query = "SELECT COUNT(1) FROM Asignaturas WHERE NombreAsignatura = @NombreAsignatura";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@NombreAsignatura", asignaturas.NombreAsignatura);
                    int count = (int)cmd.ExecuteScalar();// Ejecutar la consulta y obtener el conteo
                    return count > 0; // Devolver true si se encontraron asignaturas
                }
            }
        }
    }
}
