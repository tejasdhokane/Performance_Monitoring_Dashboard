using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Performance_Monitoring_Dashboard.Models;

namespace Performance_Monitoring_Dashboard
{
    public class PerformanceDbContext:DbContext
    {
        public PerformanceDbContext(DbContextOptions<PerformanceDbContext> options) : base(options) { }

        public DbSet<Metric> Metrics { get; set; }
    }
}
