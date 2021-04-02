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
    public class RN_Temporal
    {
        public void BD_Registrar_Temporal(EN_Temporal tem)
        {
            BD_Temporal obj = new BD_Temporal();
            obj.BD_Registrar_Temporal(tem);
        }

        public void BD_Registrar_Detalle_Temporal(EN_Det_Temporal tem)
        {
            BD_Temporal obj = new BD_Temporal();
            obj.BD_Registrar_Detalle_Temporal(tem);
        }

        public DataTable BD_LeerTemporal_Id(string idTemp)
        {
            BD_Temporal obj = new BD_Temporal();
            return obj.BD_LeerTemporal_Id(idTemp);
        }

        public void BD_Eliminar_Temporal(string idTemp)
        {
            BD_Temporal obj = new BD_Temporal();
            obj.BD_Eliminar_Temporal(idTemp);
        }
    }
}
