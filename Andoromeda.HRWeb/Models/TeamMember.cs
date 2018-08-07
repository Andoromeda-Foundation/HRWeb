using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Andoromeda.HRWeb.Models
{
    public enum TeamMemberStatus
    {
        Pending,
        Approved
    }

    public class TeamMember
    {
        [MaxLength(64)]
        [ForeignKey("User")]
        public string Username { get; set; }

        public virtual User User { get; set; }

        [MaxLength(32)]
        [ForeignKey("Team")]
        public string TeamId { get; set; }

        public virtual Team Team { get; set; }

        public TeamMemberStatus Status { get; set; }
    }
}
