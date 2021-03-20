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
using Microsell_Lite.Productos;


namespace Microsell_Lite.Compras
{
    public partial class Frm_Explor_Compra: Form
    {
        public Frm_Explor_Compra()
        {
            InitializeComponent();
        }

        private void Frm_Explor_Proveedor_Load(object sender, EventArgs e)
        {
            Configurar_listView();
            Cargar_todos_Compras();
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
            var lis = ltsCompras;

            ltsCompras.Items.Clear();
            lis.Columns.Clear();
            lis.View = View.Details;
            lis.GridLines = false;
            lis.FullRowSelect = true;
            lis.Scrollable = true;
            lis.HideSelection = false;

            //configurar las columnas

            lis.Columns.Add("ID", 100, HorizontalAlignment.Left);//0
            lis.Columns.Add("No. Factura", 165, HorizontalAlignment.Left);//0
            lis.Columns.Add("Proveedor", 273, HorizontalAlignment.Left);//0
            lis.Columns.Add("Fecha", 167, HorizontalAlignment.Left);//0
            lis.Columns.Add("Importe", 140, HorizontalAlignment.Left);//0
            lis.Columns.Add("Forma Pago", 164, HorizontalAlignment.Left);//0
            lis.Columns.Add("Tipo Ingreso", 127, HorizontalAlignment.Left);//0
            lis.Columns.Add("Tipo Documento", 124, HorizontalAlignment.Left);//0
            lis.Columns.Add("Estado Factura", 121, HorizontalAlignment.Left);//0
            lis.Columns.Add("Otros Datos", 121, HorizontalAlignment.Left);//0
        }

        //llenar list view
        private void llenar_Listview(DataTable data)
        {
            ltsCompras.Items.Clear();

            for (int i=0; i< data.Rows.Count; i++)
            {
                DataRow dr = data.Rows[i];
                ListViewItem list = new ListViewItem(dr["Id_DocComp"].ToString());
                list.SubItems.Add(dr["NroFac_Fisico"].ToString());
                list.SubItems.Add(dr["NOMBRE"].ToString());
                list.SubItems.Add(dr["Fecha_Ingre"].ToString());
                list.SubItems.Add(dr["Total_Ingre"].ToString());
                list.SubItems.Add(dr["Estado_Ingre"].ToString());
                list.SubItems.Add(dr["ModalidadPago"].ToString());
                list.SubItems.Add(dr["TipoDoc_Compra"].ToString());
                list.SubItems.Add(dr["Estado_Ingre"].ToString());
                list.SubItems.Add(dr["Datos_Adicional"].ToString());
                ltsCompras.Items.Add(list);//si no ponemos esto el list nunca llenara
            }
            PintarFilas();
            pnlmsj.Visible = false;
            lblTotalItems.Text = contextMenuStrip1.Items.Count.ToString();
        }

        private void Cargar_todos_Compras()
        {
            RN_IngresoCompra obj = new RN_IngresoCompra();
            DataTable dato = new DataTable();

            dato = obj.RN_Cargar_TodasCompras();
            if(dato.Rows.Count>0)
            {
                llenar_Listview(dato);
            }
            else
            {
                ltsCompras.Items.Clear();
                pnlmsj.Visible = true;
            }
        }


        private void buscar_Compras(string valor)
        {
            RN_IngresoCompra obj = new RN_IngresoCompra();
            DataTable dato = new DataTable();

            dato = obj.RN_Buscar_Compras(valor);
            if (dato.Rows.Count > 0)
            {
                llenar_Listview(dato);
            }
            else
            {
                ltsCompras.Items.Clear();
                pnlmsj.Visible = true;
            }
        }

        private void txtbuscar_OnValueChanged(object sender, EventArgs e)
       {
            if(txtbuscar.Text.Trim().Length > 2)
            {
                buscar_Compras(txtbuscar.Text);
            }
        }

        private void txtbuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if (txtbuscar.Text.Trim().Length > 2)
                {
                    buscar_Compras(txtbuscar.Text);
                }
                else
                {
                    Cargar_todos_Compras();
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
                Cargar_todos_Compras();
            }
        }

        private void bt_copiarIDProveedorTool_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia ver = new Frm_Advertencia();

            if(ltsCompras.SelectedIndices.Count==0)
            {
                fil.Show();
                ver.ShowDialog();
                fil.Hide();
            }
            else
            {
                var lis = ltsCompras.SelectedItems[0];
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
                Cargar_todos_Compras();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia ver = new Frm_Advertencia();
            Frm_EditProducto edi = new Frm_EditProducto();

            if (ltsCompras.SelectedIndices.Count == 0)
            {
                fil.Show();
                ver.ShowDialog();
                fil.Hide();
            }
            else
            {
                var lis = ltsCompras.SelectedItems[0];
                string idproducto = lis.SubItems[0].Text;

                fil.Show();
                edi.Tag = idproducto;
                edi.ShowDialog();
                fil.Hide();

                if(edi.Tag.ToString()=="A")
                {
                    Cargar_todos_Compras();
                }
                
            }
        }

        private void PintarFilas()
        {
            int cont = 1;
            for (int i=0; i < ltsCompras.Items.Count; i++)
            {
                if (cont % 2 == 0)
                {

                }
                else
                {
                    ltsCompras.Items[i].BackColor = Color.WhiteSmoke;
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
            Cargar_todos_Compras();
        }

        private void buscar_Compras_Dia(DateTime fecha)
        {
            RN_IngresoCompra obj = new RN_IngresoCompra();
            DataTable dato = new DataTable();

            dato = obj.RN_Buscar_Compras_Dia("dia",fecha);
            if (dato.Rows.Count > 0)
            {
                llenar_Listview(dato);
            }
            else
            {
                ltsCompras.Items.Clear();
                pnlmsj.Visible = true;
            }
        }

        private void buscar_Compras_Mes(DateTime fecha)
        {
            RN_IngresoCompra obj = new RN_IngresoCompra();
            DataTable dato = new DataTable();

            dato = obj.RN_Buscar_Compras_Dia("mes", fecha);
            if (dato.Rows.Count > 0)
            {
                llenar_Listview(dato);
            }
            else
            {
                ltsCompras.Items.Clear();
                pnlmsj.Visible = true;
            }
        }

        private void coomprasDelDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_SoloFecha solo = new Frm_SoloFecha();
            fil.Show();
            solo.ShowDialog();
            fil.Hide();

            if (solo.Tag.ToString() == "A")
            {
                DateTime xfecha = solo.dtpCambioFecha.Value;
                buscar_Compras_Dia(xfecha);
            }
        }

        private void buscarComprasDelMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_SoloFecha solo = new Frm_SoloFecha();
            fil.Show();
            solo.ShowDialog();
            fil.Hide();

            if (solo.Tag.ToString() == "A")
            {
                DateTime xfecha = solo.dtpCambioFecha.Value;
                buscar_Compras_Mes(xfecha);
            }
        }
    }
}
