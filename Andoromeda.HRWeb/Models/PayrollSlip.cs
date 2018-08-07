using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Andoromeda.HRWeb.Models
{
    public enum PaymentStatus
    {
        Pending,
        Paid
    }

    public class AdditionalSalary
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public string Description { get; set; }

        public double Tax { get; set; }
    }

    public class PayrollSlip
    {
        public Guid Id { get; set; }

        [MaxLength(64)]
        [ForeignKey("User")]
        public string Username { get; set; }

        public virtual User User { get; set; }

        public JsonObject<IEnumerable<AdditionalSalary>> AdditionalSalaries { get; set; }

        public DateTime Time { get; set; }

        public PaymentStatus PaymentStatus { get; set; }
    }
}
