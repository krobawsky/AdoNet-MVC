using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace semana_11_02.Models
{
    public class EmpModel
    {
        [Display(Name = "Id")]
        public int Empid { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Nombre requerido")]
        public string Name { get; set; }

        [Display(Name = "Cuidad")]
        [Required(ErrorMessage = "Ciudad requerida")]
        public string City { get; set; }

        [Display(Name = "Direccion")]
        [Required(ErrorMessage = "Direccion requerida")]
        public string Address { get; set; }
    }
}