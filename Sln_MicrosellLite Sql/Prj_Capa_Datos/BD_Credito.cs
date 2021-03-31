using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Prj_Capa_Entidad;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Prj_Capa_Datos
{
    public class BD_Credito : BD_Conexion
    {
        public static bool credSaved = false;
        public static bool detcredSaved = false;
        public void BD_Registrar_Credito(EN_Credito cre)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand cmd = new SqlCommand("Sp_Registrar_Credito", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idnotacredito", cre.IdCredito);
                cmd.Parameters.AddWithValue("@idDoc", cre.IdDoc);
                cmd.Parameters.AddWithValue("@Fecha_Credito", cre.FechaCredito);
                cmd.Parameters.AddWithValue("@nomcliente", cre.NomCliente);
                cmd.Parameters.AddWithValue("@total_ped", cre.TotalCredito);
                cmd.Parameters.AddWithValue("@Saldo_Pdnte", cre.SaldoPdnte);
                cmd.Parameters.AddWithValue("@Fecha_vncmnto", cre.FechaVencimiento);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();


                credSaved = true;
            }
            catch (Exception ex)
            {
                credSaved = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar" + ex.Message, "Capa Datos Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        public void BD_Registrar_Detalle_Credito(EN_Det_Credito cre)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand cmd = new SqlCommand("Sp_ingresar_det_Credito", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idnotacredito", cre.IdCredito);
                cmd.Parameters.AddWithValue("@Acuenta", cre.Acuenta);
                cmd.Parameters.AddWithValue("@saldoactual", cre.SaldoActual);
                cmd.Parameters.AddWithValue("@Fecha_Pago", cre.FechaPago);
                cmd.Parameters.AddWithValue("@TipoPago", cre.TipoPago);
                cmd.Parameters.AddWithValue("@nroOpera", cre.NroOperacion);
                cmd.Parameters.AddWithValue("@idUsu", cre.IdUsu);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();


                detcredSaved = true;
            }
            catch (Exception ex)
            {
                detcredSaved = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar" + ex.Message, "Capa Datos Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        public static double BD_Sumar_Total_Credito_Por_Cliente(string idCliente)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conectar2();
                SqlCommand da = new SqlCommand("Sp_Ver_SumaTotal_credito_xcliente",cn);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@nomcliente", idCliente);
                double totalCredito = 0;

                cn.Open();
                totalCredito = Convert.ToDouble(da.ExecuteScalar());
                cn.Close();
                return totalCredito;
            }
            catch (Exception ex)
            {
                detcredSaved = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar" + ex.Message, "Capa Datos Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
        }

        public DataTable BD_Listar_Todos_Creditos()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Ver_Todo_Credito", cn);
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

        public DataTable BD_Listar_Todos_Creditos_Valor(string valor)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Buscador_creditos", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@nomcliente", valor);

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
