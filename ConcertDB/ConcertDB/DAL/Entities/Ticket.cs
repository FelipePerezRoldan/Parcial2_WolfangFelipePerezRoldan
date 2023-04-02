using System.ComponentModel.DataAnnotations;

namespace ConcertDB.DAL.Entities
{
    public class Ticket
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Numero de boleto:")]
        public int TickectNumber { get; set; }

        [Display(Name = "Fecha de uso de la boleta:")]
        public DateTime UseDate { get; set; }

        [Required(ErrorMessage = "Este campo {0} es obligatorio.")]
        [Display(Name = "¿La boleta fue usada?:")]
        public Boolean IsUsed { get; set; }

        [Display(Name = "Puerta de entrada:")]
        [MaxLength(10)]
        public String EntranceGate { get; set; }
    }
}
