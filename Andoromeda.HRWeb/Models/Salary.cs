using System;;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Andoromeda.HRWeb.Models
{
    public class Salary
    {
        public Guid Id { get; set; }

        [MaxLength(64)]
        [ForeignKey("Username")]
        public string Username { get; set; }

        public virtual User User { get; set; }

        public DateTime EffectiveTime { get; set; }

        public DateTime? ExpireTime { get; set; }

        public double BaseSalaryPerMonth { get; set; }

        public double BonusPerMonth { get; set; }

        public double PersonalPaidInsuranceAndTax { get; set; }

        public double CorpPaidInsuranceAndTax { get; set; }
    }
}
