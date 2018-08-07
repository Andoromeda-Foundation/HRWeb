using Microsoft.EntityFrameworkCore;

namespace Andoromeda.HRWeb.Models
{
    public class HrContext : DbContext
    {
        public HrContext(DbContextOptions opt) : base(opt)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Salary> Salaries { get; set; }

        public DbSet<PayrollSlip> PayrollSlips { get; set; }

        public DbSet<VacationRequest> VacationRequests { get; set; }

        public DbSet<TeamMember> TeamMembers { get; set; }

        public DbSet<ClientCert> ClientCerts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>(e =>
            {
                e.HasIndex(x => x.RegisterTime);
                e.HasIndex(x => x.Role);
                e.HasIndex(x => x.Status);
            });

            builder.Entity<ClientCert>(e =>
            {
                e.HasIndex(x => x.ExpireTime);
                e.HasIndex(x => x.IssuedTime);
                e.HasIndex(x => x.IsRevoked);
                e.HasIndex(x => x.ThumbPrint).IsUnique();
            });

            builder.Entity<PayrollSlip>(e => {
                e.HasIndex(x => x.Time);
                e.HasIndex(x => x.PaymentStatus);
            });

            builder.Entity<VacationRequest>(e => {
                e.HasIndex(x => x.Duration);
                e.HasIndex(x => x.Begin);
                e.HasIndex(x => x.RequestTime);
                e.HasIndex(x => x.Status);
                e.HasIndex(x => x.Type);
            });
        }
    }
}
