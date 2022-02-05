using System;
using System.ComponentModel.DataAnnotations;

namespace Luis_Cruz_Aragon.Models
{
    public class ClassCliente
    {
        [Key]
        public int IdCliente { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "El campo Nombre es Requerido")]
        public string Nombre { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "El campo Apellido es Requerido")]
        public string Apellido { get; set; }
        [StringLength(200)]
        [Required(ErrorMessage = "El campo Apellido es Requerido")]
        public string Direccion { get; set; }
        [StringLength(12)]
        public string Telefono { get; set; }
        public int Edad { get; set; }
        [StringLength(16)]
        [Required(ErrorMessage = "El campo Cedula es Requerido")]
        public string Cedula { get; set; }
        [StringLength(10)]
        public string CreadoPor { get; set; }

        public DateTime  CreadoEl{ get; set; }


    }
}
