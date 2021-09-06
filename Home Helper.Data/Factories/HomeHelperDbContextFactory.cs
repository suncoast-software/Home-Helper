using Home_Helper.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Helper.Data.Factories
{
    public class HomeHelperDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<AppDbContext>();
            options.UseNpgsql("Server=localhost;Port=5432;Database=homeHelperDb;User ID=postgres;Password=451145_Gl");

            return new AppDbContext(options.Options);
        }
    }
}
