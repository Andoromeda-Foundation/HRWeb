using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Andoromeda.HRWeb.Models
{
    public class Team
    {
        [MaxLength(32)]
        public string Id { get; set; }

        [MaxLength(64)]
        [ForeignKey("Owner")]
        public string OwnerUsername { get; set; }

        public virtual User Owner { get; set; }

        [MaxLength(32)]
        public string Name { get; set; }
    }
}
