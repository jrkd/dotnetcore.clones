using Microsoft.EntityFrameworkCore;


namespace oval.models
{
    public class OvalContext : DbContext
    {
        
        public OvalContext(DbContextOptions<OvalContext> options)
            : base(options)
        { }
        
        public DbSet<Space> Spaces { get; set; }
        public DbSet<Event> Events { get; set; }
    }

}