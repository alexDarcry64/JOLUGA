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

namespace Microsell_Lite.Compras
{
    public partial class Frm_Solo_Precio : Form
    {
        public Frm_Solo_Precio()
        {
            InitializeComponent();
        }

        private void Frm_Solo_Canti_Load(object sender, EventArgs e)
        {
            txt_cant.Focus();
        }

        private void Frm_Solo_Canti_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Escape )
            {
                this.Tag = "";
                this.Close();
            }
        }

        private void txt_cant_KeyDown(object sender, KeyEventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia adver = new Frm_Advertencia();
            
            if (e.KeyCode ==Keys.Enter )
            {
                if (txt_cant.Text.Trim() == "") return;
                if (txt_cant.Text.Trim().Length == 0) { fil.Show(); adver.lbl_Msm1.Text = "Por favor agrege un precio"; fil.Hide(); txt_cant.Focus(); return; }
                if (Convert.ToDouble(txt_cant.Text) == 0) { fil.Show(); adver.lbl_Msm1.Text = "El precio no puede ser 0"; fil.Hide(); txt_cant.Focus(); return; }

                this.Tag = "A";
                this.Close();
            }


        }

        private void txt_cant_TextChanged(object sender, EventArgs e)
        {
            txt_cant.Text = txt_cant.Text.Replace(",", ".");
            txt_cant.SelectionStart = txt_cant.Text.Length;
        }

        private void txt_cant_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitario ui = new Utilitario();
            e.KeyChar = Convert.ToChar(ui.Solo_Numeros (e.KeyChar ));
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia adver = new Frm_Advertencia();
            if (txt_cant.Text.Trim() == "") return;
            if (txt_cant.Text.Trim().Length == 0) { fil.Show(); adver.lbl_Msm1.Text = "Por favor agrege un precio"; fil.Hide(); return; }
            if (Convert.ToDouble(txt_cant.Text) == 0) { fil.Show(); adver.lbl_Msm1.Text = "Por favor agrege un precio"; fil.Hide(); txt_cant.Focus(); return; }

            this.Tag = "A";
            this.Close();
        }
    }
}
