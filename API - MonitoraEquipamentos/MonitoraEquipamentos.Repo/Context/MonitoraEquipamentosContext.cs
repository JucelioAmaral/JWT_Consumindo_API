using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MonitoraEquipamentos.Domain;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoraEquipamentos.Repo.Context
{
    public class MonitoraEquipamentosContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Equipamento> Equipamento { get; set; }

        static string connectionString;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        public MonitoraEquipamentosContext(IConfiguration configuration)
        {
            connectionString = configuration
                     .GetConnectionString("DefaultConnection").ToString();

        }

        public IDbConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
