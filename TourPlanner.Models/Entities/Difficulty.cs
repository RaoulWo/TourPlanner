using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TourPlanner.Models.Enums;

namespace TourPlanner.Models.Entities;

public class Difficulty
{
    [Key]
    [Column("difficulty_id")]
    public DifficultyId DifficultyId { get; set; }

    [Required]
    [Column("name")]
    public string Name { get; set; }
}