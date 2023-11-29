using System.ComponentModel.DataAnnotations;

namespace EchoRange.Model
{
    public class Odleglosci
    {
        [Key]
        public int IdOdleglosc { get; set; }
        [Required]
        public int Odleglosc_Pomiaru { get; set; }
    }
}
