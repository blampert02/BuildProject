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
    public partial class IniciarSesion : Form
    {

        int ingreso = 0;
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            ingreso = 1;
        }

        public bool Estado()
        {
            if (ingreso > 0)
            {
                this.Close();
                return true;
            }
            else
                return false;
        }
    }
}
