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
    public partial class Frm_Solo_Fecha : Form
    {
        public Frm_Solo_Fecha()
        {
            InitializeComponent();
        }

        private void Frm_Solo_Canti_Load(object sender, EventArgs e)
        {
            dtpFecha.Focus();
        }

        private void Frm_Solo_Canti_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Escape )
            {
                this.Tag = "";
                this.Close();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            this.Tag = "A";
            this.Close();
        }

        private void pnl_titu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Utilitario ut = new Utilitario();
                ut.Mover_formulario(this);
            }
        }
    }
}
