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
    public partial class Frm_Tipo_Pago_Credito : Form
    {
        public Frm_Tipo_Pago_Credito()
        {
            InitializeComponent();
        }

        private void Frm_Edit_Precio_Load(object sender, EventArgs e)
        {
            txtCuenta.Focus();
        }

        private void elButton1_Click(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();
        }

        public void limpiar()
        {
            txtCuenta.Text = "0";
            lblTotalCuenta.Text = "0";
            lblSaldo.Text = "0";
        }

        private void btn_procesar_Click(object sender, EventArgs e)
        {
            Frm_Advertencia ver = new Frm_Advertencia();
            Frm_Filtro fil = new Frm_Filtro();
            if (txtCuenta.Text == "") { fil.Show(); ver.lbl_Msm1.Text = "Ingrese un monto"; ver.ShowDialog(); fil.Hide(); txtCuenta.Focus(); return; }
            if (Convert.ToDouble(txtCuenta.Text) == 0) { fil.Show(); ver.lbl_Msm1.Text = "El monto no puede ser 0"; ver.ShowDialog(); fil.Hide(); txtCuenta.Focus(); return; }
            if (Convert.ToDouble(txtCuenta.Text) == Convert.ToDouble(lblTotalCuenta.Text)) { fil.Show(); ver.lbl_Msm1.Text = "El importe no puede ser igual a el total a pagar. Por vafor realice una venta en efectivo"; ver.ShowDialog(); fil.Hide(); txtCuenta.Focus(); return; }
            if (Convert.ToDouble(txtCuenta.Text) > Convert.ToDouble(lblTotalCuenta.Text)) { fil.Show(); ver.lbl_Msm1.Text = "El importe a cuenta no puede ser MAYOR al total a pagar"; ver.ShowDialog(); fil.Hide(); txtCuenta.Focus(); return; }

            this.Tag = "A";
            this.Close();
        }

        private void txtCuenta_TextChanged(object sender, EventArgs e)
        {
            txtCuenta.Text = txtCuenta.Text.Replace(",", ".");
            txtCuenta.SelectionStart = txtCuenta.Text.Length;

            try
            {
                double saldoP = 0;
                saldoP = Convert.ToDouble(lblTotalCuenta.Text) - Convert.ToDouble(txtCuenta.Text);
                lblSaldo.Text = saldoP.ToString("###0.00");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitario ut = new Utilitario();
            e.KeyChar = Convert.ToChar(ut.Solo_Numeros(e.KeyChar));
        }
    }
}
