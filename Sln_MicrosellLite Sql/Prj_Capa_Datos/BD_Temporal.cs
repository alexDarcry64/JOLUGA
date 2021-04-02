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
    public class BD_Temporal : BD_Conexion
    {

        public static bool guardado = false;

        public void BD_Registrar_Temporal(EN_Temporal tem)

        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand cmd = new SqlCommand("Sp_Insertar_Temporal", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codTem", tem.IdTemporal);
                cmd.Parameters.AddWithValue("@FechaEmi", tem.FechaEmi);
                cmd.Parameters.AddWithValue("@cliente", tem.NomCliente);
                cmd.Parameters.AddWithValue("@Ruc", tem.Ruc);
                cmd.Parameters.AddWithValue("@Direccion", tem.Direccion);
                cmd.Parameters.AddWithValue("@SubTtal", tem.SubTotal);
                cmd.Parameters.AddWithValue("@IgvT", tem.IdTemporal);
                cmd.Parameters.AddWithValue("@TotalT", tem.Total);
                cmd.Parameters.AddWithValue("@SonT", tem.Sonletra);
                cmd.Parameters.AddWithValue("@vendedor", tem.Vendedor);

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

        public void BD_Registrar_Detalle_Temporal(EN_Det_Temporal tem)

        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand cmd = new SqlCommand("Sp_registrar_Det_Temporal", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codtem", tem.IdTempo);
                cmd.Parameters.AddWithValue("@CodProd", tem.CodProd);
                cmd.Parameters.AddWithValue("@Cantidad", tem.Canti);
                cmd.Parameters.AddWithValue("@Producto", tem.Producto);
                cmd.Parameters.AddWithValue("@PreUnt", tem.Precio);
                cmd.Parameters.AddWithValue("@Importe", tem.Importe);

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

        public DataTable BD_LeerTemporal_Id(string idTemp)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Listar_Temporales", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@id", idTemp);

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

        public void BD_Eliminar_Temporal(string idTemp)

        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand cmd = new SqlCommand("Sp_Delete_Det_Temporal", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", idTemp);

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
    }
}
