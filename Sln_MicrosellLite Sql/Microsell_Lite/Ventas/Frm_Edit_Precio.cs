using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prj_Capa_Negocio;
using Microsell_Lite.Utilitarios;

namespace Microsell_Lite.Ventas
{
    public partial class Frm_Edit_Precio : Form
    {
        public Frm_Edit_Precio()
        {
            InitializeComponent();
        }

        public string idProducto = "";

        private void Frm_Edit_Precio_Load(object sender, EventArgs e)
        {

            Buscar_Producto(idProducto.Trim());
            txtPrecio.Focus();

        }

        private void Buscar_Producto(string xvalor)
        {
            RN_Productos obj = new RN_Productos();
            DataTable data = new DataTable();
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia adv = new Frm_Advertencia();
            try
            {
                data = obj.RN_Buscar_Productos(xvalor.Trim());
                if (data.Rows.Count > 0)
                {
                    lblidProducto.Text = Convert.ToString(data.Rows[0]["Id_Pro"]);
                    Lbl_stockActual.Text = Convert.ToString(data.Rows[0]["Stock_Actual"]);
                    Lbl_precompra.Text = Convert.ToString(data.Rows[0]["Pre_Compra"]);
                    lbl_producto.Text = Convert.ToString(data.Rows[0]["Descripcion_Larga"]);
                    lblTipoProducto.Text = Convert.ToString(data.Rows[0]["TipoProdcto"]);
                }
            }
            catch (Exception ex)
            {
                fil.Show();
                adv.lbl_Msm1.Text = "Error al Guardar el cliente: " + ex.Message;
                adv.ShowDialog();
                fil.Hide();
            }
        }
        
        
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia adv = new Frm_Advertencia();

            if (txtPrecio.Text == "")
            {
                fil.Show();
                adv.lbl_Msm1.Text = "Por favor ingresa un precio";
                adv.ShowDialog();
                fil.Hide();
                txtPrecio.Focus();
                return;
            }
            if (Convert.ToDouble(txtPrecio.Text) == 0)
            {
                fil.Show();
                adv.lbl_Msm1.Text = "El precio de venta no puede ser 0";
                adv.ShowDialog();
                fil.Hide();
                txtPrecio.Focus();
                return;
            }

            if (txtCantidad.Text == "")
            {
                fil.Show();
                adv.lbl_Msm1.Text = "Por favor ingresa una cantidad";
                adv.ShowDialog();
                fil.Hide();
                txtCantidad.Focus();
                return;
            }
            if (Convert.ToDouble(txtCantidad.Text) == 0)
            {
                fil.Show();
                adv.lbl_Msm1.Text = "La cantidad ingresada no puede ser 0";
                adv.ShowDialog();
                fil.Hide();
                txtCantidad.Focus();
                return;
            }
            try
            {
                double preCopra = Convert.ToDouble(Lbl_precompra.Text);
                double preVenta = Convert.ToDouble(txtPrecio.Text);
                double xUtilidadUnit = 0;

                xUtilidadUnit = preVenta - preCopra;

                Lbl_UtilidadUnit.Text = xUtilidadUnit.ToString();

                if (lblTipoProducto.Text.Trim().ToString() == "Producto")
                {
                    if (Convert.ToDouble(txtCantidad.Text) > Convert.ToDouble(Lbl_stockActual.Text))
                    {
                        txtCantidad.Text = "1";
                        fil.Show();
                        adv.lbl_Msm1.Text = "La cantidad a vender no puede ser mayor que el stock";
                        adv.ShowDialog();
                        fil.Hide();
                        txtCantidad.Focus();
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
            catch (Exception ex)
            {
                txtCantidad.Text = "1";
                fil.Show();
                adv.lbl_Msm1.Text = "Error: " + ex.Message;
                adv.ShowDialog();
                fil.Hide();
                txtCantidad.Focus();
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPrecio.Text = txtPrecio.Text.Replace(",", ".");
            txtPrecio.SelectionStart = txtPrecio.Text.Length;
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            txtPrecio.Text = txtPrecio.Text.Replace(",", ".");
            txtPrecio.SelectionStart = txtPrecio.Text.Length;
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            txtCantidad.Text = txtCantidad.Text.Replace(",", ".");
            txtCantidad.SelectionStart = txtCantidad.Text.Length;
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCantidad.Text = txtCantidad.Text.Replace(",", ".");
            txtCantidad.SelectionStart = txtCantidad.Text.Length;
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAceptar_Click(sender, e);
            }
        }
    }
}
