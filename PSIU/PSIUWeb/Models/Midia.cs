using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PSIUWeb.Models
{

    public class Midia
    {
        [Key]
        public int MidiaId { get; set; }
        public string? URL { get; set; }

        public string? TipoMidia { get; set; }


    }
}
