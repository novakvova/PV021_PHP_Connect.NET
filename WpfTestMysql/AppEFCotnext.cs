using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTestMysql.Entities;

namespace WpfTestMysql
{
    public class AppEFCotnext : DbContext
    {
        public AppEFCotnext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conStr = "Server=localhost;Port=3308;Database=pv121test;User Id=root;Password=;";
            var serverVersion = 
                new MariaDbServerVersion(ServerVersion.AutoDetect(conStr));
                //new MySqlServerVersion(ServerVersion.AutoDetect(conStr));

            optionsBuilder
                .UseMySql(conStr, serverVersion);
        }

        public DbSet<Category> Categories { get; set; }
    }
}
