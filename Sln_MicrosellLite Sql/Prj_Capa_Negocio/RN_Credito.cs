using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prj_Capa_Entidad;
using Prj_Capa_Datos;
using System.Data;

namespace Prj_Capa_Negocio
{
    public class RN_Credito
    {
        public void RN_Registrar_Credito(EN_Credito cre)
        {
            BD_Credito obj = new BD_Credito();
            obj.BD_Registrar_Credito(cre);
        }

        public void RN_Registrar_Detalle_Credito(EN_Det_Credito cre)
        {
            BD_Credito obj = new BD_Credito();
            obj.BD_Registrar_Detalle_Credito(cre);
        }

        public static double RN_Sumar_Total_Credito_Por_Cliente(string idCliente)
        {
            return BD_Credito.BD_Sumar_Total_Credito_Por_Cliente(idCliente);
        }

        public DataTable RN_Listar_Todos_Creditos()
        {
            BD_Credito obj = new BD_Credito();
            return obj.BD_Listar_Todos_Creditos();
        }

        public DataTable RN_Listar_Todos_Creditos_Valor(string valor)
        {
            BD_Credito obj = new BD_Credito();
            return obj.BD_Listar_Todos_Creditos_Valor(valor);
        }
    }
}
