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

namespace Microsell_Lite.Proveedores
{
    public partial class Frm_Explor_Proveedor : Form
    {
        public Frm_Explor_Proveedor()
        {
            InitializeComponent();
        }

        private void Frm_Explor_Proveedor_Load(object sender, EventArgs e)
        {
            Configurar_listView();
            Cargar_todos_Proveedores();
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
            var lis = ltsProveedores;

            ltsProveedores.Items.Clear();
            lis.Columns.Clear();
            lis.View = View.Details;
            lis.GridLines = false;
            lis.FullRowSelect = true;
            lis.Scrollable = true;
            lis.HideSelection = false;

            //configurar las columnas

            lis.Columns.Add("ID", 80, HorizontalAlignment.Left);//0
            lis.Columns.Add("RFC", 90, HorizontalAlignment.Left);//0
            lis.Columns.Add("Nombre", 400, HorizontalAlignment.Left);//0
            lis.Columns.Add("Nro Celular", 90, HorizontalAlignment.Left);//0
            lis.Columns.Add("Rubro", 180, HorizontalAlignment.Left);//0
            lis.Columns.Add("Direccion", 286, HorizontalAlignment.Left);//0
        }

        //llenar list view
        private void llenar_Listview(DataTable data)
        {
            ltsProveedores.Items.Clear();

            for (int i=0; i< data.Rows.Count; i++)
            {
                DataRow dr = data.Rows[i];
                ListViewItem list = new ListViewItem(dr["IDPROVEE"].ToString());
                list.SubItems.Add(dr["RFC"].ToString());
                list.SubItems.Add(dr["NOMBRE"].ToString());
                list.SubItems.Add(dr["TELEFONO"].ToString());
                list.SubItems.Add(dr["RUBRO"].ToString());
                list.SubItems.Add(dr["DIRECCION"].ToString());
                ltsProveedores.Items.Add(list);//si no ponemos esto el list nunca llenara
            }
        }

        private void Cargar_todos_Proveedores()
        {
            RN_Proveedor obj = new RN_Proveedor();
            DataTable dato = new DataTable();

            dato = obj.RN_Mostrar_Todos_Proveedores();
            if(dato.Rows.Count>0)
            {
                llenar_Listview(dato);
            }
            else
            {
                ltsProveedores.Items.Clear();
            }
        }


        private void buscar_Proveedores(string valor)
        {
            RN_Proveedor obj = new RN_Proveedor();
            DataTable dato = new DataTable();

            dato = obj.RN_Buscar_Proveedores(valor);
            if (dato.Rows.Count > 0)
            {
                llenar_Listview(dato);
            }
            else
            {
                ltsProveedores.Items.Clear();
            }
        }

        private void txtbuscar_OnValueChanged(object sender, EventArgs e)
       {
            if(txtbuscar.Text.Trim().Length > 2)
            {
                buscar_Proveedores(txtbuscar.Text);
            }
        }

        private void txtbuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if (txtbuscar.Text.Trim().Length > 2)
                {
                    buscar_Proveedores(txtbuscar.Text);
                }
                else
                {
                    Cargar_todos_Proveedores();
                }

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Filtro fil = new Frm_Filtro();
                Frm_AddProveedor ad = new Frm_AddProveedor();

                fil.Show();
                ad.ShowDialog();
                fil.Hide();

                if (ad.Tag.ToString() == "A")
                {
                    Cargar_todos_Proveedores();
                }
            }
            catch (Exception)
            {

                this.Tag = "";
                Cargar_todos_Proveedores();
            }
        }

        private void bt_copiarIDProveedorTool_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia ver = new Frm_Advertencia();

            if(ltsProveedores.SelectedIndices.Count==0)
            {
                fil.Show();
                ver.lbl_Msm1.Text = "Por vavor Seleccione un Proveedor";
                ver.ShowDialog();
                fil.Hide();
            }
            else
            {
                var lis = ltsProveedores.SelectedItems[0];
                string idprovee = lis.SubItems[0].Text;

                Clipboard.Clear();
                Clipboard.SetText(idprovee.Trim());
            }
        }

        private void bt_agregarProveedorTool_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_AddProveedor ad = new Frm_AddProveedor();

            fil.Show();
            ad.ShowDialog();
            fil.Hide();

            if (ad.Tag.ToString() == "A")
            {
                Cargar_todos_Proveedores();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia ver = new Frm_Advertencia();
            Frm_EditarProveedor edi = new Frm_EditarProveedor();

            if (ltsProveedores.SelectedIndices.Count == 0)
            {
                fil.Show();
                ver.ShowDialog();
                fil.Hide();
            }
            else
            {
                var lis = ltsProveedores.SelectedItems[0];
                string idprovee = lis.SubItems[0].Text;

                fil.Show();
                edi.Tag = idprovee;
                edi.ShowDialog();
                fil.Hide();

                if(edi.Tag.ToString()=="A")
                {
                    Cargar_todos_Proveedores();
                }
                
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
    }
}
