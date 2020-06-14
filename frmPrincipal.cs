using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTCONSTRUCCIONES
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void tipoEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmTE = new Catalogo.frmTipoEmpleado();
            frmTE.ShowDialog();
            frmTE.Dispose();
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmC = new Catalogo.frmCargo();
            frmC.ShowDialog();
            frmC.Dispose();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            bool band = false;
            while (!band)
            {
                var frmIS = new IniciarSesion();
                frmIS.ShowDialog();
                frmIS.Dispose();
                band = frmIS.Estado();
            } 
                        
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmE = new Catalogo.frmEmpleado();
            frmE.ShowDialog();
            frmE.Dispose();
        }

        private void categoriaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmCP = new Catalogo.frmCategoria();
            frmCP.ShowDialog();
            frmCP.Dispose();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmP = new Catalogo.frmProductos();
            frmP.ShowDialog();
            frmP.Dispose();
        }

        private void proyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmPy = new Catalogo.frmProyecto();
            frmPy.ShowDialog();
            frmPy.Dispose();
        }
    }
}
