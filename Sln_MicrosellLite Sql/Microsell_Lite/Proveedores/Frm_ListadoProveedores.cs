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
    public partial class Frm_ListadoProveedores : Form
    {
        public Frm_ListadoProveedores()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();
        }

        private void Frm_ListadoProveedores_Load(object sender, EventArgs e)
        {
            Configurar_listView();
            Cargar_Todos_Proveedores();
        }

        private void Configurar_listView()
        {
            var lis = ltsProveedor;
            ltsProveedor.Items.Clear();
            lis.Columns.Clear();
            lis.View = View.Details;
            lis.GridLines = false;
            lis.FullRowSelect = true;
            lis.Scrollable = true;
            lis.HideSelection = false;
            //configurar columnas
            lis.Columns.Add("ID", 0, HorizontalAlignment.Left);
            lis.Columns.Add("Nombre de Proveedor", 450, HorizontalAlignment.Left); //1

        }

        private void Llenar_ListView(DataTable data)
        {
            ltsProveedor.Items.Clear();

            for(int i=0; i< data.Rows.Count; i++)
            {
                DataRow dr= data.Rows[i];
                ListViewItem list = new ListViewItem(dr["IDPROVEE"].ToString());
                list.SubItems.Add(dr["Nombre"].ToString());
                ltsProveedor.Items.Add(list);
            }
        }

        private void Cargar_Todos_Proveedores()
        {
            RN_Proveedor obj = new RN_Proveedor();
            DataTable dato = new DataTable();
            dato = obj.RN_Mostrar_Todos_Proveedores();
            if(dato.Rows.Count > 0)
            {
                Llenar_ListView(dato);
            }
            else
            {
                ltsProveedor.Items.Clear();
            }
        }

        private void ltsProveedor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(ltsProveedor.SelectedIndices.Count==0)
            {
                MessageBox.Show("Seleccionar un Proveedor", "Advertencia de Segiridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                lblId.Text = ltsProveedor.SelectedItems[0].SubItems[0].Text;
                lblNombre.Text = ltsProveedor.SelectedItems[0].SubItems[1].Text;

                this.Tag = "A";
                this.Close();
            }
        }

        private void ltsProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if(ltsProveedor.SelectedIndices.Count==0)
                {
                    MessageBox.Show("Selecciona un Proveedor", "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    lblId.Text = ltsProveedor.SelectedItems[0].SubItems[0].Text;
                    lblNombre.Text = ltsProveedor.SelectedItems[0].SubItems[1].Text;

                    this.Tag = "A";
                    this.Close();
                }
            }
        }

        private void buscar_Proveedores(string valor)
        {
            RN_Productos obj = new RN_Productos();
            DataTable dato = new DataTable();

            dato = obj.RN_Buscar_Productos(valor);
            if (dato.Rows.Count > 0)
            {
                Llenar_ListView(dato);
            }
            else
            {
                ltsProveedor.Items.Clear();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_AddProveedor ad = new Frm_AddProveedor();

            fil.Show();
            ad.ShowDialog();
            fil.Hide();

            if (ad.Tag.ToString() == "A")
            {
                Cargar_Todos_Proveedores();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia ver = new Frm_Advertencia();

            if (ltsProveedor.SelectedIndices.Count == 0)
            {
                fil.Show();
                ver.ShowDialog();
                fil.Hide();
            }
            else
            {
                var lis = ltsProveedor.SelectedItems[0];
                string idprovee = lis.SubItems[0].Text;

                Clipboard.Clear();
                Clipboard.SetText(idprovee.Trim());
            }
        }

        private void txtbuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtbuscar.Text.Trim().Length > 2)
            {
                buscar_Proveedores(txtbuscar.Text);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtbuscar.Text.Trim().Length > 2)
            {
                buscar_Proveedores(txtbuscar.Text);
            }
        }

        private void txtbuscar_OnValueChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text.Trim().Length > 2)
            {
                buscar_Proveedores(txtbuscar.Text);
            }
        }
    }
}
