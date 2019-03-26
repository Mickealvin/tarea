using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace formularioHELPRS1.Models
{
    public class persona
    {
        [Required]
        public int Cedula { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Range(16, 99)]
        public int Edad { get; set; }
        public string Telefono { get; set; }
        [EmailAddress]
        public string Correo { get; set; }
        public string Estado_civil { get; set; }
        public string Hobbys { get; set; }
        //genero
        public Gender genero { get; set; }

    }
    public enum Gender
    {
        Masculino,
        Femenino
    }

}
