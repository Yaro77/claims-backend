namespace Claims.Persistence
{
  public static class DbInitializer
  {
    public static void Initialize(ClaimsDbContext context)
    {
      context.Database.EnsureCreated();

      context.SaveChanges();
    }
  }
}