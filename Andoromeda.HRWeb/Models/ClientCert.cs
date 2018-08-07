using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Andoromeda.HRWeb.Models
{
    public class ClientCert
    {
        public Guid Id { get; set; }

        [MaxLength(64)]
        [ForeignKey("User")]
        public string Username { get; set; }

        public virtual User User { get; set; }

        public byte[] PfxBytes { get; set; }

        public DateTime IssuedTime { get; set; }

        public DateTime ExpireTime { get; set; }

        [MaxLength(128)]
        public string ThumbPrint { get; set; }

        public bool IsRevoked { get; set; }
    }
}
