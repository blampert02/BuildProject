namespace RTCONSTRUCCIONES.Catalogo
{
    partial class frmProductos
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
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNombreCat = new System.Windows.Forms.Label();
            this.txtIdCategoria = new System.Windows.Forms.TextBox();
            this.lblIdCategoria = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombreCat = new System.Windows.Forms.TextBox();
            this.btnValidarCodigo = new System.Windows.Forms.Button();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCantidad
            // 
            this.txtCantidad.AcceptsTab = true;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(275, 284);
            this.txtCantidad.MaxLength = 10;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(218, 26);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidad.Validating += new System.ComponentModel.CancelEventHandler(this.txtCantidad_Validating);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCantidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidad.Enabled = false;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(131, 283);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(115, 27);
            this.lblCantidad.TabIndex = 46;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEstado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEstado.Enabled = false;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(152, 224);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(94, 27);
            this.lblEstado.TabIndex = 44;
            this.lblEstado.Text = "Estado:";
            // 
            // txtNombre
            // 
            this.txtNombre.AcceptsTab = true;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(275, 170);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(218, 26);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;            
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombre.Enabled = false;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(144, 169);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(102, 27);
            this.lblNombre.TabIndex = 42;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblNombreCat
            // 
            this.lblNombreCat.AutoSize = true;
            this.lblNombreCat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNombreCat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreCat.Enabled = false;
            this.lblNombreCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblNombreCat.Location = new System.Drawing.Point(117, 387);
            this.lblNombreCat.Name = "lblNombreCat";
            this.lblNombreCat.Size = new System.Drawing.Size(129, 28);
            this.lblNombreCat.TabIndex = 41;
            this.lblNombreCat.Text = "Nombre C:";
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.AcceptsTab = true;
            this.txtIdCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCategoria.Location = new System.Drawing.Point(275, 339);
            this.txtIdCategoria.MaxLength = 20;
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.Size = new System.Drawing.Size(218, 26);
            this.txtIdCategoria.TabIndex = 4;
            this.txtIdCategoria.Text = "Codigo";
            this.txtIdCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIdCategoria
            // 
            this.lblIdCategoria.AutoSize = true;
            this.lblIdCategoria.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblIdCategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIdCategoria.Enabled = false;
            this.lblIdCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblIdCategoria.Location = new System.Drawing.Point(95, 337);
            this.lblIdCategoria.Name = "lblIdCategoria";
            this.lblIdCategoria.Size = new System.Drawing.Size(151, 28);
            this.lblIdCategoria.TabIndex = 39;
            this.lblIdCategoria.Text = "Id Categoria:";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProducto.Enabled = false;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(275, 26);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(108, 27);
            this.lblProducto.TabIndex = 38;
            this.lblProducto.Text = "Producto";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Enabled = false;
            this.txtIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProducto.Location = new System.Drawing.Point(275, 119);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(218, 26);
            this.txtIdProducto.TabIndex = 37;
            this.txtIdProducto.Text = "Codigo";
            this.txtIdProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblIdProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIdProducto.Enabled = false;
            this.lblIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProducto.Location = new System.Drawing.Point(105, 118);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(141, 27);
            this.lblIdProducto.TabIndex = 36;
            this.lblIdProducto.Text = "Id Producto:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(294, 454);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 28);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(410, 454);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 28);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(169, 454);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 28);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombreCat
            // 
            this.txtNombreCat.Enabled = false;
            this.txtNombreCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCat.Location = new System.Drawing.Point(275, 389);
            this.txtNombreCat.MaxLength = 50;
            this.txtNombreCat.Name = "txtNombreCat";
            this.txtNombreCat.Size = new System.Drawing.Size(218, 26);
            this.txtNombreCat.TabIndex = 52;
            this.txtNombreCat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnValidarCodigo
            // 
            this.btnValidarCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidarCodigo.Location = new System.Drawing.Point(508, 339);
            this.btnValidarCodigo.Name = "btnValidarCodigo";
            this.btnValidarCodigo.Size = new System.Drawing.Size(75, 28);
            this.btnValidarCodigo.TabIndex = 5;
            this.btnValidarCodigo.Text = "Validar";
            this.btnValidarCodigo.UseVisualStyleBackColor = true;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstado.Location = new System.Drawing.Point(275, 225);
            this.cmbEstado.MaxLength = 10;
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(218, 26);
            this.cmbEstado.TabIndex = 2;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(634, 532);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.btnValidarCodigo);
            this.Controls.Add(this.txtNombreCat);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNombreCat);
            this.Controls.Add(this.txtIdCategoria);
            this.Controls.Add(this.lblIdCategoria);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.lblIdProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProductos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProductos";            
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNombreCat;
        private System.Windows.Forms.TextBox txtIdCategoria;
        private System.Windows.Forms.Label lblIdCategoria;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombreCat;
        private System.Windows.Forms.Button btnValidarCodigo;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}