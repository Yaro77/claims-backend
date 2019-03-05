namespace Claims.Domain
{
  public abstract class Entity
  {
    public int Id { get; set; }
    
    public AuthoringInfo AuthoringInfo { get; set; }
  }
}