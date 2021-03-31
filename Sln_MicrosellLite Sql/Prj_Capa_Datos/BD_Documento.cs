using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prj_Capa_Entidad;

using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Prj_Capa_Datos
{
    public class BD_Documento : BD_Conexion
    {
        public bool BD_VerificarProducto_NroDoc(string nrDoc)
        {
            bool respuesta = false;
            Int32 value = 0;
            SqlConnection cn = new SqlConnection();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cn.ConnectionString = Conectar();
                cmd.CommandText = "Sp_Validar_Id_Doc";
                cmd.Connection = cn;
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Doc", nrDoc);

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
                seguardo = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al Guardar: " + ex.Message);
                respuesta = false;
            }
            return respuesta;
        }

        public static bool seguardo = false;

        public void BD_Registrar_Documento(EN_Documento doc)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar2();
                SqlCommand cmd = new SqlCommand("Sp_Insert_Documento", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_Doc", doc.IdDoc);
                cmd.Parameters.AddWithValue("@id_Ped", doc.IdPedido);
                cmd.Parameters.AddWithValue("@Id_Tipo", doc.IdTipo);
                cmd.Parameters.AddWithValue("@Fecha_Emi", doc.FechaDoc);
                cmd.Parameters.AddWithValue("@Importe", doc.Importe);
                cmd.Parameters.AddWithValue("@TipoPago", doc.TipoPago);
                cmd.Parameters.AddWithValue("@NroOpera", doc.NrOperacion);
                cmd.Parameters.AddWithValue("@id_Usu", doc.IdUsu);
                cmd.Parameters.AddWithValue("@Igv", doc.Igv);
                cmd.Parameters.AddWithValue("@son", doc.SonLetra);
                cmd.Parameters.AddWithValue("@TotalGanancia", doc.TotalGanancia);

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

        public void BD_Actualizar_Totales_Documento(string idDoc, double importe, double igv, string sonLe)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar2();
                SqlCommand cmd = new SqlCommand("Sp_Insert_Documento", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Doc", idDoc);
                cmd.Parameters.AddWithValue("@importe", importe);
                cmd.Parameters.AddWithValue("@Igv", igv);
                cmd.Parameters.AddWithValue("@son", sonLe);

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

        public DataTable BD_Buscador_Documentos_Valor(string valor)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Buscador_Documentos_xValor", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Xvalor", valor);

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

        public DataTable BD_Buscador_Documentos_Dia(DateTime xDia)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Listar_Doc_emitoshoy", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@FechaActual", xDia);

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

        public DataTable BD_Buscador_Documentos_Mes(DateTime xMes)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Leer_Fcturas_Emtidas_EnunMes", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Fecha_Mes", xMes);

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

        public DataTable BD_Buscador_Documentos_Mes_TipoDoc(DateTime xMes, int idTipo)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Leer_Comprobantes_Emtidas_EnunMes", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Fecha_Mes", xMes);
                da.SelectCommand.Parameters.AddWithValue("@Docu", idTipo);

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

        public DataTable BD_Buscador_Detalle_PorID(string idDoc)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Buscar_Documento_yDetalle", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Nro_Doc", idDoc);

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

        public void BD_Anular_Documento(string idDoc, string estadoDoc)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar2();
                SqlCommand cmd = new SqlCommand("Sp_Anular_Documento", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Doc", idDoc);
                cmd.Parameters.AddWithValue("@estado", estadoDoc);

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

        public void BD_Cambiar_TipoPago(string idDoc, string tipoPago)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar2();
                SqlCommand cmd = new SqlCommand("Sp_Cambiar_TipoPago_Documento", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Doc", idDoc);
                cmd.Parameters.AddWithValue("@tipoPago", tipoPago);

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

        public DataTable BD_ListarTodos_Documentos()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Listar_Todos_Documentos", cn);
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
