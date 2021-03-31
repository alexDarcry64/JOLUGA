using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Capa_Entidad
{
    public class EN_Credito
    {
        private string _idCredito;
        private string _idDoc;
        private DateTime _fechaCredito;
        private string _nomCliente;
        private double _totalCredito;
        private double _saldoPdnte;
        private DateTime _FechaVencimiento;

        public string IdCredito { get => _idCredito; set => _idCredito = value; }
        public string IdDoc { get => _idDoc; set => _idDoc = value; }
        public DateTime FechaCredito { get => _fechaCredito; set => _fechaCredito = value; }
        public string NomCliente { get => _nomCliente; set => _nomCliente = value; }
        public double TotalCredito { get => _totalCredito; set => _totalCredito = value; }
        public double SaldoPdnte { get => _saldoPdnte; set => _saldoPdnte = value; }
        public DateTime FechaVencimiento { get => _FechaVencimiento; set => _FechaVencimiento = value; }
    }
}
