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
    public class RN_Pedido
    {
        public void RN_Insertar_Pedido(EN_Pedido ped)
        {
            BD_Pedido obj = new BD_Pedido();
            obj.BD_Insertar_Pedido(ped);
        }

        public void RN_Insertar_Detalle_Pedido(EN_Det_Pedido ped)
        {
            BD_Pedido obj = new BD_Pedido();
            obj.BD_Insertar_Detalle_Pedido(ped);
        }

        public void RN_Eliminar_Detalle_Pedido(string idPedido)
        {
            BD_Pedido obj = new BD_Pedido();
            obj.BD_Eliminar_Detalle_Pedido(idPedido);
        }

        public void RN_Editar_Pedido(EN_Pedido ped)
        {
            BD_Pedido obj = new BD_Pedido();
            obj.BD_Editar_Pedido(ped);
        }

        public bool RN_Verificar_NroPedido(string nroPedido)
        {
            BD_Pedido obj = new BD_Pedido();
            return obj.BD_Verificar_NroPedido(nroPedido);
        }

        public void RN_Pedido_Atendido(string idPedido)
        {
            BD_Pedido obj = new BD_Pedido();
            obj.BD_Pedido_Atendido(idPedido);
        }

        public void RN_Cambiar_Cliente_Pedido(string idPedido, string idCliente)
        {
            BD_Pedido obj = new BD_Pedido();
            obj.BD_Cambiar_Cliente_Pedido(idPedido, idCliente);
        }

        public void RN_Eliminar_Pedido_Permanente(string idPedido)
        {
            BD_Pedido obj = new BD_Pedido();
            obj.BD_Eliminar_Pedido_Permanente(idPedido);
        }

        public DataTable RN_Buscar_Pedido_Editar(string idPedido)
        {
            BD_Pedido obj = new BD_Pedido();
            return obj.BD_Buscar_Pedido_Editar(idPedido);
        }

        public DataTable RN_Buscar_Pedido_Valor(string valor)
        {
            BD_Pedido obj = new BD_Pedido();
            return obj.BD_Buscar_Pedido_Valor(valor);
        }

        public DataTable RN_Buscar_Pedido_Fecha(string tipo, DateTime fecha)
        {
            BD_Pedido obj = new BD_Pedido();
            return obj.BD_Buscar_Pedido_Fecha(tipo,fecha);
        }

        public DataTable BD_Buscar_Pedido_Atender()
        {
            BD_Pedido obj = new BD_Pedido();
            return obj.BD_Buscar_Pedido_Atender();
        }
    }
}
