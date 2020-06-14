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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            borrarError();
            bool N = validarCampos(txtNombre, "ingresar un nombre al producto");
            bool E = validarCampos(cmbEstado, "Seleccionar el estado del producto");
            bool C = validarCampos(txtCantidad, "Establesca una cantidad");
            bool Cat = validarCampos(txtNombreCat, "Categoria no valida");

            if (N && E && C && Cat)
            {
                MessageBox.Show("Datos ingresados correctamente");
            }
        }

        //METODOS PARA EVITAR ERRORES EN EL INGRESO DE DATOS
        private bool validarCampos(TextBox a, string m)
        {
            bool ok = true;

            if (a.Text == string.Empty)
            {
                ok = false;
                errorProvider.SetError(a, m);
            }
            return ok;
        }

        private bool validarCampos(ComboBox a, string m)
        {
            bool ok = true;

            if (a.Text == string.Empty)
            {
                ok = false;
                errorProvider.SetError(a, m);
            }
            return ok;
        }

        private void borrarError()
        {
            errorProvider.SetError(txtNombre, "");
            errorProvider.SetError(cmbEstado, "");
            errorProvider.SetError(txtCantidad, "");
            errorProvider.SetError(txtNombreCat, "");
        }

        private void txtCantidad_Validating(object sender, CancelEventArgs e)
        {
            int Cant;
            if (!int.TryParse(txtCantidad.Text, out Cant))
                errorProvider.SetError(txtCantidad, "Debe ingresar valores numericos ");
            else
                errorProvider.SetError(txtCantidad, "");
        }       
    }
}
