namespace CRUD_AA
{
    partial class Alumnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bGuardar = new System.Windows.Forms.Button();
            this.txNMatricula = new System.Windows.Forms.TextBox();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.txAMaterno = new System.Windows.Forms.TextBox();
            this.txAPaterno = new System.Windows.Forms.TextBox();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtAlumnos = new System.Windows.Forms.DataGridView();
            this.iDAlumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoPAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoMatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cRUDDataSet = new CRUD_AA.CRUDDataSet();
            this.alumnosTableAdapter = new CRUD_AA.CRUDDataSetTableAdapters.AlumnosTableAdapter();
            this.alumnosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlumnos)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bGuardar);
            this.groupBox1.Controls.Add(this.txNMatricula);
            this.groupBox1.Controls.Add(this.txEmail);
            this.groupBox1.Controls.Add(this.txAMaterno);
            this.groupBox1.Controls.Add(this.txAPaterno);
            this.groupBox1.Controls.Add(this.txNombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar Alumnos";
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(142, 174);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(112, 32);
            this.bGuardar.TabIndex = 10;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // txNMatricula
            // 
            this.txNMatricula.Location = new System.Drawing.Point(154, 146);
            this.txNMatricula.Name = "txNMatricula";
            this.txNMatricula.Size = new System.Drawing.Size(100, 22);
            this.txNMatricula.TabIndex = 9;
            // 
            // txEmail
            // 
            this.txEmail.Location = new System.Drawing.Point(154, 117);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(100, 22);
            this.txEmail.TabIndex = 8;
            // 
            // txAMaterno
            // 
            this.txAMaterno.Location = new System.Drawing.Point(151, 87);
            this.txAMaterno.Name = "txAMaterno";
            this.txAMaterno.Size = new System.Drawing.Size(100, 22);
            this.txAMaterno.TabIndex = 7;
            // 
            // txAPaterno
            // 
            this.txAPaterno.Location = new System.Drawing.Point(152, 60);
            this.txAPaterno.Name = "txAPaterno";
            this.txAPaterno.Size = new System.Drawing.Size(100, 22);
            this.txAPaterno.TabIndex = 6;
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(151, 28);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(100, 22);
            this.txNombre.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Número de Matrícula:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido Materno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido Paterno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtAlumnos);
            this.groupBox2.Location = new System.Drawing.Point(12, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(874, 244);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista Alumnos";
            // 
            // dtAlumnos
            // 
            this.dtAlumnos.AllowUserToAddRows = false;
            this.dtAlumnos.AllowUserToDeleteRows = false;
            this.dtAlumnos.AutoGenerateColumns = false;
            this.dtAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDAlumnoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoPAtDataGridViewTextBoxColumn,
            this.apellidoMatDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dtAlumnos.ContextMenuStrip = this.contextMenuStrip1;
            this.dtAlumnos.DataSource = this.alumnosBindingSource;
            this.dtAlumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtAlumnos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtAlumnos.Location = new System.Drawing.Point(3, 18);
            this.dtAlumnos.MultiSelect = false;
            this.dtAlumnos.Name = "dtAlumnos";
            this.dtAlumnos.ReadOnly = true;
            this.dtAlumnos.RowHeadersWidth = 51;
            this.dtAlumnos.RowTemplate.Height = 24;
            this.dtAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtAlumnos.Size = new System.Drawing.Size(868, 223);
            this.dtAlumnos.TabIndex = 0;
            // 
            // iDAlumnoDataGridViewTextBoxColumn
            // 
            this.iDAlumnoDataGridViewTextBoxColumn.DataPropertyName = "IDAlumno";
            this.iDAlumnoDataGridViewTextBoxColumn.HeaderText = "IDAlumno";
            this.iDAlumnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDAlumnoDataGridViewTextBoxColumn.Name = "iDAlumnoDataGridViewTextBoxColumn";
            this.iDAlumnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDAlumnoDataGridViewTextBoxColumn.Visible = false;
            this.iDAlumnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // apellidoPAtDataGridViewTextBoxColumn
            // 
            this.apellidoPAtDataGridViewTextBoxColumn.DataPropertyName = "ApellidoPAt";
            this.apellidoPAtDataGridViewTextBoxColumn.HeaderText = "Apellido Paterno";
            this.apellidoPAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apellidoPAtDataGridViewTextBoxColumn.Name = "apellidoPAtDataGridViewTextBoxColumn";
            this.apellidoPAtDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidoPAtDataGridViewTextBoxColumn.Width = 125;
            // 
            // apellidoMatDataGridViewTextBoxColumn
            // 
            this.apellidoMatDataGridViewTextBoxColumn.DataPropertyName = "ApellidoMat";
            this.apellidoMatDataGridViewTextBoxColumn.HeaderText = "Apellido Materno";
            this.apellidoMatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apellidoMatDataGridViewTextBoxColumn.Name = "apellidoMatDataGridViewTextBoxColumn";
            this.apellidoMatDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidoMatDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem,
            this.modificarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(143, 52);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // alumnosBindingSource
            // 
            this.alumnosBindingSource.DataMember = "Alumnos";
            this.alumnosBindingSource.DataSource = this.cRUDDataSet;
            // 
            // cRUDDataSet
            // 
            this.cRUDDataSet.DataSetName = "CRUDDataSet";
            this.cRUDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alumnosTableAdapter
            // 
            this.alumnosTableAdapter.ClearBeforeFill = true;
            // 
            // alumnosBindingSource1
            // 
            this.alumnosBindingSource1.DataMember = "Alumnos";
            this.alumnosBindingSource1.DataSource = this.cRUDDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Descargar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 663);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Alumnos";
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.Alumnos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtAlumnos)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.TextBox txNMatricula;
        private System.Windows.Forms.TextBox txEmail;
        private System.Windows.Forms.TextBox txAMaterno;
        private System.Windows.Forms.TextBox txAPaterno;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtAlumnos;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private CRUDDataSet cRUDDataSet;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private CRUDDataSetTableAdapters.AlumnosTableAdapter alumnosTableAdapter;
        private System.Windows.Forms.BindingSource alumnosBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAlumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoMatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn númeroDeMatrículaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}