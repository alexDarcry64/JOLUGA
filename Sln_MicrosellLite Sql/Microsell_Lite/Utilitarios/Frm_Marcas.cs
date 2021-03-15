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
    public partial class Frm_Marcas : Form
    {
        public Frm_Marcas()
        {
            InitializeComponent();
        }

        private void Frm_Reg_Prod_Load(object sender, EventArgs e)
        {
            Configurar_lisView();
            Cargar_Todos_Marcas();
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
            var lis = lsv_mar;
            lsv_mar.Items.Clear();
            lis.Columns.Clear();
            lis.View = View.Details;
            lis.GridLines = false;
            lis.FullRowSelect = true;
            lis.Scrollable = true;
            lis.HideSelection = false;
            //configurar columnas
            lis.Columns.Add("Id_Marca", 40, HorizontalAlignment.Left);//0
            lis.Columns.Add("Marca", 350, HorizontalAlignment.Left);//1
        }

        private void Llenar_Listview(DataTable data)
        {
            lsv_mar.Items.Clear();

            for(int i=0; i< data.Rows.Count; i++)
            {
                DataRow dr = data.Rows[i];
                ListViewItem list = new ListViewItem(dr["Id_Marca"].ToString());
                list.SubItems.Add(dr["Marca"].ToString());
                lsv_mar.Items.Add(list);//si no ponemos esto el list nunca se llenara
            }
        }


        private void Cargar_Todos_Marcas()
        {
            RN_Marcas obj = new RN_Marcas();
            DataTable dato = new DataTable();

            dato = obj.RN_Mostrar_Todas_Marcas();
            if(dato.Rows.Count > 0)
            {
                Llenar_Listview(dato);
            }
            else
            {
                lsv_mar.Items.Clear();
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
            RN_Marcas obj = new RN_Marcas();
            if(txtnombre.Text.Trim().Length < 0) { MessageBox.Show("Ingresa el nombre de la Marca", "Registrar Marca", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
            
            if(editar==false)
            {
                //Nuevo
                obj.RN_Registrar_Marca(txtnombre.Text);
                pnl_add.Visible = false;
                Cargar_Todos_Marcas();
                txtnombre.Text = "";
            }
            else
            {
                //Ediatr
                obj.RN_Editar_Marca(Convert.ToInt32(txtid.Text), txtnombre.Text);
                pnl_add.Visible = false;
                Cargar_Todos_Marcas();
                txtnombre.Text = "";
                editar = false;
            }

            
        }

        public bool editar = false;
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(lsv_mar.SelectedIndices.Count==0)
            {
                MessageBox.Show("Seleccionar el Item para Editar", "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                var lsv = lsv_mar.SelectedItems[0];
                txtid.Text = lsv.SubItems[0].Text;
                txtnombre.Text = lsv.SubItems[1].Text;

                pnl_add.Visible = true;
                txtnombre.Focus();
                editar = true;

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lsv_mar.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Seleccionar el Item para Eliminar", "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                var lsv = lsv_mar.SelectedItems[0];
                txtid.Text = lsv.SubItems[0].Text;

                Frm_Sino sino = new Frm_Sino();

                //sino.Lbl_msm1.text = "Estas seguro de eliminar la marca";
                sino.ShowDialog();


                if(sino.Tag.ToString()=="Si")
                {
                    RN_Marcas obj = new RN_Marcas();
                    obj.RN_Eliminar_Marca(Convert.ToInt32(txtid.Text));
                    Cargar_Todos_Marcas();
                }

                

            }

        }

        

        private void lsv_mar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                btn_Selecc_Click(sender, e);
            }
        }

        private void btn_Selecc_Click(object sender, EventArgs e)
        {
            if (lsv_mar.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Seleccionar una Marca", "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                var lsv = lsv_mar.SelectedItems[0];
                txtid.Text = lsv.SubItems[0].Text;
                txtnombre.Text= lsv.SubItems[1].Text;

                this.Tag = "A";
                this.Close();



            }

        }
    }
}
