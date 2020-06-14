namespace RTCONSTRUCCIONES.Catalogo
{
    partial class frmTipoEmpleado
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
            this.txtIdTipo = new System.Windows.Forms.TextBox();
            this.lblIdTipo = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTipoEmpleado = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdTipo
            // 
            this.txtIdTipo.Enabled = false;
            this.txtIdTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdTipo.Location = new System.Drawing.Point(126, 94);
            this.txtIdTipo.Name = "txtIdTipo";
            this.txtIdTipo.Size = new System.Drawing.Size(218, 26);
            this.txtIdTipo.TabIndex = 1;
            this.txtIdTipo.Text = "Codigo";
            this.txtIdTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdTipo.Validating += new System.ComponentModel.CancelEventHandler(this.txtIdTipo_Validating);
            // 
            // lblIdTipo
            // 
            this.lblIdTipo.AutoSize = true;
            this.lblIdTipo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblIdTipo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIdTipo.Enabled = false;
            this.lblIdTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblIdTipo.Location = new System.Drawing.Point(6, 89);
            this.lblIdTipo.Name = "lblIdTipo";
            this.lblIdTipo.Size = new System.Drawing.Size(93, 28);
            this.lblIdTipo.TabIndex = 4;
            this.lblIdTipo.Text = "Id Tipo:";
            // 
            // txtTipo
            // 
            this.txtTipo.AcceptsTab = true;
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(126, 149);
            this.txtTipo.MaxLength = 50;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(218, 26);
            this.txtTipo.TabIndex = 2;
            this.txtTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTipo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTipo.Enabled = false;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTipo.Location = new System.Drawing.Point(32, 145);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(66, 28);
            this.lblTipo.TabIndex = 6;
            this.lblTipo.Text = "Tipo:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(32, 211);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 28);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(320, 211);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 28);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblTipoEmpleado
            // 
            this.lblTipoEmpleado.AutoSize = true;
            this.lblTipoEmpleado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTipoEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTipoEmpleado.Enabled = false;
            this.lblTipoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoEmpleado.Location = new System.Drawing.Point(97, 9);
            this.lblTipoEmpleado.Name = "lblTipoEmpleado";
            this.lblTipoEmpleado.Size = new System.Drawing.Size(230, 31);
            this.lblTipoEmpleado.TabIndex = 10;
            this.lblTipoEmpleado.Text = "Tipo de empleado";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(126, 211);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 28);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(218, 211);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(83, 28);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmTipoEmpleado
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(862, 299);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblTipoEmpleado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtIdTipo);
            this.Controls.Add(this.lblIdTipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTipoEmpleado";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTipoEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdTipo;
        private System.Windows.Forms.Label lblIdTipo;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTipoEmpleado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnLimpiar;
    }
}