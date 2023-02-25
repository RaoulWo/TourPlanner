using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TourPlanner.Models.Enums;

namespace TourPlanner.Models.Entities;

public class Log
{
    [Key]
    [Column("log_id")]
    public int LogId { get; set; }

    [Required]
    [Column("fk_tour_id")]
    public int TourId { get; set; }

    [Required]
    [Column("datetime")]
    public DateTime Datetime { get; set; }

    [Required]
    [Column("total_time")]
    public float TotalTime { get; set; }

    [Required]
    [Column("fk_difficulty_id")]
    public DifficultyId DifficultyId { get; set; }

    [Required]
    [Column("fk_rating_id")]
    public RatingId RatingId { get; set; }

    [Required]
    [Column("comment")]
    public string Comment { get; set; }
    
    public Tour Tour { get; set; }

    public Difficulty Difficulty { get; set; }

    public Rating Rating { get; set; }
}