using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Prj_Capa_Entidad;

namespace Prj_Capa_Datos
{
    public class BD_Caja : BD_Conexion
    {
        public static bool seguardo;

        public void BD_Registrar_Movimiento_Caja(EN_Caja caja)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar2();
                SqlCommand cmd = new SqlCommand("sp_registrar_Caja", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Fecha_Caja", caja.FechaCaja);
                cmd.Parameters.AddWithValue("@Tipo_Caja", caja.TipoCaja);
                cmd.Parameters.AddWithValue("@Concepto", caja.Concepto);
                cmd.Parameters.AddWithValue("@De_Para", caja.DePara_Cliente);
                cmd.Parameters.AddWithValue("@Nro_Doc", caja.Nr_Documento);
                cmd.Parameters.AddWithValue("@ImporteCaja", caja.ImporteCaja);
                cmd.Parameters.AddWithValue("@Id_Usu", caja.IdUsu);
                cmd.Parameters.AddWithValue("@TotalUti", caja.TotalUtilidad);
                cmd.Parameters.AddWithValue("@TipoPago", caja.TipoPago);
                cmd.Parameters.AddWithValue("@GeneradoPor", caja.GeneradoPor);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                seguardo = true;

            }
            catch (Exception ex)
            {
                seguardo = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar" + ex.Message, "Capa Datos Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void BD_Actualizar_Total_Caja(string nrDoc, double total, double totalUtil, string tipoPago)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar2();
                SqlCommand cmd = new SqlCommand("Sp_Actualizar_Total_Caja", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nro_doc", nrDoc);
                cmd.Parameters.AddWithValue("@total", total);
                cmd.Parameters.AddWithValue("@TotalUtilidad", totalUtil);
                cmd.Parameters.AddWithValue("@TipoPago", tipoPago);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                seguardo = true;

            }
            catch (Exception ex)
            {
                seguardo = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar" + ex.Message, "Capa Datos Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public DataTable BD_ListarTodas_cajas()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Listar_Todas_Cajas", cn);
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

        public DataTable BD_Listar_Cajas_Dia()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Listar_Cajas_delDia", cn);
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

        public DataTable BD_Listar_Cajas_Mes (DateTime xmes)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Listar_Cajas_del_Mes", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@fechas", xmes);

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

        public DataTable BD_Buscador_General_Cajas(string valor)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Buscador_MoviCaja_xValor", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@xvalor", valor);

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
