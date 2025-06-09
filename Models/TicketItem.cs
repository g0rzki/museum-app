using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace museum_app.Models
{
    public class TicketItem
    {
        public int Id { get; set; }

        [Required]
        public int TicketOrderId { get; set; }

        [Browsable(false)]
        public TicketOrder TicketOrder { get; set; }

        [Required]
        public int TicketTypeId { get; set; }

        [Browsable(false)]
        public TicketType TicketType { get; set; }

        [Required]
        public int ExhibitionId { get; set; }

        [Browsable(false)]
        public Exhibition Exhibition { get; set; }

        [Required]
        [Range(1, 10)]
        public int Quantity { get; set; }  
    }
}
