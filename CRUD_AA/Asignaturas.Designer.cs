namespace CRUD_AA
{
    partial class Asignaturas
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
            this.txCreditos = new System.Windows.Forms.TextBox();
            this.Creditos = new System.Windows.Forms.Label();
            this.txNAsignatura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtAsignaturas = new System.Windows.Forms.DataGridView();
            this.codigoAsignaturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreAsignaturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignaturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cRUDDataSet1 = new CRUD_AA.CRUDDataSet1();
            this.cRUDDataSet = new CRUD_AA.CRUDDataSet();
            this.cRUDDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cRUDDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cRUDDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.asignaturasTableAdapter = new CRUD_AA.CRUDDataSet1TableAdapters.AsignaturasTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtAsignaturas)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUDDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUDDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUDDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUDDataSetBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bGuardar);
            this.groupBox1.Controls.Add(this.txCreditos);
            this.groupBox1.Controls.Add(this.Creditos);
            this.groupBox1.Controls.Add(this.txNAsignatura);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 312);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar Asignatura";
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(200, 149);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(75, 23);
            this.bGuardar.TabIndex = 4;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // txCreditos
            // 
            this.txCreditos.Location = new System.Drawing.Point(102, 73);
            this.txCreditos.Name = "txCreditos";
            this.txCreditos.Size = new System.Drawing.Size(100, 22);
            this.txCreditos.TabIndex = 3;
            // 
            // Creditos
            // 
            this.Creditos.AutoSize = true;
            this.Creditos.Location = new System.Drawing.Point(22, 80);
            this.Creditos.Name = "Creditos";
            this.Creditos.Size = new System.Drawing.Size(60, 16);
            this.Creditos.TabIndex = 2;
            this.Creditos.Text = "Creditos:";
            // 
            // txNAsignatura
            // 
            this.txNAsignatura.Location = new System.Drawing.Point(155, 29);
            this.txNAsignatura.Name = "txNAsignatura";
            this.txNAsignatura.Size = new System.Drawing.Size(100, 22);
            this.txNAsignatura.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Asignatura: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtAsignaturas);
            this.groupBox2.Location = new System.Drawing.Point(413, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 235);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista Asignaturas";
            // 
            // dtAsignaturas
            // 
            this.dtAsignaturas.AllowUserToAddRows = false;
            this.dtAsignaturas.AllowUserToDeleteRows = false;
            this.dtAsignaturas.AutoGenerateColumns = false;
            this.dtAsignaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAsignaturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoAsignaturaDataGridViewTextBoxColumn,
            this.nombreAsignaturaDataGridViewTextBoxColumn,
            this.creditosDataGridViewTextBoxColumn});
            this.dtAsignaturas.ContextMenuStrip = this.contextMenuStrip1;
            this.dtAsignaturas.DataSource = this.asignaturasBindingSource;
            this.dtAsignaturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtAsignaturas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtAsignaturas.Location = new System.Drawing.Point(3, 18);
            this.dtAsignaturas.Name = "dtAsignaturas";
            this.dtAsignaturas.ReadOnly = true;
            this.dtAsignaturas.RowHeadersWidth = 51;
            this.dtAsignaturas.RowTemplate.Height = 24;
            this.dtAsignaturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtAsignaturas.Size = new System.Drawing.Size(301, 214);
            this.dtAsignaturas.TabIndex = 0;
            // 
            // codigoAsignaturaDataGridViewTextBoxColumn
            // 
            this.codigoAsignaturaDataGridViewTextBoxColumn.DataPropertyName = "CodigoAsignatura";
            this.codigoAsignaturaDataGridViewTextBoxColumn.HeaderText = "CodigoAsignatura";
            this.codigoAsignaturaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoAsignaturaDataGridViewTextBoxColumn.Name = "codigoAsignaturaDataGridViewTextBoxColumn";
            this.codigoAsignaturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoAsignaturaDataGridViewTextBoxColumn.Visible = false;
            this.codigoAsignaturaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreAsignaturaDataGridViewTextBoxColumn
            // 
            this.nombreAsignaturaDataGridViewTextBoxColumn.DataPropertyName = "NombreAsignatura";
            this.nombreAsignaturaDataGridViewTextBoxColumn.HeaderText = "Nombre Asignatura";
            this.nombreAsignaturaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreAsignaturaDataGridViewTextBoxColumn.Name = "nombreAsignaturaDataGridViewTextBoxColumn";
            this.nombreAsignaturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreAsignaturaDataGridViewTextBoxColumn.Width = 125;
            // 
            // creditosDataGridViewTextBoxColumn
            // 
            this.creditosDataGridViewTextBoxColumn.DataPropertyName = "Creditos";
            this.creditosDataGridViewTextBoxColumn.HeaderText = "Creditos";
            this.creditosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.creditosDataGridViewTextBoxColumn.Name = "creditosDataGridViewTextBoxColumn";
            this.creditosDataGridViewTextBoxColumn.ReadOnly = true;
            this.creditosDataGridViewTextBoxColumn.Width = 125;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(143, 52);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // asignaturasBindingSource
            // 
            this.asignaturasBindingSource.DataMember = "Asignaturas";
            this.asignaturasBindingSource.DataSource = this.cRUDDataSet1;
            // 
            // cRUDDataSet1
            // 
            this.cRUDDataSet1.DataSetName = "CRUDDataSet1";
            this.cRUDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cRUDDataSet
            // 
            this.cRUDDataSet.DataSetName = "CRUDDataSet";
            this.cRUDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cRUDDataSetBindingSource
            // 
            this.cRUDDataSetBindingSource.DataSource = this.cRUDDataSet;
            this.cRUDDataSetBindingSource.Position = 0;
            // 
            // cRUDDataSetBindingSource1
            // 
            this.cRUDDataSetBindingSource1.DataSource = this.cRUDDataSet;
            this.cRUDDataSetBindingSource1.Position = 0;
            // 
            // cRUDDataSetBindingSource2
            // 
            this.cRUDDataSetBindingSource2.DataSource = this.cRUDDataSet;
            this.cRUDDataSetBindingSource2.Position = 0;
            // 
            // asignaturasTableAdapter
            // 
            this.asignaturasTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Descargar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Asignaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 369);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Asignaturas";
            this.Text = "Asignaturas";
            this.Load += new System.EventHandler(this.Asignaturas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtAsignaturas)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.asignaturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUDDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUDDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUDDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUDDataSetBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtAsignaturas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.TextBox txCreditos;
        private System.Windows.Forms.Label Creditos;
        private System.Windows.Forms.TextBox txNAsignatura;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private CRUDDataSet cRUDDataSet;
        private System.Windows.Forms.BindingSource cRUDDataSetBindingSource;
        private System.Windows.Forms.BindingSource cRUDDataSetBindingSource1;
        private System.Windows.Forms.BindingSource cRUDDataSetBindingSource2;
        private CRUDDataSet1 cRUDDataSet1;
        private System.Windows.Forms.BindingSource asignaturasBindingSource;
        private CRUDDataSet1TableAdapters.AsignaturasTableAdapter asignaturasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoAsignaturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreAsignaturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditosDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}