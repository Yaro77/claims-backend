using System;

namespace Claims.Domain
{
  public struct AuthoringInfo
  {
    public User CreatedBy { get; set; }

    public DateTimeOffset CreatedAt { get; set; }

    public User LastUpdatedBy { get; set; }

    public DateTimeOffset? LastUpdatedAt { get; set; }
  }
}