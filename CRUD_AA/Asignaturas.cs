using CRUDBL;
using CRUDBOL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_AA
{
    /// <summary>
    /// Formulario para gestionar las asignaturas en el sistema 
    /// Permite listar, guardar, modificar y eliminar asignaturas.
    /// </summary>
    public partial class Asignaturas : Form
    {
        int? IdGlobal; // Idenificador global para la asignatura seleccionada   
   
        public Asignaturas()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Lista las asignaturas y la muestra en el DataGridView.
        /// </summary>
        private void ListarAsignaturas()
        {
            //LLama el metodo de seleccion de asignaturas de la capa BLL
            List<AsignaturasBOL> asignaturas = AsignaturasBL.SeleccionarTodasAsignaturas();
            dtAsignaturas.DataSource = asignaturas; // muestra en la DataGridView.
        }

        /// <summary>
        /// Guarda una nueva asignatura en la base de datos
        /// Valida todos los campos antes de realizar inserciones 
        /// </summary>
        private void GuardarAsig()
        {
            // Crea una nueva instancia de AsignaturasBOL para almacenar los datos de la asignatura
            AsignaturasBOL asignatura = new AsignaturasBOL();
            if (string.IsNullOrWhiteSpace(txNAsignatura.Text))
            {
                MessageBox.Show("El nombre de la asignatura no puede estar en blanco.");
                txNAsignatura.Focus();
                return;
            }
          
            if (string.IsNullOrWhiteSpace(txCreditos.Text))
            {
                MessageBox.Show("El campo de créditos no puede estar en blanco.");
                txCreditos.Focus();
                return;
            }
          
            int creditos;
            if (!int.TryParse(txCreditos.Text, out creditos) || creditos <= 0)
            {
                MessageBox.Show("El campo de créditos debe contener un número entero válido mayor que 0.");
                txCreditos.Focus();
                return;
            }

                // Asigna los valores de los campos al objeto asignatura
                asignatura.NombreAsignatura = txNAsignatura.Text;
                asignatura.Creditos = Convert.ToInt32(txCreditos.Text);
                // Llama al método de la capa de lógica de negocio para insertar la asignatura
                string errorMessage;
                bool res = AsignaturasBL.InsertarAsignatura(asignatura, out errorMessage);

            int creditosw= Convert.ToInt32(txCreditos.Text);
            // la cosa con web
            CRUDWeb.WebServices_CRUD ws = new CRUDWeb.WebServices_CRUD();
            ws.GuardarAsignaturas(txNAsignatura.Text, creditosw);
            // Informa al usuario si la operación fue exitosa o si ocurrió un error
            if (res)
            {
                  MessageBox.Show("Asignatura guardada exitosamente.");
                  txNAsignatura.Text = "";
                  txCreditos.Text = "";
            }
            else
            {
                MessageBox.Show($"Ocurrió un error al guardar la asignatura: {errorMessage}");
            }
                    
        }

        /// <summary>
        /// Modifica una asignatura existente en la base de datos
        /// Valida todos los campos antes de realizar modificaciones
        /// </summary>

        private void Modificar()
        {
            if (string.IsNullOrWhiteSpace(txNAsignatura.Text))
            {
                MessageBox.Show("El nombre de la asignatura no puede estar en blanco.");
                txNAsignatura.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txCreditos.Text))
            {
                MessageBox.Show("El campo de créditos no puede estar en blanco.");
                txCreditos.Focus();
                return;
            }

            int creditos;
            if (!int.TryParse(txCreditos.Text, out creditos) || creditos <= 0)
            {
                MessageBox.Show("El campo de créditos debe contener un número entero válido mayor que 0.");
                txCreditos.Focus();
                return;
            }
            // Obtiene el código de la asignatura seleccionada y carga sus datos
            int codigo = (int)IdGlobal;
           
            AsignaturasBOL AsignaturaModificar = AsignaturasBL.SeleccionarUnaAsignatura(codigo);
            AsignaturaModificar.NombreAsignatura = txNAsignatura.Text;
            AsignaturaModificar.Creditos = Convert.ToInt32(txCreditos.Text);
            // Llama al método de la capa de lógica de negocio para modificar la asignatura
            string errorMessage;                     
            bool modificar =AsignaturasBL.ModificarAsignatura(AsignaturaModificar, out errorMessage);
            // Informa al usuario si la operación fue exitosa o si ocurrió un error
            if (modificar)
            {
                MessageBox.Show("Asignatura modificada correctamente");
                 txNAsignatura.Text = "";
                 txCreditos.Text = "";
            }
            else
            {
                MessageBox.Show("Error al modificar"+errorMessage);
            }        
        }
        /// <summary>
        /// Evento de clic para el botón de guardar.
        /// Determina si se debe crear una nueva asignatura o modificar una existente,
        /// y luego actualiza la lista de asignaturas.
        /// </summary>
        private void bGuardar_Click(object sender, EventArgs e)
        {
            // Si no hay asignatura seleccionada, se guarda una nueva
            if (IdGlobal==null)
            {
                GuardarAsig();
            }
            else // Si hay asignatura seleccionada, se modifica la existente
            {
                Modificar();
            }
            // Actualiza la lista de asignaturas en el DataGridView
            ListarAsignaturas();
        }

        private void Asignaturas_Load(object sender, EventArgs e)
        {
            // Carga los datos de la tabla asignaturas al DataGridView
            this.asignaturasTableAdapter.Fill(this.cRUDDataSet1.Asignaturas);
            ListarAsignaturas();
        }
        /// <summary>
        /// Evento de clic para el menú contextual "Modificar". Carga la asignatura
        /// seleccionada en los campos del formulario para su edición.
        /// </summary>
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Obtiene el código de la asignatura seleccionada y carga sus datos en los campos de edición   
            int codigoAsig = Convert.ToInt32(dtAsignaturas.SelectedRows[0].Cells[0].Value);        
            IdGlobal = codigoAsig;
            AsignaturasBOL AsignaturaModificar =  AsignaturasBL.SeleccionarUnaAsignatura(codigoAsig);
            // Muestra los datos de la asignatura seleccionada en los campos de texto
            txNAsignatura.Text = AsignaturaModificar.NombreAsignatura;
            txCreditos.Text = Convert.ToString(AsignaturaModificar.Creditos);          
        }
        /// <summary>
        /// Evento de clic para el menú contextual "Eliminar". Elimina la asignatura seleccionada
        /// de la base de datos y actualiza la lista en el DataGridView.
        /// </summary>
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Obtiene el código de la asignatura seleccionada y llama a la capa de lógica de negocio para eliminarla
            int codigoAsig = Convert.ToInt32(dtAsignaturas.SelectedRows[0].Cells[0].Value);
            string errorMessage;
            bool eliminar = AsignaturasBL.EliminarAsignatura(codigoAsig,out errorMessage);
            // Informa al usuario si la operación fue exitosa o si ocurrió un error
            if (eliminar)
            {
                MessageBox.Show("Asignatura eliminada");

            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar"+ errorMessage);
            }
            // Actualiza la lista de asignaturas en el DataGridView
            ListarAsignaturas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CRUDWeb.WebServices_CRUD ws = new CRUDWeb.WebServices_CRUD();
            List<CRUDWeb.Asignaturas> lista = new List<CRUDWeb.Asignaturas>();
            lista=ws.listarAsignaturas().ToList();
            string errorMessage;
            foreach (var item in lista)
            {
                CRUDBOL.AsignaturasBOL asignaturasBOL = new CRUDBOL.AsignaturasBOL
                {
                  NombreAsignatura  =item.NombreAsignatura,
                  Creditos =item.Creditos
                };
                AsignaturasBL.InsertarAsignatura(asignaturasBOL, out errorMessage);
            }
            ListarAsignaturas();
        }
    }
}
