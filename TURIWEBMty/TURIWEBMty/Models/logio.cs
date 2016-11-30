using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TURIWEBMty.Models
{
    public class logio
    {
        [Required(ErrorMessage = "The ID is required.")]
        public int ID { get; set; }

        [Required(ErrorMessage = "The name is required.")]
        public string Nombre { get; set; }

        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$",
            ErrorMessage = "Invalid email address.")]
        public string Correo { get; set; }


        public string Contraseña { get; set; }
    }
}