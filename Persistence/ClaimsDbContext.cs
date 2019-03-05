using Microsoft.EntityFrameworkCore;

namespace Claims.Persistence
{
  public class ClaimsDbContext : DbContext
  {
    public ClaimsDbContext(DbContextOptions options)
      : base(options)
    {

    }
  }
}