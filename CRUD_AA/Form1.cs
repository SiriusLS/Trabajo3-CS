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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Alumnos fromAlumnos;
        private Asignaturas fromAsignatura;
        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fromAlumnos == null || fromAlumnos.IsDisposed)
            {
                fromAlumnos = new Alumnos();
                fromAlumnos.MdiParent = this;

                // Ajustar el tamaño del formulario hijo para que ocupe todo el espacio
                fromAlumnos.Dock = DockStyle.Fill; // Ocupar todo el espacio disponible
                fromAlumnos.StartPosition = FormStartPosition.Manual; // Asegúrate de que la posición sea manual
                fromAlumnos.Location = new Point(0, 0); // Establece la ubicación en la esquina superior izquierda

                // Configuración para evitar que el usuario mueva el formulario hijo
                fromAlumnos.FormBorderStyle = FormBorderStyle.FixedSingle; // Cambiar el estilo del borde
                fromAlumnos.MaximizeBox = false; // Desactivar el botón de maximizar
                fromAlumnos.MinimizeBox = false; // Desactivar el botón de minimizar

                fromAlumnos.Show();
            }
            else
            {
                fromAlumnos.Activate();
            }
        }

        private void asignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fromAsignatura == null || fromAsignatura.IsDisposed)
            {
                fromAsignatura = new Asignaturas();
                fromAsignatura.MdiParent = this;

                // Ajustar el tamaño del formulario hijo para que ocupe todo el espacio
                fromAsignatura.Dock = DockStyle.Fill; // Ocupar todo el espacio disponible
                fromAsignatura.StartPosition = FormStartPosition.Manual; // Asegúrate de que la posición sea manual
                fromAsignatura.Location = new Point(0, 0); // Establece la ubicación en la esquina superior izquierda

                // Configuración para evitar que el usuario mueva el formulario hijo
                fromAsignatura.FormBorderStyle = FormBorderStyle.FixedSingle; // Cambiar el estilo del borde
                fromAsignatura.MaximizeBox = false; // Desactivar el botón de maximizar
                fromAsignatura.MinimizeBox = false; // Desactivar el botón de minimizar

                fromAsignatura.Show();
            }
            else
            {
                fromAsignatura.Activate();
            }
        }

       
    }
}
