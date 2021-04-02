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

namespace Microsell_Lite.Ventas
{
    public partial class Frm_Print_NotaVenta : Form
    {
        public Frm_Print_NotaVenta()
        {
            InitializeComponent();
        }

        private void Frm_Print_NotaVenta_Load(object sender, EventArgs e)
        {
            ImprimirNotaVenta(this.Tag.ToString());
        }

        private void pnl_titu_MouseMove(object sender, MouseEventArgs e)
        {
            Utilitario obj = new Utilitario();

            if (e.Button == MouseButtons.Left)
            {
                obj.Mover_formulario(this);

            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ImprimirNotaVenta(string idDoc)
        {
            RN_Temporal obj = new RN_Temporal();
            DataTable dato = new DataTable();
            dato = obj.BD_LeerTemporal_Id(idDoc.Trim());

            if (dato.Rows.Count > 0)
            {
                Rpt_Print_Nota_Venta reporte = new Rpt_Print_Nota_Venta();
                vsrImpre.ReportSource = reporte;
                reporte.SetDataSource(dato);
                reporte.Refresh();
                vsrImpre.ReportSource = reporte;

                obj.BD_Eliminar_Temporal(this.Tag.ToString());
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            vsrImpre.PrintReport();
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            vsrImpre.ExportReport();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            vsrImpre.RefreshReport();
        }
    }
}
