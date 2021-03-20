using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using Prj_Capa_Entidad;
using System.Windows.Forms;

namespace Prj_Capa_Datos
{
    public class BD_Kardex : BD_Conexion
    {
        public static bool seguardo = false;

        public void BD_Registrar_Kardex(string idkardex, string idProducto, string idProveedor)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar2();
                SqlCommand cmd = new SqlCommand("sp_crear_kardex", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idkardex", idkardex);
                cmd.Parameters.AddWithValue("@idprod", idProducto);
                cmd.Parameters.AddWithValue("@idprovee", idProveedor);

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

        public void BD_Registrar_Detalle_Kardex(EN_Kardexcs kar)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand cmd = new SqlCommand("Sp_registrar_detalle_kardex", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Krdx", kar.Idkardex);
                cmd.Parameters.AddWithValue("@Item", kar.Item);
                cmd.Parameters.AddWithValue("@Doc_Soport", kar.Doc_soporte);
                cmd.Parameters.AddWithValue("@Det_Operacion", kar.Det_operacion);
                cmd.Parameters.AddWithValue("@Cantidad_In", kar.Cantidad_in);
                cmd.Parameters.AddWithValue("@Precio_Unt_In", kar.Precio_in);
                cmd.Parameters.AddWithValue("@Costo_Total_In", kar.Total_in);
                cmd.Parameters.AddWithValue("@Cantidad_Out", kar.Cantidad_out);
                cmd.Parameters.AddWithValue("@Precio_Unt_Out", kar.Precio_out);
                cmd.Parameters.AddWithValue("@Importe_Total_Out", kar.Importe_total_out);
                cmd.Parameters.AddWithValue("@Cantidad_Saldo", kar.Cantidad_saldo);
                cmd.Parameters.AddWithValue("@Promedio", kar.Promedio);
                cmd.Parameters.AddWithValue("@Costo_Total_Saldo", kar.Total_saldo);

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

        public bool BD_VerificarProducto_Cardex(string idProducto)
        {
            bool respuesta = false;
            Int32 value = 0;
            SqlConnection cn = new SqlConnection();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cn.ConnectionString = Conectar();
                cmd.CommandText = "Sp_Ver_sihay_Kardex";
                cmd.Connection = cn;
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Prod", idProducto);

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
            catch(Exception ex)
            {
                seguardo = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al Guardar: "+ex.Message);
                respuesta = false;
            }
            return respuesta;
        }

        public DataTable BD_KardexDetalle_Producto(string idCliente)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Buscador_DeKardex_Principal_yDetalle", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@xvalor", idCliente);

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
