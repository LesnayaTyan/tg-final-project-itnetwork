using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProjectInsurance_TG.Models
{
    public class Insurance
    {   [Key]
        public int Id { get; set; }
        public string Pojisteni { get; set; } = null!;
        public string? Castka { get; set; }
        public string PredmetPojisteni { get; set; } = "";
        public string? PlatnostOd { get; set; }
        public string? PlatnostDo { get; set; }
        //public int CustomerId { get; set; }
        //[Required]
        //[ForeignKey("CustomerId")]
        //public virtual Customer? Customer { get; set; }

    }
}
