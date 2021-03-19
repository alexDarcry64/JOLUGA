using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Prj_Capa_Datos;
using Prj_Capa_Entidad;
using Prj_Capa_Negocio;

namespace Prj_Capa_Negocio
{
    public class RN_Cliente
    {
        public bool RN_Verificar_NroRFC(string rfc)
        {
            BD_Cliente obj = new BD_Cliente();
            return obj.BD_Verificar_NroRFC(rfc);
        }

        public void RN_Insertar_Cliente(EN_Cliente cli)
        {
            BD_Cliente obj = new BD_Cliente();
            obj.BD_Insertar_Cliente(cli);
        }

        public void RN_Editar_Cliente(EN_Cliente cli)
        {
            BD_Cliente obj = new BD_Cliente();
            obj.BD_Editar_Cliente(cli);
        }

        public DataTable RN_Cargar_Todos_Clientes(string estado)
        {
            BD_Cliente obj = new BD_Cliente();
            return obj.BD_Cargar_Todos_Clientes(estado);
        }

        public DataTable RN_Buscar_Cliente_Valor(string valor, string estado)
        {
            BD_Cliente obj = new BD_Cliente();
            return obj.BD_Buscar_Clientes(valor,estado);
        }

        public DataTable RN_Dar_Baja_Cliente(string idCliente)
        {
            BD_Cliente obj = new BD_Cliente();
            return obj.BD_Dar_Baja_Cliente(idCliente);
        }

        public DataTable RN_Eliminar_Cliente(string idCliente)
        {
            BD_Cliente obj = new BD_Cliente();
            return obj.BD_Eliminar_Cliente(idCliente);
        }
    }
}
