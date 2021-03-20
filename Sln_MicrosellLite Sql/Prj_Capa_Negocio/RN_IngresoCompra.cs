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
    public class RN_IngresoCompra
    {
        public void RN_Ingresar_RegistroCompra(EN_IngresoCompra com)
        {
            BD_IngresoCompra obj = new BD_IngresoCompra();
            obj.BD_Insertar_RegistroCompra(com);
        }

        public void RN_Insertar_Detalle_RegistroCompra(EN_Det_IngresoCompra compra)
        {
            BD_IngresoCompra obj = new BD_IngresoCompra();
            obj.BD_Insertar_Detalle_RegistroCompra(compra);
        }

        public bool RN_Verificar_NroDocFisico(string fisico)
        {
            BD_IngresoCompra obj = new BD_IngresoCompra();
            return obj.BD_Verificar_NroDocFisico(fisico);
        }

        public DataTable RN_Buscar_Compras(string valor)
        {
            BD_IngresoCompra obj = new BD_IngresoCompra();
            return obj.BD_Buscar_Compras(valor);
        }

        public DataTable RN_Cargar_TodasCompras()
        {
            BD_IngresoCompra obj = new BD_IngresoCompra();
            return obj.BD_Cargar_TodasCompras();
        }

        public DataTable RN_Buscar_Compras_Dia(string tipo,DateTime fecha)
        {
            BD_IngresoCompra obj = new BD_IngresoCompra();
            return obj.BD_Buscar_Compras_Dia(tipo,fecha);
        }

        public void BD_Borrar_Compra(string idCompra)
        {
            BD_IngresoCompra obj = new BD_IngresoCompra();
            obj.BD_Borrar_Compra(idCompra);
        }
    }
}
