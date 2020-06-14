namespace RTCONSTRUCCIONES.Catalogo
{
    partial class frmCargo
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
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblIdCargo = new System.Windows.Forms.Label();
            this.txtIdCargo = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCargoDes = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCargo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCargo.Enabled = false;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(179, 9);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(86, 31);
            this.lblCargo.TabIndex = 11;
            this.lblCargo.Text = "Cargo";
            // 
            // lblIdCargo
            // 
            this.lblIdCargo.AutoSize = true;
            this.lblIdCargo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblIdCargo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIdCargo.Enabled = false;
            this.lblIdCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCargo.Location = new System.Drawing.Point(12, 84);
            this.lblIdCargo.Name = "lblIdCargo";
            this.lblIdCargo.Size = new System.Drawing.Size(99, 27);
            this.lblIdCargo.TabIndex = 12;
            this.lblIdCargo.Text = "Id cargo";
            // 
            // txtIdCargo
            // 
            this.txtIdCargo.Enabled = false;
            this.txtIdCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCargo.Location = new System.Drawing.Point(126, 85);
            this.txtIdCargo.Name = "txtIdCargo";
            this.txtIdCargo.Size = new System.Drawing.Size(218, 26);
            this.txtIdCargo.TabIndex = 13;
            this.txtIdCargo.Text = "Codigo";
            this.txtIdCargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSalario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSalario.Enabled = false;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(23, 138);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(88, 27);
            this.lblSalario.TabIndex = 14;
            this.lblSalario.Text = "Salario";
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(126, 139);
            this.txtSalario.MaxLength = 10;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(218, 26);
            this.txtSalario.TabIndex = 15;
            this.txtSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSalario.Validating += new System.ComponentModel.CancelEventHandler(this.txtSalario_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 27);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cargo";
            // 
            // txtCargoDes
            // 
            this.txtCargoDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargoDes.Location = new System.Drawing.Point(126, 190);
            this.txtCargoDes.MaxLength = 50;
            this.txtCargoDes.Name = "txtCargoDes";
            this.txtCargoDes.Size = new System.Drawing.Size(218, 26);
            this.txtCargoDes.TabIndex = 17;
            this.txtCargoDes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(179, 253);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 28);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(279, 253);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 28);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(76, 253);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 28);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmCargo
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(406, 318);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtCargoDes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.txtIdCargo);
            this.Controls.Add(this.lblIdCargo);
            this.Controls.Add(this.lblCargo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCargo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCargo";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblIdCargo;
        private System.Windows.Forms.TextBox txtIdCargo;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCargoDes;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}