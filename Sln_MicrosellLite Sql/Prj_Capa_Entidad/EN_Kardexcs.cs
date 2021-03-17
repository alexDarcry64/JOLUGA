using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Capa_Entidad
{
    public class EN_Kardexcs
    {
        private string _idkardex;
        private Int32 _item;
        private string _doc_soporte;
        private string _det_operacion;

        private double _cantidad_in;
        private double _precio_in;
        private double _total_in;
        private double _cantidad_out;
        private double _precio_out;
        private double _importe_total_out;
        private double _cantidad_saldo;
        private double _promedio;
        private double _total_saldo;

        public string Idkardex { get => _idkardex; set => _idkardex = value; }
        public string Doc_soporte { get => _doc_soporte; set => _doc_soporte = value; }
        public string Det_operacion { get => _det_operacion; set => _det_operacion = value; }
        public double Cantidad_in { get => _cantidad_in; set => _cantidad_in = value; }
        public double Precio_in { get => _precio_in; set => _precio_in = value; }
        public double Total_in { get => _total_in; set => _total_in = value; }
        public double Cantidad_saldo { get => _cantidad_saldo; set => _cantidad_saldo = value; }
        public double Promedio { get => _promedio; set => _promedio = value; }
        public double Total_saldo { get => _total_saldo; set => _total_saldo = value; }
        public Int32 Item { get => _item; set => _item = value; }
        public double Cantidad_out { get => _cantidad_out; set => _cantidad_out = value; }
        public double Precio_out { get => _precio_out; set => _precio_out = value; }
        public double Importe_total_out { get => _importe_total_out; set => _importe_total_out = value; }
    }
}
