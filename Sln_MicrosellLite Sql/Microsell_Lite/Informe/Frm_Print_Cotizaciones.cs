using Prj_Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microsell_Lite.Informe
{
    public partial class Frm_Print_Cotizaciones : Form
    {
        public Frm_Print_Cotizaciones()
        {
            InitializeComponent();
        }

        private void Frm_Print_Cotizaciones_Load(object sender, EventArgs e)
        {
            Crear_Impresion_Cotizacion();
        }


        public void Crear_Impresion_Cotizacion()
        {
            RN_Cotizacion cotizacion = new RN_Cotizacion();
            DataTable datos = new DataTable();

            datos = cotizacion.RN_Buscar_Cotizaciones_Editar(Convert.ToString(this.Tag));
            Rpte_Cotizacion reportEjemplo = new Rpte_Cotizacion();
            this.VzrCoti.ReportSource = reportEjemplo;
            reportEjemplo.SetDataSource(datos);
            reportEjemplo.Refresh();

            this.VzrCoti.ReportSource = reportEjemplo;
        }

    }
}
