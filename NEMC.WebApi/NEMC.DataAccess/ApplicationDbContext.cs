using Microsoft.EntityFrameworkCore;
using NEMC.DataAccess.Entities;
using System;

namespace NEMC.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        private string _connectionString;
        public ApplicationDbContext(string connectionString)
        {
            #region ConnectionString
            if (connectionString == null)
            {
                connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=nemcdb;Integrated Security=true";
            }
            #endregion
            this._connectionString = connectionString;
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(this._connectionString, sqlServerOption => sqlServerOption.CommandTimeout(180));

        public DbSet<Membership> Memberships { get; set; }
    }
}
