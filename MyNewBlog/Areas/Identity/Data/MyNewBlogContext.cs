using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyNewBlog.Areas.Identity.Data;
using System.Configuration;


using Microsoft.Extensions.Configuration;

namespace MyNewBlog.Data;

public class MyNewBlogContext : IdentityDbContext<BlogUser>

{
    protected readonly IConfiguration Configuration;
    public MyNewBlogContext(DbContextOptions<MyNewBlogContext> options, IConfiguration configuration)
        : base(options)
    {
        Configuration = configuration;
    }

 



    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {

        options.UseSqlServer(Configuration.GetConnectionString("DataBaseLink"));
    }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
