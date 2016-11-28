using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TURIWEBMty.Models
{
    public class Ubicacion
    {
        public int Id { get; set; }
        public Char ubicacion { get; set; }

        public int IdMunicipio { get; set; }

        public virtual Municipio Municipios { get; set; }
        public ICollection<Lugar> Lugares { get; set; }
    }
}