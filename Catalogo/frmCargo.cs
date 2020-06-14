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
    public partial class frmCargo : Form
    {
        public frmCargo()
        {
            InitializeComponent();
        }        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            borrarError();
            bool S = validarCampos(txtSalario, "ingresar Salario");
            bool CD = validarCampos(txtCargoDes, "ingresar cargo");          

            if (S && CD)
            {
                MessageBox.Show("Datos ingresados correctamente");
            }
        }
        private void txtSalario_Validating(object sender, CancelEventArgs e)
        {
            float I;
            if (!float.TryParse(txtSalario.Text, out I))
                errorProvider.SetError(txtSalario, "Ingrese valores enteros");
            else
                errorProvider.SetError(txtSalario, "");
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
            errorProvider.SetError(txtSalario, "");
            errorProvider.SetError(txtCargoDes, "");
            
        }
    }
}
