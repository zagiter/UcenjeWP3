using System.ComponentModel.DataAnnotations.Schema;

namespace EdunovaAPP.Models
{
    public class Smjer : Entitet
    {

        public string? Naziv { get; set; }
        public int? Trajanje { get; set; }
        public decimal? Cijena { get; set; }


        [Column("vaucer")]  // ovo se nužno ne mora u našoj APP
        public bool? Verificiran { get; set; }
    }
}
