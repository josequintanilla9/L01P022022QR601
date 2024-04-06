using System.ComponentModel.DataAnnotations;

namespace L01P022022QR601.Models
{
    public class alumnos
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }
        [Display(Name = "Codigo")]
        public string? codigo { get; set; }
        [Display(Name = "Nombre")]
        public string? nombre { get; set; }
        [Display(Name = "Apellido")]
        public string? apellidos { get; set; }
        [Display(Name = "Dui")]
        public int? dui { get; set; }
        [Display(Name = "Estado")]
        public int? estado { get; set; }
    }
}
