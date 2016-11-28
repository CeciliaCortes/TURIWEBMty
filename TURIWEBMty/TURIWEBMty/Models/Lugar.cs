using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TURIWEBMty.Models
{
    public class Lugar
    {
        public int Id { get; set; }
        public String NoLugar { get; set; }

        public int IdMunicipio { get; set; }
        public int IdTransporte { get; set; }
        public int IdUbicacion { get; set; }

        public virtual Municipio Municipios { get; set; }
        public virtual Transporte Transportes { get; set; }
        public virtual Ubicacion Ubicaciones { get; set; }
    }
}