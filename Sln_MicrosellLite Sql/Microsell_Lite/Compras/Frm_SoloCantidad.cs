using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microsell_Lite.Compras
{
    public partial class Frm_Solo_Cantidad : Form
    {
        public Frm_Solo_Cantidad()
        {
            InitializeComponent();
        }

        private void Frm_Solo_Cantidad_Load(object sender, EventArgs e)
        {
            txtCantidad.Focus();
        }

        private void Frm_Solo_Cantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Tag = "";
                this.Close();
            }
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCantidad.Text.Trim() == "") return;
                
                if (Convert.ToDouble(txtCantidad.Text) == 0) { MessageBox.Show("La cantidad debe ser mayor a 0", "Cantidad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);txtCantidad.Focus(); return; }
                this.Tag = "A";
                this.Close();
            }
        }

        private void txtCantidad_TextChange(object sender, EventArgs e)
        {
            txtCantidad.Text = txtCantidad.Text.Replace(",", ".");
            txtCantidad.SelectionStart = txtCantidad.Text.Length;
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitario ui = new Utilitario();
            e.KeyChar = Convert.ToChar(ui.Solo_Numeros(e.KeyChar));
        }
    }
}
