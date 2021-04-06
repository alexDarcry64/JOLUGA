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
    public partial class Frm_InicioCaja : Form
    {
        public Frm_InicioCaja()
        {
            InitializeComponent();
        }

        private void Frm_InicioCaja_Load(object sender, EventArgs e)
        {
            txt_importe.Focus();
        }

        private void Frm_InicioCaja_MouseMove(object sender, MouseEventArgs e)
        {
            Utilitario ui = new Utilitario();
            if (e.Button ==MouseButtons.Left )
            {
                ui.Mover_formulario(this);
            }
        }

        private void Frm_InicioCaja_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Escape )
            {
                this.Tag = "";
                this.Close();
            }

            if (e.KeyCode == Keys.Enter)
            {
                btn_procesar_Click(sender,e);
            }
        }

        private void Registrar_Inicio_Caja()
        {
            EN_Cierre_Caja ca = new EN_Cierre_Caja();
            RN_Cierre_Caja obj = new RN_Cierre_Caja();
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Exito ver = new Frm_Exito();

            try
            {
                string idCierre = RN_TipoDoc.RN_Nro_id(13);

                ca.IdCierre = idCierre;
                ca.AperturaCaja = Convert.ToDouble(txt_importe.Text);
                ca.TotalIngreso = 0;
                ca.TotalEgreso = 0;
                ca.IdUsu = Convert.ToInt32(Cls_Libreria.IdUsu);
                ca.TotalGanancia = 0;
                ca.TotalEntregado = 0;
                ca.SaldoSiguiente = 0;
                ca.TotalFactura = 0;
                ca.TotalBoleta = 0;
                ca.TotalNota = 0;
                ca.TotalCreditoCobrado = 0;
                ca.TotalCreditoEmitido = 0;

                obj.RN_Registrar_Inicio_Caja(ca);

                if (BD_Cierre_Caja.guardado == true)
                {
                    RN_TipoDoc.RN_Actualizar_NumeroCorrelativo_Producto(13);

                    fil.Show();
                    ver.lbl_Msm1.Text = "La caja se ha aperturado exitosamente";
                    ver.ShowDialog();
                    fil.Hide();

                    txt_importe.Text = "";
                    this.Tag = "A";
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                fil.Show();
                ver.lbl_Msm1.Text = "Error: "+ex.Message;
                ver.ShowDialog();
                fil.Hide();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();
        }

        private void btn_procesar_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia ver = new Frm_Advertencia();
            RN_Cierre_Caja obj = new RN_Cierre_Caja();

            if (txt_importe.Text.Trim().Length ==0)
            {
                fil.Show();
                ver.lbl_Msm1.Text = "Ingrese el importe de apertura de caja";
                ver.ShowDialog();
                fil.Hide();

                txt_importe.Focus();
                return;
            }

            if (obj.RN_Validar_Inicio_Doble_Caja() == true)
            {
                fil.Show();
                ver.lbl_Msm1.Text = "Esta caja ya esta registrada para este dia";
                ver.ShowDialog();
                fil.Hide();
            }
            else
            {
                Registrar_Inicio_Caja();
            }
            
        }
    }
}
