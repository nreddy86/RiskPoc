using ARUP.Models;
using System.Data.Entity;

namespace ARUP.Context
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name=ArupConnectionString")
        {
            this.Configuration.ProxyCreationEnabled = false;
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<ProjectStageList> ProjectStageList { get; set; }
        public DbSet<Lifecycles> Lifecycles { get; set; }
        public DbSet<RiskScores> RiskScores { get; set; }
        public DbSet<IssuePurposes> IssuePurposes { get; set; }
        public DbSet<Severities> Severities { get; set; }
        public DbSet<Likelihoods> Likelihoods { get; set; }
        public DbSet<DisciplineList> DisciplineList { get; set; }
        public DbSet<RiskStatus> RiskStatus { get; set; }
        public DbSet<RegisterEntries> RegisterEntries { get; set; }
        public DbSet<Audit> Audit { get; set; }
        public DbSet<AuditEntries> AuditEntries { get; set; }
    }
}