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
    public class BD_Cotizacion : BD_Conexion
    {
        public static bool guardo = false;
        public static bool edito = false;

        public void BD_Registrar_Cotizacion(EN_Cotizacion cot)

        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand cmd = new SqlCommand("Sp_Registrar_Cotizacion", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Cotiza", cot.IdCotizacion);
                cmd.Parameters.AddWithValue("@Id_Ped", cot.IdPedido);
                cmd.Parameters.AddWithValue("@Vigencia", cot.Vigencia);
                cmd.Parameters.AddWithValue("@TotalCotiza", cot.TotalCoti);
                cmd.Parameters.AddWithValue("@Condiciones", cot.Condiciones);
                cmd.Parameters.AddWithValue("@PrecioconIgv", cot.PrecioConIgv);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                guardo = true;

            }
            catch (Exception ex)
            {
                guardo = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar" + ex.Message, "Capa Datos Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void BD_Editar_Cotizacion(EN_Cotizacion cot)

        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand cmd = new SqlCommand("Sp_Editar_Cotizacion", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Cotiza", cot.IdCotizacion);
                cmd.Parameters.AddWithValue("@Id_Ped", cot.IdPedido);
                cmd.Parameters.AddWithValue("@FechaCoti", cot.FechaCotizacion);
                cmd.Parameters.AddWithValue("@Vigencia", cot.Vigencia);
                cmd.Parameters.AddWithValue("@TotalCotiza", cot.TotalCoti);
                cmd.Parameters.AddWithValue("@Condiciones", cot.Condiciones);
                cmd.Parameters.AddWithValue("@PrecioconIgv", cot.PrecioConIgv);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                edito = true;

            }
            catch (Exception ex)
            {
                edito = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar" + ex.Message, "Capa Datos Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void BD_Cambiar_Estado_Cotizacion(string idCotizacion, string estadoCot)

        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand cmd = new SqlCommand("Sp_Cambiar_Estado_Cotizacion", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_coti", idCotizacion);
                cmd.Parameters.AddWithValue("@Estadocoti", estadoCot);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                edito = true;

            }
            catch (Exception ex)
            {
                edito = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar" + ex.Message, "Capa Datos Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public DataTable BD_Buscar_Cotizaciones_Editar(string nroCot)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Buscar_Cotizaciones_yDetalle", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Nro_coti", nroCot);

                DataTable data = new DataTable();
                da.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                edito = false;
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
