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
    public class RN_Caja
    {
        public void RN_Registrar_Movimiento_Caja(EN_Caja caja)
        {
            BD_Caja obj = new BD_Caja();
            obj.BD_Registrar_Movimiento_Caja(caja);
        }

        public void RN_Actualizar_Total_Caja(string nrDoc, double total, double totalUtil, string tipoPago)
        {
            BD_Caja obj = new BD_Caja();
            obj.BD_Actualizar_Total_Caja(nrDoc, total, totalUtil, tipoPago);
        }

        public DataTable RN_ListarTodas_cajas()
        {
            BD_Caja obj = new BD_Caja();
            return obj.BD_ListarTodas_cajas();
        }

        public DataTable RN_Listar_Cajas_Dia()
        {
            BD_Caja obj = new BD_Caja();
            return obj.BD_ListarTodas_cajas();
        }

        public DataTable RN_Listar_Cajas_Mes(DateTime xmes)
        {
            BD_Caja obj = new BD_Caja();
            return obj.BD_Listar_Cajas_Mes(xmes);
        }

        public DataTable BD_Buscador_General_Cajas(string valor)
        {
            BD_Caja obj = new BD_Caja();
            return obj.BD_Buscador_General_Cajas(valor);
        }
    }
}
