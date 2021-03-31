using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Capa_Entidad
{
    public class EN_Caja
    {
        private DateTime _fechaCaja;
        private string _tipoCaja;
        private string _concepto;
        private string _dePara_Cliente;
        private string _nr_Documento;
        private double _importeCaja;
        private int _idUsu;
        private double _totalUtilidad;
        private string _tipoPago;
        private string _generadoPor;

        public DateTime FechaCaja { get => _fechaCaja; set => _fechaCaja = value; }
        public string TipoCaja { get => _tipoCaja; set => _tipoCaja = value; }
        public string Concepto { get => _concepto; set => _concepto = value; }
        public string DePara_Cliente { get => _dePara_Cliente; set => _dePara_Cliente = value; }
        public string Nr_Documento { get => _nr_Documento; set => _nr_Documento = value; }
        public double ImporteCaja { get => _importeCaja; set => _importeCaja = value; }
        public int IdUsu { get => _idUsu; set => _idUsu = value; }
        public double TotalUtilidad { get => _totalUtilidad; set => _totalUtilidad = value; }
        public string TipoPago { get => _tipoPago; set => _tipoPago = value; }
        public string GeneradoPor { get => _generadoPor; set => _generadoPor = value; }
    }
}
