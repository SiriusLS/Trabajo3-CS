using CRUD_AA.CRUDWeb;
using CRUDBL;
using CRUDBOL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_AA
{
    /// <summary>
    /// Formulario para gestionar los alumnos del sistema.
    /// Permite listar, guardar, modificar y eliminar alumnos.
    /// </summary>
    public partial class Alumnos : Form
    {
        // identificador gloval para el alumno seleccionado
        int? IdGlobal;
        public Alumnos()
        {
            InitializeComponent();        
        }


        /// <summary>
        /// Lista los alumnos y los muestra en el DataGridView.
        /// </summary>
        private void ListarAlumnos()
        {          //llama al metodo de seleccion de alumons de la capa BLL
            List<AlumnosBOL> alumnos = AlumnosBL.SeleccionarTodos();
            dtAlumnos.DataSource = alumnos; // muestra en la DataGridView.
        }
        /// <summary>
        /// Guarda a un alumno en la base de datos
        /// Valida todos los campos antes de realizar inserciones 
        /// </summary>
        private void GuardarAlumno()
        {
            // Crea una nueva instancia de AlumnosBOL para almacenar los datos del alumno
            AlumnosBOL alumnos = new AlumnosBOL();

            if (string.IsNullOrWhiteSpace(txNombre.Text))
            {
                MessageBox.Show("El nombre no puede estar en blanco.");
                txNombre.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txAPaterno.Text))
            {
                MessageBox.Show("El apellido paterno no puede estar en blanco.");
                txAPaterno.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txAMaterno.Text))
            {
                MessageBox.Show("El apellido materno no puede estar en blanco.");
                txAMaterno.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txEmail.Text))
            {
                MessageBox.Show("El correo electrónico no puede estar en blanco.");
                txEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txNMatricula.Text))
            {
                MessageBox.Show("El número de matrícula no puede estar en blanco.");
                txNMatricula.Focus();
                return;
            }

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(txEmail.Text, emailPattern))
            {
                MessageBox.Show("El correo electrónico no tiene un formato válido. Debe ser como nombre@dominio.cl.");
                txEmail.Focus();
                return;
            }

            //asigna los valores de los campos al objeto alumnos
            alumnos.Nombre=txNombre.Text;
            alumnos.ApellidoPAt = txAPaterno.Text;
            alumnos.ApellidoMat = txAMaterno.Text;
            alumnos.Email=txEmail.Text;
            alumnos.NumeroMatricula=txNMatricula.Text;
           
            string errorMessage;
            //llama al metodo de insercion de la capa BLL
            bool res = AlumnosBL.Insertar(alumnos, out errorMessage);
            // Informa al usuario si la operación fue exitosa o si ocurrió un error
            //sincronizacion con web
            CRUDWeb.WebServices_CRUD ws = new CRUDWeb.WebServices_CRUD();
            ws.GuardarAlumnos(txNombre.Text, txAPaterno.Text, txAMaterno.Text, txEmail.Text, txNMatricula.Text);

            if (res)
            {
                MessageBox.Show("Alumno guardado exitosamente.");
                txNombre.Text = "";
                txAPaterno.Text = "";
                txAMaterno.Text = "";
                txEmail.Text = "";
                txNMatricula.Text = "";
            }
            else
            {
                MessageBox.Show($"Ocurrió un error al guardar el alumno: {errorMessage}");
            }

        }
        /// <summary>
        /// Modifica a un alumno existente en la base de datos.
        /// Valida todos los campos antes de realizar inserciones 
        /// </summary>
        private void ModificarAlumno()
        {
            if (string.IsNullOrWhiteSpace(txNombre.Text))
            {
                MessageBox.Show("El nombre no puede estar en blanco.");
                txNombre.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txAPaterno.Text))
            {
                MessageBox.Show("El apellido paterno no puede estar en blanco.");
                txAPaterno.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txAMaterno.Text))
            {
                MessageBox.Show("El apellido materno no puede estar en blanco.");
                txAMaterno.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txEmail.Text))
            {
                MessageBox.Show("El correo electrónico no puede estar en blanco.");
                txEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txNMatricula.Text))
            {
                MessageBox.Show("El número de matrícula no puede estar en blanco.");
                txNMatricula.Focus();
                return;
            }

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(txEmail.Text, emailPattern))
            {
                MessageBox.Show("El correo electrónico no tiene un formato válido. Debe ser como nombre@dominio.cl.");
                txEmail.Focus();
                return;
            }
            // Obtiene el código del alumno seleccionado y carga sus datos
            int codigo = (int)IdGlobal;
            AlumnosBOL AlumnosModificar = AlumnosBL.SeleccionarUno(codigo);
            
            AlumnosModificar.Nombre = txNombre.Text;
            AlumnosModificar.ApellidoPAt= txAPaterno.Text;
            AlumnosModificar.ApellidoMat= txAMaterno.Text;
            AlumnosModificar.Email= txEmail.Text;
            AlumnosModificar.NumeroMatricula = txNMatricula.Text;
            //llama al metodo de modificacion de la capa BLL
            string errorMessage;
            bool modificar = AlumnosBL.Modificar(AlumnosModificar, out errorMessage);
            // Informa al usuario si la operación fue exitosa o si ocurrió un error
            if (modificar)
            {
                MessageBox.Show("Alumno modificado correctamente");
                txNombre.Text = "";
                txAPaterno.Text = "";
                txAMaterno.Text = "";
                txEmail.Text = "";
                txNMatricula.Text = "";
            }
            else
            {
                MessageBox.Show("Error al modificar "+ errorMessage);
            }
        }
        /// <summary>
        /// Evento de clic para el botón de guardar.
        /// Determina si se debe crear un nuevo alumno o modificar uno existente,
        /// y luego actualiza la lista de alumnos.
        /// </summary>
        private void bGuardar_Click(object sender, EventArgs e)
        {
            //Si no hay alumno seleccionado se crea uno nuevo
            if (IdGlobal == null)
            {
                GuardarAlumno();
                
            }
            else // si hay almuno seleccionado se modifica  
            {
                ModificarAlumno();
                IdGlobal = null;
            }
            // Actualiza la lista de usuarios en el DataGridView
            ListarAlumnos();
        }

        private void Alumnos_Load(object sender, EventArgs e)
        {        
            ListarAlumnos();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idAlum = Convert.ToInt32(dtAlumnos.SelectedRows[0].Cells[0].Value);

            string errorMessage;
            bool eliminar = AlumnosBL.Eliminar(idAlum, out errorMessage);

            if (eliminar)
            {
                MessageBox.Show("Alumno eliminado");

            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar" + errorMessage);
            }
            ListarAlumnos();
        }
        /// <summary>
        ///  Evento de clic para el menú contextual "Modificar". Carga al alumno
        /// seleccionada en los campos del formulario para su edición.
        /// </summary>

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Obtiene la id del alumno seleccionado y carga sus datos en los campos de edición   
            int idAlum = Convert.ToInt32(dtAlumnos.SelectedRows[0].Cells[0].Value);
            IdGlobal = idAlum;  
            AlumnosBOL AlumnoModificar = AlumnosBL.SeleccionarUno(idAlum);
            // Muestra los datos del alumno seleccionado en los campos de texto
            txNombre.Text = AlumnoModificar.Nombre;
            txAPaterno.Text = AlumnoModificar.ApellidoPAt;
            txAMaterno.Text = AlumnoModificar.ApellidoMat;
            txEmail.Text = AlumnoModificar.Email;
            txNMatricula.Text = AlumnoModificar.NumeroMatricula;                    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CRUDWeb.WebServices_CRUD ws = new CRUDWeb.WebServices_CRUD();
            List<CRUDWeb.Alumnos> lista = new List<CRUDWeb.Alumnos>();
            lista = ws.listarAlumnos().ToList();
            string errorMessage;
            foreach (var item in lista)
            {
                CRUDBOL.AlumnosBOL alumnoBOL = new CRUDBOL.AlumnosBOL
                {
                    Nombre= item.Nombre,
                    ApellidoPAt = item.ApellidoPAt,
                    ApellidoMat=item.ApellidoMat,
                    Email=item.Email,
                    NumeroMatricula=item.NumeroMatricula
                };
                AlumnosBL.Insertar(alumnoBOL, out errorMessage);          
            }
            ListarAlumnos();
        }
    }
}
