using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Capa_Entidad
{
    public class EN_Det_Pedido
    {
        private string idPed;
        private string _idPro;
        private Double _precio;
        private Double _cantidad;
        private Double _importe;
        private string _tipoProd;
        private string _unidadMedida;
        private Double _utilidadUnit;
        private Double _totalUtilidad;

        public string IdPed { get => idPed; set => idPed = value; }
        public string IdPro { get => _idPro; set => _idPro = value; }
        public double Precio { get => _precio; set => _precio = value; }
        public double Cantidad { get => _cantidad; set => _cantidad = value; }
        public double Importe { get => _importe; set => _importe = value; }
        public string TipoProd { get => _tipoProd; set => _tipoProd = value; }
        public string UnidadMedida { get => _unidadMedida; set => _unidadMedida = value; }
        public double UtilidadUnit { get => _utilidadUnit; set => _utilidadUnit = value; }
        public double TotalUtilidad { get => _totalUtilidad; set => _totalUtilidad = value; }
    }
}
