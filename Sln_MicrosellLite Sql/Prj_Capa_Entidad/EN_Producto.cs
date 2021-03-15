using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Capa_Entidad
{
   public class EN_Producto
    {
       

        private string _idpro;
        private string _idprove;
        private string _descripcion;
        private double _Pre_compra;
        private double _StockActual;
        private int _idCat;
        private int _idMar;
        private string _Foto;
        private double _Pre_Venta_Menor;
        private double _Pre_Venta_Mayor;
        private double _Pre_Venta;
        private string _UndMdida;
        private double _PesoUnit;
        private double _Utilidad;
        private string _TipoProd;
        private double _ValorporProd;
        private string _ClaveSAT;

        public string ClaveSAT { get => _ClaveSAT; set => _ClaveSAT = value; }
        public double ValorporProd { get => _ValorporProd; set => _ValorporProd = value; }
        public string TipoProd { get => _TipoProd; set => _TipoProd = value; }
        public double Utilidad { get => _Utilidad; set => _Utilidad = value; }
        public double PesoUnit { get => _PesoUnit; set => _PesoUnit = value; }
        public string UndMdida { get => _UndMdida; set => _UndMdida = value; }
        public double Pre_Venta { get => _Pre_Venta; set => _Pre_Venta = value; }
        public double Pre_Venta_Mayor { get => _Pre_Venta_Mayor; set => _Pre_Venta_Mayor = value; }
        public double Pre_Venta_Menor { get => _Pre_Venta_Menor; set => _Pre_Venta_Menor = value; }
        public string Foto { get => _Foto; set => _Foto = value; }
        public int IdMar { get => _idMar; set => _idMar = value; }
        public int IdCat { get => _idCat; set => _idCat = value; }
        public double StockActual { get => _StockActual; set => _StockActual = value; }
        public double Pre_compra { get => _Pre_compra; set => _Pre_compra = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Idprove { get => _idprove; set => _idprove = value; }
        public string Idpro { get => _idpro; set => _idpro = value; }
    }
}
