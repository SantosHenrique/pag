using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infra.DBConfiguration.EFCore
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
                dbContextOptionsBuilder.UseSqlServer(DatabaseConnection.ConnectionConfiguration
                    .GetConnectionString("DefaultConnection"));
        }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Aluno> Aluno { get; set; }
    }
}
