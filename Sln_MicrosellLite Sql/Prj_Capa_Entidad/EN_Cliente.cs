using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Capa_Entidad
{
    public class EN_Cliente
    {
        private string _idcliente;
        private string _razonsocial;
        private string _rfc;
        private string _direccion;
        private string _telefono;
        private string _email;
        private Int32 _idDis;
        private DateTime _fechaAniv;
        private string _contacto;
        private double _limiteCred;

        public string Idcliente { get => _idcliente; set => _idcliente = value; }
        public string Razonsocial { get => _razonsocial; set => _razonsocial = value; }
        public string Rfc { get => _rfc; set => _rfc = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Email { get => _email; set => _email = value; }
        public int IdDis { get => _idDis; set => _idDis = value; }
        public DateTime FechaAniv { get => _fechaAniv; set => _fechaAniv = value; }
        public string Contacto { get => _contacto; set => _contacto = value; }
        public double LimiteCred { get => _limiteCred; set => _limiteCred = value; }
    }
}
