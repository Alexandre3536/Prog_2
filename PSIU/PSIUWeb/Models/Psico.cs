using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PSIUWeb.Models
{
    
    public class Psico
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome requerido")]
        [Display(Name = "Nome")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "CRP requerido.")]
        [Display(Name = "CRP")]
        public string? CRP { get; set; }

        [Required(ErrorMessage = "Está liberado?")]
        [Display(Name = "Liberado")]
        public Boolean Released { get; set; }


        [ForeignKey("User")]
        public string?  UserId { get; set; }
        public AppUser? User { get; set; }
    }
}