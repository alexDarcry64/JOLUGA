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

namespace Microsell_Lite
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {

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
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Pnl_Menu_MouseMove(object sender, MouseEventArgs e)
        {
            Utilitario obj = new Utilitario();
           if (e.Button ==MouseButtons.Left )
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

          if( PanelLateral.Width == 247)
            {
                PanelLateral.Width = 40;
                PicUser_2.Visible = true;
            }
          else
            {
                PanelLateral.Width = 247;
                PicUser.Visible = true ;
                PicUser_2.Visible = false;
            }
        }

        private void Bt_ventas_Click(object sender, EventArgs e)
        {

            Frm_Ventana_Ventas ven = new Frm_Ventana_Ventas();

            ven.MdiParent = this;
            ven.Show();


        }

        private void bt_cliente_Click(object sender, EventArgs e)
        {
            Frm_Explor_Cliente cli = new Frm_Explor_Cliente();
            cli.MdiParent = this;
            cli.Show();
        }

        private void bt_compras_Click(object sender, EventArgs e)
        {
            Frm_Compras com = new Frm_Compras();
            com.MdiParent = this;
            com.Show();
        }
    }
}
