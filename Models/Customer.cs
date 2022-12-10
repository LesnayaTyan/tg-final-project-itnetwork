using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FinalProjectInsurance_TG.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        public string Jmeno { get; set; } = "";

        public string Prijmeni { get; set; } = "";

        public string? Telefon { get; set; }

        public string? Email { get; set; } = "";
        public string? Ulice { get; set; } = "";

        public string Mesto { get; set; } = "";

        public int PSC { get; set; }
        //public ICollection<Insurance> Insurances { get; set; } = null!;
    }
}
