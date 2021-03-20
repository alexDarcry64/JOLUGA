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
    public partial class Frm_SoloPrecio : Form
    {
        public Frm_SoloPrecio()
        {
            InitializeComponent();
        }

        private void txtPrecio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPrecio.Text.Trim() == "") return;

                if (Convert.ToDouble(txtPrecio.Text) == 0) { MessageBox.Show("La cantidad debe ser mayor a 0", "Cantidad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); txtPrecio.Focus(); return; }
                this.Tag = "A";
                this.Close();
            }
        }
    }
}
