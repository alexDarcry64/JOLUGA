using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Capa_Entidad
{
  public class EN_Det_IngresoCompra
    {
    private char Id_ingreso;
	private char Id_Pro;
	private decimal Precio;
    private decimal Cantidad;
    private decimal Importe;

        public char Id_ingreso1 { get => Id_ingreso; set => Id_ingreso = value; }
        public char Id_Pro1 { get => Id_Pro; set => Id_Pro = value; }
        public decimal Precio1 { get => Precio; set => Precio = value; }
        public decimal Cantidad1 { get => Cantidad; set => Cantidad = value; }
        public decimal Importe1 { get => Importe; set => Importe = value; }
    }
}
