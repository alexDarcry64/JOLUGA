using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Prj_Capa_Entidad;

namespace Prj_Capa_Datos
{
  public  class BD_Proveedor: BD_Conexion
    {
        public void BD_Registrar_Proveedor(EN_Proveedor pro)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand cmd = new SqlCommand("sp_registrar_Proveedor", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idproveedor", pro.Idproveedor);
                cmd.Parameters.AddWithValue("@nombre", pro.Nombreproveedor);
                cmd.Parameters.AddWithValue("@direccion", pro.Direccion);
                cmd.Parameters.AddWithValue("@telefono", pro.Telefono);
                cmd.Parameters.AddWithValue("@rubro", pro.Rubro);
                cmd.Parameters.AddWithValue("@rfc", pro.Rfc);
                cmd.Parameters.AddWithValue("@correo", pro.Correo);
                cmd.Parameters.AddWithValue("@contacto", pro.Contacto);
                cmd.Parameters.AddWithValue("@fotologo", pro.Fotologo);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("El proveedor se ha Registrado Exitosamente");
            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar" + ex.Message, "Capa Datos Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void BD_Editar_Proveedor(EN_Proveedor pro)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlCommand cmd = new SqlCommand("sp_Modificar_Proveedor", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idproveedor", pro.Idproveedor);
                cmd.Parameters.AddWithValue("@nombre", pro.Nombreproveedor);
                cmd.Parameters.AddWithValue("@direccion", pro.Direccion);
                cmd.Parameters.AddWithValue("@telefono", pro.Telefono);
                cmd.Parameters.AddWithValue("@rubro", pro.Rubro);
                cmd.Parameters.AddWithValue("@rfc", pro.Rfc);
                cmd.Parameters.AddWithValue("@correo", pro.Correo);
                cmd.Parameters.AddWithValue("@contacto", pro.Contacto);
                cmd.Parameters.AddWithValue("@fotologo", pro.Fotologo);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("El proveedor se ha Actualizado Exitosamente");
            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar" + ex.Message, "Capa Datos Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //consultar todos
        public DataTable BD_Mostrar_Todos_Proveedores()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("sp_Listar_Todos_Proveedores", cn);
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
                MessageBox.Show("Error al consultar" + ex.Message, "Capa Datos Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }

        }


        //BUSCAR
        public DataTable BD_Buscar_Proveedores(string valor)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("sp_buscar_proveedor_porvalor", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@valor", valor);
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
                MessageBox.Show("Error al consultar" + ex.Message, "Capa Datos Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }

        }

    }
}
