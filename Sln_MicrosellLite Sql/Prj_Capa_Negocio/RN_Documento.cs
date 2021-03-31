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
    public class RN_Documento
    {
        public bool RN_VerificarProducto_NroDoc(string nrDoc)
        {
            BD_Documento obj = new BD_Documento();
            return obj.BD_VerificarProducto_NroDoc(nrDoc);
        }

        public void RN_Registrar_Documento(EN_Documento doc)
        {
            BD_Documento obj = new BD_Documento();
            obj.BD_Registrar_Documento(doc);
        }

        public void RN_Actualizar_Totales_Documento(string idDoc, double importe, double igv, string sonLe)
        {
            BD_Documento obj = new BD_Documento();
            obj.BD_Actualizar_Totales_Documento(idDoc,importe,igv,sonLe);
        }

        public DataTable RN_Buscador_Documentos_Valor(string valor)
        {
            BD_Documento obj = new BD_Documento();
            return obj.BD_Buscador_Documentos_Valor(valor);
        }

        public DataTable RN_Buscador_Documentos_Dia(DateTime xDia)
        {
            BD_Documento obj = new BD_Documento();
            return obj.BD_Buscador_Documentos_Dia(xDia);
        }

        public DataTable RN_Buscador_Documentos_Mes(DateTime xMes)
        {
            BD_Documento obj = new BD_Documento();
            return obj.BD_Buscador_Documentos_Mes(xMes);
        }

        public DataTable RN_Buscador_Documentos_Mes_TipoDoc(DateTime xMes, int idTipo)
        {
            BD_Documento obj = new BD_Documento();
            return obj.BD_Buscador_Documentos_Mes_TipoDoc(xMes,idTipo);
        }

        public DataTable RN_Buscador_Detalle_PorID(string idDoc)
        {
            BD_Documento obj = new BD_Documento();
            return obj.BD_Buscador_Detalle_PorID(idDoc);
        }

        public void RN_Anular_Documento(string idDoc, string estadoDoc)
        {
            BD_Documento obj = new BD_Documento();
            obj.BD_Anular_Documento(idDoc,estadoDoc);
        }

        public void RN_Cambiar_TipoPago(string idDoc, string tipoPago)
        {
            BD_Documento obj = new BD_Documento();
            obj.BD_Cambiar_TipoPago(idDoc, tipoPago);
        }

        public DataTable BD_ListarTodos_Documentos()
        {
            BD_Documento obj = new BD_Documento();
            return obj.BD_ListarTodos_Documentos();
        }
    }
}
