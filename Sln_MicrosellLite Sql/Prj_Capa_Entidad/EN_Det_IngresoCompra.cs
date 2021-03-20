using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Capa_Entidad
{
  public class EN_Det_IngresoCompra
    {
    private string Id_ingreso;
	private string Id_Pro;
	private Double Precio;
    private Double Cantidad;
    private Double Importe;

        public string Id_ingreso1 { get => Id_ingreso; set => Id_ingreso = value; }
        public string Id_Pro1 { get => Id_Pro; set => Id_Pro = value; }
        public Double Precio1 { get => Precio; set => Precio = value; }
        public Double Cantidad1 { get => Cantidad; set => Cantidad = value; }
        public Double Importe1 { get => Importe; set => Importe = value; }
    }
}
