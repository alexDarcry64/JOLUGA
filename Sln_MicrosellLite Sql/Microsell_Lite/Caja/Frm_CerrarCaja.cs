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
    public partial class Frm_CerrarCaja : Form
    {
        public Frm_CerrarCaja()
        {
            InitializeComponent();
        }

        private void Pnl_Titulo_MouseMove(object sender, MouseEventArgs e)
        {
            Utilitario ui = new Utilitario();
            if (e.Button ==MouseButtons.Left )
            {
                ui.Mover_formulario(this);
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Listar_Caja_Dia()
        {
            DataTable dato = new DataTable();
            RN_Cierre_Caja obj = new RN_Cierre_Caja();
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia ver = new Frm_Advertencia();

            try
            {
                dato = obj.RN_Listar_Cierre_Caja_Dia();
                if (dato.Rows.Count > 0)
                {
                    lbl_idcaja.Text = dato.Rows[0]["Id_cierre"].ToString();
                    Lbl_aperturaCaja.Text = dato.Rows[0]["Apertura_Caja"].ToString();
                    Lbl_estado.Text = dato.Rows[0]["Estado_cierre"].ToString();
                    Lbl_fechaCaja.Text = dato.Rows[0]["Fecha_Cierre"].ToString();

                    if (Lbl_estado.Text.Trim() == "Cerrado")
                    {
                        btn_aceptar.Enabled = false;
                    }
                    else
                    {
                        btn_aceptar.Enabled = true;
                    }
                }
                else
                {
                    fil.Show();
                    ver.lbl_Msm1.Text = "Tienes que iniciar la caja para acceder al cierre";
                    ver.ShowDialog();
                    fil.Hide();

                    btn_aceptar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                fil.Show();
                ver.lbl_Msm1.Text = "Error" + ex;
                ver.ShowDialog();
                fil.Hide();
            }
        }

        private void Frm_CerrarCaja_Load(object sender, EventArgs e)
        {
            Listar_Caja_Dia();
            Buscar_Caja_Por_Boleta();
            Buscar_Caja_Por_Factura();
            Buscar_Caja_Por_Nota_Pedido();
            Buscar_Caja_Por_Otros_Ingresos();
            Buscar_Caja_Por_Abonos();
            Buscar_Salidas_Por_Deposito();
            Buscar_Caja_Por_Deposito();
            Buscar_Caja_Acredito();
            Buscar_Salidas_Por_Efectivo();
            Calcular_Ganancias_Dia();
        }

        private void Buscar_Caja_Por_Boleta()
        {
            RN_Cierre_Caja obj = new RN_Cierre_Caja();
            DataTable dato = new DataTable();

            double subImporte = 0;

            dato = obj.RN_Calcular_Ventas_Por_Tipo_Doc("Boleta");

            if (dato.Rows.Count > 0)
            {
                for (int i = 0; i < dato.Rows.Count; i++)
                {
                    DataRow dr = dato.Rows[i];
                    subImporte = subImporte + Convert.ToDouble(dr["ImporteCaja"]);
                }
                Lbl_Efectivo_boleta.Text = subImporte.ToString("###0.00");
            }
            else
            {
                Lbl_Efectivo_boleta.Text = "00";
            }
        }

        private void Buscar_Caja_Por_Factura()
        {
            RN_Cierre_Caja obj = new RN_Cierre_Caja();
            DataTable dato = new DataTable();

            double subImporte = 0;

            dato = obj.RN_Calcular_Ventas_Por_Tipo_Doc("Factura");

            if (dato.Rows.Count > 0)
            {
                for (int i = 0; i < dato.Rows.Count; i++)
                {
                    DataRow dr = dato.Rows[i];
                    subImporte = subImporte + Convert.ToDouble(dr["ImporteCaja"]);
                }
                Lbl_Efectivo_factura.Text = subImporte.ToString("###0.00");
            }
            else
            {
                Lbl_Efectivo_factura.Text = "00";
            }
        }

        private void Buscar_Caja_Por_Nota_Pedido()
        {
            RN_Cierre_Caja obj = new RN_Cierre_Caja();
            DataTable dato = new DataTable();

            double subImporte = 0;

            dato = obj.RN_Calcular_Ventas_Por_Tipo_Doc("Nota Venta");

            if (dato.Rows.Count > 0)
            {
                for (int i = 0; i < dato.Rows.Count; i++)
                {
                    DataRow dr = dato.Rows[i];
                    subImporte = subImporte + Convert.ToDouble(dr["ImporteCaja"]);
                }
                Lbl_Efectivo_Notas.Text = subImporte.ToString("###0.00");
            }
            else
            {
                Lbl_Efectivo_Notas.Text = "00";
            }
        }

        private void Buscar_Caja_Por_Otros_Ingresos()
        {
            RN_Cierre_Caja obj = new RN_Cierre_Caja();
            DataTable dato = new DataTable();

            double subImporte = 0;

            dato = obj.RN_Calcular_Ventas_Por_Tipo_Doc("Otros");

            if (dato.Rows.Count > 0)
            {
                for (int i = 0; i < dato.Rows.Count; i++)
                {
                    DataRow dr = dato.Rows[i];
                    subImporte = subImporte + Convert.ToDouble(dr["ImporteCaja"]);
                }
                Lbl_otroIngresoEfectivo.Text = subImporte.ToString("###0.00");
            }
            else
            {
                Lbl_otroIngresoEfectivo.Text = "00";
            }
        }

        private void Buscar_Caja_Por_Abonos()
        {
            RN_Cierre_Caja obj = new RN_Cierre_Caja();
            DataTable dato = new DataTable();

            double subImporte = 0;

            dato = obj.RN_Calcular_Ventas_Por_Tipo_Doc("Abono");

            if (dato.Rows.Count > 0)
            {
                for (int i = 0; i < dato.Rows.Count; i++)
                {
                    DataRow dr = dato.Rows[i];
                    subImporte = subImporte + Convert.ToDouble(dr["ImporteCaja"]);
                }
                Lbl_CreditoAbonado.Text = subImporte.ToString("###0.00");
            }
            else
            {
                Lbl_CreditoAbonado.Text = "00";
            }
        }

        private void Buscar_Caja_Por_Deposito()
        {
            RN_Cierre_Caja obj = new RN_Cierre_Caja();
            DataTable dato = new DataTable();

            double subImporte = 0;

            dato = obj.RN_Calcular_Ventas_Por_Tipo_Doc("Deposito");

            if (dato.Rows.Count > 0)
            {
                for (int i = 0; i < dato.Rows.Count; i++)
                {
                    DataRow dr = dato.Rows[i];
                    subImporte = subImporte + Convert.ToDouble(dr["ImporteCaja"]);
                }
                Lbl_Ingreso_Deposito.Text = subImporte.ToString("###0.00");
            }
            else
            {
                Lbl_Ingreso_Deposito.Text = "00";
            }
        }

        private void Buscar_Caja_Acredito()
        {
            RN_Cierre_Caja obj = new RN_Cierre_Caja();
            DataTable dato = new DataTable();

            double subImporte = 0;

            dato = obj.RN_Calcular_Ventas_Acredito();

            if (dato.Rows.Count > 0)
            {
                for (int i = 0; i < dato.Rows.Count; i++)
                {
                    DataRow dr = dato.Rows[i];
                    subImporte = subImporte + Convert.ToDouble(dr["ImporteCaja"]);
                }
                Lbl_TotalCreditos.Text = subImporte.ToString("###0.00");
            }
            else
            {
                Lbl_TotalCreditos.Text = "00";
            }
        }

        private void Buscar_Salidas_Por_Efectivo()
        {
            RN_Cierre_Caja obj = new RN_Cierre_Caja();
            DataTable dato = new DataTable();

            double subImporte = 0;

            dato = obj.RN_Calcular_Ventas_Por_Tipo_Pago("Efectivo");

            if (dato.Rows.Count > 0)
            {
                for (int i = 0; i < dato.Rows.Count; i++)
                {
                    DataRow dr = dato.Rows[i];
                    subImporte = subImporte + Convert.ToDouble(dr["ImporteCaja"]);
                }
                Lbl_SalidaEfectivo.Text = subImporte.ToString("###0.00");
            }
            else
            {
                Lbl_SalidaEfectivo.Text = "00";
            }
        }

        private void Buscar_Salidas_Por_Deposito()
        {
            RN_Cierre_Caja obj = new RN_Cierre_Caja();
            DataTable dato = new DataTable();

            double subImporte = 0;

            dato = obj.RN_Calcular_Ventas_Por_Tipo_Pago("Deposito");

            if (dato.Rows.Count > 0)
            {
                for (int i = 0; i < dato.Rows.Count; i++)
                {
                    DataRow dr = dato.Rows[i];
                    subImporte = subImporte + Convert.ToDouble(dr["ImporteCaja"]);
                }
                lbl_SalienDeposi.Text = subImporte.ToString("###0.00");
            }
            else
            {
                lbl_SalienDeposi.Text = "00";
            }
        }

        private void Btn_calcular_Click(object sender, EventArgs e)
        {
            double xxtotalIngreso = 0;
            double xxtotalEgreso = 0;
            double ingresoBruto = 0;
            double ventaTotalNeto = 0;

            try
            {
                ingresoBruto = Convert.ToDouble(Lbl_Efectivo_boleta.Text) + Convert.ToDouble(Lbl_Efectivo_factura.Text)+ Convert.ToDouble(Lbl_Efectivo_Notas.Text) + Convert.ToDouble(Lbl_otroIngresoEfectivo.Text) + Convert.ToDouble(Lbl_Ingreso_Deposito.Text);
                Lbl_totalIngreso.Text = ingresoBruto.ToString("###0.00");
                xxtotalIngreso = ingresoBruto + Convert.ToDouble(Lbl_aperturaCaja.Text);
                lbl_totalingre_bruto.Text = xxtotalIngreso.ToString("###0.00");

                xxtotalEgreso = Convert.ToDouble(Lbl_SalidaEfectivo.Text);
                Lbl_Total_Salida.Text = Convert.ToString(xxtotalEgreso + Convert.ToDouble(lbl_SalienDeposi.Text));
                lbl_xTotalEgreso.Text = Convert.ToString(xxtotalEgreso + Convert.ToDouble(lbl_SalienDeposi.Text));

                ventaTotalNeto = Convert.ToDouble(Lbl_Efectivo_boleta.Text) - Convert.ToDouble(Lbl_Total_Salida.Text);
                lbl_IngresoEfectivo_Neto.Text = ventaTotalNeto.ToString("###0.00");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txt_totalEntregar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double saldonext = 0;
                saldonext = Convert.ToDouble(lbl_IngresoEfectivo_Neto.Text) - Convert.ToDouble(txt_totalEntregar.Text);
                txt_SaldoNext.Text = saldonext.ToString("###0.00");

            }
        }

        private void Guardar_Cierre_Caja()
        {
            RN_Cierre_Caja obj = new RN_Cierre_Caja();
            EN_Cierre_Caja ci = new EN_Cierre_Caja();
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Exito ver = new Frm_Exito();

            try
            {
                ci.IdCierre = lbl_idcaja.Text;
                ci.AperturaCaja = Convert.ToDouble(Lbl_aperturaCaja.Text);
                ci.TotalIngreso = Convert.ToDouble(Lbl_totalIngreso.Text);
                ci.TotalEgreso = Convert.ToDouble(Lbl_Total_Salida.Text);
                ci.IdUsu = Convert.ToInt32(Cls_Libreria.IdUsu);
                ci.TotalDeposito = Convert.ToDouble(Lbl_Ingreso_Deposito.Text);
                ci.TotalGanancia = Convert.ToDouble(Lbl_UtilidadTotal.Text);
                ci.TotalEntregado = Convert.ToDouble(txt_totalEntregar.Text);
                ci.SaldoSiguiente = Convert.ToDouble(txt_SaldoNext.Text);
                ci.TotalBoleta = Convert.ToDouble(Lbl_Efectivo_boleta.Text);
                ci.TotalFactura = Convert.ToDouble(Lbl_Efectivo_factura.Text);
                ci.TotalNota = Convert.ToDouble(Lbl_Efectivo_Notas.Text);
                ci.TotalCreditoCobrado = Convert.ToDouble(Lbl_CreditoAbonado.Text);
                ci.TotalCreditoEmitido = Convert.ToDouble(Lbl_TotalCreditos.Text);

                obj.RN_Registrar_Cierre_Caja(ci);

                if (BD_Cierre_Caja.guardado == true)
                {
                    fil.Show();
                    ver.lbl_Msm1.Text = "La caja se ha cerrado exitosamente";
                    ver.ShowDialog();
                    fil.Hide();
                    this.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Calcular_Ganancias_Dia()
        {
            RN_Cierre_Caja obj = new RN_Cierre_Caja();
            DataTable dato = new DataTable();

            double subImporte = 0;

            dato = obj.RN_Calcular_Ganancias_Dia();

            if (dato.Rows.Count > 0)
            {
                for (int i = 0; i < dato.Rows.Count; i++)
                {
                    DataRow dr = dato.Rows[i];
                    subImporte = subImporte + Convert.ToDouble(dr["ImporteCaja"]);
                }
                Lbl_UtilidadTotal.Text = subImporte.ToString("###0.00");
            }
            else
            {
                Lbl_UtilidadTotal.Text = "00";
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Guardar_Cierre_Caja();
        }
    }
}
