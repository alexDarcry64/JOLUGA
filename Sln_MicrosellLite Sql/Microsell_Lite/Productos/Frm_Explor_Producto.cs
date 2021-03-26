﻿using System;
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
using Microsell_Lite.Productos;

namespace Microsell_Lite.Productos
{
    public partial class Frm_Explor_Producto : Form
    {
        public Frm_Explor_Producto()
        {
            InitializeComponent();
        }

        private void Frm_Explor_Proveedor_Load(object sender, EventArgs e)
        {
            Configurar_listView();
            Cargar_todos_Productos();


            Cargar_Total_ProductosCosto();
        }

        private void btn_minimi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Explor_Proveedor_MouseMove(object sender, MouseEventArgs e)
        {
            Utilitario obj = new Utilitario();
            if(e.Button== MouseButtons.Left)
            {
                obj.Mover_formulario(this);
            }
        }

        //configurar lisview

        private void Configurar_listView()
        {
            var lis = ltsProductos;

            ltsProductos.Items.Clear();
            lis.Columns.Clear();
            lis.View = View.Details;
            lis.GridLines = false;
            lis.FullRowSelect = true;
            lis.Scrollable = true;
            lis.HideSelection = false;

            //configurar las columnas

            lis.Columns.Add("ID", 100, HorizontalAlignment.Left);//0
            lis.Columns.Add("Nombre del Producto", 240, HorizontalAlignment.Left);//0
            lis.Columns.Add("Stock", 80, HorizontalAlignment.Left);//0
            lis.Columns.Add("Pre Compra", 80, HorizontalAlignment.Left);//0
            lis.Columns.Add("Pre Venta 1", 80, HorizontalAlignment.Left);//0
            lis.Columns.Add("Pre Venta 2", 80, HorizontalAlignment.Left);//0
            lis.Columns.Add("Utilidad", 80, HorizontalAlignment.Left);//0
            lis.Columns.Add("Total", 80, HorizontalAlignment.Left);//0
            lis.Columns.Add("Estado", 100, HorizontalAlignment.Left);//0
        }

        //llenar list view
        private void llenar_Listview(DataTable data)
        {
            ltsProductos.Items.Clear();

            for (int i=0; i< data.Rows.Count; i++)
            {
                DataRow dr = data.Rows[i];
                ListViewItem list = new ListViewItem(dr["Id_Pro"].ToString());
                list.SubItems.Add(dr["Descripcion_Larga"].ToString());
                list.SubItems.Add(dr["Stock_Actual"].ToString());
                list.SubItems.Add(dr["Pre_Compra"].ToString());
                list.SubItems.Add(dr["Pre_vntaxMenor"].ToString());
                list.SubItems.Add(dr["Pre_vntaxMayor"].ToString());
                list.SubItems.Add(dr["UtilidadUnit"].ToString());
                list.SubItems.Add(dr["Pre_Venta"].ToString());
                list.SubItems.Add(dr["Estado_Pro"].ToString());
                ltsProductos.Items.Add(list);//si no ponemos esto el list nunca llenara
            }
            PintarFilas();
            pnlmsj.Visible = false;
            lblTotalItems.Text = contextMenuStrip1.Items.Count.ToString();
        }

        private void Cargar_todos_Productos()
        {
            RN_Productos obj = new RN_Productos();
            DataTable dato = new DataTable();

            dato = obj.RN_Mostrar_Todos_Productos();
            if(dato.Rows.Count>0)
            {
                llenar_Listview(dato);
            }
            else
            {
                ltsProductos.Items.Clear();
                pnlmsj.Visible = true;
            }
        }

        private void Cargar_Total_ProductosCosto()
        {
            try
            {

                RN_Productos productos = new RN_Productos();

                lblTotal.Text = productos.RN_Sumar_Stock_Cantidad_Productos().ToString();

            }
            catch (Exception io)
            {

            }
        }

        private void buscar_Productos(string valor)
        {
            RN_Productos obj = new RN_Productos();
            DataTable dato = new DataTable();

            dato = obj.RN_Buscar_Productos(valor);
            if (dato.Rows.Count > 0)
            {
                llenar_Listview(dato);
            }
            else
            {
                ltsProductos.Items.Clear();
                pnlmsj.Visible = true;
            }
        }

        private void txtbuscar_OnValueChanged(object sender, EventArgs e)
       {
            if(txtbuscar.Text.Trim().Length > 2)
            {
                buscar_Productos(txtbuscar.Text);
            }
        }

        private void txtbuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if (txtbuscar.Text.Trim().Length > 2)
                {
                    buscar_Productos(txtbuscar.Text);
                }
                else
                {
                    Cargar_todos_Productos();
                }

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_AddProducto ad = new Frm_AddProducto();

            fil.Show();
            ad.ShowDialog();
            fil.Hide();

            if(ad.Tag.ToString()=="A")
            {
                Cargar_todos_Productos();
            }
        }

        private void bt_copiarIDProveedorTool_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia ver = new Frm_Advertencia();

            if(ltsProductos.SelectedIndices.Count==0)
            {
                fil.Show();
                ver.ShowDialog();
                fil.Hide();
            }
            else
            {
                var lis = ltsProductos.SelectedItems[0];
                string idprovee = lis.SubItems[0].Text;

                Clipboard.Clear();
                Clipboard.SetText(idprovee.Trim());
            }
        }

        private void bt_agregarProveedorTool_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_AddProducto ad = new Frm_AddProducto();

            fil.Show();
            ad.ShowDialog();
            fil.Hide();

            if (ad.Tag.ToString() == "A")
            {
                Cargar_todos_Productos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia ver = new Frm_Advertencia();
            ver.lbl_Msm1.Text = "Seleccione";
            Frm_EditProducto edi = new Frm_EditProducto();

            if (ltsProductos.SelectedIndices.Count == 0)
            {
                fil.Show();
                ver.ShowDialog();
                fil.Hide();
            }
            else
            {
                var lis = ltsProductos.SelectedItems[0];
                string idproducto = lis.SubItems[0].Text;

                fil.Show();
                edi.Tag = idproducto;
                edi.ShowDialog();
                fil.Hide();

                if(edi.Tag.ToString()=="A")
                {
                    Cargar_todos_Productos();
                }
                
            }
        }

        private void PintarFilas()
        {
            int cont = 1;
            for (int i=0; i < ltsProductos.Items.Count; i++)
            {
                if (cont % 2 == 0)
                {

                }
                else
                {
                    ltsProductos.Items[i].BackColor = Color.WhiteSmoke;
                }
                cont += 1;
            }
        }

        private void btnEditar_MouseMove(object sender, MouseEventArgs e)
        {
            Utilitario obj = new Utilitario();

            if (e.Button == MouseButtons.Left)
            {
                obj.Mover_formulario(this);

            }
        }
        private void pnl_titu_MouseMove(object sender, MouseEventArgs e)
        {
            Utilitario obj = new Utilitario();

            if (e.Button == MouseButtons.Left)
            {
                obj.Mover_formulario(this);

            }
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            btnEditar_Click(sender,e);
        }

        private void mostrarTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cargar_todos_Productos();
        }


    }
}
