using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Prj_Capa_Datos;
using Prj_Capa_Entidad;

namespace Prj_Capa_Negocio
{
    public class RN_TipoDoc
    {
        public static string RN_Nro_id(int idTipo)
        {
            return BD_Tipo_Doc.BD_Nro_id(idTipo);
        }

        public static void RN_Actualizar_Tipo_Doc(int idTipo)
        {
            BD_Tipo_Doc.BD_Actualizar_Tipo_Doc(idTipo);
        }

        public static void RN_Actualizar_Tipo_Cambio(int idTipo, double tipoCambio)
        {
            BD_Tipo_Doc.BD_Actualizar_Tipo_Cambio(idTipo,tipoCambio);
        }

        public static double RN_Leer_Tipo_Cambio(int idTipo)
        {
            return BD_Tipo_Doc.BD_Leer_Tipo_Cambio(idTipo);
        }

        public static void RN_Actualizar_NumeroCorrelativo_Producto(int idTipo)
        {
            BD_Tipo_Doc.BD_Actualizar_NumeroCorrelativo_Producto(idTipo);
        }
    }
}
