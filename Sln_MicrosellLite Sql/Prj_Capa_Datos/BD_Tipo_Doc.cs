using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Prj_Capa_Datos
{
    public class BD_Tipo_Doc : BD_Conexion
    {
        public static string BD_Nro_id(int idTipo)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar2();
                SqlCommand cmd = new SqlCommand("Sp_Listado_Tipo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Tipo",idTipo);

                string NumDoc;
                cn.Open();
                NumDoc = Convert.ToString(cmd.ExecuteScalar());
                cn.Close();
                return NumDoc;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                cn.Dispose();
                cn = null;
                return null;
            }
        }

        public static void BD_Actualizar_Tipo_Doc(int idTipo)
        {
            SqlConnection cn = new SqlConnection();
            
            try
            {
                cn.ConnectionString = Conectar2();
                SqlCommand cmd = new SqlCommand("dbo.Sp_Actualiza_Tipo_Doc", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Tipo", idTipo);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        public static void BD_Actualizar_NumeroCorrelativo_Producto(int idTipo)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conectar2();
                SqlCommand cmd = new SqlCommand("Sp_Actualiza_Tipo_Prodcto", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Tipo", idTipo);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        public static void BD_Actualizar_Tipo_Cambio(int idTipo, double tipoCambio)
        {
            SqlConnection cn = new SqlConnection();
            
            try
            {
                cn.ConnectionString = Conectar2();
                SqlCommand cmd = new SqlCommand("Sp_Editar_Tipo_Cambio", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idtipo", idTipo);
                cmd.Parameters.AddWithValue("@numero", tipoCambio);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        public static double BD_Leer_Tipo_Cambio(int idTipo)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conectar2();
                SqlCommand cmd = new SqlCommand("Sp_Listado_TipoCambio", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Tipo", idTipo);
                double tipoCambio;
                cn.Open();
                tipoCambio = Convert.ToDouble(cmd.ExecuteScalar());
                cn.Close();

                cmd.Dispose();
                return tipoCambio;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                return 0;
            }
        }
    }
}
