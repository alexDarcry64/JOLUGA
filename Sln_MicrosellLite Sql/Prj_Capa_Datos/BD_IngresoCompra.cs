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
    public class BD_IngresoCompra : BD_Conexion
    {
        public static bool guardado = false;
        public static bool detguardado = false;
        public static bool edito = false;
        public void BD_Insertar_RegistroCompra(EN_IngresoCompra compra)

        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand cmd = new SqlCommand("Sp_Registrar_Compra", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCom", compra.IdCom);
                cmd.Parameters.AddWithValue("@Nro_Fac_Fisico", compra.Nro_Fac_Fisico1);
                cmd.Parameters.AddWithValue("@IdProvee", compra.IdProvee1);
                cmd.Parameters.AddWithValue("@SubTotal_Com", compra.SubTotal_Com1);
                cmd.Parameters.AddWithValue("@FechaIngre", compra.FechaIngre1);
                cmd.Parameters.AddWithValue("@TotalCompra", compra.TotalCompra1);
                cmd.Parameters.AddWithValue("@IdUsu", compra.IdUsu1);
                cmd.Parameters.AddWithValue("@ModalidadPago", compra.ModalidadPago1);
                cmd.Parameters.AddWithValue("@TiempoEspera", compra.TiempoEspera1);
                cmd.Parameters.AddWithValue("@FechaVence", compra.FechaVence1);
                cmd.Parameters.AddWithValue("@EstadoIngre", compra.EstadoIngre1);
                cmd.Parameters.AddWithValue("@RecibiConforme", compra.RecibiConforme1);
                cmd.Parameters.AddWithValue("@Datos_Adicional", compra.Datos_Adicional1);
                cmd.Parameters.AddWithValue("@Tipo_Doc_Compra", compra.Tipo_Doc_Compra1);

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

        public void BD_Insertar_Detalle_RegistroCompra(EN_Det_IngresoCompra compra)

        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand cmd = new SqlCommand("Sp_Insert_Detalle_ingreso", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_ingreso", compra.Id_ingreso1);
                cmd.Parameters.AddWithValue("@Id_Pro", compra.Id_Pro1);
                cmd.Parameters.AddWithValue("@Precio", compra.Precio1);
                cmd.Parameters.AddWithValue("@Cantidad", compra.Cantidad1);
                cmd.Parameters.AddWithValue("@Importe", compra.Importe1);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                detguardado = true;

            }
            catch (Exception ex)
            {
                detguardado = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar" + ex.Message, "Capa Datos Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public bool BD_Verificar_NroDocFisico(string fisico)
        {
            bool respuesta = false;
            Int32 value = 0;
            SqlConnection cn = new SqlConnection();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cn.ConnectionString = Conectar();
                cmd.CommandText = "sp_validar_NroFisico_Compra";
                cmd.Connection = cn;
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nro_Doc_fisico", fisico);

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

        public DataTable BD_Buscar_Compras(string valor)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Buscador_Gnral_deCompras", cn);
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

        public DataTable BD_Cargar_TodasCompras()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Leer_Todas_Facturas_Compras", cn);
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

        public DataTable BD_Buscar_Compras_Dia(string tipo, DateTime fecha)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Facturas_Ingresadas_alDia", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@tipo", tipo);
                da.SelectCommand.Parameters.AddWithValue("@fecha", fecha);

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

        public void BD_Borrar_Compra(string idCompra)

        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand cmd = new SqlCommand("SP_Borrar_Factura_Ingresada", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Fac", idCompra);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                detguardado = true;

            }
            catch (Exception ex)
            {
                detguardado = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar" + ex.Message, "Capa Datos Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
