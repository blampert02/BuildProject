using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RTCONSTRUCCIONES.AccesoADatos;

namespace RTCONSTRUCCIONES.Catalogo
{
    public partial class frmEmpleado : Form
    {
        private TipoEmpleado_DAO ATipoEmpleadoDAO = new TipoEmpleado_DAO();

        public frmEmpleado()
        {
            InitializeComponent();
        }       

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            borrarError();
            bool PN = validarCampos(txtPrimerNombre, "ingresar su primer nombre");
            bool PA = validarCampos(txtPrimerApellido, "ingresar su Primer apellido");
            bool IT = validarCampos(txtIdTipo, "El tipo de empleado no es valido");
            bool C = validarCampos(txtCargo, "El Cargo no es valido");
            bool T = validarCampos(cmbTipo, "No ha seleccionado un tipo");

            if (PN && PA && IT && C)
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
            errorProvider.SetError(txtPrimerNombre, "");
            errorProvider.SetError(txtPrimerApellido, "");
            errorProvider.SetError(txtIdTipo, "");
            errorProvider.SetError(txtCargo, "");
            errorProvider.SetError(cmbTipo, "");
        }        

        private void txtIdCargo_Validating(object sender, CancelEventArgs e)
        {
            int I;
            if (!int.TryParse(txtIdCargo.Text, out I))
                errorProvider.SetError(txtIdCargo, "Ingrese valores enteros");
            else
                errorProvider.SetError(txtIdCargo, "");
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            cmbTipo.DataSource = ATipoEmpleadoDAO.listar();
            cmbTipo.DisplayMember = "Tipo de empleado";
            cmbTipo.ValueMember = "Tipo";
            cmbTipo.SelectedIndex = -1;
        }        
    }
}
