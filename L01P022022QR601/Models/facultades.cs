using System.ComponentModel.DataAnnotations;

namespace L01P022022QR601.Models
{
    public class facultades
    {
        [Key]
        [Display(Name ="ID")]
        public int id { get; set; }
        [Display(Name = "Facultad")]
        public string? facultad { get; set; }
    }
}
