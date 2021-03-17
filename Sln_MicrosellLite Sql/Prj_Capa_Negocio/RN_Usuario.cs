using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Prj_Capa_Datos;

namespace Prj_Capa_Negocio
{
    public class RN_Usuario
    {
        public bool RN_Login(string usuario, string contrasena)
        {
            BD_Usuario obj = new BD_Usuario();
            return obj.BD_Login(usuario,contrasena);
        }
        public DataTable RN_Buscar_Usuario(string user)
        {
            BD_Usuario obj = new BD_Usuario();
            return obj.BD_Buscar_Usuario(user);
        }
    }
}
