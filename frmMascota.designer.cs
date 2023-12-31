﻿namespace ABMMascotas
{
    partial class frmMascota
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cboEspecie = new System.Windows.Forms.ComboBox();
            this.rbtMacho = new System.Windows.Forms.RadioButton();
            this.rbtHembra = new System.Windows.Forms.RadioButton();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lstMascotas = new System.Windows.Forms.ListBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvMascota = new System.Windows.Forms.DataGridView();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascota)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(77, 36);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(73, 81);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Location = new System.Drawing.Point(72, 126);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(45, 13);
            this.lblEspecie.TabIndex = 2;
            this.lblEspecie.Text = "Especie";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(86, 171);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 3;
            this.lblSexo.Text = "Sexo";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(24, 216);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(93, 13);
            this.lblFechaNacimiento.TabIndex = 4;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(160, 35);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(57, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(160, 79);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(163, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // cboEspecie
            // 
            this.cboEspecie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEspecie.FormattingEnabled = true;
            this.cboEspecie.Location = new System.Drawing.Point(160, 123);
            this.cboEspecie.Name = "cboEspecie";
            this.cboEspecie.Size = new System.Drawing.Size(163, 21);
            this.cboEspecie.TabIndex = 2;
            this.cboEspecie.SelectedIndexChanged += new System.EventHandler(this.cboEspecie_SelectedIndexChanged);
            // 
            // rbtMacho
            // 
            this.rbtMacho.AutoSize = true;
            this.rbtMacho.Location = new System.Drawing.Point(160, 169);
            this.rbtMacho.Name = "rbtMacho";
            this.rbtMacho.Size = new System.Drawing.Size(73, 17);
            this.rbtMacho.TabIndex = 3;
            this.rbtMacho.TabStop = true;
            this.rbtMacho.Text = "1 - Macho";
            this.rbtMacho.UseVisualStyleBackColor = true;
            // 
            // rbtHembra
            // 
            this.rbtHembra.AutoSize = true;
            this.rbtHembra.Location = new System.Drawing.Point(248, 169);
            this.rbtHembra.Name = "rbtHembra";
            this.rbtHembra.Size = new System.Drawing.Size(77, 17);
            this.rbtHembra.TabIndex = 4;
            this.rbtHembra.TabStop = true;
            this.rbtHembra.Text = "2 - Hembra";
            this.rbtHembra.UseVisualStyleBackColor = true;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(160, 210);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(97, 20);
            this.dtpFechaNacimiento.TabIndex = 5;
            // 
            // lstMascotas
            // 
            this.lstMascotas.FormattingEnabled = true;
            this.lstMascotas.Location = new System.Drawing.Point(370, 30);
            this.lstMascotas.Name = "lstMascotas";
            this.lstMascotas.Size = new System.Drawing.Size(166, 199);
            this.lstMascotas.TabIndex = 9;
            this.lstMascotas.SelectedIndexChanged += new System.EventHandler(this.lstMascotas_SelectedIndexChanged);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 251);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(85, 34);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Enabled = false;
            this.btnBorrar.Location = new System.Drawing.Point(194, 251);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(85, 34);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(467, 251);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 34);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvMascota
            // 
            this.dgvMascota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMascota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sexo,
            this.nombre,
            this.Especies,
            this.fechaNacimiento});
            this.dgvMascota.Location = new System.Drawing.Point(576, 30);
            this.dgvMascota.Name = "dgvMascota";
            this.dgvMascota.Size = new System.Drawing.Size(545, 255);
            this.dgvMascota.TabIndex = 10;
            // 
            // sexo
            // 
            this.sexo.HeaderText = "Sexos";
            this.sexo.Name = "sexo";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombres";
            this.nombre.Name = "nombre";
            // 
            // Especies
            // 
            this.Especies.HeaderText = "Especies";
            this.Especies.Name = "Especies";
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.HeaderText = "Fecha nacimiento";
            this.fechaNacimiento.Name = "fechaNacimiento";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(103, 251);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(85, 34);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(285, 251);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(85, 34);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(376, 251);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 34);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 312);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvMascota);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lstMascotas);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.rbtHembra);
            this.Controls.Add(this.rbtMacho);
            this.Controls.Add(this.cboEspecie);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblEspecie);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Name = "frmMascota";
            this.Text = "Mascotas";
            this.Load += new System.EventHandler(this.frmMascota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cboEspecie;
        private System.Windows.Forms.RadioButton rbtMacho;
        private System.Windows.Forms.RadioButton rbtHembra;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.ListBox lstMascotas;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especies;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimiento;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}

