using System.ComponentModel.DataAnnotations;

namespace web.Models
{
    public class Ticket
    {
        [Key]
        public Guid Id { get; set; }
        public int price { get; set; }
        public Guid TheatreShowId { get; set; }
        public virtual TheatreShow? TheatreShow { get; set; }
        public string? UserId { get; set; }
        public virtual User? User { get; set; }
    }
}
