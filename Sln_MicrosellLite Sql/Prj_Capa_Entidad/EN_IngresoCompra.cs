using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Capa_Entidad
{
   public class EN_IngresoCompra
    {
        private char idCom;
private char Nro_Fac_Fisico;
private char IdProvee;
private decimal SubTotal_Com;
private DateTime FechaIngre;
private decimal TotalCompra;
private int IdUsu;
private String ModalidadPago;
private int TiempoEspera;
private DateTime FechaVence;
private String EstadoIngre;
private bool RecibiConforme;
private String Datos_Adicional;
private String Tipo_Doc_Compra;

        public char IdCom { get => idCom; set => idCom = value; }
        public char Nro_Fac_Fisico1 { get => Nro_Fac_Fisico; set => Nro_Fac_Fisico = value; }
        public char IdProvee1 { get => IdProvee; set => IdProvee = value; }
        public decimal SubTotal_Com1 { get => SubTotal_Com; set => SubTotal_Com = value; }
        public DateTime FechaIngre1 { get => FechaIngre; set => FechaIngre = value; }
        public decimal TotalCompra1 { get => TotalCompra; set => TotalCompra = value; }
        public int IdUsu1 { get => IdUsu; set => IdUsu = value; }
        public string ModalidadPago1 { get => ModalidadPago; set => ModalidadPago = value; }
        public int TiempoEspera1 { get => TiempoEspera; set => TiempoEspera = value; }
        public DateTime FechaVence1 { get => FechaVence; set => FechaVence = value; }
        public string EstadoIngre1 { get => EstadoIngre; set => EstadoIngre = value; }
        public bool RecibiConforme1 { get => RecibiConforme; set => RecibiConforme = value; }
        public string Datos_Adicional1 { get => Datos_Adicional; set => Datos_Adicional = value; }
        public string Tipo_Doc_Compra1 { get => Tipo_Doc_Compra; set => Tipo_Doc_Compra = value; }
    }
}
