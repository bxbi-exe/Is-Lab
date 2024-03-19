using Microsoft.AspNetCore.Identity;
using Microsoft.Identity.Client;

namespace web.Models
{
    public class User : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public virtual ICollection<Ticket>? Tickets { get; set; }
    }
}
