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
using Microsell_Lite.Ventas;


namespace Microsell_Lite.Compras
{
    public partial class Frm_Explor_Documento : Form
    {
        public Frm_Explor_Documento()
        {
            InitializeComponent();
        }

        private void Frm_Explor_Proveedor_Load(object sender, EventArgs e)
        {
            Configurar_listView();
            buscar_Documentos_Dia(dtpHoy.Value);
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

            lis.Columns.Add("ID Doc", 100, HorizontalAlignment.Left);//0
            lis.Columns.Add("Fecha Emision", 165, HorizontalAlignment.Left);//0
            lis.Columns.Add("Nombre Cliente", 273, HorizontalAlignment.Left);//0
            lis.Columns.Add("Tipo Documento", 167, HorizontalAlignment.Left);//0
            lis.Columns.Add("NroPedido", 140, HorizontalAlignment.Left);//0
            lis.Columns.Add("Tipo Pago", 164, HorizontalAlignment.Left);//0
            lis.Columns.Add("Total", 90, HorizontalAlignment.Left);//0
            lis.Columns.Add("Estado Doc", 121, HorizontalAlignment.Left);//0
            lis.Columns.Add("Vendedor", 121, HorizontalAlignment.Left);//0
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
        }

        private void Cargar_todos_Ventas()
        {
            RN_Documento obj = new RN_Documento();
            DataTable dato = new DataTable();

            dato = obj.RN_ListarTodos_Documentos();
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


        private void buscar_Documentos_Ventas(string valor)
        {
            RN_Documento obj = new RN_Documento();
            DataTable dato = new DataTable();

            dato = obj.RN_Buscador_Documentos_Valor(valor);
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
                buscar_Documentos_Ventas(txtbuscar.Text);
            }
        }

        private void txtbuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if (txtbuscar.Text.Trim().Length > 2)
                {
                    buscar_Documentos_Ventas(txtbuscar.Text);
                }
                else
                {
                    Cargar_todos_Ventas();
                }

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
                Cargar_todos_Ventas();
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
        }

        private void mostrarTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cargar_todos_Ventas();
        }

        private void buscar_Documentos_Dia(DateTime fecha)
        {
            RN_Documento obj = new RN_Documento();
            DataTable dato = new DataTable();

            dato = obj.RN_Buscador_Documentos_Dia(fecha);
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

        private void buscar_Ventas_Mes(DateTime fecha)
        {
            RN_Documento obj = new RN_Documento();
            DataTable dato = new DataTable();

            dato = obj.RN_Buscador_Documentos_Mes(fecha);
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
            Frm_Solo_Fecha solo = new Frm_Solo_Fecha();
            fil.Show();
            solo.ShowDialog();
            fil.Hide();

            if (solo.Tag.ToString() == "A")
            {
                DateTime xfecha = solo.dtpFecha.Value;
                buscar_Documentos_Dia(xfecha);
            }
        }

        private void buscarComprasDelMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Solo_Fecha solo = new Frm_Solo_Fecha();
            fil.Show();
            solo.ShowDialog();
            fil.Hide();

            if (solo.Tag.ToString() == "A")
            {
                DateTime xfecha = solo.dtpFecha.Value;
                buscar_Ventas_Mes(xfecha);
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void ltsCompras_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia ver = new Frm_Advertencia();
            Form_VerDet_Compra edi = new Form_VerDet_Compra();

            if (ltsCompras.SelectedIndices.Count == 0)
            {
                fil.Show();
                ver.lbl_Msm1.Text = "Seleccione un producto";
                ver.ShowDialog();
                fil.Hide();
            }
            else
            {
                var lis = ltsCompras.SelectedItems[0];
                string idCompra = lis.SubItems[0].Text;

                fil.Show();
                edi.Tag = idCompra;
                edi.ShowDialog();
                fil.Hide();

                if (edi.Tag.ToString() == "A")
                {
                    Cargar_todos_Ventas();
                }

            }
        }

        private void reimprimirDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia ver = new Frm_Advertencia();
            Form_VerDet_Compra edi = new Form_VerDet_Compra();
            Frm_Crear_Ventas venta = new Frm_Crear_Ventas();

            if (ltsCompras.SelectedIndices.Count == 0)
            {
                fil.Show();
                ver.lbl_Msm1.Text = "Seleccione un producto";
                ver.ShowDialog();
                fil.Hide();
            }
            else
            {
                var lis = ltsCompras.SelectedItems[0];
                string idDoc = lis.SubItems[0].Text;

                fil.Show();
                venta.txtBuscar.Text = idDoc;
                venta.ShowDialog();
                fil.Hide();

                if (edi.Tag.ToString() == "A")
                {
                    Cargar_todos_Ventas();
                }

            }
        }
    }
}
