using System.ComponentModel.DataAnnotations;

namespace Web1
{
  public class MessageDto
  {
    [Required]
    public string ToUsername { get; set; }
    [Required]
    public string Text { get; set; }
  }
}
