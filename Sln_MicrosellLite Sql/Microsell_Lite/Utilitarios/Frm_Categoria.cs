using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prj_Capa_Datos;
using Prj_Capa_Negocio;

namespace Microsell_Lite.Utilitarios
{
    public partial class Frm_Categoria : Form
    {
        public Frm_Categoria()
        {
            InitializeComponent();
        }

        private void Frm_Reg_Prod_Load(object sender, EventArgs e)
        {
            Configurar_lisView();
            Cargar_Todos_carteg();
        }

        private void pnl_titu_MouseMove(object sender, MouseEventArgs e)
        {
            Utilitario obj = new Utilitario();

            if (e.Button == MouseButtons.Left)
            {
                obj.Mover_formulario(this);

            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Configurar_lisView()
        {
            var lis = lsv_cat;
            lsv_cat.Items.Clear();
            lis.Columns.Clear();
            lis.View = View.Details;
            lis.GridLines = false;
            lis.FullRowSelect = true;
            lis.Scrollable = true;
            lis.HideSelection = false;
            //configurar columnas
            lis.Columns.Add("ID", 40, HorizontalAlignment.Left);//0
            lis.Columns.Add("Categoria", 350, HorizontalAlignment.Left);//1
        }

        private void Llenar_Listview(DataTable data)
        {
            lsv_cat.Items.Clear();

            for(int i=0; i< data.Rows.Count; i++)
            {
                DataRow dr = data.Rows[i];
                ListViewItem list = new ListViewItem(dr["Id_Cat"].ToString());
                list.SubItems.Add(dr["Categoria"].ToString());
                lsv_cat.Items.Add(list);//si no ponemos esto el list nunca se llenara
            }
        }


        private void Cargar_Todos_carteg()
        {
            RN_Categoria obj = new RN_Categoria();
            DataTable dato = new DataTable();

            dato = obj.RN_Mostrar_Todas_Categorias();
            if(dato.Rows.Count > 0)
            {
                Llenar_Listview(dato);
            }
            else
            {
                lsv_cat.Items.Clear();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pnl_add.Visible = true;
            txtnombre.Focus();
            editar = false;
        }

        private void btn_listo_Click(object sender, EventArgs e)
        {
            RN_Categoria obj = new RN_Categoria();
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia adv = new Frm_Advertencia();
            if (txtnombre.Text.Trim().Length < 0) { fil.Show(); adv.lbl_Msm1.Text = "Ingresa al menos un proucto"; adv.ShowDialog(); fil.Hide(); return; }
            
            if(editar==false)
            {
                //Nuevo
                obj.RN_Registrar_Categoria(txtnombre.Text);
                pnl_add.Visible = false;
                Cargar_Todos_carteg();
                txtnombre.Text = "";
            }
            else
            {
                //Ediatr
                obj.RN_Editar_Categoria(Convert.ToInt32(txtid.Text), txtnombre.Text);
                pnl_add.Visible = false;
                Cargar_Todos_carteg();
                txtnombre.Text = "";
                editar = false;
            }

            
        }

        public bool editar = false;
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Frm_Advertencia adv = new Frm_Advertencia();
            Frm_Filtro fil = new Frm_Filtro();
            if (lsv_cat.SelectedIndices.Count==0)
            {
                fil.Show();
                adv.lbl_Msm1.Text = "Seleccionar el Item para Editar";
                adv.ShowDialog();
                fil.Hide();
                return;
            }
            else
            {
                var lsv = lsv_cat.SelectedItems[0];
                txtid.Text = lsv.SubItems[0].Text;
                txtnombre.Text = lsv.SubItems[1].Text;

                pnl_add.Visible = true;
                txtnombre.Focus();
                editar = true;

            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Frm_Advertencia adv = new Frm_Advertencia();
            Frm_Filtro fil = new Frm_Filtro();
            if (lsv_cat.SelectedIndices.Count == 0)
            {
                fil.Show();
                adv.lbl_Msm1.Text = "Seleccionar una Categoria";
                adv.ShowDialog();
                fil.Hide();
                return;
            }
            else
            {
                var lsv = lsv_cat.SelectedItems[0];
                txtid.Text = lsv.SubItems[0].Text;
                txtnombre.Text = lsv.SubItems[1].Text;

                this.Tag = "A";
                this.Close();

            }
        }

        private void lsv_cat_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                btnSeleccionar_Click(sender, e);
            }
        }
    }
}
