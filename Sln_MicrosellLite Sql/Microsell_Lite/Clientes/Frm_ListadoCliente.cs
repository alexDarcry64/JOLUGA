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
using Prj_Capa_Negocio;
using Prj_Capa_Entidad;
using Prj_Capa_Datos;

namespace Microsell_Lite.Clientes
{
    public partial class Frm_ListadoCliente : Form
    {
        public static string tipo = "";

        public Frm_ListadoCliente()
        {
            InitializeComponent();
        }

        private bool Validar_Texbox()
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia ver = new Frm_Advertencia();

            if (txtId.Text.Trim().Length < 2) { fil.Show(); ver.lbl_Msm1.Text = "Ingrese un id del Cliente"; ver.ShowDialog(); fil.Hide(); return false; }
            if (txtNombre.Text.Trim().Length < 2) { fil.Show(); ver.lbl_Msm1.Text = "Ingrese la razon social del Cliente"; ver.ShowDialog(); fil.Hide(); txtNombre.Focus(); return false; }
            if (txtRuc.Text.Trim().Length < 2) { fil.Show(); ver.lbl_Msm1.Text = "Ingrese el RFC del Cliente"; ver.ShowDialog(); fil.Hide(); txtRuc.Focus(); return false; }
            if (txtDireccion.Text.Trim().Length < 2) { fil.Show(); ver.lbl_Msm1.Text = "Ingrese un id del Cliente"; ver.ShowDialog(); fil.Hide(); txtDireccion.Focus(); return false; }
            
            return true;
        }

        private void Registrar_Cliente()
        {
            RN_Cliente obj = new RN_Cliente();
            EN_Cliente cli = new EN_Cliente();
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia adv = new Frm_Advertencia();
            Frm_Exito exit = new Frm_Exito();

            try
            {
                cli.Idcliente = txtId.Text;
                cli.Razonsocial = txtNombre.Text;
                cli.Rfc = txtRuc.Text;
                cli.Direccion = txtDireccion.Text;
                cli.Telefono = "0";
                cli.Email = "-";
                cli.Contacto = "-";
                cli.IdDis = 1;
                cli.FechaAniv = dtpFechaAniv.Value;
                cli.LimiteCred = 50;

                obj.RN_Insertar_Cliente(cli);

                if (BD_Cliente.guardado == true)
                {
                    RN_TipoDoc.RN_Actualizar_NumeroCorrelativo_Producto(8);
                    limpiar();

                    this.Tag = "A";
                    fil.Show();
                    exit.lbl_Msm1.Text = "El cliente se ha guardado correctamente";
                    adv.ShowDialog();
                    fil.Hide();
                    txtbuscar.Text = txtId.Text;
                    limpiar();
                    pnlAddCliente.Visible = false;
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

        private void limpiar()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtRuc.Text = "";
        }

        private void Configurar_listView()
        {
            var lis = ltsCli;

            ltsCli.Items.Clear();
            lis.Columns.Clear();
            lis.View = View.Details;
            lis.GridLines = false;
            lis.FullRowSelect = true;
            lis.Scrollable = true;
            lis.HideSelection = false;

            //configurar las columnas

            lis.Columns.Add("ID", 0, HorizontalAlignment.Left);//0
            lis.Columns.Add("Nombre del Cliente", 210, HorizontalAlignment.Left);//0
            lis.Columns.Add("RFC", 150, HorizontalAlignment.Left);//0
            lis.Columns.Add("Estado", 100, HorizontalAlignment.Left);//0
        }

        private void Frm_ListadoCliente_Load(object sender, EventArgs e)
        {
            if (tipo.Trim().Length == 0)
            {
                Configurar_listView();
                Cargar_todos_Clientes();
            }
            else
            {
                Configurar_listView();
                buscar_Clientes(tipo);
            }
            //Configurar_listView();
            //Cargar_todos_Clientes();
        }

        private void llenar_Listview(DataTable data)
        {
            ltsCli.Items.Clear();

            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow dr = data.Rows[i];
                ListViewItem list = new ListViewItem(dr["Id_Cliente"].ToString());
                list.SubItems.Add(dr["Razon_Social_Nombres"].ToString());
                list.SubItems.Add(dr["RFC"].ToString());
                list.SubItems.Add(dr["Estado_Cli"].ToString());
                ltsCli.Items.Add(list);//si no ponemos esto el list nunca llenara
            }
            PintarFilas();
        }

        private void PintarFilas()
        {
            int cont = 1;
            for (int i = 0; i < ltsCli.Items.Count; i++)
            {
                if (cont % 2 == 0)
                {

                }
                else
                {
                    ltsCli.Items[i].BackColor = Color.WhiteSmoke;
                }
                cont += 1;
            }
        }

        public void buscar_Clientes(string valor)
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
                ltsCli.Items.Clear();
            }
        }

        private void Cargar_todos_Clientes()
        {
            RN_Cliente obj = new RN_Cliente();
            DataTable dato = new DataTable();

            dato = obj.RN_Cargar_Todos_Clientes("Activo");
            if (dato.Rows.Count > 0)
            {
                llenar_Listview(dato);
            }
            else
            {
                ltsCli.Items.Clear();
            }
        }

        private void txtbuscar_OnValueChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text.Trim().Length > 2)
            {
                buscar_Clientes(txtbuscar.Text);
            }
        }

        private void txtbuscar_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
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

        private void ltsCli_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SeleccionarCliente();
        }

        private void SeleccionarCliente()
        {
            if (ltsCli.SelectedIndices.Count == 0)
            {

            }
            else
            {
                var lis = ltsCli.SelectedItems[0];
                lblId.Text = lis.SubItems[0].Text;
                lblNomb.Text = lis.SubItems[1].Text;
                lblRuc.Text = lis.SubItems[2].Text;

                this.Tag = "A";
                this.Close();
            }
        }

        private void ltsCli_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SeleccionarCliente();
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Utilitario obj = new Utilitario();

            if (e.Button == MouseButtons.Left)
            {
                obj.Mover_formulario(this);

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar_Texbox() == true)
            {
                Registrar_Cliente();
            }
        }

        private void btnNewCliente_Click(object sender, EventArgs e)
        {
            txtId.Text = RN_TipoDoc.RN_Nro_id(8);
            pnlAddCliente.Visible = true;
            txtNombre.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            pnlAddCliente.Visible = false;
            limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();
        }
    }
}
