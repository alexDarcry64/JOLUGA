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

namespace Microsell_Lite.Clientes
{
    public partial class Frm_Explor_Cliente : Form
    {
        public Frm_Explor_Cliente()
        {
            InitializeComponent();
        }

        private void Frm_Explor_Proveedor_Load(object sender, EventArgs e)
        {
            Configurar_listView();
            Cargar_todos_Clientes();
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
            lis.Columns.Add("Nombre del Cliente", 240, HorizontalAlignment.Left);//0
            lis.Columns.Add("RFC", 80, HorizontalAlignment.Left);//0
            lis.Columns.Add("Direccion", 80, HorizontalAlignment.Left);//0
            lis.Columns.Add("Telefono", 80, HorizontalAlignment.Left);//0
            lis.Columns.Add("Limite Cred", 80, HorizontalAlignment.Left);//0
            lis.Columns.Add("Estado", 100, HorizontalAlignment.Left);//0
        }

        //llenar list view
        private void llenar_Listview(DataTable data)
        {
            ltsProductos.Items.Clear();

            for (int i=0; i< data.Rows.Count; i++)
            {
                DataRow dr = data.Rows[i];
                ListViewItem list = new ListViewItem(dr["Id_Cliente"].ToString());
                list.SubItems.Add(dr["Contacto"].ToString());
                list.SubItems.Add(dr["RFC"].ToString());
                list.SubItems.Add(dr["Direccion"].ToString());
                list.SubItems.Add(dr["Telefono"].ToString());
                list.SubItems.Add(dr["Limit_Credit"].ToString());
                list.SubItems.Add(dr["Estado_Cli"].ToString());
                ltsProductos.Items.Add(list);//si no ponemos esto el list nunca llenara
            }
            PintarFilas();
            pnlmsj.Visible = false;
            lblTotalItems.Text = contextMenuStrip1.Items.Count.ToString();
        }

        private void Cargar_todos_Clientes()
        {
            RN_Cliente obj = new RN_Cliente();
            DataTable dato = new DataTable();

            dato = obj.RN_Cargar_Todos_Clientes("Activo");
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


        private void buscar_Clientes(string valor)
        {
            RN_Cliente obj = new RN_Cliente();
            DataTable dato = new DataTable();

            dato = obj.RN_Buscar_Cliente_Valor(valor, "Activo");
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
                buscar_Clientes(txtbuscar.Text);
            }
        }

        private void txtbuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if (txtbuscar.Text.Trim().Length > 2)
                {
                    buscar_Clientes(txtbuscar.Text);
                }
                else
                {
                    Cargar_todos_Clientes();
                }

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_AddCliente ad = new Frm_AddCliente();

            fil.Show();
            ad.ShowDialog();
            fil.Hide();

            if(ad.Tag.ToString()=="A")
            {
                Cargar_todos_Clientes();
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
            Frm_AddCliente ad = new Frm_AddCliente();

            fil.Show();
            ad.ShowDialog();
            fil.Hide();

            if (ad.Tag.ToString() == "A")
            {
                Cargar_todos_Clientes();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia ver = new Frm_Advertencia();
            //Frm_EditCliente edi = new Frm_EditCliente();

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
                //edi.Tag = idproducto;
                //edi.ShowDialog();
                fil.Hide();

                //if(edi.Tag.ToString()=="A")
                //{
                //    Cargar_todos_Clientes();
                //}
                
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
            Cargar_todos_Clientes();
        }


    }
}
