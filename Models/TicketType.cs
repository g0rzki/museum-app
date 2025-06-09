using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace museum_app.Models
{
    public class TicketType
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [Range(1, 100)]
        public decimal Price { get; set; }

        [Browsable(false)]
        public virtual ICollection<TicketItem> TicketItems { get; set; }
    }
}
