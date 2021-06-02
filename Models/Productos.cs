using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Jean_P1_AP2.Models
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }

        [Required(ErrorMessage = "Ingrese una descripción")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Ingrese una cantidad de existencia")]
        public float Existencia { get; set; }

        [Required(ErrorMessage = "Ingrese un costo")]
        public float Costo { get; set; }

        public float ValorInventario { get; set; }
    }
}
