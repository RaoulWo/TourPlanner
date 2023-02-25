using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TourPlanner.Models.Enums;

namespace TourPlanner.Models.Entities;

public class Rating
{
    [Key]
    [Column("rating_id")]
    public RatingId RatingId { get; set; }

    [Required]
    [Column("name")]
    public string Name { get; set; }
}