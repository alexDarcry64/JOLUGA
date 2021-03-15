using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microsell_Lite.Utilitarios
{
    public partial class Frm_Advertencia : Form
    {
        public Frm_Advertencia()
        {
            InitializeComponent();
        }

        

        private void Frm_Advertencia_Load(object sender, EventArgs e)
        {

        }


        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Utilitario obj = new Utilitario();
                obj.Mover_formulario(this);
            }
        }

        private void btnAceptar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAceptar_Click_1(sender, e);
            }
        }
    }
}
