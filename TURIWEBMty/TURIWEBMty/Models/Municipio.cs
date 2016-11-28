using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TURIWEBMty.Models
{
    public class Municipio
    {
        public int Id { get; set; }
        public String Municipios { get; set; }
        public int Poblacion { get; set; }
        public int Superficie { get; set; }

        public ICollection<Lugar>Lugares { get; set; }
    }
}