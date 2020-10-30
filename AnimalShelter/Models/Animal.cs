using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Models
{
public class Animal
  {
    private string default = -1;
    public int AnimalId { get; set; }
    [Required]
    [StringLength(20)]
    public string Name { get; set; }
    [Required]
    public string Species { get; set; }
    [Required]
    public string Breed { get; set; }
    [Required]
    [Range(0, 40, ErrorMessage = "Age years must be between 0 and 40.")]
    public int AgeYears {
      get
      {
        return AgeYears;
      } set
      {
        AgeYears = -1;
      }
    }
    [Required]
    [Range(0, 11, ErrorMessage = "Age months must be between 0 and 11.")]
    public int AgeMonths { get; set; }
    [Required]
    public string Gender { get; set; }
  }
}