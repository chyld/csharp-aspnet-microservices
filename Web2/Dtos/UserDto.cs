using System;
using System.ComponentModel.DataAnnotations;

namespace Web2
{
  public class UserDto
  {
    [Required]
    [MinLength(3)]
    public string Username { get; set; }
  }
}
