using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Andoromeda.HRWeb.Models
{
    public enum UserStatus
    {
        Active,
        Resigned
    }

    public enum UserRole
    {
        FTE,
        Intern,
        Vendor
    }

    public class User
    {
        [Key]
        [MaxLength(64)]
        public string Username { get; set; }

        [MaxLength(20)]
        public string RealName { get; set; }

        [MaxLength(20)]
        public string NickName { get; set; }

        [MaxLength(20)]
        public string PRCID { get; set; }

        [MaxLength(64)]
        public string Email { get; set; }

        public DateTime RegisterTime { get; set; }

        [MaxLength(64)]
        [ForeignKey("Manager")]
        public string ManagerUsername { get; set; }

        public virtual User Manager { get; set; }

        [MaxLength(32)]
        public string Title { get; set; }

        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        public UserRole Role { get; set; }

        public UserStatus Status { get; set; }

        public string Resume { get; set; }

        public virtual ICollection<User> DirectReports { get; set; }
    }
}
