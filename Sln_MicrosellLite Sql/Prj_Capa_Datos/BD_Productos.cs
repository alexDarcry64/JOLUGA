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
   public  class BD_Productos: BD_Conexion
    {
        public static bool seguardo = false;
        public static bool seedito = false;
        public void BD_Registrar_Producoto(EN_Producto pro)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand cmd = new SqlCommand("Sp_registrar_Producto", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idpro", pro.Idpro);
                cmd.Parameters.AddWithValue("@idprove", pro.Idprove);
                cmd.Parameters.AddWithValue("@descripcion", pro.Descripcion);
                cmd.Parameters.AddWithValue("@Pre_compra", pro.Pre_compra);
                cmd.Parameters.AddWithValue("@StockActual", pro.StockActual);
                cmd.Parameters.AddWithValue("@idCat", pro.IdCat);
                cmd.Parameters.AddWithValue("@idMar", pro.IdMar);
                cmd.Parameters.AddWithValue("@Foto", pro.Foto);
                cmd.Parameters.AddWithValue("@Pre_Venta_Menor", pro.Pre_Venta_Menor);
                cmd.Parameters.AddWithValue("@Pre_Venta_Mayor", pro.Pre_Venta_Mayor);
                cmd.Parameters.AddWithValue("@Pre_Venta", pro.Pre_Venta);
                cmd.Parameters.AddWithValue("@UndMdida", pro.UndMdida);
                cmd.Parameters.AddWithValue("@PesoUnit", pro.PesoUnit);
                cmd.Parameters.AddWithValue("@Utilidad", pro.Utilidad);
                cmd.Parameters.AddWithValue("@TipoProd", pro.TipoProd);
                cmd.Parameters.AddWithValue("@ValorporProd", pro.ValorporProd);
                cmd.Parameters.AddWithValue("@ClaveSAT", pro.ClaveSAT);

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

        public void BD_Editar_Producto(EN_Producto pro)

        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand cmd = new SqlCommand("Sp_Editar_Producto", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idpro", pro.Idpro);
                cmd.Parameters.AddWithValue("@idprove", pro.Idprove);
                cmd.Parameters.AddWithValue("@descripcion", pro.Descripcion);
                cmd.Parameters.AddWithValue("@Pre_compra", pro.Pre_compra);
                cmd.Parameters.AddWithValue("@idCat", pro.IdCat);
                cmd.Parameters.AddWithValue("@idMar", pro.IdMar);
                cmd.Parameters.AddWithValue("@Foto", pro.Foto);
                cmd.Parameters.AddWithValue("@Pre_Venta_Menor", pro.Pre_Venta_Menor);
                cmd.Parameters.AddWithValue("@Pre_Venta_Mayor", pro.Pre_Venta_Mayor);
                cmd.Parameters.AddWithValue("@Pre_Venta", pro.Pre_Venta);
                cmd.Parameters.AddWithValue("@UndMdida", pro.UndMdida);
                cmd.Parameters.AddWithValue("@PesoUnit", pro.PesoUnit);
                cmd.Parameters.AddWithValue("@Utilidad", pro.Utilidad);
                cmd.Parameters.AddWithValue("@TipoProd", pro.TipoProd);
                cmd.Parameters.AddWithValue("@ClaveSAT", pro.ClaveSAT);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                seedito = true;

            }
            catch (Exception ex)
            {
                seedito = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar" + ex.Message, "Capa Datos Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        public DataTable BD_Mostrar_Todos_Productos()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("sp_cargar_Todos_Productos", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable data = new DataTable();

                da.Fill(data);

                da = null;
                return data;
            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al consultar" + ex.Message, "Capa Datos Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }

        }


        public DataTable BD_Buscar_Productos(string valor)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_buscador_Productos", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@valor" , valor);
                DataTable data = new DataTable();

                da.Fill(data);

                da = null;
                return data;
            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al consultar" + ex.Message, "Capa Datos Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }

        }


        public void BD_Dar_Producto(string idprod)

        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand cmd = new SqlCommand("Sp_Darbaja_Producto", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idpro", idprod);
                

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                seedito = true;

            }
            catch (Exception ex)
            {
                seedito = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar" + ex.Message, "Capa Datos Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void BD_Eliminar_Producto(string idprod)

        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand cmd = new SqlCommand("sp_Eliminar_Producto", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idpro", idprod);


                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                seedito = true;

            }
            catch (Exception ex)
            {
                seedito = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar" + ex.Message, "Capa Datos Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        public void BD_Sumar_Stock_Producto(string idprod, double stock)

        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand cmd = new SqlCommand("sp_SumarStock", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idpro", idprod);
                cmd.Parameters.AddWithValue("@stock", stock);


                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                seedito = true;

            }
            catch (Exception ex)
            {
                seedito = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar" + ex.Message, "Capa Datos Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void BD_Restar_Stock_Producto(string idprod, double stock)

        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand cmd = new SqlCommand("sp_Restar_Stock", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idpro", idprod);
                cmd.Parameters.AddWithValue("@stock", stock);


                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                seedito = true;

            }
            catch (Exception ex)
            {
                seedito = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar" + ex.Message, "Capa Datos Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        public void BD_Actualizar_PrecioCompra_Producto(string idprod, double precompra, double preVenta_mnor, double utilidad, double valoralmacen)

        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand cmd = new SqlCommand("Sp_Actulizar_Precios_CompraVenta_Producto", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idpro", idprod);
                cmd.Parameters.AddWithValue("@Pre_Compra", precompra);
                cmd.Parameters.AddWithValue("@Pre_vntaxMenor", preVenta_mnor);
                cmd.Parameters.AddWithValue("@Utilidad", utilidad);
                cmd.Parameters.AddWithValue("@ValorAlmacen", valoralmacen);


                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                seedito = true;

            }
            catch (Exception ex)
            {
                seedito = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar" + ex.Message, "Capa Datos Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


    }
}
