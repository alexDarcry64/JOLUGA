using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsell_Lite.Utilitarios;

namespace Microsell_Lite.Ventas
{
    public partial class Frm_Edit_Cant : Form
    {
        public Frm_Edit_Cant()
        {
            InitializeComponent();
        }

        private void Frm_Edit_Precio_Load(object sender, EventArgs e)
        {

        }

        private void txt_cant_KeyDown(object sender, KeyEventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia adv = new Frm_Advertencia();
            if (e.KeyCode == Keys.Enter)
            {
                if (lblTipoProd.Text.Trim().ToString() == "Producto")
                {
                    if (Convert.ToDouble(txt_cant.Text) > Convert.ToDouble(lblStock.Text))
                    {
                        fil.Show();
                        adv.lbl_Msm1.Text = "No cuentas con la cantidad suficiente de productos en el almacen";
                        adv.ShowDialog();
                        fil.Hide();
                        txt_cant.Text = "1";
                        return;
                    }
                    else
                    {
                        this.Tag = "A";
                        this.Close();
                    }
                }
                else
                {
                    this.Tag = "A";
                    this.Close();
                }
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();
        }
    }
}
