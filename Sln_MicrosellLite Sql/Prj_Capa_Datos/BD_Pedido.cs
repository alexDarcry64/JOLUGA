using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Prj_Capa_Entidad;
using System.Data.SqlClient;

namespace Prj_Capa_Datos
{
    public class BD_Pedido : BD_Conexion
    {
        public static bool guarda = false;
        public static bool detalleguarda = false;

        public void BD_Insertar_Pedido(EN_Pedido ped)

        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand cmd = new SqlCommand("Sp_Registrar_Pedido", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_Ped", ped.Id_pedido);
                cmd.Parameters.AddWithValue("@Id_Cliente", ped.IdCliente);
                cmd.Parameters.AddWithValue("@SubTotal", ped.SubTotal);
                cmd.Parameters.AddWithValue("@IgvPed", ped.Igv);
                cmd.Parameters.AddWithValue("@TotalPed", ped.TotalPedido);
                cmd.Parameters.AddWithValue("@id_Usu", ped.IdUsuario);
                cmd.Parameters.AddWithValue("@TotalGancia", ped.TotalGanancia);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                guarda = true;

            }
            catch (Exception ex)
            {
                guarda = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar" + ex.Message, "Capa Datos Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void BD_Insertar_Detalle_Pedido(EN_Det_Pedido ped)

        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand cmd = new SqlCommand("sp_Registrar_detalle_Pedido", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_Ped", ped.IdPed);
                cmd.Parameters.AddWithValue("@Id_Pro", ped.IdPro);
                cmd.Parameters.AddWithValue("@Precio", ped.Precio);
                cmd.Parameters.AddWithValue("@Cantidad", ped.Cantidad);
                cmd.Parameters.AddWithValue("@Importe", ped.Importe);
                cmd.Parameters.AddWithValue("@Tipo_Prod", ped.TipoProd);
                cmd.Parameters.AddWithValue("@Und_Medida", ped.UnidadMedida);
                cmd.Parameters.AddWithValue("@Utilidad_Unit", ped.UtilidadUnit);
                cmd.Parameters.AddWithValue("@TotalUtilidad", ped.TotalUtilidad);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                detalleguarda = true;

            }
            catch (Exception ex)
            {
                detalleguarda = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar" + ex.Message, "Capa Datos Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void BD_Eliminar_Detalle_Pedido(string idPedido)

        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand cmd = new SqlCommand("sp_eliminar_detalle_Pedido", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_Ped", idPedido);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                guarda = true;

            }
            catch (Exception ex)
            {
                guarda = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar" + ex.Message, "Capa Datos Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void BD_Editar_Pedido(EN_Pedido ped)

        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand cmd = new SqlCommand("Sp_Editar_Pedido", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_Ped", ped.Id_pedido);
                cmd.Parameters.AddWithValue("@Id_Cliente", ped.IdCliente);
                cmd.Parameters.AddWithValue("@SubTotal", ped.SubTotal);
                cmd.Parameters.AddWithValue("@IgvPed", ped.Igv);
                cmd.Parameters.AddWithValue("@TotalPed", ped.TotalPedido);
                cmd.Parameters.AddWithValue("@id_Usu", ped.IdUsuario);
                cmd.Parameters.AddWithValue("@TotalGancia", ped.TotalGanancia);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                guarda = true;

            }
            catch (Exception ex)
            {
                guarda = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar" + ex.Message, "Capa Datos Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public bool BD_Verificar_NroPedido(string nroPedido)
        {
            bool respuesta = false;
            Int32 value = 0;
            SqlConnection cn = new SqlConnection();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cn.ConnectionString = Conectar();
                cmd.CommandText = "Sp_Verificar_Id_Pedido";
                cmd.Connection = cn;
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Ped", nroPedido);

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

        public void BD_Pedido_Atendido(string idPedido)

        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand cmd = new SqlCommand("Sp_Pedido_Atendido", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Ped", idPedido);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                guarda = true;

            }
            catch (Exception ex)
            {
                guarda = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar" + ex.Message, "Capa Datos Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void BD_Cambiar_Cliente_Pedido(string idPedido, string idCliente)

        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand cmd = new SqlCommand("Sp_Actu_clien_Ped", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Ped", idPedido);
                cmd.Parameters.AddWithValue("@Id_cli", idCliente); 

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                guarda = true;

            }
            catch (Exception ex)
            {
                guarda = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar" + ex.Message, "Capa Datos Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void BD_Eliminar_Pedido_Permanente(string idPedido)

        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand cmd = new SqlCommand("Sp_Eliminar_Pedido_Completo" +
                    "", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Ped", idPedido);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                guarda = true;

            }
            catch (Exception ex)
            {
                guarda = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar" + ex.Message, "Capa Datos Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public DataTable BD_Buscar_Pedido_Editar(string idPedido)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Buscar_Pedido_Para_Editar", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Id_Ped", idPedido);

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

        public DataTable BD_Buscar_Pedido_Valor(string valor)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_buscar_Pedidos_porValor", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@valor", valor);

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

        public DataTable BD_Buscar_Pedido_Fecha(string tipo, DateTime fecha)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Listar_Pedidos_porFecha", cn);
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

        public DataTable BD_Buscar_Pedido_Atender()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Leer_Pedidos_PorAtender", cn);
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

        //public DataTable BD_Cargar_Todos_Pedidos()
        //{
        //    SqlConnection cn = new SqlConnection();
        //    try
        //    {
        //        cn.ConnectionString = Conectar();
        //        SqlDataAdapter da = new SqlDataAdapter("Sp_Buscar_Pedido_Para_Editar", cn);
        //        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        //        da.SelectCommand.Parameters.AddWithValue("@Id_Ped", idPedido);

        //        DataTable data = new DataTable();
        //        da.Fill(data);
        //        return data;
        //    }
        //    catch (Exception ex)
        //    {
        //        if (cn.State == ConnectionState.Open)
        //        {
        //            cn.Close();
        //        }
        //        MessageBox.Show("Error al guardar" + ex.Message, "Capa Datos Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    }
        //    return null;
        //}
    }
}
