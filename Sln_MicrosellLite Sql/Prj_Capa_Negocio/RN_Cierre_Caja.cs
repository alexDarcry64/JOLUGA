using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prj_Capa_Datos;
using Prj_Capa_Entidad;
using System.Data;

namespace Prj_Capa_Negocio
{
    public class RN_Cierre_Caja
    {
        public void RN_Registrar_Inicio_Caja(EN_Cierre_Caja caja)
        {
            BD_Cierre_Caja obj = new BD_Cierre_Caja();
            obj.BD_Registrar_Inicio_Caja(caja);
        }

        public void RN_Registrar_Cierre_Caja(EN_Cierre_Caja caja)
        {
            BD_Cierre_Caja obj = new BD_Cierre_Caja();
            obj.BD_Registrar_Cierre_Caja(caja);
        }

        public DataTable RN_Listar_Cierre_Caja_Dia()
        {
            BD_Cierre_Caja obj = new BD_Cierre_Caja();
            return obj.BD_Listar_Cierre_Caja_Dia();
        }

        public bool RN_Validar_Inicio_Doble_Caja()
        {
            BD_Cierre_Caja obj = new BD_Cierre_Caja();
            return obj.BD_Validar_Inicio_Doble_Caja();
        }

        public DataTable RN_Calcular_Ventas_Por_Tipo_Doc(string nomTipoDoc)
        {
            BD_Cierre_Caja obj = new BD_Cierre_Caja();
            return obj.BD_Calcular_Ventas_Por_Tipo_Doc(nomTipoDoc);
        }

        public DataTable RN_Calcular_Ventas_Por_Tipo_Pago(string tipoPago)
        {
            BD_Cierre_Caja obj = new BD_Cierre_Caja();
            return obj.BD_Calcular_Ventas_Por_Tipo_Pago(tipoPago);
        }

        public DataTable RN_Calcular_Ventas_Acredito()
        {
            BD_Cierre_Caja obj = new BD_Cierre_Caja();
            return obj.BD_Calcular_Ventas_Acredito();
        }

        public DataTable RN_Calcular_Ventas_ADeposito()
        {
            BD_Cierre_Caja obj = new BD_Cierre_Caja();
            return obj.BD_Calcular_Ventas_ADeposito();
        }

        public DataTable RN_Calcular_Ganancias_Dia()
        {
            BD_Cierre_Caja obj = new BD_Cierre_Caja();
            return obj.BD_Calcular_Ganancias_Dia();
        }
    }
}
