namespace RTCONSTRUCCIONES.Catalogo
{
    partial class frmEmpleado
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
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.lblIdCargo = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtIdTipo = new System.Windows.Forms.TextBox();
            this.lblIdTipo = new System.Windows.Forms.Label();
            this.lblPrimerNombre = new System.Windows.Forms.Label();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.lblSegundoNombre = new System.Windows.Forms.Label();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.txtINSS = new System.Windows.Forms.TextBox();
            this.lblINSS = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtIdCargo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.btnValidarCodigos = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Enabled = false;
            this.txtIdEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEmpleado.Location = new System.Drawing.Point(238, 95);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(218, 26);
            this.txtIdEmpleado.TabIndex = 15;
            this.txtIdEmpleado.Text = "Codigo";
            this.txtIdEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIdCargo
            // 
            this.lblIdCargo.AutoSize = true;
            this.lblIdCargo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblIdCargo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIdCargo.Enabled = false;
            this.lblIdCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCargo.Location = new System.Drawing.Point(68, 94);
            this.lblIdCargo.Name = "lblIdCargo";
            this.lblIdCargo.Size = new System.Drawing.Size(151, 27);
            this.lblIdCargo.TabIndex = 14;
            this.lblIdCargo.Text = "Id Empleado:";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmpleado.Enabled = false;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(414, 26);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(118, 27);
            this.lblEmpleado.TabIndex = 16;
            this.lblEmpleado.Text = "Empleado";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(402, 431);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 28);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(585, 431);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 28);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(238, 432);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 28);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTipo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTipo.Enabled = false;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTipo.Location = new System.Drawing.Point(153, 363);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(66, 28);
            this.lblTipo.TabIndex = 19;
            this.lblTipo.Text = "Tipo:";
            // 
            // txtIdTipo
            // 
            this.txtIdTipo.Enabled = false;
            this.txtIdTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdTipo.Location = new System.Drawing.Point(238, 315);
            this.txtIdTipo.Name = "txtIdTipo";
            this.txtIdTipo.Size = new System.Drawing.Size(218, 26);
            this.txtIdTipo.TabIndex = 18;
            this.txtIdTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIdTipo
            // 
            this.lblIdTipo.AutoSize = true;
            this.lblIdTipo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblIdTipo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIdTipo.Enabled = false;
            this.lblIdTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblIdTipo.Location = new System.Drawing.Point(12, 313);
            this.lblIdTipo.Name = "lblIdTipo";
            this.lblIdTipo.Size = new System.Drawing.Size(207, 28);
            this.lblIdTipo.TabIndex = 17;
            this.lblIdTipo.Text = "Id Tipo Empleado:";
            // 
            // lblPrimerNombre
            // 
            this.lblPrimerNombre.AutoSize = true;
            this.lblPrimerNombre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPrimerNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrimerNombre.Enabled = false;
            this.lblPrimerNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerNombre.Location = new System.Drawing.Point(42, 145);
            this.lblPrimerNombre.Name = "lblPrimerNombre";
            this.lblPrimerNombre.Size = new System.Drawing.Size(177, 27);
            this.lblPrimerNombre.TabIndex = 25;
            this.lblPrimerNombre.Text = "Primer Nombre:";
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.AcceptsTab = true;
            this.txtPrimerNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimerNombre.Location = new System.Drawing.Point(238, 146);
            this.txtPrimerNombre.MaxLength = 20;
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(218, 26);
            this.txtPrimerNombre.TabIndex = 1;
            this.txtPrimerNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.AcceptsTab = true;
            this.txtSegundoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundoNombre.Location = new System.Drawing.Point(709, 146);
            this.txtSegundoNombre.MaxLength = 20;
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(218, 26);
            this.txtSegundoNombre.TabIndex = 2;
            this.txtSegundoNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSegundoNombre
            // 
            this.lblSegundoNombre.AutoSize = true;
            this.lblSegundoNombre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSegundoNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSegundoNombre.Enabled = false;
            this.lblSegundoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoNombre.Location = new System.Drawing.Point(487, 145);
            this.lblSegundoNombre.Name = "lblSegundoNombre";
            this.lblSegundoNombre.Size = new System.Drawing.Size(202, 27);
            this.lblSegundoNombre.TabIndex = 27;
            this.lblSegundoNombre.Text = "Segundo Nombre:";
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.AcceptsTab = true;
            this.txtPrimerApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimerApellido.Location = new System.Drawing.Point(238, 201);
            this.txtPrimerApellido.MaxLength = 20;
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(218, 26);
            this.txtPrimerApellido.TabIndex = 3;
            this.txtPrimerApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPrimerApellido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrimerApellido.Enabled = false;
            this.lblPrimerApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerApellido.Location = new System.Drawing.Point(38, 200);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(181, 27);
            this.lblPrimerApellido.TabIndex = 29;
            this.lblPrimerApellido.Text = "Primer Apellido:";
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.AcceptsTab = true;
            this.txtSegundoApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundoApellido.Location = new System.Drawing.Point(709, 201);
            this.txtSegundoApellido.MaxLength = 20;
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(218, 26);
            this.txtSegundoApellido.TabIndex = 4;
            this.txtSegundoApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSegundoApellido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSegundoApellido.Enabled = false;
            this.lblSegundoApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoApellido.Location = new System.Drawing.Point(483, 201);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(206, 27);
            this.lblSegundoApellido.TabIndex = 31;
            this.lblSegundoApellido.Text = "Segundo Apellido:";
            // 
            // txtINSS
            // 
            this.txtINSS.AcceptsTab = true;
            this.txtINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtINSS.Location = new System.Drawing.Point(238, 260);
            this.txtINSS.MaxLength = 10;
            this.txtINSS.Name = "txtINSS";
            this.txtINSS.Size = new System.Drawing.Size(218, 26);
            this.txtINSS.TabIndex = 5;
            this.txtINSS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblINSS
            // 
            this.lblINSS.AutoSize = true;
            this.lblINSS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblINSS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblINSS.Enabled = false;
            this.lblINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblINSS.Location = new System.Drawing.Point(146, 260);
            this.lblINSS.Name = "lblINSS";
            this.lblINSS.Size = new System.Drawing.Size(73, 27);
            this.lblINSS.TabIndex = 33;
            this.lblINSS.Text = "INSS:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(238, 365);
            this.cmbTipo.MaxLength = 50;
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(218, 26);
            this.cmbTipo.TabIndex = 6;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCargo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCargo.Enabled = false;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblCargo.Location = new System.Drawing.Point(604, 361);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(85, 28);
            this.lblCargo.TabIndex = 38;
            this.lblCargo.Text = "Cargo:";
            // 
            // txtIdCargo
            // 
            this.txtIdCargo.AcceptsTab = true;
            this.txtIdCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCargo.Location = new System.Drawing.Point(709, 313);
            this.txtIdCargo.Name = "txtIdCargo";
            this.txtIdCargo.Size = new System.Drawing.Size(218, 26);
            this.txtIdCargo.TabIndex = 7;
            this.txtIdCargo.Text = "Codigo";
            this.txtIdCargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdCargo.Validating += new System.ComponentModel.CancelEventHandler(this.txtIdCargo_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(577, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 28);
            this.label2.TabIndex = 36;
            this.label2.Text = "Id Cargo:";
            // 
            // txtCargo
            // 
            this.txtCargo.Enabled = false;
            this.txtCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.Location = new System.Drawing.Point(709, 365);
            this.txtCargo.MaxLength = 50;
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(218, 26);
            this.txtCargo.TabIndex = 39;
            this.txtCargo.TabStop = false;
            this.txtCargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnValidarCodigos
            // 
            this.btnValidarCodigos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidarCodigos.Location = new System.Drawing.Point(797, 397);
            this.btnValidarCodigos.Name = "btnValidarCodigos";
            this.btnValidarCodigos.Size = new System.Drawing.Size(130, 28);
            this.btnValidarCodigos.TabIndex = 8;
            this.btnValidarCodigos.Text = "Validar codigos";
            this.btnValidarCodigos.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmEmpleado
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(951, 515);
            this.Controls.Add(this.btnValidarCodigos);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.txtIdCargo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtINSS);
            this.Controls.Add(this.lblINSS);
            this.Controls.Add(this.txtSegundoApellido);
            this.Controls.Add(this.lblSegundoApellido);
            this.Controls.Add(this.txtPrimerApellido);
            this.Controls.Add(this.lblPrimerApellido);
            this.Controls.Add(this.txtSegundoNombre);
            this.Controls.Add(this.lblSegundoNombre);
            this.Controls.Add(this.txtPrimerNombre);
            this.Controls.Add(this.lblPrimerNombre);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtIdTipo);
            this.Controls.Add(this.lblIdTipo);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.txtIdEmpleado);
            this.Controls.Add(this.lblIdCargo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmpleado";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmpleado";
            this.Load += new System.EventHandler(this.frmEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.Label lblIdCargo;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtIdTipo;
        private System.Windows.Forms.Label lblIdTipo;
        private System.Windows.Forms.Label lblPrimerNombre;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.Label lblSegundoNombre;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.TextBox txtINSS;
        private System.Windows.Forms.Label lblINSS;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtIdCargo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Button btnValidarCodigos;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}