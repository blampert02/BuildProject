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
    public partial class frmTipoEmpleado : Form
    {
        private TipoEmpleado_DAO ATipoEmpleadoDAO = new TipoEmpleado_DAO();
        private bool NuevoReg = true;


        public frmTipoEmpleado()
        {
            InitializeComponent();
        }        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            borrarError();
            bool T = validarCampos(txtTipo, "ingresar Tipo empleado");
            TipoEmpleado ATipoEmpleado = new TipoEmpleado();


            if (T && NuevoReg)
            {             
                
                ATipoEmpleado.Tipo = txtTipo.Text.Trim();
                if(ATipoEmpleadoDAO.agregar(ATipoEmpleado))                
                    MessageBox.Show("El registro fue ingresado correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);                
                else                
                    MessageBox.Show("El registro no fue ingresado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);                
                
            }
            else
            {
                ATipoEmpleado = ATipoEmpleadoDAO.buscar(txtIdTipo.Text.Trim());
                ATipoEmpleado.Tipo = txtTipo.Text.Trim();
                if(ATipoEmpleadoDAO.modificar(ATipoEmpleado))
                    MessageBox.Show("El registro fue Modificado correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("El registro no fue Modificado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            limpiar();

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
            errorProvider.SetError(txtTipo, "");            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            borrarError();
            bool I = validarCampos(txtTipo, "El campo del codigo esta vacio");
            bool T = validarCampos(txtTipo, "El campo esta vacio");


            if (I && T && !NuevoReg)
            {

                TipoEmpleado ATipoEmpleado = ATipoEmpleadoDAO.buscar(txtIdTipo.Text.Trim());
                if (ATipoEmpleadoDAO.eliminar(ATipoEmpleado))
                    MessageBox.Show("El registro fue Eliminado correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("El registro no fue Eliminado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);


                limpiar();
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            NuevoReg = true;
            txtIdTipo.Text = "";
            txtTipo.Text = "";
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = false;
            txtTipo.Focus();
        }

        private void txtIdTipo_Validating(object sender, CancelEventArgs e)
        {
            TipoEmpleado ATipoEmpleado = ATipoEmpleadoDAO.buscar(txtIdTipo.Text.Trim());

            if(ATipoEmpleado != null)
            {
                NuevoReg = false;
                btnGuardar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }
    }
}
