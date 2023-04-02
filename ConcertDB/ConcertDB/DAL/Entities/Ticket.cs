using System.ComponentModel.DataAnnotations;

namespace ConcertDB.DAL.Entities
{
    public class Ticket 
    {
        [Key]
        [Required]
        [Display(Name = "Número de boleto:")]
        public Guid Id { get; set; }
        [Display(Name = "Fecha de creación:")]
        public DateTime? CreatedDate { get; set; }
        [Display(Name = "Fecha de actualización:")]
        public DateTime? ModifiedDate { get; set; }
        [Display(Name = "Fecha de uso de la boleta.")]
        public DateTime UseDate { get; set; }
        [Required(ErrorMessage = "Este campo {0} es obligatorio.")]
        [Display(Name = "La boleta fue usada:")]
        public Boolean IsUsed { get; set; }
        [Display(Name = "Entrace Gate")]
        [MaxLength(10)]
        public String EntranceGate { get; set; }
    }
}
