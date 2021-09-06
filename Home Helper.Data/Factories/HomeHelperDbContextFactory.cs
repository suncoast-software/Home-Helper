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
            options.UseNpgsql("Server=SERVER;Port=PORT;Database=DB;User ID=USERID;Password=PASSWORD");

            return new AppDbContext(options.Options);
        }
    }
}
