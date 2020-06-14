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
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            borrarError();
            bool N = validarCampos(txtNombre, "ingresar un nombre a la categoria");            
            bool D = validarCampos(txtDescripcion, "Establesca descripcion");            

            if (N && D)
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

        private void borrarError()
        {
            errorProvider.SetError(txtNombre, "");
            errorProvider.SetError(txtDescripcion, "");            
        }
    }
}
