﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Capa_Datos
{
   public class BD_Conexion
    {
        public string Conectar()
        {
            return "data source=DESKTOP-BJONN1L;Initial Catalog=JOLUGAGO;Integrated security=true";
        }

        public static string Conectar2()
        {
            return "data source=DESKTOP-BJONN1L;Initial Catalog=JOLUGAGO;Integrated security=true";
        }
    }
}
