using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;

namespace MyNewBlog.Data
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

            options.UseSqlServer(Configuration.GetConnectionString("DataBaseLink"));
        }

        public DbSet<Post> Posts { get; set; }




    }


}




    

