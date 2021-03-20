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
    public class RN_Kardex
    {
        public void RN_Registrar_Kardex(string idkardex, string idProducto, string idProveedor)
        {
            BD_Kardex obj = new BD_Kardex();
            obj.BD_Registrar_Kardex(idkardex,idProducto,idProveedor);
        }

        public void RN_Registrar_Detalle_Kardex(EN_Kardexcs kar)
        {
            BD_Kardex obj = new BD_Kardex();
            obj.BD_Registrar_Detalle_Kardex(kar);
        }

        public bool RN_VerificarProducto_Cardex(string idProducto)
        {
            BD_Kardex obj = new BD_Kardex();
            return obj.BD_VerificarProducto_Cardex(idProducto);
        }

        public DataTable RN_KardexDetalle_Producto(string idCliente)
        {
            BD_Kardex obj = new BD_Kardex();
            return obj.BD_KardexDetalle_Producto(idCliente);
        }
    }
}
