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
 public class BD_Categoria:BD_Conexion
    {
        public void  BD_Registrar_Categoria(string nomCateg)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand cmd = new SqlCommand("sp_registrar_categoria", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", nomCateg);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("La categoria se ha Registrado Exitosamente");
            }
            catch(Exception ex)
            {
                if(cn.State==ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar"+ ex.Message, "Capa Datos Categoria",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        //editar
        public void BD_Editar_Categoria(int idcateg, string nomCateg)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand cmd = new SqlCommand("sp_modificar_categoria", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idcat", idcateg);
                cmd.Parameters.AddWithValue("@nombre", nomCateg);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("La categoria se ha Editado Exitosamente");
            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar" + ex.Message, "Capa Datos Categoria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //mostrar
        public DataTable BD_Mostrar_Todas_Categorias()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("sp_listar_todas_Categorias", cn);
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
                MessageBox.Show("Error al consultar" + ex.Message, "Capa Datos Categoria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
           
        }

    }
}
