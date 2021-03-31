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
    public partial class Frm_Distrito : Form
    {
        public Frm_Distrito()
        {
            InitializeComponent();
        }

        private void Frm_Reg_Prod_Load(object sender, EventArgs e)
        {
            Configurar_lisView();
            Cargar_Todos_Distrito();
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
            var lis = lsv_dis;
            lsv_dis.Items.Clear();
            lis.Columns.Clear();
            lis.View = View.Details;
            lis.GridLines = false;
            lis.FullRowSelect = true;
            lis.Scrollable = true;
            lis.HideSelection = false;
            //configurar columnas
            lis.Columns.Add("Id_Dis", 40, HorizontalAlignment.Left);//0
            lis.Columns.Add("Distrito", 350, HorizontalAlignment.Left);//1
        }

        private void Llenar_Listview(DataTable data)
        {
            lsv_dis.Items.Clear();

            for(int i=0; i< data.Rows.Count; i++)
            {
                DataRow dr = data.Rows[i];
                ListViewItem list = new ListViewItem(dr["Id_Dis"].ToString());
                list.SubItems.Add(dr["Distrito"].ToString());
                lsv_dis.Items.Add(list);//si no ponemos esto el list nunca se llenara
            }
        }


        private void Cargar_Todos_Distrito()
        {
            RN_Distrito obj = new RN_Distrito();
            DataTable dato = new DataTable();

            dato = obj.RN_Mostrar_Todos_Distrito();
            if(dato.Rows.Count > 0)
            {
                Llenar_Listview(dato);
            }
            else
            {
                lsv_dis.Items.Clear();
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
            RN_Distrito obj = new RN_Distrito();
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia adv = new Frm_Advertencia();
            if (txtnombre.Text.Trim().Length < 0) { fil.Show(); adv.lbl_Msm1.Text = "Ingresa el nombre del distrito"; adv.ShowDialog(); fil.Hide(); return; }
            
            if(editar==false)
            {
                //Nuevo
                obj.RN_Registrar_Distrito(txtnombre.Text);
                pnl_add.Visible = false;
                Cargar_Todos_Distrito();
                txtnombre.Text = "";
            }
            else
            {
                //Ediatr
                obj.RN_Editar_Distrito(Convert.ToInt32(txtid.Text), txtnombre.Text);
                pnl_add.Visible = false;
                Cargar_Todos_Distrito();
                txtnombre.Text = "";
                editar = false;
            }

            
        }

        public bool editar = false;
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Frm_Advertencia adv = new Frm_Advertencia();
            Frm_Filtro fil = new Frm_Filtro();

            if (lsv_dis.SelectedIndices.Count==0)
            {
                fil.Show();
                adv.lbl_Msm1.Text = "Seleccionar el Item para Editar";
                adv.ShowDialog();
                fil.Hide();
                return;
            }
            else
            {
                var lsv = lsv_dis.SelectedItems[0];
                txtid.Text = lsv.SubItems[0].Text;
                txtnombre.Text = lsv.SubItems[1].Text;

                pnl_add.Visible = true;
                txtnombre.Focus();
                editar = true;

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Frm_Advertencia adv = new Frm_Advertencia();
            Frm_Filtro fil = new Frm_Filtro();
            if (lsv_dis.SelectedIndices.Count == 0)
            {
                fil.Show();
                adv.lbl_Msm1.Text = "Seleccionar el Item para Eliminar";
                adv.ShowDialog();
                fil.Hide();
                return;
            }
            else
            {
                var lsv = lsv_dis.SelectedItems[0];
                txtid.Text = lsv.SubItems[0].Text;

                Frm_Sino sino = new Frm_Sino();

                //sino.Lbl_msm1.text = "Estas seguro de eliminar la marca";
                sino.ShowDialog();


                if(sino.Tag.ToString()=="Si")
                {
                    RN_Distrito obj = new RN_Distrito();
                    obj.RN_Eliminar_Distrito(Convert.ToInt32(txtid.Text));
                    Cargar_Todos_Distrito();
                }

                

            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

            //pendiente
        }
    }
}
