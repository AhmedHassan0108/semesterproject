using Microsoft.EntityFrameworkCore;
using project.Models;
namespace project.odata
{
    public class AppDbcontext:DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext>options) : base(options)
        {

        }
        public DbSet<data> data { get; set }
     
    }
}
