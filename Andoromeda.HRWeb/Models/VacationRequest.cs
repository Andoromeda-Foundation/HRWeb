using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Andoromeda.HRWeb.Models
{
    public enum VacationType
    {
        AnnualVacation,
        LastYearShiftAnnualVacation,
        SickLeave,
        Absence,
        MarriageLeave,
        MaternityLeave,
        FamilyCarriageLeave,
        FuneralLeave,
        NoPaidLeave,
        VolunteerLeave
    }

    public enum VacationStatus
    {
        Pending,
        Approved,
        Rejected,
        Cancelled
    }

    public class VacationRequest
    {
        public Guid Id { get; set; }

        [MaxLength(64)]
        [ForeignKey("Requester")]
        public string RequesterUsername { get; set; }

        public virtual User Requester { get; set; }

        public VacationType Type { get; set; }

        public VacationStatus Status { get; set; }

        [MaxLength(64)]
        [ForeignKey("Manager")]
        public string ManagerUsername { get; set; }

        public virtual User Manager { get; set; }

        public DateTime Begin { get; set; }

        public TimeSpan Duration { get; set; }

        public DateTime RequestTime { get; set; } = DateTime.Now;
    }
}
