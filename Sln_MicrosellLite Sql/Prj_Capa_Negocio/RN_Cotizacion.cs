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
    public class RN_Cotizacion
    {
        public void RN_Registrar_Cotizacion(EN_Cotizacion cot)
        {
            BD_Cotizacion obj = new BD_Cotizacion();
            obj.BD_Registrar_Cotizacion(cot);
        }

        public void RN_Editar_Cotizacion(EN_Cotizacion cot)
        {
            BD_Cotizacion obj = new BD_Cotizacion();
            obj.BD_Editar_Cotizacion(cot);
        }

        public void RN_Cambiar_Estado_Cotizacion(string idCotizacion, string estadoCot)
        {
            BD_Cotizacion obj = new BD_Cotizacion();
            obj.BD_Cambiar_Estado_Cotizacion(idCotizacion,estadoCot);
        }

        public DataTable RN_Buscar_Cotizaciones_Editar(string nroCot)
        {
            BD_Cotizacion obj = new BD_Cotizacion();
            return obj.BD_Buscar_Cotizaciones_Editar(nroCot);
        }
    }
}
