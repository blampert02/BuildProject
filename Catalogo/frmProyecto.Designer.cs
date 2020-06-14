namespace RTCONSTRUCCIONES.Catalogo
{
    partial class frmProyecto
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.lblNombreP = new System.Windows.Forms.Label();
            this.lblFechaFinalizacion = new System.Windows.Forms.Label();
            this.txtFechaInicio = new System.Windows.Forms.TextBox();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblNombreCat = new System.Windows.Forms.Label();
            this.txtIdCategoria = new System.Windows.Forms.TextBox();
            this.lblNombreB = new System.Windows.Forms.Label();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.txtIdProyecto = new System.Windows.Forms.TextBox();
            this.lblIdProyecto = new System.Windows.Forms.Label();
            this.lblNombreE = new System.Windows.Forms.Label();
            this.txtFechaFinalizacion = new System.Windows.Forms.TextBox();
            this.txtNombreB = new System.Windows.Forms.TextBox();
            this.txtNombreE = new System.Windows.Forms.TextBox();
            this.lblIdPlanilla = new System.Windows.Forms.Label();
            this.txtIdPlanilla = new System.Windows.Forms.TextBox();
            this.lblPlanilla = new System.Windows.Forms.Label();
            this.txtPresupuesto = new System.Windows.Forms.TextBox();
            this.lblPresupuesto = new System.Windows.Forms.Label();
            this.txtMontoACobrar = new System.Windows.Forms.TextBox();
            this.lblMontoACobrar = new System.Windows.Forms.Label();
            this.txtFueraPresup = new System.Windows.Forms.TextBox();
            this.lblFueraPresup = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(394, 646);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 28);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(510, 646);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 28);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(280, 646);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 28);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombreP
            // 
            this.txtNombreP.AcceptsTab = true;
            this.txtNombreP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreP.Location = new System.Drawing.Point(300, 250);
            this.txtNombreP.MaxLength = 50;
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(316, 26);
            this.txtNombreP.TabIndex = 3;
            this.txtNombreP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNombreP.TextChanged += new System.EventHandler(this.txtNombreP_TextChanged);
            // 
            // lblNombreP
            // 
            this.lblNombreP.AutoSize = true;
            this.lblNombreP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNombreP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreP.Enabled = false;
            this.lblNombreP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreP.Location = new System.Drawing.Point(69, 249);
            this.lblNombreP.Name = "lblNombreP";
            this.lblNombreP.Size = new System.Drawing.Size(202, 27);
            this.lblNombreP.TabIndex = 62;
            this.lblNombreP.Text = "Nombre Proyecto:";
            // 
            // lblFechaFinalizacion
            // 
            this.lblFechaFinalizacion.AutoSize = true;
            this.lblFechaFinalizacion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFechaFinalizacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFechaFinalizacion.Enabled = false;
            this.lblFechaFinalizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinalizacion.Location = new System.Drawing.Point(51, 191);
            this.lblFechaFinalizacion.Name = "lblFechaFinalizacion";
            this.lblFechaFinalizacion.Size = new System.Drawing.Size(220, 27);
            this.lblFechaFinalizacion.TabIndex = 60;
            this.lblFechaFinalizacion.Text = "Fecha Finalizacion:";
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.AcceptsTab = true;
            this.txtFechaInicio.AccessibleDescription = "";
            this.txtFechaInicio.AccessibleName = "";
            this.txtFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaInicio.Location = new System.Drawing.Point(300, 136);
            this.txtFechaInicio.MaxLength = 10;
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(316, 26);
            this.txtFechaInicio.TabIndex = 1;
            this.txtFechaInicio.Tag = "";
            this.txtFechaInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFechaInicio.Validating += new System.ComponentModel.CancelEventHandler(this.txtFechaInicio_Validating);
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFechaInicio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFechaInicio.Enabled = false;
            this.lblFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.Location = new System.Drawing.Point(120, 136);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(149, 27);
            this.lblFechaInicio.TabIndex = 58;
            this.lblFechaInicio.Text = "Fecha Inicio:";
            // 
            // lblNombreCat
            // 
            this.lblNombreCat.AutoSize = true;
            this.lblNombreCat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNombreCat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreCat.Enabled = false;
            this.lblNombreCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblNombreCat.Location = new System.Drawing.Point(10, 355);
            this.lblNombreCat.Name = "lblNombreCat";
            this.lblNombreCat.Size = new System.Drawing.Size(261, 28);
            this.lblNombreCat.TabIndex = 57;
            this.lblNombreCat.Text = "Id Empleado Asignado:";
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.AcceptsTab = true;
            this.txtIdCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCategoria.Location = new System.Drawing.Point(300, 358);
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.Size = new System.Drawing.Size(316, 26);
            this.txtIdCategoria.TabIndex = 5;
            this.txtIdCategoria.Text = "Codigo";
            this.txtIdCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNombreB
            // 
            this.lblNombreB.AutoSize = true;
            this.lblNombreB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNombreB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreB.Enabled = false;
            this.lblNombreB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblNombreB.Location = new System.Drawing.Point(78, 304);
            this.lblNombreB.Name = "lblNombreB";
            this.lblNombreB.Size = new System.Drawing.Size(193, 28);
            this.lblNombreB.TabIndex = 55;
            this.lblNombreB.Text = "Nombre Bodega:";
            // 
            // lblProyecto
            // 
            this.lblProyecto.AutoSize = true;
            this.lblProyecto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblProyecto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProyecto.Enabled = false;
            this.lblProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProyecto.Location = new System.Drawing.Point(400, 21);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(118, 31);
            this.lblProyecto.TabIndex = 54;
            this.lblProyecto.Text = "Proyecto";
            // 
            // txtIdProyecto
            // 
            this.txtIdProyecto.Enabled = false;
            this.txtIdProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProyecto.Location = new System.Drawing.Point(300, 85);
            this.txtIdProyecto.Name = "txtIdProyecto";
            this.txtIdProyecto.Size = new System.Drawing.Size(316, 26);
            this.txtIdProyecto.TabIndex = 53;
            this.txtIdProyecto.Text = "Codigo";
            this.txtIdProyecto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIdProyecto
            // 
            this.lblIdProyecto.AutoSize = true;
            this.lblIdProyecto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblIdProyecto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIdProyecto.Enabled = false;
            this.lblIdProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProyecto.Location = new System.Drawing.Point(130, 84);
            this.lblIdProyecto.Name = "lblIdProyecto";
            this.lblIdProyecto.Size = new System.Drawing.Size(140, 27);
            this.lblIdProyecto.TabIndex = 52;
            this.lblIdProyecto.Text = "Id Proyecto:";
            // 
            // lblNombreE
            // 
            this.lblNombreE.AutoSize = true;
            this.lblNombreE.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNombreE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreE.Enabled = false;
            this.lblNombreE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblNombreE.Location = new System.Drawing.Point(50, 413);
            this.lblNombreE.Name = "lblNombreE";
            this.lblNombreE.Size = new System.Drawing.Size(219, 28);
            this.lblNombreE.TabIndex = 68;
            this.lblNombreE.Text = "Nombre Empleado:";
            // 
            // txtFechaFinalizacion
            // 
            this.txtFechaFinalizacion.AcceptsTab = true;
            this.txtFechaFinalizacion.AccessibleDescription = "YYYY-MM-DD";
            this.txtFechaFinalizacion.AccessibleName = "YYYY-MM-DD";
            this.txtFechaFinalizacion.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.txtFechaFinalizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaFinalizacion.Location = new System.Drawing.Point(300, 192);
            this.txtFechaFinalizacion.MaxLength = 10;
            this.txtFechaFinalizacion.Name = "txtFechaFinalizacion";
            this.txtFechaFinalizacion.Size = new System.Drawing.Size(316, 26);
            this.txtFechaFinalizacion.TabIndex = 2;
            this.txtFechaFinalizacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFechaFinalizacion.Validating += new System.ComponentModel.CancelEventHandler(this.txtFechaFinalizacion_Validating);
            // 
            // txtNombreB
            // 
            this.txtNombreB.AcceptsTab = true;
            this.txtNombreB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreB.Location = new System.Drawing.Point(300, 304);
            this.txtNombreB.MaxLength = 20;
            this.txtNombreB.Name = "txtNombreB";
            this.txtNombreB.Size = new System.Drawing.Size(316, 26);
            this.txtNombreB.TabIndex = 4;
            this.txtNombreB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNombreE
            // 
            this.txtNombreE.Enabled = false;
            this.txtNombreE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreE.Location = new System.Drawing.Point(300, 415);
            this.txtNombreE.MaxLength = 80;
            this.txtNombreE.Name = "txtNombreE";
            this.txtNombreE.Size = new System.Drawing.Size(316, 26);
            this.txtNombreE.TabIndex = 71;
            this.txtNombreE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblIdPlanilla
            // 
            this.lblIdPlanilla.AutoSize = true;
            this.lblIdPlanilla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblIdPlanilla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIdPlanilla.Enabled = false;
            this.lblIdPlanilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblIdPlanilla.Location = new System.Drawing.Point(70, 525);
            this.lblIdPlanilla.Name = "lblIdPlanilla";
            this.lblIdPlanilla.Size = new System.Drawing.Size(127, 28);
            this.lblIdPlanilla.TabIndex = 73;
            this.lblIdPlanilla.Text = "Id Planilla:";
            // 
            // txtIdPlanilla
            // 
            this.txtIdPlanilla.Enabled = false;
            this.txtIdPlanilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPlanilla.Location = new System.Drawing.Point(221, 525);
            this.txtIdPlanilla.Name = "txtIdPlanilla";
            this.txtIdPlanilla.Size = new System.Drawing.Size(164, 26);
            this.txtIdPlanilla.TabIndex = 72;
            this.txtIdPlanilla.Text = "Codigo";
            this.txtIdPlanilla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPlanilla
            // 
            this.lblPlanilla.AutoSize = true;
            this.lblPlanilla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPlanilla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlanilla.Enabled = false;
            this.lblPlanilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanilla.Location = new System.Drawing.Point(400, 472);
            this.lblPlanilla.Name = "lblPlanilla";
            this.lblPlanilla.Size = new System.Drawing.Size(102, 31);
            this.lblPlanilla.TabIndex = 74;
            this.lblPlanilla.Text = "Planilla";
            // 
            // txtPresupuesto
            // 
            this.txtPresupuesto.AcceptsTab = true;
            this.txtPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPresupuesto.Location = new System.Drawing.Point(683, 527);
            this.txtPresupuesto.MaxLength = 10;
            this.txtPresupuesto.Name = "txtPresupuesto";
            this.txtPresupuesto.Size = new System.Drawing.Size(127, 26);
            this.txtPresupuesto.TabIndex = 8;
            this.txtPresupuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPresupuesto.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblPresupuesto
            // 
            this.lblPresupuesto.AutoSize = true;
            this.lblPresupuesto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPresupuesto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPresupuesto.Enabled = false;
            this.lblPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblPresupuesto.Location = new System.Drawing.Point(510, 525);
            this.lblPresupuesto.Name = "lblPresupuesto";
            this.lblPresupuesto.Size = new System.Drawing.Size(154, 28);
            this.lblPresupuesto.TabIndex = 75;
            this.lblPresupuesto.Text = "Presupuesto:";
            this.lblPresupuesto.Click += new System.EventHandler(this.lblPresupuesto_Click);
            // 
            // txtMontoACobrar
            // 
            this.txtMontoACobrar.AcceptsTab = true;
            this.txtMontoACobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoACobrar.Location = new System.Drawing.Point(221, 573);
            this.txtMontoACobrar.MaxLength = 10;
            this.txtMontoACobrar.Name = "txtMontoACobrar";
            this.txtMontoACobrar.Size = new System.Drawing.Size(164, 26);
            this.txtMontoACobrar.TabIndex = 7;
            this.txtMontoACobrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMontoACobrar
            // 
            this.lblMontoACobrar.AutoSize = true;
            this.lblMontoACobrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMontoACobrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMontoACobrar.Enabled = false;
            this.lblMontoACobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblMontoACobrar.Location = new System.Drawing.Point(12, 571);
            this.lblMontoACobrar.Name = "lblMontoACobrar";
            this.lblMontoACobrar.Size = new System.Drawing.Size(185, 28);
            this.lblMontoACobrar.TabIndex = 77;
            this.lblMontoACobrar.Text = "Monto a Cobrar:";
            // 
            // txtFueraPresup
            // 
            this.txtFueraPresup.AcceptsTab = true;
            this.txtFueraPresup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFueraPresup.Location = new System.Drawing.Point(683, 575);
            this.txtFueraPresup.MaxLength = 10;
            this.txtFueraPresup.Name = "txtFueraPresup";
            this.txtFueraPresup.Size = new System.Drawing.Size(127, 26);
            this.txtFueraPresup.TabIndex = 9;
            this.txtFueraPresup.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFueraPresup
            // 
            this.lblFueraPresup.AutoSize = true;
            this.lblFueraPresup.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFueraPresup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFueraPresup.Enabled = false;
            this.lblFueraPresup.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblFueraPresup.Location = new System.Drawing.Point(409, 573);
            this.lblFueraPresup.Name = "lblFueraPresup";
            this.lblFueraPresup.Size = new System.Drawing.Size(255, 28);
            this.lblFueraPresup.TabIndex = 79;
            this.lblFueraPresup.Text = "Fuera de Presupuesto:";
            // 
            // btnValidar
            // 
            this.btnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.Location = new System.Drawing.Point(622, 358);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(145, 28);
            this.btnValidar.TabIndex = 6;
            this.btnValidar.Text = "validar Codigo";
            this.btnValidar.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmProyecto
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(852, 704);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.txtFueraPresup);
            this.Controls.Add(this.lblFueraPresup);
            this.Controls.Add(this.txtMontoACobrar);
            this.Controls.Add(this.lblMontoACobrar);
            this.Controls.Add(this.txtPresupuesto);
            this.Controls.Add(this.lblPresupuesto);
            this.Controls.Add(this.lblPlanilla);
            this.Controls.Add(this.lblIdPlanilla);
            this.Controls.Add(this.txtIdPlanilla);
            this.Controls.Add(this.txtNombreE);
            this.Controls.Add(this.txtNombreB);
            this.Controls.Add(this.txtFechaFinalizacion);
            this.Controls.Add(this.lblNombreE);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNombreP);
            this.Controls.Add(this.lblNombreP);
            this.Controls.Add(this.lblFechaFinalizacion);
            this.Controls.Add(this.txtFechaInicio);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.lblNombreCat);
            this.Controls.Add(this.txtIdCategoria);
            this.Controls.Add(this.lblNombreB);
            this.Controls.Add(this.lblProyecto);
            this.Controls.Add(this.txtIdProyecto);
            this.Controls.Add(this.lblIdProyecto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProyecto";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProyecto";
            this.Load += new System.EventHandler(this.frmProyecto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.Label lblNombreP;
        private System.Windows.Forms.Label lblFechaFinalizacion;
        private System.Windows.Forms.TextBox txtFechaInicio;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblNombreCat;
        private System.Windows.Forms.TextBox txtIdCategoria;
        private System.Windows.Forms.Label lblNombreB;
        private System.Windows.Forms.Label lblProyecto;
        private System.Windows.Forms.TextBox txtIdProyecto;
        private System.Windows.Forms.Label lblIdProyecto;
        private System.Windows.Forms.Label lblNombreE;
        private System.Windows.Forms.TextBox txtFechaFinalizacion;
        private System.Windows.Forms.TextBox txtNombreB;
        private System.Windows.Forms.TextBox txtNombreE;
        private System.Windows.Forms.Label lblIdPlanilla;
        private System.Windows.Forms.TextBox txtIdPlanilla;
        private System.Windows.Forms.Label lblPlanilla;
        private System.Windows.Forms.TextBox txtPresupuesto;
        private System.Windows.Forms.Label lblPresupuesto;
        private System.Windows.Forms.TextBox txtMontoACobrar;
        private System.Windows.Forms.Label lblMontoACobrar;
        private System.Windows.Forms.TextBox txtFueraPresup;
        private System.Windows.Forms.Label lblFueraPresup;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}