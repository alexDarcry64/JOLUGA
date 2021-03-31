using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Capa_Entidad
{
    public class EN_Documento
    {
        private string _idDoc;
        private string _idPedido;
        private int _idTipo;
        private DateTime _fechaDoc;
        private double _importe;
        private string _tipoPago;
        private string _nrOperacion;
        private int _idUsu;
        private double _igv;
        private string _sonLetra;
        private double _totalGanancia;

        public string IdDoc { get => _idDoc; set => _idDoc = value; }
        public string IdPedido { get => _idPedido; set => _idPedido = value; }
        public int IdTipo { get => _idTipo; set => _idTipo = value; }
        public DateTime FechaDoc { get => _fechaDoc; set => _fechaDoc = value; }
        public double Importe { get => _importe; set => _importe = value; }
        public string TipoPago { get => _tipoPago; set => _tipoPago = value; }
        public string NrOperacion { get => _nrOperacion; set => _nrOperacion = value; }
        public int IdUsu { get => _idUsu; set => _idUsu = value; }
        public double Igv { get => _igv; set => _igv = value; }
        public string SonLetra { get => _sonLetra; set => _sonLetra = value; }
        public double TotalGanancia { get => _totalGanancia; set => _totalGanancia = value; }
    }
}
