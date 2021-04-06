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
using Prj_Capa_Entidad;
using Prj_Capa_Negocio;
using Microsell_Lite.Utilitarios;

namespace Microsell_Lite.Caja
{
    public partial class Frm_Reg_otroIngresos : Form
    {
        public Frm_Reg_otroIngresos()
        {
            InitializeComponent();
        }

        private void Pnl_titulo_MouseMove(object sender, MouseEventArgs e)
        {
            Utilitario ui = new Utilitario();
            if (e.Button == MouseButtons.Left)
            {
                ui.Mover_formulario(this);
            }
        }

        private void Frm_Reg_otroIngresos_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();

        }

        private void Guardar_IngresoCaja()
        {
            RN_Caja obj = new RN_Caja();
            EN_Caja cja = new EN_Caja();
            Frm_Advertencia ver = new Frm_Advertencia();
            Frm_Filtro fil = new Frm_Filtro();

            try
            {
                cja.FechaCaja = dtp_fecha.Value;
                cja.TipoCaja = "Entrada";
                cja.Concepto = txt_concepto.Text;
                cja.DePara_Cliente = txt_cliente.Text;
                cja.Nr_Documento = txt_nroDoc.Text;
                cja.ImporteCaja = Convert.ToDouble(txt_importe.Text);
                cja.IdUsu = Convert.ToInt32(Cls_Libreria.IdUsu);
                cja.TotalUtilidad = 0;
                cja.TipoPago = cbo_tipoPago.Text;
                cja.GeneradoPor = "Otros";
                obj.RN_Registrar_Movimiento_Caja(cja);

                if (BD_Caja.seguardo == true)
                {
                    fil.Show();
                    ver.lbl_Msm1.Text = "El ingreso se guardo exitosamente";
                    ver.ShowDialog();
                    fil.Hide();

                    this.Tag = "A";
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                fil.Show();
                ver.lbl_Msm1.Text = "Ha ocurrido un error: " + ex.Message;
                ver.ShowDialog();
                fil.Hide();
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Guardar_IngresoCaja();
        }
    }
}
