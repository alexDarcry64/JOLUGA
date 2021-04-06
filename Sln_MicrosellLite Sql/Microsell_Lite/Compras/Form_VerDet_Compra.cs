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

namespace Microsell_Lite.Compras
{
    public partial class Form_VerDet_Compra : Form
    {
        public Form_VerDet_Compra()
        {
            InitializeComponent();
        }

        private void Form_VerDet_Compra_Load(object sender, EventArgs e)
        {
            Configurar_listView();
            BuscarDetCompra(this.Tag.ToString());
        }

        private void Form_VerDet_Compra_MouseMove(object sender, MouseEventArgs e)
        {
            Utilitario ui = new Utilitario();
            if (e.Button == MouseButtons.Left)
            {
                ui.Mover_formulario(this);
            }
        }

        private void Configurar_listView()
        {
            var lis = lsv_Detalle;

            lis.Items.Clear();
            lis.Columns.Clear();
            lis.View = View.Details;
            lis.GridLines = false;
            lis.FullRowSelect = true;
            lis.Scrollable = true;
            lis.HideSelection = false;

            //configurar las columnas

            lis.Columns.Add("ID", 100, HorizontalAlignment.Left);//0
            lis.Columns.Add("ID Producto", 165, HorizontalAlignment.Left);//0
            lis.Columns.Add("Descripcion del producto", 273, HorizontalAlignment.Left);//0
            lis.Columns.Add("Precio", 167, HorizontalAlignment.Left);//0
            lis.Columns.Add("Cant", 164, HorizontalAlignment.Left);//0
            lis.Columns.Add("Importe", 140, HorizontalAlignment.Left);//0
        }

        private void BuscarDetCompra(string idCompra)
        {
            RN_IngresoCompra obj = new RN_IngresoCompra();
            DataTable data = new DataTable();
            data = obj.RN_Buscar_Compras_Detalle(idCompra.Trim());

            if (data.Rows.Count > 0)
            {
                lsv_Detalle.Items.Clear();

                for (int i = 0; i < data.Rows.Count; i++)
                {
                    DataRow dr = data.Rows[i];
                    ListViewItem list = new ListViewItem(dr["Id_DocComp"].ToString());
                    list.SubItems.Add(dr["Id_Pro"].ToString());
                    list.SubItems.Add(dr["Descripcion_Larga"].ToString());
                    list.SubItems.Add(dr["PrecioUnit"].ToString());
                    list.SubItems.Add(dr["Cantidad"].ToString());
                    list.SubItems.Add(dr["Importe"].ToString());
                    lsv_Detalle.Items.Add(list);//si no ponemos esto el list nunca llenara
                }
            
            }
        }
    }
}
