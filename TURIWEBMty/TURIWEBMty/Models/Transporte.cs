using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TURIWEBMty.Models
{
    public class Transporte
    {
        public int Id { get; set; }
        public String Transportee { get; set; }

        public DateTime IdHorario { get; set; }

        public virtual Horario Horarios { get; set; }
        public ICollection<Lugar> Lugares { get; set; }
    }
}