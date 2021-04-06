using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsell_Lite.Clientes;
using Microsell_Lite.Productos;
using Microsell_Lite.Ventas;
using Microsell_Lite.Compras;
using Microsell_Lite.Proveedores;
using Microsell_Lite.Utilitarios;
using Microsell_Lite.Cotizacion;
using System.IO;
using Prj_Capa_Negocio;
using Microsell_Lite.Caja;

namespace Microsell_Lite
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
            if (Cls_Libreria.Nombre != null)
            {
                lbl_user.Text = Cls_Libreria.Nombre;
                lbl_Rol.Text = Cls_Libreria.Rol;
            }
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void bt_almacen_Click(object sender, EventArgs e)
        {
            //Explor_Producto explo = new Explor_Producto();
            //if (pnl_fondo.Contains(explo)==false )
            //{
            //    pnl_fondo.Controls.Add(explo);
            //    explo.Dock = DockStyle.Fill;
            //    explo.BringToFront();
            //}
            //else
            //{
            //    explo.BringToFront();
            //}
            Frm_Explor_Producto pro = new Frm_Explor_Producto();

            pro.MdiParent = this;
            pro.Show();
            if (PanelLateral.Width == 247)
            {
                PanelLateral.Width = 40;
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Sino sino = new Frm_Sino();
            fil.Show();
            sino.Lbl_msm1.Text = "¿Quieres salir del sistema?";
            sino.ShowDialog();
            fil.Hide();

            if (sino.Tag.ToString() == "Si")
            {
                Application.Exit();
            }
        }

        private void Pnl_Menu_MouseMove(object sender, MouseEventArgs e)
        {
            Utilitario obj = new Utilitario();
            if (e.Button == MouseButtons.Left)
            {
                obj.Mover_formulario(this);
            }
        }

        private void btn_minimi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {

            if (PanelLateral.Width == 247)
            {
                PanelLateral.Width = 40;
                PicUser_2.Visible = true;
            }
            else
            {
                PanelLateral.Width = 247;
                PicUser.Visible = true;
                PicUser_2.Visible = false;
            }
        }

        private void Bt_ventas_Click(object sender, EventArgs e)
        {

            Frm_Crear_Ventas ven = new Frm_Crear_Ventas();

            ven.MdiParent = this;
            ven.Show();

            if (PanelLateral.Width == 247)
            {
                PanelLateral.Width = 40;
            }
        }

        private void bt_cliente_Click(object sender, EventArgs e)
        {
            Frm_Explor_Cliente cli = new Frm_Explor_Cliente();
            cli.MdiParent = this;
            cli.Show();
            if (PanelLateral.Width == 247)
            {
                PanelLateral.Width = 40;
            }
        }

        private void bt_compras_Click(object sender, EventArgs e)
        {
            Frm_Compras com = new Frm_Compras();
            com.MdiParent = this;
            com.Show();
            if (PanelLateral.Width == 247)
            {
                PanelLateral.Width = 40;
            }
        }

        private void Bt_AbrirExploradorDeCompras_Click(object sender, EventArgs e)
        {
            Frm_Explor_Compra explor = new Frm_Explor_Compra();
            explor.MdiParent = this;
            explor.Show();
        }

        private void Bt_AbrirExploradorDeProveedores_Click(object sender, EventArgs e)
        {
            Frm_Explor_Proveedor pro = new Frm_Explor_Proveedor();
            pro.MdiParent = this;
            pro.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void Bt_cotizar_Click(object sender, EventArgs e)
        {
            Frm_Cotizacion coti = new Frm_Cotizacion();
            coti.MdiParent = this;
            coti.Show();
            if (PanelLateral.Width == 247)
            {
                PanelLateral.Width = 40;
            }
        }

        private void bt_DocEmitidos_Click(object sender, EventArgs e)
        {
            Frm_Explor_Documento doc = new Frm_Explor_Documento();
            doc.MdiParent = this;
            doc.Show();
            if (PanelLateral.Width == 247)
            {
                PanelLateral.Width = 40;
            }
        }

        public void CargarDatosUsuario()
        {
            Frm_Filtro fil = new Frm_Filtro();
            RN_Cierre_Caja obj = new RN_Cierre_Caja();
            Frm_InicioCaja ca = new Frm_InicioCaja();

            fil.Show();
            MessageBox.Show("Bienvenido " + Cls_Libreria.Nombre);
            fil.Hide();

            if (obj.RN_Validar_Inicio_Doble_Caja() == false)
            {
                fil.Show();
                ca.ShowDialog();
                fil.Hide();
            }

            lbl_user.Text = Cls_Libreria.Nombre;
            lbl_Rol.Text = Cls_Libreria.Rol;

            if (Cls_Libreria.Foto.Trim().Length == 0 | Cls_Libreria.Foto == null) return;

            if (File.Exists (Cls_Libreria.Foto) == true)
            {
                PicUser.Load(Cls_Libreria.Foto);
                PicUser_2.Load(Cls_Libreria.Foto);
            }
            else
            {
                //PicUser.Image = Properties.Resources.user114;
                //PicUser_2.Image = Properties.Resources.user114;
            }
        }

        private void Bt_HacerCierreDeCaja_Click(object sender, EventArgs e)
        {
            Frm_CerrarCaja caj = new Frm_CerrarCaja();
            caj.MdiParent = this;
            caj.Show();
        }
    }
}
