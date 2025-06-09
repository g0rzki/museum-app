using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace museum_app.Models
{
    public class Exhibition
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Browsable(false)]
        public virtual ICollection<TicketItem> TicketItems { get; set; }
    }
}
