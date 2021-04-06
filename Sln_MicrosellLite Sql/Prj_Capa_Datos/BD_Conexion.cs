using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj_Capa_Datos
{
   public class BD_Conexion
    {
        //public string Conectar()
        //{
        //    return "data source=DESKTOP-BJONN1L;Initial Catalog=JOLUGAGO;Integrated security=true";
        //}

        public string Conectar()
        {
            StreamReader leer;
            string ruta = Application.StartupPath;
            leer = new StreamReader(ruta + @"\conexion.txt");
            string linea;
            linea = leer.ReadLine();
            return linea; 
        }

        public static string Conectar2()
        {
            return "data source=DESKTOP-BJONN1L;Initial Catalog=JOLUGAGO;Integrated security=true";
        }
    }
}
