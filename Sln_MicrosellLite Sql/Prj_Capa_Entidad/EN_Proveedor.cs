﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Capa_Entidad
{
   public class EN_Proveedor
    {
        private String _idproveedor;
        private string _nombreproveedor;
        private string _direccion;
        private string _telefono;
        private string _rubro;
        private string _rfc;
        private string _correo;
        private string _contacto;
        private string _fotologo;

        public string Fotologo { get => _fotologo; set => _fotologo = value; }
        public string Contacto { get => _contacto; set => _contacto = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public string Rfc { get => _rfc; set => _rfc = value; }
        public string Rubro { get => _rubro; set => _rubro = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Nombreproveedor { get => _nombreproveedor; set => _nombreproveedor = value; }
        public string Idproveedor { get => _idproveedor; set => _idproveedor = value; }
    }
}
