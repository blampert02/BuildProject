using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTCONSTRUCCIONES.Catalogo
{
    public partial class frmProyecto : Form
    {
        public frmProyecto()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblPresupuesto_Click(object sender, EventArgs e)
        {
        }

        private void frmProyecto_Load(object sender, EventArgs e)
        {
        }

        private void txtNombreP_TextChanged(object sender, EventArgs e)
        {           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            borrarError();
            bool P = validarCampos(txtNombreP, "ingresar un nombre de proyecto");            
            bool E = validarCampos(txtNombreE, "No hay un encargado asignado");

            if (P && E)
            {
                MessageBox.Show("Datos ingresados correctamente");
            }
        }


        //METODOS PARA EVITAR ERRORES EN EL INGRESO DE DATOS
        private bool validarCampos(TextBox a, string m)
        {
            bool ok = true;

            if(a.Text==string.Empty)
            {
                ok = false;
                errorProvider.SetError(a, m);
            }
            return ok;
        }

        private void borrarError ()
        {
            errorProvider.SetError(txtNombreP,"");            
            errorProvider.SetError(txtNombreE, "");
        }

        private void txtFechaInicio_Validating(object sender, CancelEventArgs e)
        {
            DateTime fechaInicio;
            if(!DateTime.TryParse(txtFechaInicio.Text, out fechaInicio))            
                errorProvider.SetError(txtFechaInicio, "Formato de fecha YYYY-MM-DD");            
            else
                errorProvider.SetError(txtFechaInicio, "");
        }

        private void txtFechaFinalizacion_Validating(object sender, CancelEventArgs e)
        {
            DateTime fechaInicio;
            if (!DateTime.TryParse(txtFechaFinalizacion.Text, out fechaInicio))
                errorProvider.SetError(txtFechaFinalizacion, "Formato de fecha YYYY-MM-DD");
            else
                errorProvider.SetError(txtFechaFinalizacion, "");
        }
    }
}
