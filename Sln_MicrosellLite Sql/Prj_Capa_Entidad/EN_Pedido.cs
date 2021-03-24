using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Capa_Entidad
{
    public class EN_Pedido
    {
        private string _id_pedido;
        private string _idCliente;
        private Double _subTotal;
        private Double _Igv;
        private Double _totalPedido;
        private int _idUsuario;
        private Double _totalGanancia;

        public string Id_pedido { get => _id_pedido; set => _id_pedido = value; }
        public string IdCliente { get => _idCliente; set => _idCliente = value; }
        public double SubTotal { get => _subTotal; set => _subTotal = value; }
        public double Igv { get => _Igv; set => _Igv = value; }
        public int IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public double TotalGanancia { get => _totalGanancia; set => _totalGanancia = value; }
        public double TotalPedido { get => _totalPedido; set => _totalPedido = value; }
    }
}
