using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace museum_app.Models
{
    public class TicketOrder
    {
        public int Id { get; set; }

        [Required]
        public DateTime PurchaseDate { get; set; }

        [Browsable(false)]
        public ICollection<TicketItem> TicketItems { get; set; }
    }
}
