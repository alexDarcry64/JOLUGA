using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Capa_Entidad
{
    public class EN_Cotizacion
    {
        private string _idCotizacion;
        private string _idPedido;
        private DateTime _fechaCotizacion;
        private int _vigencia;
        private Double _totalCoti;
        private string _condiciones;
        private double _igv;
        private string _precioConIgv;
        private string _estadoCoti;

        public string IdCotizacion { get => _idCotizacion; set => _idCotizacion = value; }
        public string IdPedido { get => _idPedido; set => _idPedido = value; }
        public DateTime FechaCotizacion { get => _fechaCotizacion; set => _fechaCotizacion = value; }
        public int Vigencia { get => _vigencia; set => _vigencia = value; }
        public double TotalCoti { get => _totalCoti; set => _totalCoti = value; }
        public string Condiciones { get => _condiciones; set => _condiciones = value; }
        public double Igv { get => _igv; set => _igv = value; }
        public string PrecioConIgv { get => _precioConIgv; set => _precioConIgv = value; }
        public string EstadoCoti { get => _estadoCoti; set => _estadoCoti = value; }
    }
}
