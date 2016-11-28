using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TURIWEBMty.Models
{
    public class Horario
    {
        public int ID { get; set; }
        public DateTime Hora { get; set; }

        public ICollection<Transporte> Transportes { get; set; }
    }
}