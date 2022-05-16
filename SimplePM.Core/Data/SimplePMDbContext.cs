using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SimplePM.Core.Models;

namespace SimplePM.Core.Data
{
  public class SimplePMDbContext : IdentityDbContext<User>
  {
    public SimplePMDbContext(DbContextOptions<SimplePMDbContext> options)
        : base(options)
    {
    }

    public DbSet<Notes> Notes { get; set; }

    public DbSet<Project> Projects { get; set; }

    public DbSet<ProjectRoles> ProjectRoles { get; set; }

    public DbSet<ProjectSchedle> ProjectSchedles { get; set; }

    public DbSet<ProjectTasks> ProjectTasks { get; set; }

    public DbSet<ProjectUsers> ProjectUsers { get; set; }

    public DbSet<TaskUsers> TaskUsers { get; set; }
  }
}