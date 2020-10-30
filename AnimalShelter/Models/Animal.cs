using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Models
{
public class Animal
  {
    public int AnimalId { get; set; }
    [Required]
    [StringLength(20)]
    public string Name { get; set; }
    [Required]
    public string Species { get; set; }
    [Required]
    public string Breed { get; set; }
    [Required]
    [Range(0, 40, ErrorMessage = "Age must be between 0 and 40.")]
    public int Age { get; set; }
    [Required]
    public string Gender { get; set; }
  }
}