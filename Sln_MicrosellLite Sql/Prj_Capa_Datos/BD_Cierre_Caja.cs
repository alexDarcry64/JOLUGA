using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prj_Capa_Entidad;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Prj_Capa_Datos
{
    public class BD_Cierre_Caja : BD_Conexion
    {
        public static bool guardado = false;

        public void BD_Registrar_Inicio_Caja(EN_Cierre_Caja caja)

        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand cmd = new SqlCommand("Reg_Cierre_Caja", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCierre", caja.IdCierre);
                cmd.Parameters.AddWithValue("@Apertura_Caja", caja.AperturaCaja);
                cmd.Parameters.AddWithValue("@Total_Ingreso", caja.TotalIngreso);
                cmd.Parameters.AddWithValue("@TotalEgreso", caja.TotalEgreso);
                cmd.Parameters.AddWithValue("@Id_usu", caja.IdUsu);
                cmd.Parameters.AddWithValue("@TodoDeposito", caja.TotalDeposito);
                cmd.Parameters.AddWithValue("@TotalGanancia", caja.TotalGanancia);
                cmd.Parameters.AddWithValue("@TotalEntregado", caja.TotalEntregado);
                cmd.Parameters.AddWithValue("@SaldoSiguiente", caja.SaldoSiguiente);
                cmd.Parameters.AddWithValue("@TotalFactura", caja.TotalFactura);
                cmd.Parameters.AddWithValue("@TotalBoleta", caja.TotalBoleta);
                cmd.Parameters.AddWithValue("@Totalnota", caja.TotalNota);
                cmd.Parameters.AddWithValue("@TotalCreditoCobrado", caja.TotalCreditoCobrado);
                cmd.Parameters.AddWithValue("@TotalCreditoEmitido", caja.TotalCreditoEmitido);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                guardado = true;

            }
            catch (Exception ex)
            {
                guardado = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar" + ex.Message, "Capa Datos Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void BD_Registrar_Cierre_Caja(EN_Cierre_Caja caja)

        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand cmd = new SqlCommand("sp_registrar_Cierre_Caja", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDCIERRE", caja.IdCierre);
                cmd.Parameters.AddWithValue("@Apertura_Caja", caja.AperturaCaja);
                cmd.Parameters.AddWithValue("@Total_Ingreso", caja.TotalIngreso);
                cmd.Parameters.AddWithValue("@TotalEgreso", caja.TotalEgreso);
                cmd.Parameters.AddWithValue("@Id_usu", caja.IdUsu);
                cmd.Parameters.AddWithValue("@TodoDeposito", caja.TotalDeposito);
                cmd.Parameters.AddWithValue("@TotalGanancia", caja.TotalGanancia);
                cmd.Parameters.AddWithValue("@TotalEntregado", caja.TotalEntregado);
                cmd.Parameters.AddWithValue("@SaldoSiguiente", caja.SaldoSiguiente);
                cmd.Parameters.AddWithValue("@TotalFactura", caja.TotalFactura);
                cmd.Parameters.AddWithValue("@TotalBoleta", caja.TotalBoleta);
                cmd.Parameters.AddWithValue("@Totalnota", caja.TotalNota);
                cmd.Parameters.AddWithValue("@TotalCreditoCobrado", caja.TotalCreditoCobrado);
                cmd.Parameters.AddWithValue("@TotalCreditoEmitido", caja.TotalCreditoEmitido);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                guardado = true;

            }
            catch (Exception ex)
            {
                guardado = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar" + ex.Message, "Capa Datos Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public DataTable BD_Listar_Cierre_Caja_Dia()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Cargar_CierreCaja_delDia", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;


                DataTable data = new DataTable();
                da.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar" + ex.Message, "Capa Datos Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }

        public bool BD_Validar_Inicio_Doble_Caja()
        {
            bool respuesta = false;
            Int32 value = 0;
            SqlConnection cn = new SqlConnection();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cn.ConnectionString = Conectar();
                cmd.CommandText = "SP_VALIDAR_REGISTRO_CAJA";
                cmd.Connection = cn;
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                value = Convert.ToInt32(cmd.ExecuteScalar());

                if (value > 0)
                {
                    respuesta = true;
                }
                else
                {
                    respuesta = false;
                }

                cmd.Parameters.Clear();
                cmd.Dispose();
                cmd = null;
                cn.Close();
            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al Guardar: " + ex.Message);
                respuesta = false;
            }
            return respuesta;
        }

        public DataTable BD_Calcular_Ventas_Por_Tipo_Doc(string nomTipoDoc)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Calcular_Ventas_PorTipoDoc", cn);
                da.SelectCommand.Parameters.AddWithValue("@tipodoc", nomTipoDoc);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;


                DataTable data = new DataTable();
                da.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar" + ex.Message, "Capa Datos Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }

        public DataTable BD_Calcular_Ventas_Por_Tipo_Pago(string tipoPago)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Calcular_Gastos_porTipoPago", cn);
                da.SelectCommand.Parameters.AddWithValue("@tipopago", tipoPago);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;


                DataTable data = new DataTable();
                da.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar" + ex.Message, "Capa Datos Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }

        public DataTable BD_Calcular_Ventas_Acredito()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Calcular_Ventas_aCredito", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;


                DataTable data = new DataTable();
                da.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar" + ex.Message, "Capa Datos Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }

        public DataTable BD_Calcular_Ventas_ADeposito()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Calcular_Ventas_aDeposito", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;


                DataTable data = new DataTable();
                da.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar" + ex.Message, "Capa Datos Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }

        public DataTable BD_Calcular_Ganancias_Dia()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Calcular_Ventas_GananciadelDia", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;


                DataTable data = new DataTable();
                da.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar" + ex.Message, "Capa Datos Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }
    }
}
